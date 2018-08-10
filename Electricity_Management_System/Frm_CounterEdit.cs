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
        private double TOTAL_USAGE;
        private int MONTHLY_COST;
        private int BOX_ID;
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

            Txt_InitialUsage.Click += new EventHandler(Txt_InitialUsage_Click);

        }

        void Txt_InitialUsage_Click(object sender, EventArgs args)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want a custom usage value?" + Environment.NewLine + "This may cause problems!", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Txt_InitialUsage.Enabled = true;
            }
        }
    }
}
