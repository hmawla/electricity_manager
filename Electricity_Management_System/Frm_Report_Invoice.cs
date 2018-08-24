using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Management_System
{
    public partial class Frm_Report_Invoice : MaterialSkin.Controls.MaterialForm
    {
        private int INVOICE_ID;
        private int VALUE_PER_KWATT;


        public Frm_Report_Invoice(int INVOICE_ID)
        {
            InitializeComponent();
            this.INVOICE_ID = INVOICE_ID;

        }
    }
}
