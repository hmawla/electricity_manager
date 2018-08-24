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
    public partial class Frm_ReleaseInvoice : MaterialSkin.Controls.MaterialForm
    {
        private int CUSTOMER_ID;
        private String CUSTOMER_NAME;
        private int TOTAL_USAGE;
        private int MONTHLY_COST;
        private int VALUE_PER_KWATT;
        private int PRICE_ID;


        public Frm_ReleaseInvoice(int customer_id)
        {
            InitializeComponent();
            this.CUSTOMER_ID = customer_id;
            DataTable dt = new DataTable();
            dt = ReadQueryOut("SELECT customer_name, total_usage, monthly_cost FROM customer WHERE customer_id = " + CUSTOMER_ID);
            CUSTOMER_NAME = dt.Rows[0].ItemArray[0].ToString();
            TOTAL_USAGE = int.Parse(dt.Rows[0].ItemArray[1].ToString()); ;
            MONTHLY_COST = int.Parse(dt.Rows[0].ItemArray[2].ToString());
            dt.Reset();
            dt = ReadQueryOut("SELECT price_id, value_per_kwatt FROM price WHERE price_id = (SELECT MAX(price_id) FROM price)");
            VALUE_PER_KWATT = int.Parse(dt.Rows[0].ItemArray[1].ToString());
            PRICE_ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());

            Lbl_CustomerID.Text = CUSTOMER_ID.ToString();
            Lbl_CustomerName.Text = CUSTOMER_NAME;
            Lbl_LastUsage.Text = TOTAL_USAGE.ToString();

            Txt_Total.Text = MONTHLY_COST.ToString();

            Txt_CurrentUsage.TextChanged += new EventHandler(Txt_CurrentUsage_TextChanged);
            Btn_Submit.Click += new EventHandler(Btn_Submit_Click);
            Btn_SubmitPrint.Click += new EventHandler(Btn_SubmitPrint_Click);
        }

        void Txt_CurrentUsage_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_CurrentUsage.Text, out int CurrUsage) && CurrUsage >= TOTAL_USAGE)
            {
                Txt_Total.Text = (CurrUsage - TOTAL_USAGE) * VALUE_PER_KWATT + MONTHLY_COST + "";
            }
            else
            {
                Txt_Total.Text = MONTHLY_COST.ToString();
            }
        }

        void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_CurrentUsage.Text, out int CurrUsage) && CurrUsage >= TOTAL_USAGE)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to release the " + DateTime.Now.ToShortDateString() + " invoice for the customer #" + CUSTOMER_ID + "?" + Environment.NewLine + "Customer should pay " + Txt_Total.Text + "L.L.", "Adding a new Customer!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int INVOICE_ID = GenID("invoice", "invoice_id");
                    ExecuteQuery("INSERT INTO invoice VALUES(" + INVOICE_ID + "date(), " + TOTAL_USAGE + ", " + CurrUsage + ", " + MONTHLY_COST + ", " + (CurrUsage - TOTAL_USAGE) + ", " + PRICE_ID + ", " + CUSTOMER_ID + ")");
                    MessageBox.Show("Invoice #" + INVOICE_ID + " release.");
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please fill all required data correctly!");
            }
        }

        void Btn_SubmitPrint_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_CurrentUsage.Text, out int CurrUsage) && CurrUsage >= TOTAL_USAGE)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to release the " + DateTime.Now.ToShortDateString() + " invoice for the customer #" + CUSTOMER_ID + "?" + Environment.NewLine + "Customer should pay " + Txt_Total.Text + "L.L.", "Adding a new Customer!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int INVOICE_ID = GenID("invoice", "invoice_id");
                    ExecuteQuery("INSERT INTO invoice VALUES(" + INVOICE_ID + "date(), " + TOTAL_USAGE + ", " + CurrUsage + ", " + MONTHLY_COST + ", " + (CurrUsage - TOTAL_USAGE) + ", " + PRICE_ID + ", " + CUSTOMER_ID + ")");
                    MessageBox.Show("Invoice #" + INVOICE_ID + " release.");
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please fill all required data correctly!");
            }
        }
    }
}
