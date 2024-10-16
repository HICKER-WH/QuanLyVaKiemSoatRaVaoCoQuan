namespace Project01.FrmChild
{
  partial class FrmReport
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbbStatus = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.cbbType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dtp = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPreview = new System.Windows.Forms.Button();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel22.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel22
			// 
			this.tableLayoutPanel22.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel22.ColumnCount = 1;
			this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel22.Controls.Add(this.dgv, 0, 1);
			this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel22.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel22.Margin = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel22.Name = "tableLayoutPanel22";
			this.tableLayoutPanel22.RowCount = 2;
			this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel22.Size = new System.Drawing.Size(1540, 845);
			this.tableLayoutPanel22.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
			this.tableLayoutPanel1.ColumnCount = 12;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.cbbStatus, 7, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnExport, 10, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbbType, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.dtp, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnPreview, 9, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1540, 70);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// cbbStatus
			// 
			this.cbbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbStatus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbStatus.FormattingEnabled = true;
			this.cbbStatus.Items.AddRange(new object[] {
            "Shift 1",
            "Shift 2",
            "Shift 3",
            "All"});
			this.cbbStatus.Location = new System.Drawing.Point(1113, 18);
			this.cbbStatus.Margin = new System.Windows.Forms.Padding(6);
			this.cbbStatus.Name = "cbbStatus";
			this.cbbStatus.Size = new System.Drawing.Size(95, 33);
			this.cbbStatus.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LightBlue;
			this.label2.Location = new System.Drawing.Point(988, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 70);
			this.label2.TabIndex = 33;
			this.label2.Text = "Trạng thái";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.LightBlue;
			this.label4.Location = new System.Drawing.Point(20, 0);
			this.label4.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 70);
			this.label4.TabIndex = 24;
			this.label4.Text = "Tìm kiếm";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnExport.BackColor = System.Drawing.Color.SeaGreen;
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExport.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExport.Location = new System.Drawing.Point(1356, 9);
			this.btnExport.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
			this.btnExport.Name = "btnExport";
			this.btnExport.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnExport.Size = new System.Drawing.Size(142, 52);
			this.btnExport.TabIndex = 34;
			this.btnExport.Text = "Xuất excel";
			this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExport.UseVisualStyleBackColor = false;
			this.btnExport.Click += new System.EventHandler(this.btnExxport_Click);
			// 
			// cbbType
			// 
			this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbType.FormattingEnabled = true;
			this.cbbType.Items.AddRange(new object[] {
            "Shift 1",
            "Shift 2",
            "Shift 3",
            "All"});
			this.cbbType.Location = new System.Drawing.Point(852, 18);
			this.cbbType.Margin = new System.Windows.Forms.Padding(6);
			this.cbbType.Name = "cbbType";
			this.cbbType.Size = new System.Drawing.Size(100, 33);
			this.cbbType.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.LightBlue;
			this.label3.Location = new System.Drawing.Point(773, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 70);
			this.label3.TabIndex = 30;
			this.label3.Text = "Nhóm";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(135, 18);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(205, 34);
			this.txtSearch.TabIndex = 25;
			// 
			// dtp
			// 
			this.dtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dtp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp.Location = new System.Drawing.Point(447, 18);
			this.dtp.Margin = new System.Windows.Forms.Padding(6);
			this.dtp.Name = "dtp";
			this.dtp.Size = new System.Drawing.Size(290, 34);
			this.dtp.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightBlue;
			this.label1.Location = new System.Drawing.Point(376, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 70);
			this.label1.TabIndex = 26;
			this.label1.Text = "Ngày";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPreview
			// 
			this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPreview.BackColor = System.Drawing.Color.CadetBlue;
			this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPreview.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPreview.ForeColor = System.Drawing.Color.White;
			this.btnPreview.Location = new System.Drawing.Point(1220, 9);
			this.btnPreview.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnPreview.Size = new System.Drawing.Size(124, 52);
			this.btnPreview.TabIndex = 32;
			this.btnPreview.Text = "Preview";
			this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPreview.UseVisualStyleBackColor = false;
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv.BackgroundColor = System.Drawing.Color.MintCream;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv.ColumnHeadersHeight = 35;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.EnableHeadersVisualStyles = false;
			this.dgv.Location = new System.Drawing.Point(6, 76);
			this.dgv.Margin = new System.Windows.Forms.Padding(6);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersVisible = false;
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 35;
			this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv.Size = new System.Drawing.Size(1528, 763);
			this.dgv.TabIndex = 7;
			this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
			// 
			// FrmReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1540, 845);
			this.Controls.Add(this.tableLayoutPanel22);
			this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmReport";
			this.Text = "FrmReport";
			this.Load += new System.EventHandler(this.FrmReport_Load);
			this.tableLayoutPanel22.ResumeLayout(false);
			this.tableLayoutPanel22.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox cbbStatus;
		private System.Windows.Forms.DateTimePicker dtp;
		private System.Windows.Forms.ComboBox cbbType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPreview;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnExport;
	}
}