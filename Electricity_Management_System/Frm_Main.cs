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
using Microsoft.Reporting.WinForms;

namespace Electricity_Management_System
{
    public partial class Frm_Main : MaterialSkin.Controls.MaterialForm
    {
        private String info_PricePerWatt;
        private int info_NumberOfBoxes;
        private int info_NumberOfCounters;
        private int info_NumberOfCustomers;
        private String info_NewestCustomer;
        private double info_ApproximateIncome;
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
            DGV_Counters.Click += new EventHandler(DGV_Counters_Click);

            //Filter Text Boxes
            Txt_FindCustomerByName.TextChanged += new EventHandler(Txt_FindCustomerByName_TextChanged);
            Txt_CounterFilterByCost.TextChanged += new EventHandler(Txt_CounterFilterByCost_TextChanged);

            //Addition Buttons
            Btn_AddNewCustomer.Click += new EventHandler(Btn_AddNewCustomer_Click);
            Btn_AddNewCounter.Click += new EventHandler(Btn_AddNewCounter_Click);
            Btn_AddNewBox.Click += new EventHandler(Btn_AddNewBox_Click);

            //Modification Buttons
            Btn_ModCustomer.Click += new EventHandler(Btn_ModCustomer_Click);
            Btn_ModCounter.Click += new EventHandler(Btn_ModCounter_Click);
            Btn_ModBox.Click += new EventHandler(Btn_ModBox_Click);

            //Reset Buttons
            Btn_ResetCustomers.Click += new EventHandler(Btn_ResetCustomers_Click);
            Btn_ResetBoxes.Click += new EventHandler(Btn_ResetCounters_Click);

            //Bottom Buttons
            Btn_Help.Click += new EventHandler(Btn_Help_Click);
            Btn_About.Click += new EventHandler(Btn_About_Click);

            //Theme Manager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
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
            dt = ReadQueryOut("SELECT COUNT(counter_id) FROM [counter]");
            info_NumberOfCounters = int.Parse(dt.Rows[0].ItemArray[0].ToString());
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
            Lbl_info_NumberOfCounters.Text = info_NumberOfCounters.ToString();
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
                UpdateCounters();
            }
            else if (Tab_Navigator.SelectedIndex == 3)
            {
                UpdateBoxes();
            }
            else if (Tab_Navigator.SelectedIndex == 4)
            {
            }
            else if (Tab_Navigator.SelectedIndex == 5)
            {
                DataTable dt = ReadQueryOut("SELECT customer_id, customer_name FROM customer WHERE customer_id = (SELECT MAX(customer_id) FROM customer)");
                rpt.Database.Tables[0].SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            }
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
            FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], customer_phone AS [Phone], customer_debt AS [Debt in LL], counter_id AS [Counter], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id");
        }
        

        void UpdateCustomers(String CUSTOMER_NAME)
        {
            FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], customer_phone AS [Phone], customer_debt AS [Debt in LL], counter_id AS [Counter], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id AND customer_name LIKE '%" + CUSTOMER_NAME + "%'");
        }

        void UpdateCounters()
        {
            Txt_CounterFilterByCost.Text = "";
            FillDGV(DGV_Counters, "SELECT counter_id AS [ID], ampere_value AS [Type in Ampere], total_usage AS [Usage in Watt], monthly_cost AS [Cost in LL], box_id AS [Box] FROM [counter]");
        }

        void UpdateCounters(String MONTHLY_COST)
        {
            FillDGV(DGV_Counters, "SELECT counter_id AS [ID], ampere_value AS [Type in Ampere], total_usage AS [Usage in Watt], monthly_cost AS [Cost in LL], box_id AS [Box] FROM [counter] WHERE monthly_cost LIKE '" + MONTHLY_COST + "%'");
        }

        void UpdateBoxes()
        {
            FillDGV(DGV_Boxes, "SELECT box_id AS [ID], box_name AS [Box Name], street_name + ', ' + region_name AS [Address] FROM box b, street s, region r WHERE b.street_id = s.street_id AND s.region_id = r.region_id");
        }

        void UpdateBoxes(String BOX_NAME)
        {
            FillDGV(DGV_Boxes, "SELECT box_id AS [ID], box_name AS [Box Name], street_name + ', ' + region_name AS [Address] FROM box b, street s, region r WHERE b.street_id = s.street_id AND s.region_id = r.region_id WHERE box_name LIKE '%" + BOX_NAME + "%'");
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
        void DGV_Counters_Click(object sender, EventArgs e)
        {
            if (DGV_Counters.SelectedRows.Count > 0)
            {
                Frm_CounterDetails frm = new Frm_CounterDetails(int.Parse(DGV_Counters.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();
                frm.Dispose();
                UpdateCounters();

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
        void Txt_CounterFilterByCost_TextChanged(object sender, EventArgs e)
        {
            if (Txt_CounterFilterByCost.Text.Length > 0)
            {
                UpdateCounters(Txt_CounterFilterByCost.Text);
            }
            else
            {
                UpdateCounters();
            }
        }

        void Btn_ResetCustomers_Click(object sender, EventArgs e)
        {
            Txt_FindCustomerByName.Text = "";
        }

        void Btn_ResetCounters_Click(object sender, EventArgs e)
        {
            Txt_CounterFilterByCost.Text = "";
        }

        void Btn_AddNewCounter_Click(object sender, EventArgs args)
        {
            Frm_CounterEdit frm = new Frm_CounterEdit();
            frm.ShowDialog();
            frm.Dispose();
            UpdateCounters();
        }

        void Btn_ModCounter_Click(object sender, EventArgs args)
        {
            if(DGV_Counters.SelectedRows.Count > 0){
                Frm_CounterEdit frm = new Frm_CounterEdit(int.Parse(DGV_Counters.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();
                frm.Dispose();
                UpdateCounters();
            }
            else
            {
                MessageBox.Show("Please select a counter!");
            }

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
