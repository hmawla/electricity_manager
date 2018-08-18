namespace Electricity_Management_System
{
    partial class Frm_CustomerEdit
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
            this.Txt_Customer_Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Btn_Submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Lbl_Customer_ID = new MaterialSkin.Controls.MaterialLabel();
            this.CBox_Region = new System.Windows.Forms.ComboBox();
            this.Lbl_Customer_Name = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Customer_Phone = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_Customer_Phone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_Customer_Floor = new System.Windows.Forms.NumericUpDown();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CBox_Street = new System.Windows.Forms.ComboBox();
            this.Txt_Building = new MaterialSkin.Controls.MaterialLabel();
            this.CBox_Building = new System.Windows.Forms.ComboBox();
            this.Txt_CounterType = new System.Windows.Forms.NumericUpDown();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_MonthlyCost = new System.Windows.Forms.NumericUpDown();
            this.Txt_InitialUsage = new System.Windows.Forms.NumericUpDown();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.Cbox_Box = new MetroFramework.Controls.MetroComboBox();
            this.Btn_New = new MaterialSkin.Controls.MaterialFlatButton();
            this.Lbl_Box_ID = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Customer_Floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CounterType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MonthlyCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_InitialUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Customer_Name
            // 
            this.Txt_Customer_Name.Depth = 0;
            this.Txt_Customer_Name.Hint = "";
            this.Txt_Customer_Name.Location = new System.Drawing.Point(26, 155);
            this.Txt_Customer_Name.MaxLength = 32767;
            this.Txt_Customer_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Customer_Name.Name = "Txt_Customer_Name";
            this.Txt_Customer_Name.PasswordChar = '\0';
            this.Txt_Customer_Name.SelectedText = "";
            this.Txt_Customer_Name.SelectionLength = 0;
            this.Txt_Customer_Name.SelectionStart = 0;
            this.Txt_Customer_Name.Size = new System.Drawing.Size(139, 23);
            this.Txt_Customer_Name.TabIndex = 1;
            this.Txt_Customer_Name.TabStop = false;
            this.Txt_Customer_Name.UseSystemPasswordChar = false;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.AutoSize = true;
            this.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Submit.Depth = 0;
            this.Btn_Submit.Icon = null;
            this.Btn_Submit.Location = new System.Drawing.Point(557, 214);
            this.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Primary = true;
            this.Btn_Submit.Size = new System.Drawing.Size(71, 36);
            this.Btn_Submit.TabIndex = 11;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            // 
            // Lbl_Customer_ID
            // 
            this.Lbl_Customer_ID.AutoSize = true;
            this.Lbl_Customer_ID.Depth = 0;
            this.Lbl_Customer_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Customer_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Customer_ID.Location = new System.Drawing.Point(22, 101);
            this.Lbl_Customer_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Customer_ID.Name = "Lbl_Customer_ID";
            this.Lbl_Customer_ID.Size = new System.Drawing.Size(97, 19);
            this.Lbl_Customer_ID.TabIndex = 2;
            this.Lbl_Customer_ID.Text = "Customer ID:";
            // 
            // CBox_Region
            // 
            this.CBox_Region.Font = new System.Drawing.Font("Roboto", 11F);
            this.CBox_Region.FormattingEnabled = true;
            this.CBox_Region.Location = new System.Drawing.Point(190, 156);
            this.CBox_Region.Name = "CBox_Region";
            this.CBox_Region.Size = new System.Drawing.Size(145, 27);
            this.CBox_Region.TabIndex = 4;
            // 
            // Lbl_Customer_Name
            // 
            this.Lbl_Customer_Name.AutoSize = true;
            this.Lbl_Customer_Name.Depth = 0;
            this.Lbl_Customer_Name.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Customer_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Customer_Name.Location = new System.Drawing.Point(22, 133);
            this.Lbl_Customer_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Customer_Name.Name = "Lbl_Customer_Name";
            this.Lbl_Customer_Name.Size = new System.Drawing.Size(53, 19);
            this.Lbl_Customer_Name.TabIndex = 4;
            this.Lbl_Customer_Name.Text = "Name:";
            // 
            // Lbl_Customer_Phone
            // 
            this.Lbl_Customer_Phone.AutoSize = true;
            this.Lbl_Customer_Phone.Depth = 0;
            this.Lbl_Customer_Phone.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Customer_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Customer_Phone.Location = new System.Drawing.Point(22, 186);
            this.Lbl_Customer_Phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Customer_Phone.Name = "Lbl_Customer_Phone";
            this.Lbl_Customer_Phone.Size = new System.Drawing.Size(55, 19);
            this.Lbl_Customer_Phone.TabIndex = 6;
            this.Lbl_Customer_Phone.Text = "Phone:";
            // 
            // Txt_Customer_Phone
            // 
            this.Txt_Customer_Phone.Depth = 0;
            this.Txt_Customer_Phone.Hint = "";
            this.Txt_Customer_Phone.Location = new System.Drawing.Point(26, 208);
            this.Txt_Customer_Phone.MaxLength = 32767;
            this.Txt_Customer_Phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Customer_Phone.Name = "Txt_Customer_Phone";
            this.Txt_Customer_Phone.PasswordChar = '\0';
            this.Txt_Customer_Phone.SelectedText = "";
            this.Txt_Customer_Phone.SelectionLength = 0;
            this.Txt_Customer_Phone.SelectionStart = 0;
            this.Txt_Customer_Phone.Size = new System.Drawing.Size(139, 23);
            this.Txt_Customer_Phone.TabIndex = 2;
            this.Txt_Customer_Phone.TabStop = false;
            this.Txt_Customer_Phone.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(186, 133);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Region:";
            // 
            // Txt_Customer_Floor
            // 
            this.Txt_Customer_Floor.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_Customer_Floor.Location = new System.Drawing.Point(26, 261);
            this.Txt_Customer_Floor.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Txt_Customer_Floor.Name = "Txt_Customer_Floor";
            this.Txt_Customer_Floor.Size = new System.Drawing.Size(139, 25);
            this.Txt_Customer_Floor.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(22, 239);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(48, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Floor:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(186, 186);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Street:";
            // 
            // CBox_Street
            // 
            this.CBox_Street.Font = new System.Drawing.Font("Roboto", 11F);
            this.CBox_Street.FormattingEnabled = true;
            this.CBox_Street.Location = new System.Drawing.Point(190, 209);
            this.CBox_Street.Name = "CBox_Street";
            this.CBox_Street.Size = new System.Drawing.Size(145, 27);
            this.CBox_Street.TabIndex = 5;
            // 
            // Txt_Building
            // 
            this.Txt_Building.AutoSize = true;
            this.Txt_Building.Depth = 0;
            this.Txt_Building.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_Building.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt_Building.Location = new System.Drawing.Point(186, 239);
            this.Txt_Building.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Building.Name = "Txt_Building";
            this.Txt_Building.Size = new System.Drawing.Size(66, 19);
            this.Txt_Building.TabIndex = 20;
            this.Txt_Building.Text = "Building:";
            // 
            // CBox_Building
            // 
            this.CBox_Building.Font = new System.Drawing.Font("Roboto", 11F);
            this.CBox_Building.FormattingEnabled = true;
            this.CBox_Building.Location = new System.Drawing.Point(190, 262);
            this.CBox_Building.Name = "CBox_Building";
            this.CBox_Building.Size = new System.Drawing.Size(145, 27);
            this.CBox_Building.TabIndex = 6;
            // 
            // Txt_CounterType
            // 
            this.Txt_CounterType.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_CounterType.Location = new System.Drawing.Point(500, 175);
            this.Txt_CounterType.Name = "Txt_CounterType";
            this.Txt_CounterType.Size = new System.Drawing.Size(128, 25);
            this.Txt_CounterType.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(496, 155);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(111, 19);
            this.materialLabel3.TabIndex = 42;
            this.materialLabel3.Text = "Type (Ampere):";
            // 
            // Txt_MonthlyCost
            // 
            this.Txt_MonthlyCost.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_MonthlyCost.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Txt_MonthlyCost.Location = new System.Drawing.Point(366, 225);
            this.Txt_MonthlyCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Txt_MonthlyCost.Name = "Txt_MonthlyCost";
            this.Txt_MonthlyCost.Size = new System.Drawing.Size(128, 25);
            this.Txt_MonthlyCost.TabIndex = 10;
            // 
            // Txt_InitialUsage
            // 
            this.Txt_InitialUsage.DecimalPlaces = 1;
            this.Txt_InitialUsage.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_InitialUsage.Location = new System.Drawing.Point(366, 175);
            this.Txt_InitialUsage.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Txt_InitialUsage.Name = "Txt_InitialUsage";
            this.Txt_InitialUsage.ReadOnly = true;
            this.Txt_InitialUsage.Size = new System.Drawing.Size(128, 25);
            this.Txt_InitialUsage.TabIndex = 8;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(362, 203);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(137, 19);
            this.materialLabel5.TabIndex = 41;
            this.materialLabel5.Text = "Monthly Cost (L.L):";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(362, 155);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(100, 19);
            this.materialLabel6.TabIndex = 40;
            this.materialLabel6.Text = "Usage (Watt):";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(345, 77);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 261);
            this.materialDivider1.TabIndex = 43;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Cbox_Box
            // 
            this.Cbox_Box.FormattingEnabled = true;
            this.Cbox_Box.ItemHeight = 23;
            this.Cbox_Box.Location = new System.Drawing.Point(366, 123);
            this.Cbox_Box.Name = "Cbox_Box";
            this.Cbox_Box.Size = new System.Drawing.Size(155, 29);
            this.Cbox_Box.TabIndex = 7;
            this.Cbox_Box.UseSelectable = true;
            // 
            // Btn_New
            // 
            this.Btn_New.AutoSize = true;
            this.Btn_New.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_New.Depth = 0;
            this.Btn_New.Icon = null;
            this.Btn_New.Location = new System.Drawing.Point(528, 120);
            this.Btn_New.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_New.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Primary = true;
            this.Btn_New.Size = new System.Drawing.Size(51, 36);
            this.Btn_New.TabIndex = 48;
            this.Btn_New.Text = "New";
            this.Btn_New.UseVisualStyleBackColor = true;
            // 
            // Lbl_Box_ID
            // 
            this.Lbl_Box_ID.AutoSize = true;
            this.Lbl_Box_ID.Depth = 0;
            this.Lbl_Box_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Box_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Box_ID.Location = new System.Drawing.Point(362, 101);
            this.Lbl_Box_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Box_ID.Name = "Lbl_Box_ID";
            this.Lbl_Box_ID.Size = new System.Drawing.Size(56, 19);
            this.Lbl_Box_ID.TabIndex = 49;
            this.Lbl_Box_ID.Text = "Box ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13F);
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Customer Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 13F);
            this.label2.Location = new System.Drawing.Point(352, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Counter Details:";
            // 
            // Frm_CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbox_Box);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Lbl_Box_ID);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.Txt_CounterType);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Txt_MonthlyCost);
            this.Controls.Add(this.Txt_InitialUsage);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.Txt_Building);
            this.Controls.Add(this.CBox_Building);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.CBox_Street);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.Txt_Customer_Floor);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Lbl_Customer_Phone);
            this.Controls.Add(this.Txt_Customer_Phone);
            this.Controls.Add(this.Lbl_Customer_Name);
            this.Controls.Add(this.CBox_Region);
            this.Controls.Add(this.Lbl_Customer_ID);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Txt_Customer_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CustomerEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Customer_Floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CounterType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MonthlyCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_InitialUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_Customer_Name;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_Submit;
        private MaterialSkin.Controls.MaterialLabel Lbl_Customer_ID;
        private System.Windows.Forms.ComboBox CBox_Region;
        private MaterialSkin.Controls.MaterialLabel Lbl_Customer_Name;
        private MaterialSkin.Controls.MaterialLabel Lbl_Customer_Phone;
        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_Customer_Phone;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NumericUpDown Txt_Customer_Floor;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox CBox_Street;
        private MaterialSkin.Controls.MaterialLabel Txt_Building;
        private System.Windows.Forms.ComboBox CBox_Building;
        private System.Windows.Forms.NumericUpDown Txt_CounterType;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown Txt_MonthlyCost;
        private System.Windows.Forms.NumericUpDown Txt_InitialUsage;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroComboBox Cbox_Box;
        private MaterialSkin.Controls.MaterialFlatButton Btn_New;
        private MaterialSkin.Controls.MaterialLabel Lbl_Box_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}