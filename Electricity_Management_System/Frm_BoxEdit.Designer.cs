namespace Electricity_Management_System
{
    partial class Frm_BoxEdit
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
            this.Lbl_Box_Name = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Box_ID = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_Submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Txt_Box_Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CBox_Street = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CBox_Region = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Lbl_Box_Name
            // 
            this.Lbl_Box_Name.AutoSize = true;
            this.Lbl_Box_Name.Depth = 0;
            this.Lbl_Box_Name.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Box_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Box_Name.Location = new System.Drawing.Point(12, 115);
            this.Lbl_Box_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Box_Name.Name = "Lbl_Box_Name";
            this.Lbl_Box_Name.Size = new System.Drawing.Size(82, 19);
            this.Lbl_Box_Name.TabIndex = 25;
            this.Lbl_Box_Name.Text = "Box Name:";
            // 
            // Lbl_Box_ID
            // 
            this.Lbl_Box_ID.AutoSize = true;
            this.Lbl_Box_ID.Depth = 0;
            this.Lbl_Box_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_Box_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Box_ID.Location = new System.Drawing.Point(12, 74);
            this.Lbl_Box_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Box_ID.Name = "Lbl_Box_ID";
            this.Lbl_Box_ID.Size = new System.Drawing.Size(56, 19);
            this.Lbl_Box_ID.TabIndex = 23;
            this.Lbl_Box_ID.Text = "Box ID:";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.AutoSize = true;
            this.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Submit.Depth = 0;
            this.Btn_Submit.Icon = null;
            this.Btn_Submit.Location = new System.Drawing.Point(241, 220);
            this.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Primary = true;
            this.Btn_Submit.Size = new System.Drawing.Size(71, 36);
            this.Btn_Submit.TabIndex = 22;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            // 
            // Txt_Box_Name
            // 
            this.Txt_Box_Name.Depth = 0;
            this.Txt_Box_Name.Hint = "";
            this.Txt_Box_Name.Location = new System.Drawing.Point(16, 137);
            this.Txt_Box_Name.MaxLength = 32767;
            this.Txt_Box_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Box_Name.Name = "Txt_Box_Name";
            this.Txt_Box_Name.PasswordChar = '\0';
            this.Txt_Box_Name.SelectedText = "";
            this.Txt_Box_Name.SelectionLength = 0;
            this.Txt_Box_Name.SelectionStart = 0;
            this.Txt_Box_Name.Size = new System.Drawing.Size(139, 23);
            this.Txt_Box_Name.TabIndex = 21;
            this.Txt_Box_Name.TabStop = false;
            this.Txt_Box_Name.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(163, 162);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 19);
            this.materialLabel2.TabIndex = 29;
            this.materialLabel2.Text = "Street:";
            // 
            // CBox_Street
            // 
            this.CBox_Street.Font = new System.Drawing.Font("Roboto", 11F);
            this.CBox_Street.FormattingEnabled = true;
            this.CBox_Street.Location = new System.Drawing.Point(167, 185);
            this.CBox_Street.Name = "CBox_Street";
            this.CBox_Street.Size = new System.Drawing.Size(145, 27);
            this.CBox_Street.TabIndex = 28;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 162);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Region:";
            // 
            // CBox_Region
            // 
            this.CBox_Region.Font = new System.Drawing.Font("Roboto", 11F);
            this.CBox_Region.FormattingEnabled = true;
            this.CBox_Region.Location = new System.Drawing.Point(16, 185);
            this.CBox_Region.Name = "CBox_Region";
            this.CBox_Region.Size = new System.Drawing.Size(145, 27);
            this.CBox_Region.TabIndex = 26;
            // 
            // Frm_BoxEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 269);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.CBox_Street);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CBox_Region);
            this.Controls.Add(this.Lbl_Box_Name);
            this.Controls.Add(this.Lbl_Box_ID);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Txt_Box_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BoxEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel Lbl_Box_Name;
        private MaterialSkin.Controls.MaterialLabel Lbl_Box_ID;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_Submit;
        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_Box_Name;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox CBox_Street;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox CBox_Region;
    }
}