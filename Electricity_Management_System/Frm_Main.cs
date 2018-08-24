using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Electricity_Management_System.OleDb_Tools;

namespace Electricity_Management_System
{
    public partial class Frm_Main : MaterialSkin.Controls.MaterialForm
    {
        private String info_PricePerWatt;
        private int info_NumberOfBoxes;
        private int info_NumberOfCustomers;
        private String info_NewestCustomer;
        private double info_ApproximateIncome;
        private Boolean ShowingUnreleased = false;
        CRpt_InvoiceCustomer rpt;


        public Frm_Main()
        {
            InitializeComponent();
            UpdateInfo();

            this.Load += new EventHandler(Main_OnLoad);

            //Tab Navigation
            Tab_Navigator.SelectedIndexChanged += new EventHandler(Tab_Navigator_SelectedIndexChanged);
            
            //DataGridViews
            DGV_Customers.Click += new EventHandler(DGV_Customers_Click);
            DGV_Invoices.Click += new EventHandler(DGV_Invoices_Click);

            //Filter Text Boxes
            Txt_FindCustomerByName.TextChanged += new EventHandler(Txt_FindCustomerByName_TextChanged);

            //Addition Buttons
            Btn_AddNewCustomer.Click += new EventHandler(Btn_AddNewCustomer_Click);
            Btn_AddNewBox.Click += new EventHandler(Btn_AddNewBox_Click);

            //Modification Buttons
            Btn_ModCustomer.Click += new EventHandler(Btn_ModCustomer_Click);
            Btn_ModBox.Click += new EventHandler(Btn_ModBox_Click);

            //Reset Buttons
            Btn_ResetCustomers.Click += new EventHandler(Btn_ResetCustomers_Click);

            //Bottom Buttons
            Btn_Help.Click += new EventHandler(Btn_Help_Click);
            Btn_About.Click += new EventHandler(Btn_About_Click);

            //Invoices Events
            Btn_ShowUnreleased.Click += new EventHandler(Btn_ShowUnreleased_Click);

            //Theme Manager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            //Check for unreleased invoices and send notification about it
            int NumberOfUnreleasedInvoices = getUnreleasedCount();
            if (NumberOfUnreleasedInvoices > 0)
            {
                theNotifyIcon.BalloonTipClicked += new EventHandler(theNotifyIcon_BalloonTipClicked_Click);
                theNotifyIcon.BalloonTipText = "You have " + NumberOfUnreleasedInvoices + " unreleased invoice(s)";
                theNotifyIcon.BalloonTipTitle = "Elect Manager";
                theNotifyIcon.Visible = true;
                theNotifyIcon.Icon = this.Icon;
                theNotifyIcon.ShowBalloonTip(500);
            }
        }

        void theNotifyIcon_BalloonTipClicked_Click(object sender, EventArgs e)
        {
            Tab_Navigator.SelectedIndex = 3;
        }

        void Btn_Help_Click(object sender, EventArgs e)
        {
            Frm_Help frm = new Frm_Help();
            frm.ShowDialog();
        }

        void Btn_About_Click(object sender, EventArgs e)
        {
            Frm_About frm = new Frm_About();
            frm.ShowDialog();

        }

        void Main_OnLoad(object sender, EventArgs e)
        {
            OpenConnection();
            rpt = new CRpt_InvoiceCustomer();
            rpt.DataSourceConnections[0].SetConnection(getDBFile(), "", "Admin", "");
            //((CrystalDecisions.CrystalReports.Engine.TextObject)rpt.Section3.ReportObjects["Customer_Name"]).Text = "Some Really Long Customer Name";
            rpt.Refresh();
            //DataBackup();
        }

        void DataBackup()
        {
            DataTable dt = new DataTable();
            dt = ReadQueryOut("SELECT backup_date FROM backup WHERE backup_date = date()");
            if (dt.Rows.Count == 0)
            {
                File.Copy("elect_db.accdb", "Backups/" + DateTime.Now.Day + "_" + DateTime.Now.Month +"_" + DateTime.Now.Year + ".bak");
                ExecuteQuery("INSERT INTO backup(backup_date) VALUES(date())");
            }
        }

        void UpdateInfo()
        {
            DataTable dt = new DataTable();
            dt = ReadQueryOut("SELECT COUNT(box_id) FROM box");
            info_NumberOfBoxes = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            dt = ReadQueryOut("SELECT COUNT(customer_id) FROM customer");
            info_NumberOfCustomers = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            dt = ReadQueryOut("SELECT customer_id, customer_name FROM customer WHERE customer_id = (SELECT MAX(customer_id) FROM customer)");
            if (dt.Rows.Count > 0)
            {
                info_NewestCustomer = "(" + dt.Rows[0].ItemArray[0] + ") " + dt.Rows[0].ItemArray[1];
            }
            else
            {
                info_NewestCustomer = "No New Customers!";
            }

            Lbl_info_NumberOfBoxes.Text = info_NumberOfBoxes.ToString();
            Lbl_info_NumberOfCustomers.Text = info_NumberOfCustomers.ToString();
            Lbl_info_NewestCustomer.Text = info_NewestCustomer;
            

        }

