namespace Electricity_Management_System
{
    partial class Frm_CounterDetails
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
            this.Btn_Exit = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btn_Edit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Lbl_BoxID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_MonthlyCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_TotalUsage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_CounterID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_CounterType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AutoSize = true;
            this.Btn_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Exit.BackColor = System.Drawing.Color.White;
            this.Btn_Exit.Depth = 0;
            this.Btn_Exit.Icon = null;
            this.Btn_Exit.Location = new System.Drawing.Point(73, 269);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Primary = true;
            this.Btn_Exit.Size = new System.Drawing.Size(63, 36);
            this.Btn_Exit.TabIndex = 23;
            this.Btn_Exit.Text = "Close";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.AutoSize = true;
            this.Btn_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Edit.Depth = 0;
            this.Btn_Edit.Icon = null;
            this.Btn_Edit.Location = new System.Drawing.Point(16, 269);
            this.Btn_Edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Primary = true;
            this.Btn_Edit.Size = new System.Drawing.Size(50, 36);
            this.Btn_Edit.TabIndex = 22;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            // 
            // Lbl_BoxID
            // 
            this.Lbl_BoxID.AutoSize = true;
            this.Lbl_BoxID.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_BoxID.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BoxID.Location = new System.Drawing.Point(223, 97);
            this.Lbl_BoxID.Name = "Lbl_BoxID";
            this.Lbl_BoxID.Size = new System.Drawing.Size(60, 29);
            this.Lbl_BoxID.TabIndex = 19;
            this.Lbl_BoxID.Text = "<ID>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F);
            this.label6.Location = new System.Drawing.Point(223, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Box ID:";
            // 
            // Lbl_MonthlyCost
            // 
            this.Lbl_MonthlyCost.AutoSize = true;
            this.Lbl_MonthlyCost.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_MonthlyCost.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MonthlyCost.Location = new System.Drawing.Point(14, 215);
            this.Lbl_MonthlyCost.Name = "Lbl_MonthlyCost";
            this.Lbl_MonthlyCost.Size = new System.Drawing.Size(180, 29);
            this.Lbl_MonthlyCost.TabIndex = 17;
            this.Lbl_MonthlyCost.Text = "<Monthly Cost>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F);
            this.label4.Location = new System.Drawing.Point(14, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monthly Cost:";
            // 
            // Lbl_TotalUsage
            // 
            this.Lbl_TotalUsage.AutoSize = true;
            this.Lbl_TotalUsage.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_TotalUsage.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TotalUsage.Location = new System.Drawing.Point(13, 156);
            this.Lbl_TotalUsage.MaximumSize = new System.Drawing.Size(350, 29);
            this.Lbl_TotalUsage.Name = "Lbl_TotalUsage";
            this.Lbl_TotalUsage.Size = new System.Drawing.Size(105, 29);
            this.Lbl_TotalUsage.TabIndex = 15;
            this.Lbl_TotalUsage.Text = "<Usage>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F);
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Usage:";
            // 
            // Lbl_CounterID
            // 
            this.Lbl_CounterID.AutoSize = true;
            this.Lbl_CounterID.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CounterID.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CounterID.Location = new System.Drawing.Point(12, 97);
            this.Lbl_CounterID.Name = "Lbl_CounterID";
            this.Lbl_CounterID.Size = new System.Drawing.Size(60, 29);
            this.Lbl_CounterID.TabIndex = 13;
            this.Lbl_CounterID.Text = "<ID>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Counter ID:";
            // 
            // Lbl_CounterType
            // 
            this.Lbl_CounterType.AutoSize = true;
            this.Lbl_CounterType.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CounterType.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CounterType.Location = new System.Drawing.Point(223, 156);
            this.Lbl_CounterType.MaximumSize = new System.Drawing.Size(350, 29);
            this.Lbl_CounterType.Name = "Lbl_CounterType";
            this.Lbl_CounterType.Size = new System.Drawing.Size(181, 29);
            this.Lbl_CounterType.TabIndex = 25;
            this.Lbl_CounterType.Text = "<Type> Ampere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F);
            this.label5.Location = new System.Drawing.Point(223, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Type:";
            // 
            // Frm_CounterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.ControlBox = false;
            this.Controls.Add(this.Lbl_CounterType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Lbl_BoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lbl_MonthlyCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_TotalUsage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_CounterID);
            this.Controls.Add(this.label1);
            this.Name = "Frm_CounterDetails";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Btn_Exit;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_Edit;
        private System.Windows.Forms.Label Lbl_BoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_MonthlyCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_TotalUsage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_CounterID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_CounterType;
        private System.Windows.Forms.Label label5;
    }
}