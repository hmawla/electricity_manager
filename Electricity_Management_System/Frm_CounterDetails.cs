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
    public partial class Frm_CounterDetails : MaterialSkin.Controls.MaterialForm
    {
        private int COUNTER_ID;
        public Frm_CounterDetails(int COUNTER_ID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            this.COUNTER_ID = COUNTER_ID;
            UpdateDetails();

            Btn_Exit.Click += new EventHandler(Btn_Exit_Click);
            Btn_Edit.Click += new EventHandler(Btn_Edit_Click);
            this.Click += new EventHandler(this_click);

        }

        void UpdateDetails()
        {
            DataTable dt = new DataTable();
            dt = ReadQueryOut("SELECT total_usage, monthly_cost, box_id FROM [counter] WHERE counter_id = " + COUNTER_ID);
            Lbl_CounterID.Text = COUNTER_ID.ToString();
            Lbl_TotalUsage.Text = dt.Rows[0].ItemArray[0].ToString();
            Lbl_MonthlyCost.Text = dt.Rows[0].ItemArray[1].ToString();
            Lbl_BoxID.Text = dt.Rows[0].ItemArray[2].ToString();
        }

        void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void Btn_Edit_Click(object sender, EventArgs e)
        {
            Frm_CounterEdit frm = new Frm_CounterEdit(COUNTER_ID);
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
