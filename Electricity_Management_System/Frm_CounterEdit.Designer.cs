namespace Electricity_Management_System
{
    partial class Frm_CounterEdit
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
            this.Btn_New = new MaterialSkin.Controls.MaterialFlatButton();
            this.Lbl_Box_ID = new MaterialSkin.Controls.MaterialLabel();
            this.Cbox_Box = new System.Windows.Forms.ComboBox();
            this.Lbl_Customer_Phone = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Customer_Name = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Counter_ID = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_Submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Txt_InitialUsage = new System.Windows.Forms.NumericUpDown();
            this.Txt_MonthlyCost = new System.Windows.Forms.NumericUpDown();
            this.Txt_CounterType = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_InitialUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MonthlyCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CounterType)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_New
            // 
            this.Btn_New.AutoSize = true;
            this.Btn_New.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_New.Depth = 0;
            this.Btn_New.Icon = null;
            this.Btn_New.Location = new System.Drawing.Point(152, 127);
            this.Btn_New.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_New.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Primary = true;
            this.Btn_New.Size = new System.Drawing.Size(51, 36);
            this.Btn_New.TabIndex = 1;
            this.Btn_New.Text = "New";
            this.Btn_New.UseVisualStyleBackColor = true;
            // 
            // Lbl_Box_ID
            // 
            this.Lbl_Box_ID.AutoSize = true;
            this.Lbl_Box_ID.Depth = 0;
            this.Lbl_Box_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Box_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Box_ID.Location = new System.Drawing.Point(12, 110);
            this.Lbl_Box_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Box_ID.Name = "Lbl_Box_ID";
            this.Lbl_Box_ID.Size = new System.Drawing.Size(56, 19);
            this.Lbl_Box_ID.TabIndex = 32;
            this.Lbl_Box_ID.Text = "Box ID:";
            // 
            // Cbox_Box
            // 
            this.Cbox_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Box.Font = new System.Drawing.Font("Roboto", 11F);
            this.Cbox_Box.FormattingEnabled = true;
            this.Cbox_Box.Location = new System.Drawing.Point(12, 132);
            this.Cbox_Box.Name = "Cbox_Box";
            this.Cbox_Box.Size = new System.Drawing.Size(133, 27);
            this.Cbox_Box.TabIndex = 0;
            // 
            // Lbl_Customer_Phone
            // 
            this.Lbl_Customer_Phone.AutoSize = true;
            this.Lbl_Customer_Phone.Depth = 0;
            this.Lbl_Customer_Phone.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Customer_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Customer_Phone.Location = new System.Drawing.Point(12, 219);
            this.Lbl_Customer_Phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Customer_Phone.Name = "Lbl_Customer_Phone";
            this.Lbl_Customer_Phone.Size = new System.Drawing.Size(137, 19);
            this.Lbl_Customer_Phone.TabIndex = 27;
            this.Lbl_Customer_Phone.Text = "Monthly Cost (L.L):";
            // 
            // Lbl_Customer_Name
            // 
            this.Lbl_Customer_Name.AutoSize = true;
            this.Lbl_Customer_Name.Depth = 0;
            this.Lbl_Customer_Name.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Customer_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Customer_Name.Location = new System.Drawing.Point(12, 169);
            this.Lbl_Customer_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Customer_Name.Name = "Lbl_Customer_Name";
            this.Lbl_Customer_Name.Size = new System.Drawing.Size(100, 19);
            this.Lbl_Customer_Name.TabIndex = 25;
            this.Lbl_Customer_Name.Text = "Usage (Watt):";
            // 
            // Lbl_Counter_ID
            // 
            this.Lbl_Counter_ID.AutoSize = true;
            this.Lbl_Counter_ID.Depth = 0;
            this.Lbl_Counter_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Counter_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Counter_ID.Location = new System.Drawing.Point(12, 77);
            this.Lbl_Counter_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Counter_ID.Name = "Lbl_Counter_ID";
            this.Lbl_Counter_ID.Size = new System.Drawing.Size(84, 19);
            this.Lbl_Counter_ID.TabIndex = 23;
            this.Lbl_Counter_ID.Text = "Counter ID:";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.AutoSize = true;
            this.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Submit.Depth = 0;
            this.Btn_Submit.Icon = null;
            this.Btn_Submit.Location = new System.Drawing.Point(203, 235);
            this.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Primary = true;
            this.Btn_Submit.Size = new System.Drawing.Size(71, 36);
            this.Btn_Submit.TabIndex = 5;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            // 
            // Txt_InitialUsage
            // 
            this.Txt_InitialUsage.DecimalPlaces = 1;
            this.Txt_InitialUsage.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_InitialUsage.Location = new System.Drawing.Point(12, 191);
            this.Txt_InitialUsage.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Txt_InitialUsage.Name = "Txt_InitialUsage";
            this.Txt_InitialUsage.ReadOnly = true;
            this.Txt_InitialUsage.Size = new System.Drawing.Size(128, 25);
            this.Txt_InitialUsage.TabIndex = 2;
            // 
            // Txt_MonthlyCost
            // 
            this.Txt_MonthlyCost.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_MonthlyCost.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Txt_MonthlyCost.Location = new System.Drawing.Point(12, 241);
            this.Txt_MonthlyCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Txt_MonthlyCost.Name = "Txt_MonthlyCost";
            this.Txt_MonthlyCost.Size = new System.Drawing.Size(128, 25);
            this.Txt_MonthlyCost.TabIndex = 4;
            // 
            // Txt_CounterType
            // 
            this.Txt_CounterType.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_CounterType.Location = new System.Drawing.Point(146, 191);
            this.Txt_CounterType.Name = "Txt_CounterType";
            this.Txt_CounterType.Size = new System.Drawing.Size(128, 25);
            this.Txt_CounterType.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(146, 169);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Type (Ampere):";
            // 
            // Frm_CounterEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 286);
            this.Controls.Add(this.Txt_CounterType);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Txt_MonthlyCost);
            this.Controls.Add(this.Txt_InitialUsage);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Lbl_Box_ID);
            this.Controls.Add(this.Cbox_Box);
            this.Controls.Add(this.Lbl_Customer_Phone);
            this.Controls.Add(this.Lbl_Customer_Name);
            this.Controls.Add(this.Lbl_Counter_ID);
            this.Controls.Add(this.Btn_Submit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CounterEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_InitialUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MonthlyCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CounterType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Btn_New;
        private MaterialSkin.Controls.MaterialLabel Lbl_Box_ID;
        private System.Windows.Forms.ComboBox Cbox_Box;
        private MaterialSkin.Controls.MaterialLabel Lbl_Customer_Phone;
        private MaterialSkin.Controls.MaterialLabel Lbl_Customer_Name;
        private MaterialSkin.Controls.MaterialLabel Lbl_Counter_ID;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_Submit;
        private System.Windows.Forms.NumericUpDown Txt_InitialUsage;
        private System.Windows.Forms.NumericUpDown Txt_MonthlyCost;
        private System.Windows.Forms.NumericUpDown Txt_CounterType;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}