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
    public partial class Frm_CounterEdit : MaterialSkin.Controls.MaterialForm
    {
        private int COUNTER_ID;
        private float TOTAL_USAGE;
        private int MONTHLY_COST;
        private int BOX_ID;
        private Boolean OutSide = false;
        private Boolean Editing;

        public Frm_CounterEdit()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            COUNTER_ID = GenID("[counter]", "counter_id");
            Lbl_Counter_ID.Text = "Counter ID: " + COUNTER_ID;
            Editing = false;

            FillCBox(Cbox_Box, "SELECT box_id, box_name FROM box", "box_id", "box_id");

            Txt_InitialUsage.Click += new EventHandler(Txt_InitialUsage_Click);
            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);

        }

        public Frm_CounterEdit(int COUNTER_ID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            this.COUNTER_ID = COUNTER_ID;
            Lbl_Counter_ID.Text = "Counter ID: " + COUNTER_ID;
            Editing = true;

            FillCBox(Cbox_Box, "SELECT box_id, box_name FROM box", "box_id", "box_id");

            DataTable dt = new DataTable();
            dt = ReadQueryOut("SELECT total_usage, monthly_cost, box_id FROM [counter] WHERE counter_id = " + COUNTER_ID);
            TOTAL_USAGE = float.Parse(dt.Rows[0].ItemArray[0].ToString());
            MONTHLY_COST = int.Parse(dt.Rows[0].ItemArray[1].ToString());
            BOX_ID = int.Parse(dt.Rows[0].ItemArray[2].ToString());

            Txt_InitialUsage.Value = (Decimal)TOTAL_USAGE;
            Txt_MonthlyCost.Value = MONTHLY_COST;
            Cbox_Box.SelectedValue = BOX_ID;

            Txt_InitialUsage.Click += new EventHandler(Txt_InitialUsage_Click);
            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);

        }
        
        public int ShowNewDialog()
        {
            OutSide = true;
            ShowDialog();
            return COUNTER_ID;
        }

        void Txt_InitialUsage_Click(object sender, EventArgs args)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want a custom usage value?" + Environment.NewLine + "This may cause problems!", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Txt_InitialUsage.ReadOnly = false;
            }
        }

        void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (Cbox_Box.SelectedValue != null)
            {
                if (Editing)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit counter#" + COUNTER_ID + " ?", "Edit Counter!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TOTAL_USAGE = (float)Txt_InitialUsage.Value;
                        MONTHLY_COST = (int)Txt_MonthlyCost.Value;
                        BOX_ID = (int)Cbox_Box.SelectedValue;
                        ExecuteQuery("UPDATE [counter] SET total_usage =  " + TOTAL_USAGE + ", monthly_cost = " + MONTHLY_COST + ", box_id =  " + BOX_ID + " WHERE counter_id = " + COUNTER_ID);
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
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new counter?", "New Counter!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TOTAL_USAGE = (float)Txt_InitialUsage.Value;
                        MONTHLY_COST = (int)Txt_MonthlyCost.Value;
                        BOX_ID = (int)Cbox_Box.SelectedValue;
                        ExecuteQuery("INSERT INTO [counter] VALUES(" + COUNTER_ID + ", " + TOTAL_USAGE + ", " + MONTHLY_COST + ", " + BOX_ID + ")");
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
