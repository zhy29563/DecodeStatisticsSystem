namespace DecodeStatisticsSystem
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RtxtRunLog = new System.Windows.Forms.RichTextBox();
            this.GBoxRunLog = new System.Windows.Forms.GroupBox();
            this.MPClv = new MetroFramework.Controls.MetroPanel();
            this.GBoxResultClv = new System.Windows.Forms.GroupBox();
            this.MGClv = new MetroFramework.Controls.MetroGrid();
            this.ColIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPInfoClv = new MetroFramework.Controls.MetroPanel();
            this.GBoxStatisticClv = new System.Windows.Forms.GroupBox();
            this.TLPStatisticClv = new System.Windows.Forms.TableLayoutPanel();
            this.MTxtReadSingle = new MetroFramework.Controls.MetroTextBox();
            this.MTxtReadMulti = new MetroFramework.Controls.MetroTextBox();
            this.MLReadRateClv = new MetroFramework.Controls.MetroLabel();
            this.MLReadSuccessClv = new MetroFramework.Controls.MetroLabel();
            this.MLReadFailClv = new MetroFramework.Controls.MetroLabel();
            this.MTxtReadFail = new MetroFramework.Controls.MetroTextBox();
            this.MLReadTotalClv = new MetroFramework.Controls.MetroLabel();
            this.MTxtReadTotal = new MetroFramework.Controls.MetroTextBox();
            this.GBoxCommSetting = new System.Windows.Forms.GroupBox();
            this.TLPCommSetting = new System.Windows.Forms.TableLayoutPanel();
            this.MTxtIPPort = new MetroFramework.Controls.MetroTextBox();
            this.MBtnCommSet = new MetroFramework.Controls.MetroButton();
            this.MLIPAddrClv = new MetroFramework.Controls.MetroLabel();
            this.MTxtIPAddr = new MetroFramework.Controls.MetroTextBox();
            this.MLIPPortCLv = new MetroFramework.Controls.MetroLabel();
            this.MBtnCommRestart = new MetroFramework.Controls.MetroButton();
            this.MLConnectedClv = new MetroFramework.Controls.MetroLabel();
            this.GBoxRunLog.SuspendLayout();
            this.MPClv.SuspendLayout();
            this.GBoxResultClv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGClv)).BeginInit();
            this.MPInfoClv.SuspendLayout();
            this.GBoxStatisticClv.SuspendLayout();
            this.TLPStatisticClv.SuspendLayout();
            this.GBoxCommSetting.SuspendLayout();
            this.TLPCommSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // RtxtRunLog
            // 
            this.RtxtRunLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtRunLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtRunLog.Location = new System.Drawing.Point(7, 23);
            this.RtxtRunLog.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RtxtRunLog.Name = "RtxtRunLog";
            this.RtxtRunLog.Size = new System.Drawing.Size(1055, 138);
            this.RtxtRunLog.TabIndex = 1;
            this.RtxtRunLog.Text = "";
            // 
            // GBoxRunLog
            // 
            this.GBoxRunLog.Controls.Add(this.RtxtRunLog);
            this.GBoxRunLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBoxRunLog.Location = new System.Drawing.Point(14, 487);
            this.GBoxRunLog.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GBoxRunLog.Name = "GBoxRunLog";
            this.GBoxRunLog.Padding = new System.Windows.Forms.Padding(7);
            this.GBoxRunLog.Size = new System.Drawing.Size(1069, 168);
            this.GBoxRunLog.TabIndex = 2;
            this.GBoxRunLog.TabStop = false;
            this.GBoxRunLog.Text = "运行日志";
            // 
            // MPClv
            // 
            this.MPClv.Controls.Add(this.GBoxResultClv);
            this.MPClv.Controls.Add(this.MPInfoClv);
            this.MPClv.Controls.Add(this.MLConnectedClv);
            this.MPClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPClv.HorizontalScrollbarBarColor = true;
            this.MPClv.HorizontalScrollbarHighlightOnWheel = false;
            this.MPClv.HorizontalScrollbarSize = 10;
            this.MPClv.Location = new System.Drawing.Point(14, 65);
            this.MPClv.Name = "MPClv";
            this.MPClv.Padding = new System.Windows.Forms.Padding(5);
            this.MPClv.Size = new System.Drawing.Size(1069, 422);
            this.MPClv.TabIndex = 3;
            this.MPClv.VerticalScrollbarBarColor = true;
            this.MPClv.VerticalScrollbarHighlightOnWheel = false;
            this.MPClv.VerticalScrollbarSize = 10;
            // 
            // GBoxResultClv
            // 
            this.GBoxResultClv.Controls.Add(this.MGClv);
            this.GBoxResultClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBoxResultClv.Location = new System.Drawing.Point(5, 50);
            this.GBoxResultClv.Name = "GBoxResultClv";
            this.GBoxResultClv.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.GBoxResultClv.Size = new System.Drawing.Size(1059, 290);
            this.GBoxResultClv.TabIndex = 3;
            this.GBoxResultClv.TabStop = false;
            this.GBoxResultClv.Text = "结果";
            // 
            // MGClv
            // 
            this.MGClv.AllowUserToAddRows = false;
            this.MGClv.AllowUserToDeleteRows = false;
            this.MGClv.AllowUserToResizeRows = false;
            this.MGClv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MGClv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGClv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MGClv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGClv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGClv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MGClv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MGClv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIndex,
            this.ColTime,
            this.ColContent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGClv.DefaultCellStyle = dataGridViewCellStyle2;
            this.MGClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MGClv.EnableHeadersVisualStyles = false;
            this.MGClv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGClv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGClv.Location = new System.Drawing.Point(5, 21);
            this.MGClv.MultiSelect = false;
            this.MGClv.Name = "MGClv";
            this.MGClv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGClv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MGClv.RowHeadersVisible = false;
            this.MGClv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MGClv.RowTemplate.Height = 23;
            this.MGClv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MGClv.Size = new System.Drawing.Size(1049, 259);
            this.MGClv.TabIndex = 4;
            // 
            // ColIndex
            // 
            this.ColIndex.FillWeight = 27.95089F;
            this.ColIndex.HeaderText = "序号";
            this.ColIndex.Name = "ColIndex";
            this.ColIndex.ReadOnly = true;
            // 
            // ColTime
            // 
            this.ColTime.FillWeight = 91.37056F;
            this.ColTime.HeaderText = "时间";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            // 
            // ColContent
            // 
            this.ColContent.FillWeight = 180.6786F;
            this.ColContent.HeaderText = "内容";
            this.ColContent.Name = "ColContent";
            this.ColContent.ReadOnly = true;
            // 
            // MPInfoClv
            // 
            this.MPInfoClv.Controls.Add(this.GBoxStatisticClv);
            this.MPInfoClv.Controls.Add(this.GBoxCommSetting);
            this.MPInfoClv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MPInfoClv.HorizontalScrollbarBarColor = true;
            this.MPInfoClv.HorizontalScrollbarHighlightOnWheel = false;
            this.MPInfoClv.HorizontalScrollbarSize = 10;
            this.MPInfoClv.Location = new System.Drawing.Point(5, 340);
            this.MPInfoClv.Name = "MPInfoClv";
            this.MPInfoClv.Size = new System.Drawing.Size(1059, 77);
            this.MPInfoClv.TabIndex = 5;
            this.MPInfoClv.VerticalScrollbarBarColor = true;
            this.MPInfoClv.VerticalScrollbarHighlightOnWheel = false;
            this.MPInfoClv.VerticalScrollbarSize = 10;
            // 
            // GBoxStatisticClv
            // 
            this.GBoxStatisticClv.Controls.Add(this.TLPStatisticClv);
            this.GBoxStatisticClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBoxStatisticClv.Location = new System.Drawing.Point(0, 0);
            this.GBoxStatisticClv.Name = "GBoxStatisticClv";
            this.GBoxStatisticClv.Size = new System.Drawing.Size(725, 77);
            this.GBoxStatisticClv.TabIndex = 4;
            this.GBoxStatisticClv.TabStop = false;
            this.GBoxStatisticClv.Text = "统计信息";
            // 
            // TLPStatisticClv
            // 
            this.TLPStatisticClv.ColumnCount = 4;
            this.TLPStatisticClv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLPStatisticClv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPStatisticClv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLPStatisticClv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPStatisticClv.Controls.Add(this.MTxtReadSingle, 1, 0);
            this.TLPStatisticClv.Controls.Add(this.MTxtReadMulti, 3, 1);
            this.TLPStatisticClv.Controls.Add(this.MLReadRateClv, 2, 1);
            this.TLPStatisticClv.Controls.Add(this.MLReadSuccessClv, 0, 0);
            this.TLPStatisticClv.Controls.Add(this.MLReadFailClv, 2, 0);
            this.TLPStatisticClv.Controls.Add(this.MTxtReadFail, 3, 0);
            this.TLPStatisticClv.Controls.Add(this.MLReadTotalClv, 0, 1);
            this.TLPStatisticClv.Controls.Add(this.MTxtReadTotal, 1, 1);
            this.TLPStatisticClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPStatisticClv.Location = new System.Drawing.Point(3, 19);
            this.TLPStatisticClv.Name = "TLPStatisticClv";
            this.TLPStatisticClv.RowCount = 2;
            this.TLPStatisticClv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPStatisticClv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPStatisticClv.Size = new System.Drawing.Size(719, 55);
            this.TLPStatisticClv.TabIndex = 0;
            // 
            // MTxtReadSingle
            // 
            // 
            // 
            // 
            this.MTxtReadSingle.CustomButton.Image = null;
            this.MTxtReadSingle.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.MTxtReadSingle.CustomButton.Name = "";
            this.MTxtReadSingle.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.MTxtReadSingle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtReadSingle.CustomButton.TabIndex = 1;
            this.MTxtReadSingle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtReadSingle.CustomButton.UseSelectable = true;
            this.MTxtReadSingle.CustomButton.Visible = false;
            this.MTxtReadSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MTxtReadSingle.Lines = new string[] {
        "0"};
            this.MTxtReadSingle.Location = new System.Drawing.Point(123, 3);
            this.MTxtReadSingle.MaxLength = 32767;
            this.MTxtReadSingle.Name = "MTxtReadSingle";
            this.MTxtReadSingle.PasswordChar = '\0';
            this.MTxtReadSingle.ReadOnly = true;
            this.MTxtReadSingle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtReadSingle.SelectedText = "";
            this.MTxtReadSingle.SelectionLength = 0;
            this.MTxtReadSingle.SelectionStart = 0;
            this.MTxtReadSingle.ShortcutsEnabled = true;
            this.MTxtReadSingle.Size = new System.Drawing.Size(233, 21);
            this.MTxtReadSingle.TabIndex = 1;
            this.MTxtReadSingle.Text = "0";
            this.MTxtReadSingle.UseSelectable = true;
            this.MTxtReadSingle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtReadSingle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTxtReadMulti
            // 
            // 
            // 
            // 
            this.MTxtReadMulti.CustomButton.Image = null;
            this.MTxtReadMulti.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.MTxtReadMulti.CustomButton.Name = "";
            this.MTxtReadMulti.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.MTxtReadMulti.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtReadMulti.CustomButton.TabIndex = 1;
            this.MTxtReadMulti.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtReadMulti.CustomButton.UseSelectable = true;
            this.MTxtReadMulti.CustomButton.Visible = false;
            this.MTxtReadMulti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MTxtReadMulti.Lines = new string[] {
        "0"};
            this.MTxtReadMulti.Location = new System.Drawing.Point(482, 30);
            this.MTxtReadMulti.MaxLength = 32767;
            this.MTxtReadMulti.Name = "MTxtReadMulti";
            this.MTxtReadMulti.PasswordChar = '\0';
            this.MTxtReadMulti.ReadOnly = true;
            this.MTxtReadMulti.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtReadMulti.SelectedText = "";
            this.MTxtReadMulti.SelectionLength = 0;
            this.MTxtReadMulti.SelectionStart = 0;
            this.MTxtReadMulti.ShortcutsEnabled = true;
            this.MTxtReadMulti.Size = new System.Drawing.Size(234, 22);
            this.MTxtReadMulti.TabIndex = 1;
            this.MTxtReadMulti.Text = "0";
            this.MTxtReadMulti.UseSelectable = true;
            this.MTxtReadMulti.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtReadMulti.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MLReadRateClv
            // 
            this.MLReadRateClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLReadRateClv.Location = new System.Drawing.Point(362, 27);
            this.MLReadRateClv.Name = "MLReadRateClv";
            this.MLReadRateClv.Size = new System.Drawing.Size(114, 28);
            this.MLReadRateClv.TabIndex = 0;
            this.MLReadRateClv.Text = "多个条码";
            this.MLReadRateClv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MLReadSuccessClv
            // 
            this.MLReadSuccessClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLReadSuccessClv.Location = new System.Drawing.Point(3, 0);
            this.MLReadSuccessClv.Name = "MLReadSuccessClv";
            this.MLReadSuccessClv.Size = new System.Drawing.Size(114, 27);
            this.MLReadSuccessClv.TabIndex = 0;
            this.MLReadSuccessClv.Text = "单个条码";
            this.MLReadSuccessClv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MLReadFailClv
            // 
            this.MLReadFailClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLReadFailClv.Location = new System.Drawing.Point(362, 0);
            this.MLReadFailClv.Name = "MLReadFailClv";
            this.MLReadFailClv.Size = new System.Drawing.Size(114, 27);
            this.MLReadFailClv.TabIndex = 0;
            this.MLReadFailClv.Text = "读取失败";
            this.MLReadFailClv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MTxtReadFail
            // 
            // 
            // 
            // 
            this.MTxtReadFail.CustomButton.Image = null;
            this.MTxtReadFail.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.MTxtReadFail.CustomButton.Name = "";
            this.MTxtReadFail.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.MTxtReadFail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtReadFail.CustomButton.TabIndex = 1;
            this.MTxtReadFail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtReadFail.CustomButton.UseSelectable = true;
            this.MTxtReadFail.CustomButton.Visible = false;
            this.MTxtReadFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MTxtReadFail.Lines = new string[] {
        "0"};
            this.MTxtReadFail.Location = new System.Drawing.Point(482, 3);
            this.MTxtReadFail.MaxLength = 32767;
            this.MTxtReadFail.Name = "MTxtReadFail";
            this.MTxtReadFail.PasswordChar = '\0';
            this.MTxtReadFail.ReadOnly = true;
            this.MTxtReadFail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtReadFail.SelectedText = "";
            this.MTxtReadFail.SelectionLength = 0;
            this.MTxtReadFail.SelectionStart = 0;
            this.MTxtReadFail.ShortcutsEnabled = true;
            this.MTxtReadFail.Size = new System.Drawing.Size(234, 21);
            this.MTxtReadFail.TabIndex = 1;
            this.MTxtReadFail.Text = "0";
            this.MTxtReadFail.UseSelectable = true;
            this.MTxtReadFail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtReadFail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MLReadTotalClv
            // 
            this.MLReadTotalClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLReadTotalClv.Location = new System.Drawing.Point(3, 27);
            this.MLReadTotalClv.Name = "MLReadTotalClv";
            this.MLReadTotalClv.Size = new System.Drawing.Size(114, 28);
            this.MLReadTotalClv.TabIndex = 0;
            this.MLReadTotalClv.Text = "读取总量";
            this.MLReadTotalClv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MTxtReadTotal
            // 
            // 
            // 
            // 
            this.MTxtReadTotal.CustomButton.Image = null;
            this.MTxtReadTotal.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.MTxtReadTotal.CustomButton.Name = "";
            this.MTxtReadTotal.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.MTxtReadTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtReadTotal.CustomButton.TabIndex = 1;
            this.MTxtReadTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtReadTotal.CustomButton.UseSelectable = true;
            this.MTxtReadTotal.CustomButton.Visible = false;
            this.MTxtReadTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MTxtReadTotal.Lines = new string[] {
        "0"};
            this.MTxtReadTotal.Location = new System.Drawing.Point(123, 30);
            this.MTxtReadTotal.MaxLength = 32767;
            this.MTxtReadTotal.Name = "MTxtReadTotal";
            this.MTxtReadTotal.PasswordChar = '\0';
            this.MTxtReadTotal.ReadOnly = true;
            this.MTxtReadTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtReadTotal.SelectedText = "";
            this.MTxtReadTotal.SelectionLength = 0;
            this.MTxtReadTotal.SelectionStart = 0;
            this.MTxtReadTotal.ShortcutsEnabled = true;
            this.MTxtReadTotal.Size = new System.Drawing.Size(233, 22);
            this.MTxtReadTotal.TabIndex = 1;
            this.MTxtReadTotal.Text = "0";
            this.MTxtReadTotal.UseSelectable = true;
            this.MTxtReadTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtReadTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GBoxCommSetting
            // 
            this.GBoxCommSetting.Controls.Add(this.TLPCommSetting);
            this.GBoxCommSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.GBoxCommSetting.Location = new System.Drawing.Point(725, 0);
            this.GBoxCommSetting.Name = "GBoxCommSetting";
            this.GBoxCommSetting.Size = new System.Drawing.Size(334, 77);
            this.GBoxCommSetting.TabIndex = 5;
            this.GBoxCommSetting.TabStop = false;
            this.GBoxCommSetting.Text = "通讯设置";
            // 
            // TLPCommSetting
            // 
            this.TLPCommSetting.ColumnCount = 3;
            this.TLPCommSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.42857F));
            this.TLPCommSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.76191F));
            this.TLPCommSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.TLPCommSetting.Controls.Add(this.MTxtIPPort, 1, 1);
            this.TLPCommSetting.Controls.Add(this.MBtnCommSet, 2, 0);
            this.TLPCommSetting.Controls.Add(this.MLIPAddrClv, 0, 0);
            this.TLPCommSetting.Controls.Add(this.MTxtIPAddr, 1, 0);
            this.TLPCommSetting.Controls.Add(this.MLIPPortCLv, 0, 1);
            this.TLPCommSetting.Controls.Add(this.MBtnCommRestart, 2, 1);
            this.TLPCommSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPCommSetting.Location = new System.Drawing.Point(3, 19);
            this.TLPCommSetting.Name = "TLPCommSetting";
            this.TLPCommSetting.RowCount = 2;
            this.TLPCommSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPCommSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPCommSetting.Size = new System.Drawing.Size(328, 55);
            this.TLPCommSetting.TabIndex = 0;
            // 
            // MTxtIPPort
            // 
            this.MTxtIPPort.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTxtIPPort.CustomButton.Image = null;
            this.MTxtIPPort.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.MTxtIPPort.CustomButton.Name = "";
            this.MTxtIPPort.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.MTxtIPPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtIPPort.CustomButton.TabIndex = 1;
            this.MTxtIPPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtIPPort.CustomButton.UseSelectable = true;
            this.MTxtIPPort.CustomButton.Visible = false;
            this.MTxtIPPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MTxtIPPort.Lines = new string[0];
            this.MTxtIPPort.Location = new System.Drawing.Point(106, 30);
            this.MTxtIPPort.MaxLength = 32767;
            this.MTxtIPPort.Name = "MTxtIPPort";
            this.MTxtIPPort.PasswordChar = '\0';
            this.MTxtIPPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtIPPort.SelectedText = "";
            this.MTxtIPPort.SelectionLength = 0;
            this.MTxtIPPort.SelectionStart = 0;
            this.MTxtIPPort.ShortcutsEnabled = true;
            this.MTxtIPPort.Size = new System.Drawing.Size(140, 22);
            this.MTxtIPPort.TabIndex = 1;
            this.MTxtIPPort.UseCustomBackColor = true;
            this.MTxtIPPort.UseSelectable = true;
            this.MTxtIPPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtIPPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MTxtIPPort.Click += new System.EventHandler(this.MTxtIPPort_Click);
            // 
            // MBtnCommSet
            // 
            this.MBtnCommSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MBtnCommSet.Location = new System.Drawing.Point(252, 3);
            this.MBtnCommSet.Name = "MBtnCommSet";
            this.MBtnCommSet.Size = new System.Drawing.Size(73, 21);
            this.MBtnCommSet.TabIndex = 0;
            this.MBtnCommSet.Text = "设置";
            this.MBtnCommSet.UseSelectable = true;
            this.MBtnCommSet.Click += new System.EventHandler(this.MBtnCommSet_Click);
            // 
            // MLIPAddrClv
            // 
            this.MLIPAddrClv.AutoSize = true;
            this.MLIPAddrClv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLIPAddrClv.Location = new System.Drawing.Point(3, 0);
            this.MLIPAddrClv.Name = "MLIPAddrClv";
            this.MLIPAddrClv.Size = new System.Drawing.Size(97, 27);
            this.MLIPAddrClv.TabIndex = 0;
            this.MLIPAddrClv.Text = "网络地址";
            this.MLIPAddrClv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MTxtIPAddr
            // 
            this.MTxtIPAddr.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTxtIPAddr.CustomButton.Image = null;
            this.MTxtIPAddr.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.MTxtIPAddr.CustomButton.Name = "";
            this.MTxtIPAddr.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.MTxtIPAddr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTxtIPAddr.CustomButton.TabIndex = 1;
            this.MTxtIPAddr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTxtIPAddr.CustomButton.UseSelectable = true;
            this.MTxtIPAddr.CustomButton.Visible = false;
            this.MTxtIPAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MTxtIPAddr.Lines = new string[0];
            this.MTxtIPAddr.Location = new System.Drawing.Point(106, 3);
            this.MTxtIPAddr.MaxLength = 32767;
            this.MTxtIPAddr.Name = "MTxtIPAddr";
            this.MTxtIPAddr.PasswordChar = '\0';
            this.MTxtIPAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTxtIPAddr.SelectedText = "";
            this.MTxtIPAddr.SelectionLength = 0;
            this.MTxtIPAddr.SelectionStart = 0;
            this.MTxtIPAddr.ShortcutsEnabled = true;
            this.MTxtIPAddr.Size = new System.Drawing.Size(140, 21);
            this.MTxtIPAddr.TabIndex = 1;
            this.MTxtIPAddr.UseCustomBackColor = true;
            this.MTxtIPAddr.UseSelectable = true;
            this.MTxtIPAddr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTxtIPAddr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MTxtIPAddr.Click += new System.EventHandler(this.MTxtIPAddr_Click);
            // 
            // MLIPPortCLv
            // 
            this.MLIPPortCLv.AutoSize = true;
            this.MLIPPortCLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLIPPortCLv.Location = new System.Drawing.Point(3, 27);
            this.MLIPPortCLv.Name = "MLIPPortCLv";
            this.MLIPPortCLv.Size = new System.Drawing.Size(97, 28);
            this.MLIPPortCLv.TabIndex = 0;
            this.MLIPPortCLv.Text = "网络端口";
            this.MLIPPortCLv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MBtnCommRestart
            // 
            this.MBtnCommRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MBtnCommRestart.Location = new System.Drawing.Point(252, 30);
            this.MBtnCommRestart.Name = "MBtnCommRestart";
            this.MBtnCommRestart.Size = new System.Drawing.Size(73, 22);
            this.MBtnCommRestart.TabIndex = 2;
            this.MBtnCommRestart.Text = "重启";
            this.MBtnCommRestart.UseSelectable = true;
            this.MBtnCommRestart.Click += new System.EventHandler(this.MBtnCommRestart_Click);
            // 
            // MLConnectedClv
            // 
            this.MLConnectedClv.BackColor = System.Drawing.Color.Yellow;
            this.MLConnectedClv.Dock = System.Windows.Forms.DockStyle.Top;
            this.MLConnectedClv.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MLConnectedClv.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MLConnectedClv.Location = new System.Drawing.Point(5, 5);
            this.MLConnectedClv.Name = "MLConnectedClv";
            this.MLConnectedClv.Size = new System.Drawing.Size(1059, 45);
            this.MLConnectedClv.TabIndex = 2;
            this.MLConnectedClv.Text = "Connected";
            this.MLConnectedClv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MLConnectedClv.UseCustomBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 677);
            this.Controls.Add(this.MPClv);
            this.Controls.Add(this.GBoxRunLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(14, 65, 14, 22);
            this.Text = "SystemStatisticSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GBoxRunLog.ResumeLayout(false);
            this.MPClv.ResumeLayout(false);
            this.GBoxResultClv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MGClv)).EndInit();
            this.MPInfoClv.ResumeLayout(false);
            this.GBoxStatisticClv.ResumeLayout(false);
            this.TLPStatisticClv.ResumeLayout(false);
            this.GBoxCommSetting.ResumeLayout(false);
            this.TLPCommSetting.ResumeLayout(false);
            this.TLPCommSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtxtRunLog;
        private System.Windows.Forms.GroupBox GBoxRunLog;
        private MetroFramework.Controls.MetroPanel MPClv;
        private System.Windows.Forms.GroupBox GBoxResultClv;
        private MetroFramework.Controls.MetroGrid MGClv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContent;
        private MetroFramework.Controls.MetroPanel MPInfoClv;
        private System.Windows.Forms.GroupBox GBoxStatisticClv;
        private System.Windows.Forms.TableLayoutPanel TLPStatisticClv;
        private MetroFramework.Controls.MetroTextBox MTxtReadSingle;
        private MetroFramework.Controls.MetroTextBox MTxtReadMulti;
        private MetroFramework.Controls.MetroLabel MLReadRateClv;
        private MetroFramework.Controls.MetroLabel MLReadSuccessClv;
        private MetroFramework.Controls.MetroLabel MLReadFailClv;
        private MetroFramework.Controls.MetroTextBox MTxtReadFail;
        private MetroFramework.Controls.MetroLabel MLReadTotalClv;
        private MetroFramework.Controls.MetroTextBox MTxtReadTotal;
        private System.Windows.Forms.GroupBox GBoxCommSetting;
        private System.Windows.Forms.TableLayoutPanel TLPCommSetting;
        private MetroFramework.Controls.MetroTextBox MTxtIPPort;
        private MetroFramework.Controls.MetroButton MBtnCommSet;
        private MetroFramework.Controls.MetroLabel MLIPAddrClv;
        private MetroFramework.Controls.MetroTextBox MTxtIPAddr;
        private MetroFramework.Controls.MetroLabel MLIPPortCLv;
        private MetroFramework.Controls.MetroButton MBtnCommRestart;
        private MetroFramework.Controls.MetroLabel MLConnectedClv;
    }
}