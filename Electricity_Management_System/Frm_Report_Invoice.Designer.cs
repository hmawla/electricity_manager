namespace Electricity_Management_System
{
    partial class Frm_Report_Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CRptV_Invoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRptV_Invoice
            // 
            this.CRptV_Invoice.ActiveViewIndex = -1;
            this.CRptV_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRptV_Invoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRptV_Invoice.DisplayStatusBar = false;
            this.CRptV_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRptV_Invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CRptV_Invoice.Location = new System.Drawing.Point(0, 0);
            this.CRptV_Invoice.Name = "CRptV_Invoice";
            this.CRptV_Invoice.ShowLogo = false;
            this.CRptV_Invoice.ShowPageNavigateButtons = false;
            this.CRptV_Invoice.ShowParameterPanelButton = false;
            this.CRptV_Invoice.Size = new System.Drawing.Size(821, 464);
            this.CRptV_Invoice.TabIndex = 0;
            this.CRptV_Invoice.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Report_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 464);
            this.Controls.Add(this.CRptV_Invoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "Frm_Report_Invoice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Invoice Print";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRptV_Invoice;
    }
}