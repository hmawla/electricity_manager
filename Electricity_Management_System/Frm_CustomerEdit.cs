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
        private int STREET_ID;
        private int REGION_ID;
        private DataTable dt;
        private Boolean Editing;
        private Boolean EditingRegion = false;
        private Boolean EditingStreet = false;

        public Frm_CustomerEdit()
        {
            InitializeComponent();
            CUSTOMER_ID = GenID("customer","customer_id");
            Lbl_Customer_ID.Text = "Customer ID: " + CUSTOMER_ID;
            Editing = false;
            FillCBox(Cbox_Counter, "SELECT [counter_id] FROM [counter]", "counter_id", "counter_id");
            FillCBox(CBox_Region, "SELECT region_id, region_name FROM region", "region_id", "region_name");
            FillCBox(CBox_Street, "SELECT street_id, street_name FROM street WHERE region_id = " + CBox_Region.SelectedValue, "street_id", "street_name");
            FillCBox(CBox_Building, "SELECT building_id, building_name FROM building WHERE street_id = " + CBox_Street.SelectedValue, "building_id", "building_name");
            CBox_Region.SelectedIndexChanged += new EventHandler(CBox_regions_SelectedIndexChanged);
            CBox_Region.TextChanged += new EventHandler(CBox_Region_TextChanged);
            CBox_Street.SelectedIndexChanged += new EventHandler(CBox_streets_SelectedIndexChanged);
            CBox_Street.TextChanged += new EventHandler(CBox_Street_TextChanged);
            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);

        }

        public Frm_CustomerEdit(int CUSTOMER_ID)
        {
            InitializeComponent();
            Editing = true;
            this.CUSTOMER_ID = CUSTOMER_ID;
            Lbl_Customer_ID.Text = "Customer ID: " + CUSTOMER_ID;
            dt = new DataTable();
            dt = ReadQueryOut("SELECT customer_name, customer_phone, floor, counter_id, building.building_id, street.street_id, region.region_id FROM customer, building, street, region WHERE customer.building_id = building.building_id AND building.street_id = street.street_id AND street.region_id = region.region_id AND customer_id = " + CUSTOMER_ID);
            CUSTOMER_NAME = dt.Rows[0].ItemArray[0].ToString();
            CUSTOMER_PHONE = dt.Rows[0].ItemArray[1].ToString();
            FLOOR = int.Parse(dt.Rows[0].ItemArray[2].ToString());
            COUNTER_ID = int.Parse(dt.Rows[0].ItemArray[3].ToString());
            BUILDING_ID = int.Parse(dt.Rows[0].ItemArray[4].ToString());
            STREET_ID = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            REGION_ID = int.Parse(dt.Rows[0].ItemArray[6].ToString());

            Txt_Customer_Name.Text = CUSTOMER_NAME;
            Txt_Customer_Phone.Text = CUSTOMER_PHONE;
            Txt_Customer_Floor.Value = FLOOR;
            Cbox_Counter.SelectedValue = COUNTER_ID;
            CBox_Building.SelectedValue = BUILDING_ID;

            FillCBox(Cbox_Counter, "SELECT [counter_id] FROM [counter]", "counter_id", "counter_id");
            FillCBox(CBox_Region, "SELECT region_id, region_name FROM region", "region_id", "region_name");
            CBox_Region.SelectedValue = REGION_ID;
            FillCBox(CBox_Street, "SELECT street_id, street_name FROM street WHERE region_id = " + CBox_Region.SelectedValue, "street_id", "street_name");
            CBox_Street.SelectedValue = STREET_ID;
            FillCBox(CBox_Building, "SELECT building_id, building_name FROM building WHERE street_id = " + CBox_Street.SelectedValue, "building_id", "building_name");
            CBox_Building.SelectedValue = BUILDING_ID;
            CBox_Region.SelectedIndexChanged += new EventHandler(CBox_regions_SelectedIndexChanged);
            CBox_Region.TextChanged += new EventHandler(CBox_Region_TextChanged);
            CBox_Street.SelectedIndexChanged += new EventHandler(CBox_streets_SelectedIndexChanged);
            CBox_Street.TextChanged += new EventHandler(CBox_Street_TextChanged);



            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);

        }

        void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (Txt_Customer_Name.Text.Length > 0 && Txt_Customer_Phone.Text.Length > 0 && Txt_Customer_Floor.Value >=0 && CBox_Building.Text.Length > 0 && CBox_Street.Text.Length > 0 && CBox_Region.Text.Length > 0 && Cbox_Counter.Text.Length > 0)
            {

                if (!Editing)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new customer?", "Adding a new Customer!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CUSTOMER_NAME = Txt_Customer_Name.Text;
                        CUSTOMER_PHONE = Txt_Customer_Phone.Text;
                        FLOOR = int.Parse(Txt_Customer_Floor.Text);
                        COUNTER_ID = int.Parse(Cbox_Counter.SelectedValue.ToString());
                        BUILDING_ID = AddBuilding(CBox_Region, CBox_Street, CBox_Building);

                        ExecuteQuery("INSERT INTO customer VALUES(" + CUSTOMER_ID + ", '" + CUSTOMER_NAME + "', '" + CUSTOMER_PHONE + "', " + FLOOR + ", " + COUNTER_ID + ", " + BUILDING_ID + ")");
                        this.Dispose();
                    }
                    
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit customer #" + CUSTOMER_ID, "Editing a Customer!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CUSTOMER_NAME = Txt_Customer_Name.Text;
                        CUSTOMER_PHONE = Txt_Customer_Phone.Text;
                        FLOOR = int.Parse(Txt_Customer_Floor.Text);
                        COUNTER_ID = int.Parse(Cbox_Counter.SelectedValue.ToString());
                        BUILDING_ID = AddBuilding(CBox_Region, CBox_Street, CBox_Building);

                        ExecuteQuery("UPDATE customer SET customer_name = '" + CUSTOMER_NAME + "', customer_phone = '" + CUSTOMER_PHONE + "', floor = " + FLOOR + ", counter_id = " + COUNTER_ID + ", building_id = " + BUILDING_ID + " WHERE customer_id = " + CUSTOMER_ID);
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all required information!");
            }
        }

        private void CBox_regions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!EditingRegion)
            {
                FillCBox(CBox_Street, "SELECT street_id, street_name FROM street WHERE region_id = " + CBox_Region.SelectedValue, "street_id", "street_name");
            }
        }

        private void CBox_Region_TextChanged(object sender, EventArgs e)
        {
            if (CBox_Region.SelectedValue == null)
            {
                EditingRegion = true;
                CBox_Street.DataSource = null;
                CBox_Street.Text = "";

                CBox_Building.DataSource = null;
                CBox_Building.Text = "";
                EditingRegion = false;
            }
        }

        private void CBox_streets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!EditingRegion)
            {
                FillCBox(CBox_Building, "SELECT building_id, building_name FROM building WHERE street_id = " + CBox_Street.SelectedValue, "building_id", "building_name");
            }
        }

        private void CBox_Street_TextChanged(object sender, EventArgs e)
        {
            if (CBox_Street.SelectedValue == null)
            {
                EditingStreet = true;
                CBox_Building.DataSource = null;
                CBox_Building.Text = "";
                EditingStreet = false;
            }
        }
    }
}
