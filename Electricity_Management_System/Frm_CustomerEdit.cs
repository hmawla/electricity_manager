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
    public partial class Frm_CustomerEdit : MaterialSkin.Controls.MaterialForm
    {

        private int CUSTOMER_ID;
        private String CUSTOMER_NAME;
        private String CUSTOMER_PHONE;
        private int FLOOR;
        private float TOTAL_USAGE;
        private int MONTHLY_COST;
        private int COUNTER_TYPE;
        private int BUILDING_ID;
        private int STREET_ID;
        private int REGION_ID;
        private int BOX_ID;

        private DataTable dt;

        private Boolean Editing;
        private Boolean EditingRegion = false;
        private Boolean EditingStreet = false;

        public Frm_CustomerEdit()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            CUSTOMER_ID = GenID("customer","customer_id");
            Lbl_Customer_ID.Text = "Customer ID: " + CUSTOMER_ID;
            Editing = false;
            FillCBox(CBox_Region, "SELECT region_id, region_name FROM region", "region_id", "region_name");
            FillCBox(CBox_Street, "SELECT street_id, street_name FROM street WHERE region_id = " + CBox_Region.SelectedValue, "street_id", "street_name");
            FillCBox(CBox_Building, "SELECT building_id, building_name FROM building WHERE street_id = " + CBox_Street.SelectedValue, "building_id", "building_name");
            FillCBox(Cbox_Box, "SELECT box_id, box_name FROM box", "box_id", "box_id");

            CBox_Region.SelectedIndexChanged += new EventHandler(CBox_regions_SelectedIndexChanged);
            CBox_Region.TextChanged += new EventHandler(CBox_Region_TextChanged);
            CBox_Street.SelectedIndexChanged += new EventHandler(CBox_streets_SelectedIndexChanged);
            CBox_Street.TextChanged += new EventHandler(CBox_Street_TextChanged);

            Txt_InitialUsage.Click += new EventHandler(Txt_InitialUsage_Click);
            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);
            Btn_New.Click += new EventHandler(Btn_New_Click);

        }

        public Frm_CustomerEdit(int CUSTOMER_ID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            Editing = true;
            this.CUSTOMER_ID = CUSTOMER_ID;
            Lbl_Customer_ID.Text = "Customer ID: " + CUSTOMER_ID;
            dt = new DataTable();
            dt = ReadQueryOut("SELECT customer_name, customer_phone, floor, building.building_id, street.street_id, region.region_id, total_usage, monthly_cost, ampere_value, box.box_id FROM customer, building, street, region, box WHERE box.box_id = customer.box_id AND customer.building_id = building.building_id AND building.street_id = street.street_id AND street.region_id = region.region_id AND customer_id = " + CUSTOMER_ID);
            CUSTOMER_NAME = dt.Rows[0].ItemArray[0].ToString();
            CUSTOMER_PHONE = dt.Rows[0].ItemArray[1].ToString();
            FLOOR = int.Parse(dt.Rows[0].ItemArray[2].ToString());;
            BUILDING_ID = int.Parse(dt.Rows[0].ItemArray[3].ToString());
            STREET_ID = int.Parse(dt.Rows[0].ItemArray[4].ToString());
            REGION_ID = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            TOTAL_USAGE = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            MONTHLY_COST = int.Parse(dt.Rows[0].ItemArray[7].ToString());
            COUNTER_TYPE = int.Parse(dt.Rows[0].ItemArray[8].ToString());
            BOX_ID = int.Parse(dt.Rows[0].ItemArray[9].ToString());

            

            Txt_Customer_Name.Text = CUSTOMER_NAME;
            Txt_Customer_Phone.Text = CUSTOMER_PHONE;
            Txt_Customer_Floor.Value = FLOOR;
            CBox_Building.SelectedValue = BUILDING_ID;
            Txt_InitialUsage.Value = (Decimal)TOTAL_USAGE;
            Txt_MonthlyCost.Value = MONTHLY_COST;
            
            Txt_CounterType.Value = COUNTER_TYPE;

            FillCBox(Cbox_Box, "SELECT box_id, box_name FROM box", "box_id", "box_id");
            Cbox_Box.SelectedValue = BOX_ID;
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

            Txt_InitialUsage.Click += new EventHandler(Txt_InitialUsage_Click);
            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);
            Btn_New.Click += new EventHandler(Btn_New_Click);

        }

        void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (Txt_Customer_Name.Text.Length > 0 && Txt_Customer_Phone.Text.Length > 0 && Txt_Customer_Floor.Value >=0 && CBox_Building.Text.Length > 0 && CBox_Street.Text.Length > 0 && CBox_Region.Text.Length > 0 && Cbox_Box.Text.Length > 0)
            {

                if (!Editing)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new customer?", "Adding a new Customer!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CUSTOMER_NAME = Txt_Customer_Name.Text;
                        CUSTOMER_PHONE = Txt_Customer_Phone.Text;
                        FLOOR = int.Parse(Txt_Customer_Floor.Text);
                        TOTAL_USAGE = (float)Txt_InitialUsage.Value;
                        MONTHLY_COST = (int)Txt_MonthlyCost.Value;
                        COUNTER_TYPE = (int)Txt_CounterType.Value;
                        BOX_ID = (int)Cbox_Box.SelectedValue;
                        BUILDING_ID = AddBuilding(CBox_Region, CBox_Street, CBox_Building);

                        ExecuteQuery("INSERT INTO customer VALUES(" + CUSTOMER_ID + ", '" + CUSTOMER_NAME + "', '" + CUSTOMER_PHONE + "', " + FLOOR + ", " + TOTAL_USAGE + ", " + MONTHLY_COST + ", " + COUNTER_TYPE + ", date(), " + BUILDING_ID + ", " + BOX_ID + ")");
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
                        TOTAL_USAGE = (float)Txt_InitialUsage.Value;
                        MONTHLY_COST = (int)Txt_MonthlyCost.Value;
                        COUNTER_TYPE = (int)Txt_CounterType.Value;
                        BOX_ID = (int)Cbox_Box.SelectedValue;
                        BUILDING_ID = AddBuilding(CBox_Region, CBox_Street, CBox_Building);

                        ExecuteQuery("UPDATE customer SET customer_name = '" + CUSTOMER_NAME + "', customer_phone = '" + CUSTOMER_PHONE + "', floor = " + FLOOR + ", total_usage = " + TOTAL_USAGE + ", monthly_cost = " + COUNTER_TYPE + ", building_id = " + BUILDING_ID + ", box_id = " + BOX_ID + " WHERE customer_id = " + CUSTOMER_ID);
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all required information!");
            }
        }

        void Txt_InitialUsage_Click(object sender, EventArgs args)
        {
            if (Txt_InitialUsage.ReadOnly)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want a custom usage value?" + Environment.NewLine + "This may cause problems!", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Txt_InitialUsage.ReadOnly = false;
                }
                else
                {
                    Txt_InitialUsage.Value = 0;
                }
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

        void Btn_New_Click(object sender, EventArgs e)
        {
            Frm_BoxEdit frm = new Frm_BoxEdit();
            int NEW_Box_ID = frm.ShowNewDialog();
            frm.Dispose();
            FillCBox(Cbox_Box, "SELECT box_id FROM box", "box_id", "box_id");
            Cbox_Box.SelectedValue = NEW_Box_ID;

        }
    }
}
