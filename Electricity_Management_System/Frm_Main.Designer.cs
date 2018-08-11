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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.Tab_Navigator = new MaterialSkin.Controls.MaterialTabControl();
            this.Tab_Info = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.Tab_Customers = new System.Windows.Forms.TabPage();
            this.Btn_ResetCustomers = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_FindCustomerByName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Btn_DeleteCustomer = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btn_ModCustomer = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btn_AddNewCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.Tab_Counters = new System.Windows.Forms.TabPage();
            this.Btn_ResetCounters = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_CounterFilterByCost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Btn_DeleteCounter = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btn_ModCounter = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btn_AddNewCounter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DGV_Counters = new System.Windows.Forms.DataGridView();
            this.Tab_Boxes = new System.Windows.Forms.TabPage();
            this.Tab_Invoices = new System.Windows.Forms.TabPage();
            this.Tab_General = new System.Windows.Forms.TabPage();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tab_Navigator.SuspendLayout();
            this.Tab_Info.SuspendLayout();
            this.Tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.Tab_Counters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Counters)).BeginInit();
            this.Tab_Boxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(836, 32);
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
            this.Tab_Navigator.Size = new System.Drawing.Size(808, 405);
            this.Tab_Navigator.TabIndex = 1;
            // 
            // Tab_Info
            // 
            this.Tab_Info.Controls.Add(this.label10);
            this.Tab_Info.Controls.Add(this.label11);
            this.Tab_Info.Controls.Add(this.label8);
            this.Tab_Info.Controls.Add(this.label9);
            this.Tab_Info.Controls.Add(this.label6);
            this.Tab_Info.Controls.Add(this.label7);
            this.Tab_Info.Controls.Add(this.label4);
            this.Tab_Info.Controls.Add(this.label5);
            this.Tab_Info.Controls.Add(this.label2);
            this.Tab_Info.Controls.Add(this.label3);
            this.Tab_Info.Controls.Add(this.label1);
            this.Tab_Info.Controls.Add(this.lable1);
            this.Tab_Info.Location = new System.Drawing.Point(4, 22);
            this.Tab_Info.Name = "Tab_Info";
            this.Tab_Info.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Info.Size = new System.Drawing.Size(800, 379);
            this.Tab_Info.TabIndex = 0;
            this.Tab_Info.Text = "INFO";
            this.Tab_Info.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(348, 38);
            this.label10.TabIndex = 16;
            this.label10.Text = "<Monthly_Income> L.L.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 18F);
            this.label11.Location = new System.Drawing.Point(8, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 29);
            this.label11.TabIndex = 15;
            this.label11.Text = "Approximate Monthly Income:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 38);
            this.label8.TabIndex = 14;
            this.label8.Text = "<COUNT(CUSTOMERS)>";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 18F);
            this.label9.Location = new System.Drawing.Point(8, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Number Of Customers:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "<COUNT(BOXES)>";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 18F);
            this.label7.Location = new System.Drawing.Point(452, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Number Of Boxes:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "<COUNT(COUNTERS)>";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 18F);
            this.label5.Location = new System.Drawing.Point(450, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number Of Counters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "<Value_Per_Watt> L.L.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 18F);
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Price Per Watt:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "<Customer_Name>";
            // 
            // lable1
            // 
            this.lable1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Roboto", 18F);
            this.lable1.Location = new System.Drawing.Point(6, 309);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(211, 29);
            this.lable1.TabIndex = 5;
            this.lable1.Text = "Newest Customer:";
            // 
            // Tab_Customers
            // 
            this.Tab_Customers.BackColor = System.Drawing.Color.White;
            this.Tab_Customers.Controls.Add(this.Btn_ResetCustomers);
            this.Tab_Customers.Controls.Add(this.materialLabel1);
            this.Tab_Customers.Controls.Add(this.Txt_FindCustomerByName);
            this.Tab_Customers.Controls.Add(this.Btn_DeleteCustomer);
            this.Tab_Customers.Controls.Add(this.Btn_ModCustomer);
            this.Tab_Customers.Controls.Add(this.Btn_AddNewCustomer);
            this.Tab_Customers.Controls.Add(this.DGV_Customers);
            this.Tab_Customers.Location = new System.Drawing.Point(4, 22);
            this.Tab_Customers.Name = "Tab_Customers";
            this.Tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Customers.Size = new System.Drawing.Size(800, 379);
            this.Tab_Customers.TabIndex = 1;
            this.Tab_Customers.Text = "CUSTOMERS";
            // 
            // Btn_ResetCustomers
            // 
            this.Btn_ResetCustomers.AutoSize = true;
            this.Btn_ResetCustomers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ResetCustomers.Depth = 0;
            this.Btn_ResetCustomers.Icon = null;
            this.Btn_ResetCustomers.Location = new System.Drawing.Point(233, 82);
            this.Btn_ResetCustomers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ResetCustomers.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ResetCustomers.Name = "Btn_ResetCustomers";
            this.Btn_ResetCustomers.Primary = true;
            this.Btn_ResetCustomers.Size = new System.Drawing.Size(30, 36);
            this.Btn_ResetCustomers.TabIndex = 6;
            this.Btn_ResetCustomers.Text = "X";
            this.Btn_ResetCustomers.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Customers.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_Customers.GridColor = System.Drawing.Color.Black;
            this.DGV_Customers.Location = new System.Drawing.Point(6, 125);
            this.DGV_Customers.MultiSelect = false;
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.ReadOnly = true;
            this.DGV_Customers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_Customers.RowHeadersVisible = false;
            this.DGV_Customers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Customers.Size = new System.Drawing.Size(788, 248);
            this.DGV_Customers.TabIndex = 0;
            // 
            // Tab_Counters
            // 
            this.Tab_Counters.BackColor = System.Drawing.Color.White;
            this.Tab_Counters.Controls.Add(this.Btn_ResetCounters);
            this.Tab_Counters.Controls.Add(this.materialLabel2);
            this.Tab_Counters.Controls.Add(this.Txt_CounterFilterByCost);
            this.Tab_Counters.Controls.Add(this.Btn_DeleteCounter);
            this.Tab_Counters.Controls.Add(this.Btn_ModCounter);
            this.Tab_Counters.Controls.Add(this.Btn_AddNewCounter);
            this.Tab_Counters.Controls.Add(this.DGV_Counters);
            this.Tab_Counters.Location = new System.Drawing.Point(4, 22);
            this.Tab_Counters.Name = "Tab_Counters";
            this.Tab_Counters.Size = new System.Drawing.Size(800, 379);
            this.Tab_Counters.TabIndex = 2;
            this.Tab_Counters.Text = "COUNTERS";
            // 
            // Btn_ResetCounters
            // 
            this.Btn_ResetCounters.AutoSize = true;
            this.Btn_ResetCounters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ResetCounters.Depth = 0;
            this.Btn_ResetCounters.Icon = null;
            this.Btn_ResetCounters.Location = new System.Drawing.Point(233, 80);
            this.Btn_ResetCounters.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ResetCounters.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ResetCounters.Name = "Btn_ResetCounters";
            this.Btn_ResetCounters.Primary = true;
            this.Btn_ResetCounters.Size = new System.Drawing.Size(30, 36);
            this.Btn_ResetCounters.TabIndex = 13;
            this.Btn_ResetCounters.Text = "X";
            this.Btn_ResetCounters.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 75);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(103, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Filter By Cost:";
            // 
            // Txt_CounterFilterByCost
            // 
            this.Txt_CounterFilterByCost.Depth = 0;
            this.Txt_CounterFilterByCost.Hint = "";
            this.Txt_CounterFilterByCost.Location = new System.Drawing.Point(7, 94);
            this.Txt_CounterFilterByCost.MaxLength = 32767;
            this.Txt_CounterFilterByCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_CounterFilterByCost.Name = "Txt_CounterFilterByCost";
            this.Txt_CounterFilterByCost.PasswordChar = '\0';
            this.Txt_CounterFilterByCost.SelectedText = "";
            this.Txt_CounterFilterByCost.SelectionLength = 0;
            this.Txt_CounterFilterByCost.SelectionStart = 0;
            this.Txt_CounterFilterByCost.Size = new System.Drawing.Size(219, 23);
            this.Txt_CounterFilterByCost.TabIndex = 11;
            this.Txt_CounterFilterByCost.TabStop = false;
            this.Txt_CounterFilterByCost.UseSystemPasswordChar = false;
            // 
            // Btn_DeleteCounter
            // 
            this.Btn_DeleteCounter.AutoSize = true;
            this.Btn_DeleteCounter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_DeleteCounter.Depth = 0;
            this.Btn_DeleteCounter.Icon = null;
            this.Btn_DeleteCounter.Location = new System.Drawing.Point(304, 7);
            this.Btn_DeleteCounter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_DeleteCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_DeleteCounter.Name = "Btn_DeleteCounter";
            this.Btn_DeleteCounter.Primary = false;
            this.Btn_DeleteCounter.Size = new System.Drawing.Size(134, 36);
            this.Btn_DeleteCounter.TabIndex = 10;
            this.Btn_DeleteCounter.Text = "Delete Counter";
            this.Btn_DeleteCounter.UseVisualStyleBackColor = true;
            // 
            // Btn_ModCounter
            // 
            this.Btn_ModCounter.AutoSize = true;
            this.Btn_ModCounter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ModCounter.Depth = 0;
            this.Btn_ModCounter.Icon = null;
            this.Btn_ModCounter.Location = new System.Drawing.Point(160, 7);
            this.Btn_ModCounter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ModCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ModCounter.Name = "Btn_ModCounter";
            this.Btn_ModCounter.Primary = true;
            this.Btn_ModCounter.Size = new System.Drawing.Size(136, 36);
            this.Btn_ModCounter.TabIndex = 9;
            this.Btn_ModCounter.Text = "Modify Counter";
            this.Btn_ModCounter.UseVisualStyleBackColor = true;
            // 
            // Btn_AddNewCounter
            // 
            this.Btn_AddNewCounter.AutoSize = true;
            this.Btn_AddNewCounter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_AddNewCounter.Depth = 0;
            this.Btn_AddNewCounter.Icon = null;
            this.Btn_AddNewCounter.Location = new System.Drawing.Point(7, 7);
            this.Btn_AddNewCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_AddNewCounter.Name = "Btn_AddNewCounter";
            this.Btn_AddNewCounter.Primary = true;
            this.Btn_AddNewCounter.Size = new System.Drawing.Size(146, 36);
            this.Btn_AddNewCounter.TabIndex = 8;
            this.Btn_AddNewCounter.Text = "Add New Counter";
            this.Btn_AddNewCounter.UseVisualStyleBackColor = true;
            // 
            // DGV_Counters
            // 
            this.DGV_Counters.AllowUserToAddRows = false;
            this.DGV_Counters.AllowUserToDeleteRows = false;
            this.DGV_Counters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Counters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Counters.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Counters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Counters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Counters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Counters.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Counters.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_Counters.GridColor = System.Drawing.Color.Black;
            this.DGV_Counters.Location = new System.Drawing.Point(6, 123);
            this.DGV_Counters.MultiSelect = false;
            this.DGV_Counters.Name = "DGV_Counters";
            this.DGV_Counters.ReadOnly = true;
            this.DGV_Counters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Counters.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_Counters.RowHeadersVisible = false;
            this.DGV_Counters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Counters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Counters.Size = new System.Drawing.Size(788, 248);
            this.DGV_Counters.TabIndex = 7;
            // 
            // Tab_Boxes
            // 
            this.Tab_Boxes.BackColor = System.Drawing.Color.White;
            this.Tab_Boxes.Controls.Add(this.materialFlatButton2);
            this.Tab_Boxes.Controls.Add(this.materialLabel3);
            this.Tab_Boxes.Controls.Add(this.materialSingleLineTextField1);
            this.Tab_Boxes.Controls.Add(this.materialFlatButton3);
            this.Tab_Boxes.Controls.Add(this.materialFlatButton4);
            this.Tab_Boxes.Controls.Add(this.materialRaisedButton2);
            this.Tab_Boxes.Controls.Add(this.dataGridView1);
            this.Tab_Boxes.Location = new System.Drawing.Point(4, 22);
            this.Tab_Boxes.Name = "Tab_Boxes";
            this.Tab_Boxes.Size = new System.Drawing.Size(800, 379);
            this.Tab_Boxes.TabIndex = 4;
            this.Tab_Boxes.Text = "BOXES";
            // 
            // Tab_Invoices
            // 
            this.Tab_Invoices.Location = new System.Drawing.Point(4, 22);
            this.Tab_Invoices.Name = "Tab_Invoices";
            this.Tab_Invoices.Size = new System.Drawing.Size(800, 379);
            this.Tab_Invoices.TabIndex = 3;
            this.Tab_Invoices.Text = "INVOICES";
            this.Tab_Invoices.UseVisualStyleBackColor = true;
            // 
            // Tab_General
            // 
            this.Tab_General.Location = new System.Drawing.Point(4, 22);
            this.Tab_General.Name = "Tab_General";
            this.Tab_General.Size = new System.Drawing.Size(800, 379);
            this.Tab_General.TabIndex = 5;
            this.Tab_General.Text = "GENERAL";
            this.Tab_General.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-1, 511);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(836, 1);
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
            this.materialRaisedButton1.Location = new System.Drawing.Point(765, 518);
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
            this.materialFlatButton1.Location = new System.Drawing.Point(692, 518);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(66, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "About";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(233, 80);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = true;
            this.materialFlatButton2.Size = new System.Drawing.Size(30, 36);
            this.materialFlatButton2.TabIndex = 20;
            this.materialFlatButton2.Text = "X";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(7, 75);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(103, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Filter By Cost:";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(7, 94);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(219, 23);
            this.materialSingleLineTextField1.TabIndex = 18;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(304, 7);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(134, 36);
            this.materialFlatButton3.TabIndex = 17;
            this.materialFlatButton3.Text = "Delete Counter";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(160, 7);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = true;
            this.materialFlatButton4.Size = new System.Drawing.Size(136, 36);
            this.materialFlatButton4.TabIndex = 16;
            this.materialFlatButton4.Text = "Modify Counter";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(7, 7);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(146, 36);
            this.materialRaisedButton2.TabIndex = 15;
            this.materialRaisedButton2.Text = "Add New Counter";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(6, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(788, 248);
            this.dataGridView1.TabIndex = 14;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 561);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.Tab_Navigator);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Tab_Navigator.ResumeLayout(false);
            this.Tab_Info.ResumeLayout(false);
            this.Tab_Info.PerformLayout();
            this.Tab_Customers.ResumeLayout(false);
            this.Tab_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.Tab_Counters.ResumeLayout(false);
            this.Tab_Counters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Counters)).EndInit();
            this.Tab_Boxes.ResumeLayout(false);
            this.Tab_Boxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private MaterialSkin.Controls.MaterialFlatButton Btn_ResetCustomers;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_FindCustomerByName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialFlatButton Btn_ResetCounters;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_CounterFilterByCost;
        private MaterialSkin.Controls.MaterialFlatButton Btn_DeleteCounter;
        private MaterialSkin.Controls.MaterialFlatButton Btn_ModCounter;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_AddNewCounter;
        private System.Windows.Forms.DataGridView DGV_Counters;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

