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
            Tab_Navigator.SelectedIndexChanged += new EventHandler(Tab_Navigator_SelectedIndexChanged);
            Btn_AddNewCustomer.Click += new EventHandler(Btn_AddNewCustomer_Click);
            Btn_ModCustomer.Click += new EventHandler(Btn_ModCustomer_Click);

            

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        void Main_OnLoad(object sender, EventArgs e)
        {
            OpenConnection();
        }

        void Tab_Navigator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab_Navigator.SelectedIndex == 1)
            {
                FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], customer_phone AS [Phone], counter_id AS [Counter], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id");
            }
        }

        void Btn_AddNewCustomer_Click(object sender, EventArgs e)
        {
            Frm_CustomerEdit frm = new Frm_CustomerEdit();
            frm.ShowDialog();
            FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], customer_phone AS [Phone], counter_id AS [Counter], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id");
        }

        void Btn_ModCustomer_Click(object sender, EventArgs e)
        {
            if (DGV_Customers.SelectedRows.Count > 0)
            {
                Frm_CustomerEdit frm = new Frm_CustomerEdit(int.Parse(DGV_Customers.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();
                FillDGV(DGV_Customers, "SELECT customer_id AS [ID], customer_name AS [Name], customer_phone AS [Phone], counter_id AS [Counter], building_name & ', ' & street_name AS [Address] FROM customer, building, street WHERE customer.building_id = building.building_id AND building.street_id = street.street_id");
            }
            else
            {
                MessageBox.Show("Please select a customer!");
            }
            
        }
    }
}
