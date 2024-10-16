namespace Project01.FrmChild
{
  partial class ManagerEmployeeFrm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvEmployees = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnReloadUser = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvTypeEmployees = new System.Windows.Forms.DataGridView();
			this.C21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C25 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.C26 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAddType = new System.Windows.Forms.Button();
			this.btnReloadTypeEmployee = new System.Windows.Forms.Button();
			this.C11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C18 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.C19 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTypeEmployees)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Azure;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dgvEmployees, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1532, 787);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// dgvEmployees
			// 
			this.dgvEmployees.AllowUserToAddRows = false;
			this.dgvEmployees.AllowUserToResizeColumns = false;
			this.dgvEmployees.AllowUserToResizeRows = false;
			this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEmployees.BackgroundColor = System.Drawing.Color.MintCream;
			this.dgvEmployees.ColumnHeadersHeight = 40;
			this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C11,
            this.C12,
            this.C110,
            this.C13,
            this.C14,
            this.C15,
            this.C16,
            this.C17,
            this.C18,
            this.C19});
			this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEmployees.GridColor = System.Drawing.Color.MintCream;
			this.dgvEmployees.Location = new System.Drawing.Point(6, 64);
			this.dgvEmployees.Margin = new System.Windows.Forms.Padding(6);
			this.dgvEmployees.Name = "dgvEmployees";
			this.dgvEmployees.ReadOnly = true;
			this.dgvEmployees.RowHeadersVisible = false;
			this.dgvEmployees.RowHeadersWidth = 51;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dgvEmployees.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvEmployees.RowTemplate.Height = 40;
			this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmployees.Size = new System.Drawing.Size(1520, 717);
			this.dgvEmployees.TabIndex = 4;
			this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.CadetBlue;
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 374F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnReloadUser, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1532, 50);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.BackColor = System.Drawing.Color.AliceBlue;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.CadetBlue;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(1164, 6);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnAdd.Size = new System.Drawing.Size(362, 38);
			this.btnAdd.TabIndex = 19;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnReloadUser
			// 
			this.btnReloadUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReloadUser.BackColor = System.Drawing.Color.DarkCyan;
			this.btnReloadUser.FlatAppearance.BorderSize = 0;
			this.btnReloadUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReloadUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReloadUser.ForeColor = System.Drawing.Color.PowderBlue;
			this.btnReloadUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReloadUser.Location = new System.Drawing.Point(790, 6);
			this.btnReloadUser.Margin = new System.Windows.Forms.Padding(6);
			this.btnReloadUser.Name = "btnReloadUser";
			this.btnReloadUser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnReloadUser.Size = new System.Drawing.Size(362, 38);
			this.btnReloadUser.TabIndex = 22;
			this.btnReloadUser.Text = "Đồng bộ dữ liệu";
			this.btnReloadUser.UseVisualStyleBackColor = false;
			this.btnReloadUser.Click += new System.EventHandler(this.btnReloadUser_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.ItemSize = new System.Drawing.Size(250, 50);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1540, 845);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 54);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1532, 787);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Thông Tin Người Dùng";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tableLayoutPanel3);
			this.tabPage2.Location = new System.Drawing.Point(4, 54);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1532, 787);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Phân nhóm";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.BackColor = System.Drawing.Color.MintCream;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.dgvTypeEmployees, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1532, 787);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// dgvTypeEmployees
			// 
			this.dgvTypeEmployees.AllowUserToAddRows = false;
			this.dgvTypeEmployees.AllowUserToResizeColumns = false;
			this.dgvTypeEmployees.AllowUserToResizeRows = false;
			this.dgvTypeEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTypeEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTypeEmployees.BackgroundColor = System.Drawing.Color.MintCream;
			this.dgvTypeEmployees.ColumnHeadersHeight = 40;
			this.dgvTypeEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvTypeEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C21,
            this.C22,
            this.C23,
            this.C24,
            this.C25,
            this.C26});
			this.dgvTypeEmployees.Location = new System.Drawing.Point(6, 64);
			this.dgvTypeEmployees.Margin = new System.Windows.Forms.Padding(6);
			this.dgvTypeEmployees.Name = "dgvTypeEmployees";
			this.dgvTypeEmployees.ReadOnly = true;
			this.dgvTypeEmployees.RowHeadersVisible = false;
			this.dgvTypeEmployees.RowHeadersWidth = 51;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			this.dgvTypeEmployees.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTypeEmployees.RowTemplate.Height = 40;
			this.dgvTypeEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTypeEmployees.Size = new System.Drawing.Size(1520, 717);
			this.dgvTypeEmployees.TabIndex = 5;
			this.dgvTypeEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeEmployees_CellContentClick);
			// 
			// C21
			// 
			this.C21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.C21.HeaderText = "STT";
			this.C21.MinimumWidth = 6;
			this.C21.Name = "C21";
			this.C21.ReadOnly = true;
			this.C21.Width = 55;
			// 
			// C22
			// 
			this.C22.HeaderText = "Tên nhóm";
			this.C22.MinimumWidth = 6;
			this.C22.Name = "C22";
			this.C22.ReadOnly = true;
			// 
			// C23
			// 
			this.C23.HeaderText = "Ngày tạo";
			this.C23.MinimumWidth = 6;
			this.C23.Name = "C23";
			this.C23.ReadOnly = true;
			// 
			// C24
			// 
			this.C24.HeaderText = "Ngày cập nhật";
			this.C24.MinimumWidth = 6;
			this.C24.Name = "C24";
			this.C24.ReadOnly = true;
			// 
			// C25
			// 
			this.C25.HeaderText = "";
			this.C25.MinimumWidth = 6;
			this.C25.Name = "C25";
			this.C25.ReadOnly = true;
			this.C25.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.C25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// C26
			// 
			this.C26.HeaderText = "";
			this.C26.MinimumWidth = 6;
			this.C26.Name = "C26";
			this.C26.ReadOnly = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.BackColor = System.Drawing.Color.CadetBlue;
			this.tableLayoutPanel4.ColumnCount = 4;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel4.Controls.Add(this.btnAddType, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnReloadTypeEmployee, 2, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1532, 50);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// btnAddType
			// 
			this.btnAddType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddType.BackColor = System.Drawing.Color.AliceBlue;
			this.btnAddType.FlatAppearance.BorderSize = 0;
			this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddType.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddType.ForeColor = System.Drawing.Color.CadetBlue;
			this.btnAddType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddType.Location = new System.Drawing.Point(1164, 6);
			this.btnAddType.Margin = new System.Windows.Forms.Padding(6);
			this.btnAddType.Name = "btnAddType";
			this.btnAddType.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnAddType.Size = new System.Drawing.Size(362, 38);
			this.btnAddType.TabIndex = 19;
			this.btnAddType.Text = "Thêm";
			this.btnAddType.UseVisualStyleBackColor = false;
			this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
			// 
			// btnReloadTypeEmployee
			// 
			this.btnReloadTypeEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReloadTypeEmployee.BackColor = System.Drawing.Color.DarkCyan;
			this.btnReloadTypeEmployee.FlatAppearance.BorderSize = 0;
			this.btnReloadTypeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReloadTypeEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReloadTypeEmployee.ForeColor = System.Drawing.Color.PowderBlue;
			this.btnReloadTypeEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReloadTypeEmployee.Location = new System.Drawing.Point(790, 6);
			this.btnReloadTypeEmployee.Margin = new System.Windows.Forms.Padding(6);
			this.btnReloadTypeEmployee.Name = "btnReloadTypeEmployee";
			this.btnReloadTypeEmployee.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnReloadTypeEmployee.Size = new System.Drawing.Size(362, 38);
			this.btnReloadTypeEmployee.TabIndex = 21;
			this.btnReloadTypeEmployee.Text = "Đồng bộ dữ liệu";
			this.btnReloadTypeEmployee.UseVisualStyleBackColor = false;
			this.btnReloadTypeEmployee.Click += new System.EventHandler(this.btnReloadTypeEmployee_Click);
			// 
			// C11
			// 
			this.C11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.C11.HeaderText = "STT";
			this.C11.MinimumWidth = 6;
			this.C11.Name = "C11";
			this.C11.ReadOnly = true;
			this.C11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.C11.Width = 55;
			// 
			// C12
			// 
			this.C12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.C12.HeaderText = "Họ và tên";
			this.C12.MinimumWidth = 6;
			this.C12.Name = "C12";
			this.C12.ReadOnly = true;
			this.C12.Width = 205;
			// 
			// C110
			// 
			this.C110.HeaderText = "Phân loại";
			this.C110.MinimumWidth = 8;
			this.C110.Name = "C110";
			this.C110.ReadOnly = true;
			// 
			// C13
			// 
			this.C13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.C13.HeaderText = "Số CCCD";
			this.C13.MinimumWidth = 6;
			this.C13.Name = "C13";
			this.C13.ReadOnly = true;
			this.C13.Width = 159;
			// 
			// C14
			// 
			this.C14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.C14.HeaderText = "Số điện thoại";
			this.C14.MinimumWidth = 6;
			this.C14.Name = "C14";
			this.C14.ReadOnly = true;
			this.C14.Width = 134;
			// 
			// C15
			// 
			this.C15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.C15.HeaderText = "ID Người Dùng";
			this.C15.MinimumWidth = 6;
			this.C15.Name = "C15";
			this.C15.ReadOnly = true;
			this.C15.Width = 155;
			// 
			// C16
			// 
			this.C16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.C16.HeaderText = "Ngày tạo";
			this.C16.MinimumWidth = 6;
			this.C16.Name = "C16";
			this.C16.ReadOnly = true;
			this.C16.Width = 147;
			// 
			// C17
			// 
			this.C17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.C17.HeaderText = "Ngày cập nhật";
			this.C17.MinimumWidth = 6;
			this.C17.Name = "C17";
			this.C17.ReadOnly = true;
			this.C17.Width = 211;
			// 
			// C18
			// 
			this.C18.HeaderText = "";
			this.C18.MinimumWidth = 6;
			this.C18.Name = "C18";
			this.C18.ReadOnly = true;
			this.C18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.C18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// C19
			// 
			this.C19.HeaderText = "";
			this.C19.MinimumWidth = 6;
			this.C19.Name = "C19";
			this.C19.ReadOnly = true;
			// 
			// ManagerEmployeeFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1540, 845);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "ManagerEmployeeFrm";
			this.Text = "FrmMasterData";
			this.Load += new System.EventHandler(this.FrmMasterData_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTypeEmployees)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Button btnAddType;
    private System.Windows.Forms.DataGridView dgvEmployees;
    private System.Windows.Forms.DataGridView dgvTypeEmployees;
    private System.Windows.Forms.Button btnReloadTypeEmployee;
    private System.Windows.Forms.Button btnReloadUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn C21;
		private System.Windows.Forms.DataGridViewTextBoxColumn C22;
		private System.Windows.Forms.DataGridViewTextBoxColumn C23;
		private System.Windows.Forms.DataGridViewTextBoxColumn C24;
		private System.Windows.Forms.DataGridViewButtonColumn C25;
		private System.Windows.Forms.DataGridViewButtonColumn C26;
		private System.Windows.Forms.DataGridViewTextBoxColumn C11;
		private System.Windows.Forms.DataGridViewTextBoxColumn C12;
		private System.Windows.Forms.DataGridViewTextBoxColumn C110;
		private System.Windows.Forms.DataGridViewTextBoxColumn C13;
		private System.Windows.Forms.DataGridViewTextBoxColumn C14;
		private System.Windows.Forms.DataGridViewTextBoxColumn C15;
		private System.Windows.Forms.DataGridViewTextBoxColumn C16;
		private System.Windows.Forms.DataGridViewTextBoxColumn C17;
		private System.Windows.Forms.DataGridViewButtonColumn C18;
		private System.Windows.Forms.DataGridViewButtonColumn C19;
	}
}