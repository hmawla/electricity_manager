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
    public partial class Frm_CustomerEdit : MaterialSkin.Controls.MaterialForm
    {

        private int CUSTOMER_ID;
        private String CUSTOMER_NAME;
        private String CUSTOMER_PHONE;
        private int FLOOR;
        private int COUNTER_ID;
        private int BUILDING_ID;
        private DataTable dt;
        private Boolean Editing;

        public Frm_CustomerEdit()
        {
            InitializeComponent();
            CUSTOMER_ID = GenID("customer","customer_id");
            Lbl_Customer_ID.Text = "Customer ID: " + CUSTOMER_ID;
            Editing = false;
            
        }

        public Frm_CustomerEdit(int CUSTOMER_ID)
        {
            InitializeComponent();
            Editing = true;
            this.CUSTOMER_ID = CUSTOMER_ID;
            Lbl_Customer_ID.Text = "Customer ID: " + CUSTOMER_ID;
            dt = new DataTable();
            dt = ReadQueryOut("SELECT customer_name, customer_phone, floor, counter_id, building_id FROM customer WHERE customer_id = " + CUSTOMER_ID);
            CUSTOMER_NAME = dt.Rows[0].ItemArray[0].ToString();
            CUSTOMER_PHONE = dt.Rows[0].ItemArray[0].ToString();
            FLOOR = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            COUNTER_ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            BUILDING_ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());

            Txt_Customer_Name.Text = CUSTOMER_NAME;
            Txt_Customer_Phone.Text = CUSTOMER_PHONE;
            Txt_Customer_Floor.Value = FLOOR;
            Cbox_Counter.SelectedValue = COUNTER_ID;
            CBox_Building.SelectedValue = BUILDING_ID;

            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);

            
        }

        void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (Txt_Customer_Name.Text.Length > 0 && Txt_Customer_Phone.Text.Length > 0 && Txt_Customer_Floor.Value >=0 && CBox_Building.Text.Length > 0 && CBox_Street.Text.Length > 0 && CBox_Region.Text.Length > 0 && Cbox_Counter.Text.Length > 0)
            {
                //DATA CAN BE ACCEPTED
                //WILL NEED Building/Street/Region generator
                //Will need textboxes validation rules
                //Now it is time for rest :P
            }
            else
            {
                MessageBox.Show("Please fill all required information!");
            }
        }
    }
}
