namespace Electricity_Management_System
{
    partial class Frm_ReleaseInvoice
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
            this.Lbl_CustomerID = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_CustomerName = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_LastUsage = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_CurrentUsage = new System.Windows.Forms.NumericUpDown();
            this.Btn_SubmitPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Btn_Submit = new MaterialSkin.Controls.MaterialFlatButton();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CurrentUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_CustomerID
            // 
            this.Lbl_CustomerID.AutoSize = true;
            this.Lbl_CustomerID.Depth = 0;
            this.Lbl_CustomerID.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_CustomerID.Location = new System.Drawing.Point(8, 79);
            this.Lbl_CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_CustomerID.Name = "Lbl_CustomerID";
            this.Lbl_CustomerID.Size = new System.Drawing.Size(97, 19);
            this.Lbl_CustomerID.TabIndex = 20;
            this.Lbl_CustomerID.Text = "Customer ID:";
            // 
            // Lbl_CustomerName
            // 
            this.Lbl_CustomerName.AutoSize = true;
            this.Lbl_CustomerName.Depth = 0;
            this.Lbl_CustomerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_CustomerName.Location = new System.Drawing.Point(8, 98);
            this.Lbl_CustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_CustomerName.Name = "Lbl_CustomerName";
            this.Lbl_CustomerName.Size = new System.Drawing.Size(123, 19);
            this.Lbl_CustomerName.TabIndex = 21;
            this.Lbl_CustomerName.Text = "Customer Name:";
            // 
            // Lbl_LastUsage
            // 
            this.Lbl_LastUsage.AutoSize = true;
            this.Lbl_LastUsage.Depth = 0;
            this.Lbl_LastUsage.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_LastUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_LastUsage.Location = new System.Drawing.Point(8, 117);
            this.Lbl_LastUsage.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_LastUsage.Name = "Lbl_LastUsage";
            this.Lbl_LastUsage.Size = new System.Drawing.Size(88, 19);
            this.Lbl_LastUsage.TabIndex = 22;
            this.Lbl_LastUsage.Text = "Last Usage:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 152);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(108, 19);
            this.materialLabel4.TabIndex = 23;
            this.materialLabel4.Text = "Current Usage:";
            // 
            // Txt_CurrentUsage
            // 
            this.Txt_CurrentUsage.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_CurrentUsage.Location = new System.Drawing.Point(16, 174);
            this.Txt_CurrentUsage.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Txt_CurrentUsage.Name = "Txt_CurrentUsage";
            this.Txt_CurrentUsage.Size = new System.Drawing.Size(120, 25);
            this.Txt_CurrentUsage.TabIndex = 24;
            // 
            // Btn_SubmitPrint
            // 
            this.Btn_SubmitPrint.AutoSize = true;
            this.Btn_SubmitPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_SubmitPrint.Depth = 0;
            this.Btn_SubmitPrint.Icon = null;
            this.Btn_SubmitPrint.Location = new System.Drawing.Point(175, 205);
            this.Btn_SubmitPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_SubmitPrint.Name = "Btn_SubmitPrint";
            this.Btn_SubmitPrint.Primary = true;
            this.Btn_SubmitPrint.Size = new System.Drawing.Size(126, 36);
            this.Btn_SubmitPrint.TabIndex = 25;
            this.Btn_SubmitPrint.Text = "Submit & Print";
            this.Btn_SubmitPrint.UseVisualStyleBackColor = true;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.AutoSize = true;
            this.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Submit.Depth = 0;
            this.Btn_Submit.Icon = null;
            this.Btn_Submit.Location = new System.Drawing.Point(58, 205);
            this.Btn_Submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Primary = true;
            this.Btn_Submit.Size = new System.Drawing.Size(110, 36);
            this.Btn_Submit.TabIndex = 26;
            this.Btn_Submit.Text = "Submit only";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            // 
            // Txt_Total
            // 
            this.Txt_Total.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(151, 174);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(113, 25);
            this.Txt_Total.TabIndex = 27;
            this.Txt_Total.Text = "1500";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(147, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Total Cost:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(270, 176);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 29;
            this.materialLabel2.Text = "L.L.";
            // 
            // Frm_ReleaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 254);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Btn_SubmitPrint);
            this.Controls.Add(this.Txt_CurrentUsage);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.Lbl_LastUsage);
            this.Controls.Add(this.Lbl_CustomerName);
            this.Controls.Add(this.Lbl_CustomerID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReleaseInvoice";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CurrentUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel Lbl_CustomerID;
        private MaterialSkin.Controls.MaterialLabel Lbl_CustomerName;
        private MaterialSkin.Controls.MaterialLabel Lbl_LastUsage;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.NumericUpDown Txt_CurrentUsage;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_SubmitPrint;
        private MaterialSkin.Controls.MaterialFlatButton Btn_Submit;
        private System.Windows.Forms.TextBox Txt_Total;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}