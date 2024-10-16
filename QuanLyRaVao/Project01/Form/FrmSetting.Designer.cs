namespace Project01.FrmChild
{
  partial class FrmSetting
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column14 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column15 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnReloadUser = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvRoleUser = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAddRoleUser = new System.Windows.Forms.Button();
			this.btnReloadRoleUser = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btnSaveSettingSecond = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCheckIn = new System.Windows.Forms.TextBox();
			this.txtCheckOut = new System.Windows.Forms.TextBox();
			this.txtCheckNG = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSaveSettingOutput = new System.Windows.Forms.Button();
			this.cbbCOM = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
			this.btnReloadCom = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRoleUser)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.ItemSize = new System.Drawing.Size(250, 50);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1881, 1040);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 54);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1873, 982);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Danh sách tài khoản";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dgvUser, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1873, 982);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// dgvUser
			// 
			this.dgvUser.AllowUserToAddRows = false;
			this.dgvUser.AllowUserToResizeColumns = false;
			this.dgvUser.AllowUserToResizeRows = false;
			this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUser.BackgroundColor = System.Drawing.Color.MintCream;
			this.dgvUser.ColumnHeadersHeight = 40;
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column17,
            this.Column13,
            this.Column16,
            this.Column14,
            this.Column15});
			this.dgvUser.Location = new System.Drawing.Point(4, 62);
			this.dgvUser.Margin = new System.Windows.Forms.Padding(4);
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.ReadOnly = true;
			this.dgvUser.RowHeadersVisible = false;
			this.dgvUser.RowHeadersWidth = 51;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUser.RowTemplate.Height = 40;
			this.dgvUser.Size = new System.Drawing.Size(1865, 916);
			this.dgvUser.TabIndex = 4;
			this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
			// 
			// Column11
			// 
			this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column11.HeaderText = "STT";
			this.Column11.MinimumWidth = 6;
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			this.Column11.Width = 94;
			// 
			// Column12
			// 
			this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column12.HeaderText = "Tên tài khoản";
			this.Column12.MinimumWidth = 6;
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			this.Column12.Width = 206;
			// 
			// Column17
			// 
			this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column17.HeaderText = "Nhóm phân quyền";
			this.Column17.MinimumWidth = 6;
			this.Column17.Name = "Column17";
			this.Column17.ReadOnly = true;
			this.Column17.Width = 257;
			// 
			// Column13
			// 
			this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column13.HeaderText = "Ngày tạo";
			this.Column13.MinimumWidth = 6;
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			this.Column13.Width = 147;
			// 
			// Column16
			// 
			this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column16.HeaderText = "Ngày cập nhật";
			this.Column16.MinimumWidth = 6;
			this.Column16.Name = "Column16";
			this.Column16.ReadOnly = true;
			this.Column16.Width = 211;
			// 
			// Column14
			// 
			this.Column14.HeaderText = "";
			this.Column14.MinimumWidth = 6;
			this.Column14.Name = "Column14";
			this.Column14.ReadOnly = true;
			this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Column15
			// 
			this.Column15.HeaderText = "";
			this.Column15.MinimumWidth = 6;
			this.Column15.Name = "Column15";
			this.Column15.ReadOnly = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.CadetBlue;
			this.tableLayoutPanel2.ColumnCount = 7;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.btnAdd, 6, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnReloadUser, 5, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1873, 52);
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
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.CadetBlue;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(1628, 4);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnAdd.Size = new System.Drawing.Size(241, 44);
			this.btnAdd.TabIndex = 19;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAddUser_Click);
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
			this.btnReloadUser.Location = new System.Drawing.Point(1379, 4);
			this.btnReloadUser.Margin = new System.Windows.Forms.Padding(4);
			this.btnReloadUser.Name = "btnReloadUser";
			this.btnReloadUser.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnReloadUser.Size = new System.Drawing.Size(241, 44);
			this.btnReloadUser.TabIndex = 21;
			this.btnReloadUser.Text = "Đồng bộ dữ liệu";
			this.btnReloadUser.UseVisualStyleBackColor = false;
			this.btnReloadUser.Click += new System.EventHandler(this.btnReloadUser_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tableLayoutPanel3);
			this.tabPage2.Location = new System.Drawing.Point(4, 54);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1873, 982);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Nhóm quyền";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.dgvRoleUser, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1873, 982);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// dgvRoleUser
			// 
			this.dgvRoleUser.AllowUserToAddRows = false;
			this.dgvRoleUser.AllowUserToResizeColumns = false;
			this.dgvRoleUser.AllowUserToResizeRows = false;
			this.dgvRoleUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRoleUser.BackgroundColor = System.Drawing.Color.MintCream;
			this.dgvRoleUser.ColumnHeadersHeight = 40;
			this.dgvRoleUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvRoleUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
			this.dgvRoleUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvRoleUser.Location = new System.Drawing.Point(4, 62);
			this.dgvRoleUser.Margin = new System.Windows.Forms.Padding(4);
			this.dgvRoleUser.Name = "dgvRoleUser";
			this.dgvRoleUser.ReadOnly = true;
			this.dgvRoleUser.RowHeadersVisible = false;
			this.dgvRoleUser.RowHeadersWidth = 51;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			this.dgvRoleUser.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRoleUser.RowTemplate.Height = 40;
			this.dgvRoleUser.Size = new System.Drawing.Size(1865, 916);
			this.dgvRoleUser.TabIndex = 3;
			this.dgvRoleUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoleUser_CellClick);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column1.HeaderText = "STT";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 94;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column2.HeaderText = "Tên nhóm phân quyền";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 304;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column3.HeaderText = "Ngày tạo";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 147;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column6.HeaderText = "Ngày cập nhật";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 211;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.BackColor = System.Drawing.Color.CadetBlue;
			this.tableLayoutPanel4.ColumnCount = 7;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.btnAddRoleUser, 6, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnReloadRoleUser, 5, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1873, 52);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// btnAddRoleUser
			// 
			this.btnAddRoleUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddRoleUser.BackColor = System.Drawing.Color.AliceBlue;
			this.btnAddRoleUser.FlatAppearance.BorderSize = 0;
			this.btnAddRoleUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddRoleUser.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRoleUser.ForeColor = System.Drawing.Color.CadetBlue;
			this.btnAddRoleUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddRoleUser.Location = new System.Drawing.Point(1628, 4);
			this.btnAddRoleUser.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddRoleUser.Name = "btnAddRoleUser";
			this.btnAddRoleUser.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnAddRoleUser.Size = new System.Drawing.Size(241, 44);
			this.btnAddRoleUser.TabIndex = 19;
			this.btnAddRoleUser.Text = "Thêm";
			this.btnAddRoleUser.UseVisualStyleBackColor = false;
			this.btnAddRoleUser.Click += new System.EventHandler(this.btnAddRoleUser_Click);
			// 
			// btnReloadRoleUser
			// 
			this.btnReloadRoleUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReloadRoleUser.BackColor = System.Drawing.Color.DarkCyan;
			this.btnReloadRoleUser.FlatAppearance.BorderSize = 0;
			this.btnReloadRoleUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReloadRoleUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReloadRoleUser.ForeColor = System.Drawing.Color.PowderBlue;
			this.btnReloadRoleUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReloadRoleUser.Location = new System.Drawing.Point(1379, 4);
			this.btnReloadRoleUser.Margin = new System.Windows.Forms.Padding(4);
			this.btnReloadRoleUser.Name = "btnReloadRoleUser";
			this.btnReloadRoleUser.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnReloadRoleUser.Size = new System.Drawing.Size(241, 44);
			this.btnReloadRoleUser.TabIndex = 20;
			this.btnReloadRoleUser.Text = "Đồng bộ dữ liệu";
			this.btnReloadRoleUser.UseVisualStyleBackColor = false;
			this.btnReloadRoleUser.Click += new System.EventHandler(this.btnReloadRoleUser_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tableLayoutPanel5);
			this.tabPage3.Location = new System.Drawing.Point(4, 54);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1873, 982);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Phần mềm";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel5.BackColor = System.Drawing.Color.MintCream;
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 3);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(7, 191);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 5;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 406F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(1871, 923);
			this.tableLayoutPanel5.TabIndex = 4;
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.BackColor = System.Drawing.Color.SteelBlue;
			this.tableLayoutPanel6.ColumnCount = 7;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.numericUpDown1, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.btnSaveSettingSecond, 3, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 12);
			this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1871, 68);
			this.tableLayoutPanel6.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(13, 0);
			this.label5.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(544, 68);
			this.label5.TabIndex = 46;
			this.label5.Text = "Thời gian giữa 2 lần quét trùng nhau (giây):";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.numericUpDown1.Location = new System.Drawing.Point(561, 15);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(192, 38);
			this.numericUpDown1.TabIndex = 47;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// btnSaveSettingSecond
			// 
			this.btnSaveSettingSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveSettingSecond.BackColor = System.Drawing.Color.CadetBlue;
			this.btnSaveSettingSecond.FlatAppearance.BorderSize = 0;
			this.btnSaveSettingSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveSettingSecond.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveSettingSecond.ForeColor = System.Drawing.Color.Linen;
			this.btnSaveSettingSecond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveSettingSecond.Location = new System.Drawing.Point(774, 12);
			this.btnSaveSettingSecond.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
			this.btnSaveSettingSecond.Name = "btnSaveSettingSecond";
			this.btnSaveSettingSecond.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnSaveSettingSecond.Size = new System.Drawing.Size(192, 44);
			this.btnSaveSettingSecond.TabIndex = 19;
			this.btnSaveSettingSecond.Text = "Lưu";
			this.btnSaveSettingSecond.UseVisualStyleBackColor = false;
			this.btnSaveSettingSecond.Click += new System.EventHandler(this.btnSaveSettingSecond_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tableLayoutPanel7);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Salmon;
			this.groupBox1.Location = new System.Drawing.Point(4, 105);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox1.Size = new System.Drawing.Size(1863, 406);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tín hiệu Output";
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Controls.Add(this.label3, 0, 5);
			this.tableLayoutPanel7.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel7.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel7.Controls.Add(this.txtCheckIn, 1, 3);
			this.tableLayoutPanel7.Controls.Add(this.txtCheckOut, 1, 4);
			this.tableLayoutPanel7.Controls.Add(this.txtCheckNG, 1, 5);
			this.tableLayoutPanel7.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel7.Controls.Add(this.btnSaveSettingOutput, 1, 6);
			this.tableLayoutPanel7.Controls.Add(this.cbbCOM, 1, 1);
			this.tableLayoutPanel7.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel7.Controls.Add(this.numericUpDownPort, 1, 2);
			this.tableLayoutPanel7.Controls.Add(this.btnReloadCom, 2, 1);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 37);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 7;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(1863, 369);
			this.tableLayoutPanel7.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(13, 248);
			this.label3.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(552, 59);
			this.label3.TabIndex = 49;
			this.label3.Text = "Dữ liệu xuất tín hiệu quét mã không tìm thấy";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(13, 189);
			this.label2.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(552, 59);
			this.label2.TabIndex = 48;
			this.label2.Text = "Dữ liệu xuất  tín hiệu quét check out";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(13, 130);
			this.label1.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(552, 59);
			this.label1.TabIndex = 46;
			this.label1.Text = "Dữ liệu xuất tín hiệu quét check in";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCheckIn
			// 
			this.txtCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCheckIn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCheckIn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCheckIn.Location = new System.Drawing.Point(569, 140);
			this.txtCheckIn.Margin = new System.Windows.Forms.Padding(4);
			this.txtCheckIn.Name = "txtCheckIn";
			this.txtCheckIn.Size = new System.Drawing.Size(259, 39);
			this.txtCheckIn.TabIndex = 50;
			// 
			// txtCheckOut
			// 
			this.txtCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCheckOut.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCheckOut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCheckOut.Location = new System.Drawing.Point(569, 199);
			this.txtCheckOut.Margin = new System.Windows.Forms.Padding(4);
			this.txtCheckOut.Name = "txtCheckOut";
			this.txtCheckOut.Size = new System.Drawing.Size(259, 39);
			this.txtCheckOut.TabIndex = 51;
			// 
			// txtCheckNG
			// 
			this.txtCheckNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCheckNG.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCheckNG.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCheckNG.Location = new System.Drawing.Point(569, 258);
			this.txtCheckNG.Margin = new System.Windows.Forms.Padding(4);
			this.txtCheckNG.Name = "txtCheckNG";
			this.txtCheckNG.Size = new System.Drawing.Size(259, 39);
			this.txtCheckNG.TabIndex = 52;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(13, 12);
			this.label4.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(552, 59);
			this.label4.TabIndex = 47;
			this.label4.Text = "COM:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSaveSettingOutput
			// 
			this.btnSaveSettingOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveSettingOutput.BackColor = System.Drawing.Color.PaleVioletRed;
			this.btnSaveSettingOutput.FlatAppearance.BorderSize = 0;
			this.btnSaveSettingOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveSettingOutput.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveSettingOutput.ForeColor = System.Drawing.Color.LavenderBlush;
			this.btnSaveSettingOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveSettingOutput.Location = new System.Drawing.Point(569, 313);
			this.btnSaveSettingOutput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnSaveSettingOutput.Name = "btnSaveSettingOutput";
			this.btnSaveSettingOutput.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnSaveSettingOutput.Size = new System.Drawing.Size(259, 50);
			this.btnSaveSettingOutput.TabIndex = 19;
			this.btnSaveSettingOutput.Text = "Lưu";
			this.btnSaveSettingOutput.UseVisualStyleBackColor = false;
			this.btnSaveSettingOutput.Click += new System.EventHandler(this.btnSaveSettingOutput_Click);
			// 
			// cbbCOM
			// 
			this.cbbCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbbCOM.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cbbCOM.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbCOM.FormattingEnabled = true;
			this.cbbCOM.Location = new System.Drawing.Point(565, 21);
			this.cbbCOM.Margin = new System.Windows.Forms.Padding(0);
			this.cbbCOM.Name = "cbbCOM";
			this.cbbCOM.Size = new System.Drawing.Size(267, 39);
			this.cbbCOM.TabIndex = 53;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(13, 71);
			this.label6.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(552, 59);
			this.label6.TabIndex = 54;
			this.label6.Text = "Port:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownPort
			// 
			this.numericUpDownPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownPort.BackColor = System.Drawing.Color.WhiteSmoke;
			this.numericUpDownPort.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownPort.Location = new System.Drawing.Point(569, 81);
			this.numericUpDownPort.Margin = new System.Windows.Forms.Padding(4);
			this.numericUpDownPort.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownPort.Name = "numericUpDownPort";
			this.numericUpDownPort.Size = new System.Drawing.Size(259, 39);
			this.numericUpDownPort.TabIndex = 55;
			this.numericUpDownPort.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
			// 
			// btnReloadCom
			// 
			this.btnReloadCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReloadCom.BackColor = System.Drawing.Color.Teal;
			this.btnReloadCom.FlatAppearance.BorderSize = 0;
			this.btnReloadCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReloadCom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReloadCom.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnReloadCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReloadCom.Location = new System.Drawing.Point(836, 22);
			this.btnReloadCom.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
			this.btnReloadCom.Name = "btnReloadCom";
			this.btnReloadCom.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnReloadCom.Size = new System.Drawing.Size(137, 39);
			this.btnReloadCom.TabIndex = 56;
			this.btnReloadCom.Text = "Load lại";
			this.btnReloadCom.UseVisualStyleBackColor = false;
			this.btnReloadCom.Click += new System.EventHandler(this.btnReloadCom_Click);
			// 
			// FrmSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(1881, 1040);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmSetting";
			this.Text = "FrmSetting";
			this.Load += new System.EventHandler(this.FrmSetting_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvRoleUser)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Button btnAddRoleUser;
    private System.Windows.Forms.DataGridView dgvRoleUser;
    private System.Windows.Forms.Button btnReloadRoleUser;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataGridView dgvUser;
    private System.Windows.Forms.Button btnReloadUser;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Button btnSaveSettingSecond;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnSaveSettingOutput;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCheckIn;
    private System.Windows.Forms.TextBox txtCheckOut;
    private System.Windows.Forms.TextBox txtCheckNG;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cbbCOM;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown numericUpDownPort;
    private System.Windows.Forms.Button btnReloadCom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
		private System.Windows.Forms.DataGridViewButtonColumn Column14;
		private System.Windows.Forms.DataGridViewButtonColumn Column15;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewButtonColumn Column4;
		private System.Windows.Forms.DataGridViewButtonColumn Column5;
	}
}