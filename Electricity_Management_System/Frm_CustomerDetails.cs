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
    public partial class Frm_CustomerDetails : MaterialSkin.Controls.MaterialForm
    {
        private int CUSTOMER_ID;
        public Frm_CustomerDetails(int CUSTOMER_ID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            this.CUSTOMER_ID = CUSTOMER_ID;
            UpdateDetails();
            
            Btn_Exit.Click += new EventHandler(Btn_Exit_Click);
            Btn_Edit.Click += new EventHandler(Btn_Edit_Click);
            this.Click += new EventHandler(this_click);

        }

        void UpdateDetails()
        {
            DataTable dt = new DataTable();
            dt = ReadQueryOut("SELECT customer_name, customer_phone, floor, building_name, street_name, region_name, total_usage, monthly_cost, ampere_value, box.box_id FROM customer, building, street, region, box WHERE box.box_id = customer.box_id AND customer.building_id = building.building_id AND building.street_id = street.street_id AND street.region_id = region.region_id AND customer_id = " + CUSTOMER_ID);
            Lbl_CustomerID.Text = CUSTOMER_ID.ToString();
            Lbl_CustomerName.Text = dt.Rows[0].ItemArray[0].ToString();
            Lbl_CustomerPhone.Text = dt.Rows[0].ItemArray[1].ToString();
            Lbl_TotalUsage.Text = dt.Rows[0].ItemArray[6].ToString() + " KWATT";
            Lbl_MonthlyCost.Text = dt.Rows[0].ItemArray[7].ToString() + " L.L.";
            Lbl_CounterType.Text = dt.Rows[0].ItemArray[8].ToString() + " Ampere";
            Lbl_BoxID.Text = dt.Rows[0].ItemArray[9].ToString();
            Lbl_Address.Text = "(" + dt.Rows[0].ItemArray[2].ToString() + ")" + " " + dt.Rows[0].ItemArray[3].ToString() + ", " + dt.Rows[0].ItemArray[4].ToString() + ", " + dt.Rows[0].ItemArray[5].ToString();
        }

        void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void Btn_Edit_Click(object sender, EventArgs e)
        {
            Frm_CustomerEdit frm = new Frm_CustomerEdit(CUSTOMER_ID);
            frm.ShowDialog();
            frm.Dispose();
            UpdateDetails();
        }
        void this_click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
