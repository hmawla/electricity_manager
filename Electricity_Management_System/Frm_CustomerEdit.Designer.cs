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
            this.Lbl_Counter_ID = new MaterialSkin.Controls.MaterialLabel();
            this.Cbox_Counter = new System.Windows.Forms.ComboBox();
            this.Btn_New = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CBox_Street = new System.Windows.Forms.ComboBox();
            this.Txt_Building = new MaterialSkin.Controls.MaterialLabel();
            this.CBox_Building = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Customer_Floor)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Customer_Name
            // 
            this.Txt_Customer_Name.Depth = 0;
            this.Txt_Customer_Name.Hint = "";
            this.Txt_Customer_Name.Location = new System.Drawing.Point(16, 177);
            this.Txt_Customer_Name.MaxLength = 32767;
            this.Txt_Customer_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Customer_Name.Name = "Txt_Customer_Name";
            this.Txt_Customer_Name.PasswordChar = '\0';
            this.Txt_Customer_Name.SelectedText = "";
            this.Txt_Customer_Name.SelectionLength = 0;
            this.Txt_Customer_Name.SelectionStart = 0;
            this.Txt_Customer_Name.Size = new System.Drawing.Size(139, 23);
            this.Txt_Customer_Name.TabIndex = 0;
            this.Txt_Customer_Name.TabStop = false;
            this.Txt_Customer_Name.UseSystemPasswordChar = false;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.AutoSize = true;
            this.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Submit.Depth = 0;
            this.Btn_Submit.Icon = null;
            this.Btn_Submit.Location = new System.Drawing.Point(254, 332);
            this.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Primary = true;
            this.Btn_Submit.Size = new System.Drawing.Size(71, 36);
            this.Btn_Submit.TabIndex = 1;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            // 
            // Lbl_Customer_ID
            // 
            this.Lbl_Customer_ID.AutoSize = true;
            this.Lbl_Customer_ID.Depth = 0;
            this.Lbl_Customer_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Customer_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Customer_ID.Location = new System.Drawing.Point(12, 77);
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
            this.CBox_Region.Location = new System.Drawing.Point(180, 178);
            this.CBox_Region.Name = "CBox_Region";
            this.CBox_Region.Size = new System.Drawing.Size(145, 27);
            this.CBox_Region.TabIndex = 3;
            // 
            // Lbl_Customer_Name
            // 
            this.Lbl_Customer_Name.AutoSize = true;
            this.Lbl_Customer_Name.Depth = 0;
            this.Lbl_Customer_Name.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Customer_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Customer_Name.Location = new System.Drawing.Point(12, 155);
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
            this.Lbl_Customer_Phone.Location = new System.Drawing.Point(12, 208);
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
            this.Txt_Customer_Phone.Location = new System.Drawing.Point(16, 230);
            this.Txt_Customer_Phone.MaxLength = 32767;
            this.Txt_Customer_Phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Customer_Phone.Name = "Txt_Customer_Phone";
            this.Txt_Customer_Phone.PasswordChar = '\0';
            this.Txt_Customer_Phone.SelectedText = "";
            this.Txt_Customer_Phone.SelectionLength = 0;
            this.Txt_Customer_Phone.SelectionStart = 0;
            this.Txt_Customer_Phone.Size = new System.Drawing.Size(139, 23);
            this.Txt_Customer_Phone.TabIndex = 5;
            this.Txt_Customer_Phone.TabStop = false;
            this.Txt_Customer_Phone.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(176, 155);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Region:";
            // 
            // Txt_Customer_Floor
            // 
            this.Txt_Customer_Floor.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_Customer_Floor.Location = new System.Drawing.Point(16, 283);
            this.Txt_Customer_Floor.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Txt_Customer_Floor.Name = "Txt_Customer_Floor";
            this.Txt_Customer_Floor.Size = new System.Drawing.Size(139, 25);
            this.Txt_Customer_Floor.TabIndex = 12;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 261);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(48, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Floor:";
            // 
            // Lbl_Counter_ID
            // 
            this.Lbl_Counter_ID.AutoSize = true;
            this.Lbl_Counter_ID.Depth = 0;
            this.Lbl_Counter_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Counter_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Counter_ID.Location = new System.Drawing.Point(12, 110);
            this.Lbl_Counter_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Counter_ID.Name = "Lbl_Counter_ID";
            this.Lbl_Counter_ID.Size = new System.Drawing.Size(84, 19);
            this.Lbl_Counter_ID.TabIndex = 15;
            this.Lbl_Counter_ID.Text = "Counter ID:";
            // 
            // Cbox_Counter
            // 
            this.Cbox_Counter.Font = new System.Drawing.Font("Roboto", 11F);
            this.Cbox_Counter.FormattingEnabled = true;
            this.Cbox_Counter.Location = new System.Drawing.Point(102, 107);
            this.Cbox_Counter.Name = "Cbox_Counter";
            this.Cbox_Counter.Size = new System.Drawing.Size(145, 27);
            this.Cbox_Counter.TabIndex = 14;
            // 
            // Btn_New
            // 
            this.Btn_New.AutoSize = true;
            this.Btn_New.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_New.Depth = 0;
            this.Btn_New.Icon = null;
            this.Btn_New.Location = new System.Drawing.Point(254, 102);
            this.Btn_New.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_New.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Primary = true;
            this.Btn_New.Size = new System.Drawing.Size(51, 36);
            this.Btn_New.TabIndex = 16;
            this.Btn_New.Text = "New";
            this.Btn_New.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(176, 208);
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
            this.CBox_Street.Location = new System.Drawing.Point(180, 231);
            this.CBox_Street.Name = "CBox_Street";
            this.CBox_Street.Size = new System.Drawing.Size(145, 27);
            this.CBox_Street.TabIndex = 17;
            // 
            // Txt_Building
            // 
            this.Txt_Building.AutoSize = true;
            this.Txt_Building.Depth = 0;
            this.Txt_Building.Font = new System.Drawing.Font("Roboto", 11F);
            this.Txt_Building.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt_Building.Location = new System.Drawing.Point(176, 261);
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
            this.CBox_Building.Location = new System.Drawing.Point(180, 284);
            this.CBox_Building.Name = "CBox_Building";
            this.CBox_Building.Size = new System.Drawing.Size(145, 27);
            this.CBox_Building.TabIndex = 19;
            // 
            // Frm_CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 382);
            this.Controls.Add(this.Txt_Building);
            this.Controls.Add(this.CBox_Building);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.CBox_Street);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Lbl_Counter_ID);
            this.Controls.Add(this.Cbox_Counter);
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
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Customer_Floor)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel Lbl_Counter_ID;
        private System.Windows.Forms.ComboBox Cbox_Counter;
        private MaterialSkin.Controls.MaterialFlatButton Btn_New;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox CBox_Street;
        private MaterialSkin.Controls.MaterialLabel Txt_Building;
        private System.Windows.Forms.ComboBox CBox_Building;
    }
}