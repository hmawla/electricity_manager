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
    public partial class Frm_Report_Invoice : MaterialSkin.Controls.MaterialForm
    {
        private int INVOICE_ID;
        private DateTime INVOICE_DATE;
        private int PREVIOUS_USAGE;
        private int CURRENT_USAGE;
        private int MONTHYL_COST;
        private int TOTAL_USAGE;
        private int CUSTOMER_ID;
        private int BOX_ID;
        private String BOX_NAME;

        private int VALUE_PER_KWATT;
        private String CUSTOMER_NAME;
        private String CUSTOMER_PHONE;
        private int FLOOR;
        private int AMPERE_VALUE;
        private String BUILDING_NAME;
        private String STREET_NAME;
        private String REGION_NAME;




        public Frm_Report_Invoice(int INVOICE_ID)
        {
            InitializeComponent();
            this.INVOICE_ID = INVOICE_ID;
            getData(INVOICE_ID);
            UpdateReport();
        }

        void getData(int INVOICE_ID)
        {
            DataTable dt = ReadQueryOut("SELECT invoice_date, previous_usage, current_usage, i.monthly_cost, i.total_usage, value_per_kwatt, c.customer_id, customer_name, customer_phone, floor, ampere_value, box.box_id, box_name, building_name, street_name, region_name FROM customer c, box, building b, street s, region r, invoice i, price p WHERE c.box_id = box.box_id AND c.building_id = b.building_id AND b.street_id = s.street_id AND s.region_id = r.region_id AND c.customer_id = i.customer_id AND i.price_id = p.price_id AND invoice_id = " + INVOICE_ID);
            INVOICE_DATE = DateTime.Parse(dt.Rows[0].ItemArray[0].ToString());
            PREVIOUS_USAGE = int.Parse(dt.Rows[0].ItemArray[1].ToString());
            CURRENT_USAGE = int.Parse(dt.Rows[0].ItemArray[2].ToString());
            MONTHYL_COST = int.Parse(dt.Rows[0].ItemArray[3].ToString());
            TOTAL_USAGE = int.Parse(dt.Rows[0].ItemArray[4].ToString());
            VALUE_PER_KWATT = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            CUSTOMER_ID = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            CUSTOMER_NAME = dt.Rows[0].ItemArray[7].ToString();
            CUSTOMER_PHONE = dt.Rows[0].ItemArray[8].ToString();
            FLOOR = int.Parse(dt.Rows[0].ItemArray[9].ToString());
            AMPERE_VALUE = int.Parse(dt.Rows[0].ItemArray[10].ToString());
            BOX_ID = int.Parse(dt.Rows[0].ItemArray[11].ToString());
            BOX_NAME = dt.Rows[0].ItemArray[12].ToString();
            BUILDING_NAME = dt.Rows[0].ItemArray[13].ToString();
            STREET_NAME = dt.Rows[0].ItemArray[14].ToString();
            REGION_NAME = dt.Rows[0].ItemArray[15].ToString();
        }

        void UpdateReport()
        {
            CRpt_InvoiceCustomer theReportDocument= new CRpt_InvoiceCustomer();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["InvoiceDate"]).Text = INVOICE_DATE.ToShortDateString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["CurrentDate"]).Text = DateTime.Now.ToShortDateString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["CustomerName"]).Text = CUSTOMER_NAME;
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["CustomerPhone"]).Text = CUSTOMER_PHONE;
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["CustomerAddress"]).Text = REGION_NAME + ", " + STREET_NAME + ", " + BUILDING_NAME;
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["CustomerFloor"]).Text = FLOOR.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["CustomerID"]).Text = CUSTOMER_ID.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["CounterType"]).Text = AMPERE_VALUE.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["BoxID"]).Text = BOX_ID.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["BoxAddress"]).Text = BOX_NAME;
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["Month1"]).Text = getArabicMonth(int.Parse(DateTime.Today.AddMonths(-1).ToString("MM")));
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["Month2"]).Text = getArabicMonth(int.Parse(DateTime.Today.ToString("MM")));
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["Month1Usage"]).Text = PREVIOUS_USAGE.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["Month2Usage"]).Text = CURRENT_USAGE.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["CurrentUsage"]).Text = TOTAL_USAGE.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["PricePerKWatt"]).Text = VALUE_PER_KWATT.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["TotalPrice"]).Text = (TOTAL_USAGE * VALUE_PER_KWATT).ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["MonthlyCost"]).Text = MONTHYL_COST.ToString();
            ((CrystalDecisions.CrystalReports.Engine.TextObject)theReportDocument.Section3.ReportObjects["NetTotal"]).Text = (MONTHYL_COST + (TOTAL_USAGE * VALUE_PER_KWATT)).ToString();

            CRptV_Invoice.ReportSource = theReportDocument;
            CRptV_Invoice.RefreshReport();
        }
    }
}