        void Tab_Navigator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab_Navigator.SelectedIndex == 0)
            {
                UpdateInfo();
            }
            else if (Tab_Navigator.SelectedIndex == 1)
            {
                UpdateCustomers();
            }
            else if (Tab_Navigator.SelectedIndex == 2)
            {
                UpdateBoxes();
            }
            else if (Tab_Navigator.SelectedIndex == 3)
            {
                UpdateInvoices();
                ShowingUnreleased = false;
                Btn_ShowUnreleased.Text = "Show";
                int NumberOfUnreleasedInvoices = getUnreleasedCount();
                if (NumberOfUnreleasedInvoices > 0)
                {
                    Lbl_NoOfUnreleased.Text = "You have " + NumberOfUnreleasedInvoices + " unreleased invoice(s)";
                    Lbl_NoOfUnreleased.ForeColor = Color.Red;
                    Btn_ShowUnreleased.Enabled = true;
                }
                else
                {
                    Lbl_NoOfUnreleased.Text = "All this month's invoices are released!";
                    Lbl_NoOfUnreleased.ForeColor = Color.Green;
                    Btn_ShowUnreleased.Enabled = false;
                }
                DateTime NextMonth = DateTime.Now;
                int dayNumber = int.Parse(DateTime.Now.ToString("dd"));
                int NumberOfDaysInTheCurrentMonth = DateTime.DaysInMonth(int.Parse(DateTime.Now.ToString("yyyy")), int.Parse(DateTime.Now.ToString("MM")));
                int NumberOfDaysTillNextMonth = NumberOfDaysInTheCurrentMonth - dayNumber;

                if (NumberOfDaysTillNextMonth > 1)
                {
                    Lbl_NextInvoiceDays.Text = NumberOfDaysTillNextMonth + " Days";
                }
                else
                {
                    Lbl_NextInvoiceDays.Text = NumberOfDaysTillNextMonth + " Day";
                }
                

            }
            else if (Tab_Navigator.SelectedIndex == 4)
            {
                DataTable dt = ReadQueryOut("SELECT customer_id, customer_name " +
                    "FROM customer WHERE customer_id = (SELECT MAX(customer_id) FROM customer)");
                rpt.Database.Tables[0].SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            }
        }

        int getUnreleasedCount()
        {
            int NumberOfUnreleasedInvoices;
            DataTable dt = ReadQueryOut("SELECT COUNT(*) " +
                "FROM customer WHERE date() >= dateserial(Year(added_date), Month(added_date) + 1, 1) " +
                "AND customer_id NOT IN (SELECT customer_id FROM invoice WHERE " +
                "invoice_date LIKE '%" + DateTime.Now.ToString("MM/yyyy") + "')");
            NumberOfUnreleasedInvoices = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            dt.Reset();
            return NumberOfUnreleasedInvoices;
        }

        void UpdateInvoices()
        {
            DTP_InvoiceSearch.Value = DateTime.Now;
            UpdateInvoices(DTP_InvoiceSearch.Value);
        }
        void UpdateInvoices(DateTime theDate)
        {
            FillDGV(DGV_Invoices, "SELECT invoice_id AS [Invoice#], box_id AS [Box#], c.customer_id AS [ID], customer_name AS [Name], current_usage AS [Usage in KWATT] FROM customer c, invoice i WHERE c.customer_id = i.customer_id");
        }

        void Btn_ShowUnreleased_Click(object sender, EventArgs e)
        {
            if (!ShowingUnreleased)
            {
                ShowUnreleased();
                Btn_ShowUnreleased.Text = "Reset";
            }
            else
            {
                UpdateInvoices(DTP_InvoiceSearch.Value);
                Btn_ShowUnreleased.Text = "Show";
            }
            ShowingUnreleased = !ShowingUnreleased;


        }

        void ShowUnreleased()
        {
            FillDGV(DGV_Invoices, "SELECT box.box_id AS [Box]," +
                " customer.customer_id AS [Customer ID]," +
                " customer_name AS [Customer]," +
                " total_usage AS [Last Usage in KWATT] FROM customer," +
                " box WHERE customer.box_id = box.box_id AND customer.customer_id " +
                "NOT IN (SELECT customer_id FROM invoice WHERE " +
                "invoice_date LIKE '%" + DateTime.Now.ToString("MM/yyyy") + "')");
        }

        void Btn_AddNewCustomer_Click(object sender, EventArgs e)
        {
            Frm_CustomerEdit frm = new Frm_CustomerEdit();
            frm.ShowDialog();
            UpdateCustomers();
        }

        void Btn_AddNewBox_Click(object sender, EventArgs args)
        {
            Frm_BoxEdit frm = new Frm_BoxEdit();
            frm.ShowDialog();
            UpdateBoxes();
        }

        void UpdateCustomers()
        {
            Txt_FindCustomerByName.Text = "";
            FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], total_usage AS [Total Usage in KWATT], box_id AS [Box], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id");
        }
        

        void UpdateCustomers(String CUSTOMER_NAME)
        {
            FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], total_usage AS [Total Usage in KWATT], box_id AS [Box], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id AND customer_name LIKE '%" + CUSTOMER_NAME + "%'");
        }

        void UpdateBoxes()
        {
            FillDGV(DGV_Boxes, "SELECT box_id AS [ID], box_name AS [Near], street_name + ', ' + region_name AS [Address] FROM box b, street s, region r WHERE b.street_id = s.street_id AND s.region_id = r.region_id");
        }

        void UpdateBoxes(String BOX_NAME)
        {
            FillDGV(DGV_Boxes, "SELECT box_id AS [ID], box_name AS [Near], street_name + ', ' + region_name AS [Address] FROM box b, street s, region r WHERE b.street_id = s.street_id AND s.region_id = r.region_id WHERE box_name LIKE '%" + BOX_NAME + "%'");
        }

        void Btn_ModCustomer_Click(object sender, EventArgs e)
        {
            if (DGV_Customers.SelectedRows.Count > 0)
            {
                Frm_CustomerEdit frm = new Frm_CustomerEdit(int.Parse(DGV_Customers.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();
                UpdateCustomers();
            }
            else
            {
                MessageBox.Show("Please select a customer!");
            }
            
        }

        void Btn_ModBox_Click(object sender, EventArgs e)
        {
            if (DGV_Boxes.SelectedRows.Count > 0)
            {
                Frm_BoxEdit frm = new Frm_BoxEdit(int.Parse(DGV_Boxes.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();
                UpdateBoxes();
            }
            else
            {
                MessageBox.Show("Please select a box!");
            }

        }

        void DGV_Customers_Click(object sender, EventArgs e)
        {
            if (DGV_Customers.SelectedRows.Count > 0)
            {
                Frm_CustomerDetails frm = new Frm_CustomerDetails(int.Parse(DGV_Customers.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();
                frm.Dispose();
                UpdateCustomers();

            }
        }
        void DGV_Invoices_Click(object sender, EventArgs e)
        {
            if (ShowingUnreleased)
            {
                if (DGV_Invoices.SelectedRows.Count > 0)
                {
                    Frm_ReleaseInvoice frm = new Frm_ReleaseInvoice(int.Parse(DGV_Invoices.SelectedRows[0].Cells[1].Value.ToString()));
                    frm.ShowDialog();
                    frm.Dispose();
                    ShowUnreleased();
                    if (DGV_Invoices.Rows.Count == 0)
                    {
                        Btn_ShowUnreleased.PerformClick();
                    }
                    int NumberOfUnreleasedInvoices = getUnreleasedCount();
                    if (NumberOfUnreleasedInvoices > 0)
                    {
                        Lbl_NoOfUnreleased.Text = "You have " + NumberOfUnreleasedInvoices + " unreleased invoice(s)";
                        Lbl_NoOfUnreleased.ForeColor = Color.Red;
                        Btn_ShowUnreleased.Enabled = true;
                    }
                    else
                    {
                        Lbl_NoOfUnreleased.Text = "All this month's invoices are released!";
                        Lbl_NoOfUnreleased.ForeColor = Color.Green;
                        Btn_ShowUnreleased.Enabled = false;
                    }

                }
            }
            else
            {
                if (DGV_Invoices.SelectedRows.Count > 0)
                {
                    Frm_Report_Invoice Frm = new Frm_Report_Invoice(int.Parse(DGV_Invoices.SelectedRows[0].Cells[2].Value.ToString()));
                    Frm.ShowDialog();
                }
            }
            
        }

        void Txt_FindCustomerByName_TextChanged(object sender, EventArgs e)
        {
            if (Txt_FindCustomerByName.Text.Length > 0)
            {
                UpdateCustomers(Txt_FindCustomerByName.Text);
            }
            else
            {
                UpdateCustomers();
            }
        }

        void Btn_ResetCustomers_Click(object sender, EventArgs e)
        {
            Txt_FindCustomerByName.Text = "";
        }
    }
}
