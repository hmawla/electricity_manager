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
    public partial class Frm_BoxEdit : MaterialSkin.Controls.MaterialForm
    {
        private int BOX_ID;
        private String BOX_NAME;
        private int STREET_ID;
        private int REGION_ID;
        private Boolean Editing;
        private Boolean EditingRegion = false;
        private Boolean OutSide = false;

        public Frm_BoxEdit()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            Editing = false;
            BOX_ID = GenID("box", "box_id");
            Lbl_Box_ID.Text = "Box ID: " + BOX_ID;

            FillCBox(CBox_Region, "SELECT region_id, region_name FROM region", "region_id", "region_name");
            FillCBox(CBox_Street, "SELECT street_id, street_name FROM street WHERE region_id = " + CBox_Region.SelectedValue, "street_id", "street_name");
            CBox_Region.SelectedIndexChanged += new EventHandler(CBox_regions_SelectedIndexChanged);
            CBox_Region.TextChanged += new EventHandler(CBox_Region_TextChanged);
            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);

        }

        public Frm_BoxEdit(int BOX_ID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            Editing = true;
            this.BOX_ID = BOX_ID;
            Lbl_Box_ID.Text = "Box ID: " + BOX_ID;
            DataTable dt = new DataTable();
            dt = ReadQueryOut("SELECT box_name, s.street_id, r.region_id FROM box b, street s, region r WHERE b.street_id = s.street_id AND s.region_id = r.region_id");
            BOX_NAME = dt.Rows[0].ItemArray[0].ToString();
            STREET_ID = int.Parse(dt.Rows[0].ItemArray[1].ToString());
            REGION_ID = int.Parse(dt.Rows[0].ItemArray[2].ToString());

            FillCBox(CBox_Region, "SELECT region_id, region_name FROM region", "region_id", "region_name");
            CBox_Region.SelectedValue = REGION_ID;
            FillCBox(CBox_Street, "SELECT street_id, street_name FROM street WHERE region_id = " + REGION_ID, "street_id", "street_name");
            CBox_Street.SelectedValue = STREET_ID;

            Txt_Box_Name.Text = BOX_NAME;

            CBox_Region.SelectedIndexChanged += new EventHandler(CBox_regions_SelectedIndexChanged);
            CBox_Region.TextChanged += new EventHandler(CBox_Region_TextChanged);
            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);
        }

        public int ShowNewDialog()
        {
            OutSide = true;
            ShowDialog();
            return BOX_ID;
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
                EditingRegion = false;
            }
        }

        void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (Txt_Box_Name.Text.Length > 0 && CBox_Street.Text.Length > 0 && CBox_Region.Text.Length > 0)
            {

                if (!Editing)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new box?", "Adding a new box!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        BOX_NAME = Txt_Box_Name.Text;
                        STREET_ID = AddStreet(CBox_Region, CBox_Street);

                        ExecuteQuery("INSERT INTO box VALUES(" + BOX_ID + ", '" + BOX_NAME + "', " + STREET_ID + ")");
                        if (!OutSide)
                        {
                            this.Dispose();
                        }
                        else
                        {
                            Hide();
                        }
                    }

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit box #" + BOX_ID, "Editing a Box!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        BOX_NAME = Txt_Box_Name.Text;
                        STREET_ID = AddStreet(CBox_Region, CBox_Street);

                        ExecuteQuery("UPDATE box SET box_name = '" + BOX_NAME + "', street_id = " + STREET_ID + " WHERE box_id = " + BOX_ID);
                        if (!OutSide)
                        {
                            this.Dispose();
                        }
                        else
                        {
                            Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all required information!");
            }
        }
    }
}
