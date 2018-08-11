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
using static Electricity_Management_System.OleDb_Tools;

namespace Electricity_Management_System
{
    public partial class Frm_Main : MaterialSkin.Controls.MaterialForm
    {
        public Frm_Main()
        {
            InitializeComponent();

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

            //Modification Buttons
            Btn_ModCustomer.Click += new EventHandler(Btn_ModCustomer_Click);
            Btn_ModCounter.Click += new EventHandler(Btn_ModCounter_Click);

            //Reset Buttons
            Btn_ResetCustomers.Click += new EventHandler(Btn_ResetCustomers_Click);
            materialFlatButton2.Click += new EventHandler(Btn_ResetCounters_Click);

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
        }

        void Tab_Navigator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab_Navigator.SelectedIndex == 1)
            {
                UpdateCustomers();
            }
            else if (Tab_Navigator.SelectedIndex == 2)
            {
                UpdateCounters();
            }
        }

        void Btn_AddNewCustomer_Click(object sender, EventArgs e)
        {
            Frm_CustomerEdit frm = new Frm_CustomerEdit();
            frm.ShowDialog();
            UpdateCustomers();
        }

        void UpdateCustomers()
        {
            Txt_FindCustomerByName.Text = "";
            FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], customer_phone AS [Phone], counter_id AS [Counter], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id");
        }
        

        void UpdateCustomers(String CUSTOMER_NAME)
        {
            FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], customer_phone AS [Phone], counter_id AS [Counter], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id AND customer_name LIKE '%" + CUSTOMER_NAME + "%'");
        }

        void UpdateCounters()
        {
            Txt_CounterFilterByCost.Text = "";
            FillDGV(DGV_Counters, "SELECT counter_id AS [ID], total_usage AS [Usage in Watt], monthly_cost AS [Cost in LL], box_id AS [Box] FROM [counter]");
        }

        void UpdateCounters(String MONTHLY_COST)
        {
            FillDGV(DGV_Counters, "SELECT counter_id AS [ID], total_usage AS [Usage in Watt], monthly_cost AS [Cost in LL], box_id AS [Box] FROM [counter] WHERE monthly_cost LIKE '" + MONTHLY_COST + "%'");
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
    }
}
