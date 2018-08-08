namespace Electricity_Management_System
{
    partial class Frm_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.Tab_Navigator = new MaterialSkin.Controls.MaterialTabControl();
            this.Tab_Info = new System.Windows.Forms.TabPage();
            this.Tab_Customers = new System.Windows.Forms.TabPage();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Tab_Counters = new System.Windows.Forms.TabPage();
            this.Tab_Invoices = new System.Windows.Forms.TabPage();
            this.Tab_Boxes = new System.Windows.Forms.TabPage();
            this.Tab_General = new System.Windows.Forms.TabPage();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.Btn_AddNewCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Btn_ModCustomer = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btn_DeleteCustomer = new MaterialSkin.Controls.MaterialFlatButton();
            this.Txt_FindCustomerByName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_Reset = new MaterialSkin.Controls.MaterialFlatButton();
            this.Tab_Navigator.SuspendLayout();
            this.Tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.Tab_Navigator;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(754, 32);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Tab_Navigator
            // 
            this.Tab_Navigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Navigator.Controls.Add(this.Tab_Info);
            this.Tab_Navigator.Controls.Add(this.Tab_Customers);
            this.Tab_Navigator.Controls.Add(this.Tab_Counters);
            this.Tab_Navigator.Controls.Add(this.Tab_Boxes);
            this.Tab_Navigator.Controls.Add(this.Tab_Invoices);
            this.Tab_Navigator.Controls.Add(this.Tab_General);
            this.Tab_Navigator.Depth = 0;
            this.Tab_Navigator.Location = new System.Drawing.Point(12, 101);
            this.Tab_Navigator.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_Navigator.Name = "Tab_Navigator";
            this.Tab_Navigator.SelectedIndex = 0;
            this.Tab_Navigator.Size = new System.Drawing.Size(726, 395);
            this.Tab_Navigator.TabIndex = 1;
            // 
            // Tab_Info
            // 
            this.Tab_Info.Location = new System.Drawing.Point(4, 22);
            this.Tab_Info.Name = "Tab_Info";
            this.Tab_Info.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Info.Size = new System.Drawing.Size(718, 369);
            this.Tab_Info.TabIndex = 0;
            this.Tab_Info.Text = "INFO";
            this.Tab_Info.UseVisualStyleBackColor = true;
            // 
            // Tab_Customers
            // 
            this.Tab_Customers.BackColor = System.Drawing.Color.White;
            this.Tab_Customers.Controls.Add(this.Btn_Reset);
            this.Tab_Customers.Controls.Add(this.materialLabel1);
            this.Tab_Customers.Controls.Add(this.Txt_FindCustomerByName);
            this.Tab_Customers.Controls.Add(this.Btn_DeleteCustomer);
            this.Tab_Customers.Controls.Add(this.Btn_ModCustomer);
            this.Tab_Customers.Controls.Add(this.Btn_AddNewCustomer);
            this.Tab_Customers.Controls.Add(this.DGV_Customers);
            this.Tab_Customers.Location = new System.Drawing.Point(4, 22);
            this.Tab_Customers.Name = "Tab_Customers";
            this.Tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Customers.Size = new System.Drawing.Size(718, 369);
            this.Tab_Customers.TabIndex = 1;
            this.Tab_Customers.Text = "CUSTOMERS";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-1, 501);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(754, 1);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(683, 508);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(55, 36);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "HELP";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(610, 508);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(66, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "About";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // Tab_Counters
            // 
            this.Tab_Counters.Location = new System.Drawing.Point(4, 22);
            this.Tab_Counters.Name = "Tab_Counters";
            this.Tab_Counters.Size = new System.Drawing.Size(718, 369);
            this.Tab_Counters.TabIndex = 2;
            this.Tab_Counters.Text = "COUNTERS";
            this.Tab_Counters.UseVisualStyleBackColor = true;
            // 
            // Tab_Invoices
            // 
            this.Tab_Invoices.Location = new System.Drawing.Point(4, 22);
            this.Tab_Invoices.Name = "Tab_Invoices";
            this.Tab_Invoices.Size = new System.Drawing.Size(718, 369);
            this.Tab_Invoices.TabIndex = 3;
            this.Tab_Invoices.Text = "INVOICES";
            this.Tab_Invoices.UseVisualStyleBackColor = true;
            // 
            // Tab_Boxes
            // 
            this.Tab_Boxes.Location = new System.Drawing.Point(4, 22);
            this.Tab_Boxes.Name = "Tab_Boxes";
            this.Tab_Boxes.Size = new System.Drawing.Size(718, 369);
            this.Tab_Boxes.TabIndex = 4;
            this.Tab_Boxes.Text = "BOXES";
            this.Tab_Boxes.UseVisualStyleBackColor = true;
            // 
            // Tab_General
            // 
            this.Tab_General.Location = new System.Drawing.Point(4, 22);
            this.Tab_General.Name = "Tab_General";
            this.Tab_General.Size = new System.Drawing.Size(718, 369);
            this.Tab_General.TabIndex = 5;
            this.Tab_General.Text = "GENERAL";
            this.Tab_General.UseVisualStyleBackColor = true;
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.AllowUserToAddRows = false;
            this.DGV_Customers.AllowUserToDeleteRows = false;
            this.DGV_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Customers.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Customers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Customers.GridColor = System.Drawing.Color.Black;
            this.DGV_Customers.Location = new System.Drawing.Point(6, 125);
            this.DGV_Customers.MultiSelect = false;
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.ReadOnly = true;
            this.DGV_Customers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Customers.RowHeadersVisible = false;
            this.DGV_Customers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Customers.Size = new System.Drawing.Size(706, 238);
            this.DGV_Customers.TabIndex = 0;
            // 
            // Btn_AddNewCustomer
            // 
            this.Btn_AddNewCustomer.AutoSize = true;
            this.Btn_AddNewCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_AddNewCustomer.Depth = 0;
            this.Btn_AddNewCustomer.Icon = null;
            this.Btn_AddNewCustomer.Location = new System.Drawing.Point(7, 9);
            this.Btn_AddNewCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_AddNewCustomer.Name = "Btn_AddNewCustomer";
            this.Btn_AddNewCustomer.Primary = true;
            this.Btn_AddNewCustomer.Size = new System.Drawing.Size(157, 36);
            this.Btn_AddNewCustomer.TabIndex = 1;
            this.Btn_AddNewCustomer.Text = "Add New Customer";
            this.Btn_AddNewCustomer.UseVisualStyleBackColor = true;
            // 
            // Btn_ModCustomer
            // 
            this.Btn_ModCustomer.AutoSize = true;
            this.Btn_ModCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ModCustomer.Depth = 0;
            this.Btn_ModCustomer.Icon = null;
            this.Btn_ModCustomer.Location = new System.Drawing.Point(170, 9);
            this.Btn_ModCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ModCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ModCustomer.Name = "Btn_ModCustomer";
            this.Btn_ModCustomer.Primary = true;
            this.Btn_ModCustomer.Size = new System.Drawing.Size(147, 36);
            this.Btn_ModCustomer.TabIndex = 2;
            this.Btn_ModCustomer.Text = "Modify Customer";
            this.Btn_ModCustomer.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteCustomer
            // 
            this.Btn_DeleteCustomer.AutoSize = true;
            this.Btn_DeleteCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_DeleteCustomer.Depth = 0;
            this.Btn_DeleteCustomer.Icon = null;
            this.Btn_DeleteCustomer.Location = new System.Drawing.Point(325, 9);
            this.Btn_DeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_DeleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_DeleteCustomer.Name = "Btn_DeleteCustomer";
            this.Btn_DeleteCustomer.Primary = false;
            this.Btn_DeleteCustomer.Size = new System.Drawing.Size(145, 36);
            this.Btn_DeleteCustomer.TabIndex = 3;
            this.Btn_DeleteCustomer.Text = "Delete Customer";
            this.Btn_DeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // Txt_FindCustomerByName
            // 
            this.Txt_FindCustomerByName.Depth = 0;
            this.Txt_FindCustomerByName.Hint = "";
            this.Txt_FindCustomerByName.Location = new System.Drawing.Point(7, 96);
            this.Txt_FindCustomerByName.MaxLength = 32767;
            this.Txt_FindCustomerByName.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_FindCustomerByName.Name = "Txt_FindCustomerByName";
            this.Txt_FindCustomerByName.PasswordChar = '\0';
            this.Txt_FindCustomerByName.SelectedText = "";
            this.Txt_FindCustomerByName.SelectionLength = 0;
            this.Txt_FindCustomerByName.SelectionStart = 0;
            this.Txt_FindCustomerByName.Size = new System.Drawing.Size(219, 23);
            this.Txt_FindCustomerByName.TabIndex = 4;
            this.Txt_FindCustomerByName.TabStop = false;
            this.Txt_FindCustomerByName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Find Name:";
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.AutoSize = true;
            this.Btn_Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Reset.Depth = 0;
            this.Btn_Reset.Icon = null;
            this.Btn_Reset.Location = new System.Drawing.Point(233, 82);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Reset.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Primary = true;
            this.Btn_Reset.Size = new System.Drawing.Size(30, 36);
            this.Btn_Reset.TabIndex = 6;
            this.Btn_Reset.Text = "X";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 551);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.Tab_Navigator);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Frm_Main";
            this.Text = "Main Menu";
            this.Tab_Navigator.ResumeLayout(false);
            this.Tab_Customers.ResumeLayout(false);
            this.Tab_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl Tab_Navigator;
        private System.Windows.Forms.TabPage Tab_Info;
        private System.Windows.Forms.TabPage Tab_Customers;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.TabPage Tab_Counters;
        private System.Windows.Forms.TabPage Tab_Boxes;
        private System.Windows.Forms.TabPage Tab_Invoices;
        private System.Windows.Forms.TabPage Tab_General;
        private MaterialSkin.Controls.MaterialFlatButton Btn_DeleteCustomer;
        private MaterialSkin.Controls.MaterialFlatButton Btn_ModCustomer;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_AddNewCustomer;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private MaterialSkin.Controls.MaterialFlatButton Btn_Reset;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_FindCustomerByName;
    }
}

