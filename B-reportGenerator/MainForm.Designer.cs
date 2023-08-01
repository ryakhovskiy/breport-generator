namespace B_reportGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdbGroupBox = new System.Windows.Forms.GroupBox();
            this.reportMonthTextBox = new System.Windows.Forms.TextBox();
            this.reportMonthLabel = new System.Windows.Forms.Label();
            this.reportYearTextBox = new System.Windows.Forms.TextBox();
            this.reportYearLabel = new System.Windows.Forms.Label();
            this.openCsvFileCheckBox = new System.Windows.Forms.CheckBox();
            this.reportDateTextBox = new System.Windows.Forms.TextBox();
            this.reportDateLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.generateCsvReportButton = new System.Windows.Forms.Button();
            this.outputCsvReportFileButton = new System.Windows.Forms.Button();
            this.outputCsvReportFileTextBox = new System.Windows.Forms.TextBox();
            this.outputCsvReportPathLabel = new System.Windows.Forms.Label();
            this.publicCloudInstancesCiCsvPathButton = new System.Windows.Forms.Button();
            this.sqlInstancesCiCsvPathButton = new System.Windows.Forms.Button();
            this.windowsCiCsvPathButton = new System.Windows.Forms.Button();
            this.publicCloudInstancesCiCsvPathTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstancesCiCsvPathTextBox = new System.Windows.Forms.TextBox();
            this.windowsCiCsvPathTextBox = new System.Windows.Forms.TextBox();
            this.publicCloudInstancesCsvPathLabel = new System.Windows.Forms.Label();
            this.sqlInstancesCiCsvPathLabel = new System.Windows.Forms.Label();
            this.windowsCiCsvPathLabel = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.reportCustomizationsGroupBox = new System.Windows.Forms.GroupBox();
            this.aagLabel = new System.Windows.Forms.Label();
            this.materialsLabel = new System.Windows.Forms.Label();
            this.aagDataGridView = new System.Windows.Forms.DataGridView();
            this.ActiveNode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassiveNodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteTeamVmButton = new System.Windows.Forms.Button();
            this.addTeamVmButton = new System.Windows.Forms.Button();
            this.teamVmTextBox = new System.Windows.Forms.TextBox();
            this.teamVMsListBox = new System.Windows.Forms.ListBox();
            this.testVmList = new System.Windows.Forms.Label();
            this.windowsCiToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.reportCustomizationTabControl = new System.Windows.Forms.TabControl();
            this.dataCustomizationTabPage = new System.Windows.Forms.TabPage();
            this.formatCustomizationTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sqlInstanceCsvInstanceNameColumnLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvServerNameColumnTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvServerNameColumnLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvInstanceNameColumnTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvCreatedOnFormatTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvEditionColumnLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvInstallStatusColumnLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvCreatedOnColumnTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvInstallStatusColumnTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvCreatedOnColumnLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvInstallStatusValueLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvVersionColumnTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvInstallStatusValueTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvVersionColumnLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvServiceNameColumnLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvEditionColumnTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvServiceNameColumnTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvCreatedOnFormatLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvRecoveryServerColumnLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvRecoveryServerColumnTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pcdbCsvCreatedOnDateFormatTextBox = new System.Windows.Forms.TextBox();
            this.pcdbCsvNameColumnLabel = new System.Windows.Forms.Label();
            this.pcdbCsvInstallStatusColumnLabel = new System.Windows.Forms.Label();
            this.pcdbCsvCreatedOnColumnTextBox = new System.Windows.Forms.TextBox();
            this.pcdbCsvInstallStatusColumnTextBox = new System.Windows.Forms.TextBox();
            this.pcdbCsvCreatedOnColumnLabel = new System.Windows.Forms.Label();
            this.pcdbCsvInstallStatusValueLabel = new System.Windows.Forms.Label();
            this.pcdbCsvInstallStatusValueTextBox = new System.Windows.Forms.TextBox();
            this.pcdbCsvServiceNameColumnLabel = new System.Windows.Forms.Label();
            this.pcdbCsvNameColumnTextBox = new System.Windows.Forms.TextBox();
            this.pcdbCsvServiceNameColumnTextBox = new System.Windows.Forms.TextBox();
            this.pcdbCsvCreatedOnDateFormatLabel = new System.Windows.Forms.Label();
            this.pcdbCsvServiceInstanceColumnLabel = new System.Windows.Forms.Label();
            this.pcdbCsvServiceInstanceColumnTextBox = new System.Windows.Forms.TextBox();
            this.windowsCsvCustomizationsGroupBox = new System.Windows.Forms.GroupBox();
            this.winCsvNameColumnLabel = new System.Windows.Forms.Label();
            this.createdOnDateFormatTextBox = new System.Windows.Forms.TextBox();
            this.winCsvNameColumnTextBox = new System.Windows.Forms.TextBox();
            this.winCsvCpuCountColumnLabel = new System.Windows.Forms.Label();
            this.CreatedOnColumnTextBox = new System.Windows.Forms.TextBox();
            this.CreatedOnColumnLabel = new System.Windows.Forms.Label();
            this.winCsvCpuCoreCountColumnTextBox = new System.Windows.Forms.TextBox();
            this.winCsvCpuCoreCountColumnLabel = new System.Windows.Forms.Label();
            this.winCsvCpuCountColumnTextBox = new System.Windows.Forms.TextBox();
            this.createdOnDateFormatLabel = new System.Windows.Forms.Label();
            this.winCsvServiceInstanceColumnTextBox = new System.Windows.Forms.TextBox();
            this.winCsvServiceInstanceColumnLabel = new System.Windows.Forms.Label();
            this.winCsvServiceNameColumnTextBox = new System.Windows.Forms.TextBox();
            this.winCsvServiceNameColumnLabel = new System.Windows.Forms.Label();
            this.winCsvInstallStatusValueTextBox = new System.Windows.Forms.TextBox();
            this.winCsvInstallStatusValueLabel = new System.Windows.Forms.Label();
            this.winCsvInstallStatusColumnNameTextBox = new System.Windows.Forms.TextBox();
            this.winCsvInstallStatusColumnNameLabel = new System.Windows.Forms.Label();
            this.sqlInstanceCsvNameColumnTextBox = new System.Windows.Forms.TextBox();
            this.sqlInstanceCsvNameColumnLabel = new System.Windows.Forms.Label();
            this.cmdbGroupBox.SuspendLayout();
            this.reportCustomizationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aagDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            this.reportCustomizationTabControl.SuspendLayout();
            this.dataCustomizationTabPage.SuspendLayout();
            this.formatCustomizationTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.windowsCsvCustomizationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdbGroupBox
            // 
            this.cmdbGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdbGroupBox.Controls.Add(this.reportMonthTextBox);
            this.cmdbGroupBox.Controls.Add(this.reportMonthLabel);
            this.cmdbGroupBox.Controls.Add(this.reportYearTextBox);
            this.cmdbGroupBox.Controls.Add(this.reportYearLabel);
            this.cmdbGroupBox.Controls.Add(this.openCsvFileCheckBox);
            this.cmdbGroupBox.Controls.Add(this.reportDateTextBox);
            this.cmdbGroupBox.Controls.Add(this.reportDateLabel);
            this.cmdbGroupBox.Controls.Add(this.progressLabel);
            this.cmdbGroupBox.Controls.Add(this.mainProgressBar);
            this.cmdbGroupBox.Controls.Add(this.generateCsvReportButton);
            this.cmdbGroupBox.Controls.Add(this.outputCsvReportFileButton);
            this.cmdbGroupBox.Controls.Add(this.outputCsvReportFileTextBox);
            this.cmdbGroupBox.Controls.Add(this.outputCsvReportPathLabel);
            this.cmdbGroupBox.Controls.Add(this.publicCloudInstancesCiCsvPathButton);
            this.cmdbGroupBox.Controls.Add(this.sqlInstancesCiCsvPathButton);
            this.cmdbGroupBox.Controls.Add(this.windowsCiCsvPathButton);
            this.cmdbGroupBox.Controls.Add(this.publicCloudInstancesCiCsvPathTextBox);
            this.cmdbGroupBox.Controls.Add(this.sqlInstancesCiCsvPathTextBox);
            this.cmdbGroupBox.Controls.Add(this.windowsCiCsvPathTextBox);
            this.cmdbGroupBox.Controls.Add(this.publicCloudInstancesCsvPathLabel);
            this.cmdbGroupBox.Controls.Add(this.sqlInstancesCiCsvPathLabel);
            this.cmdbGroupBox.Controls.Add(this.windowsCiCsvPathLabel);
            this.cmdbGroupBox.Location = new System.Drawing.Point(10, 9);
            this.cmdbGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdbGroupBox.Name = "cmdbGroupBox";
            this.cmdbGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdbGroupBox.Size = new System.Drawing.Size(1092, 166);
            this.cmdbGroupBox.TabIndex = 0;
            this.cmdbGroupBox.TabStop = false;
            this.cmdbGroupBox.Text = "CMDB";
            // 
            // reportMonthTextBox
            // 
            this.reportMonthTextBox.Location = new System.Drawing.Point(749, 114);
            this.reportMonthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportMonthTextBox.Name = "reportMonthTextBox";
            this.reportMonthTextBox.Size = new System.Drawing.Size(43, 23);
            this.reportMonthTextBox.TabIndex = 105;
            this.reportMonthTextBox.Leave += new System.EventHandler(this.reportMonthTextBox_Leave);
            // 
            // reportMonthLabel
            // 
            this.reportMonthLabel.AutoSize = true;
            this.reportMonthLabel.Location = new System.Drawing.Point(662, 114);
            this.reportMonthLabel.Name = "reportMonthLabel";
            this.reportMonthLabel.Size = new System.Drawing.Size(81, 15);
            this.reportMonthLabel.TabIndex = 104;
            this.reportMonthLabel.Text = "Report Month";
            // 
            // reportYearTextBox
            // 
            this.reportYearTextBox.Location = new System.Drawing.Point(579, 114);
            this.reportYearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportYearTextBox.Name = "reportYearTextBox";
            this.reportYearTextBox.Size = new System.Drawing.Size(65, 23);
            this.reportYearTextBox.TabIndex = 103;
            this.reportYearTextBox.Leave += new System.EventHandler(this.reportYearTextBox_Leave);
            // 
            // reportYearLabel
            // 
            this.reportYearLabel.AutoSize = true;
            this.reportYearLabel.Location = new System.Drawing.Point(506, 117);
            this.reportYearLabel.Name = "reportYearLabel";
            this.reportYearLabel.Size = new System.Drawing.Size(67, 15);
            this.reportYearLabel.TabIndex = 102;
            this.reportYearLabel.Text = "Report Year";
            // 
            // openCsvFileCheckBox
            // 
            this.openCsvFileCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openCsvFileCheckBox.AutoSize = true;
            this.openCsvFileCheckBox.Checked = true;
            this.openCsvFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openCsvFileCheckBox.Location = new System.Drawing.Point(679, 142);
            this.openCsvFileCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openCsvFileCheckBox.Name = "openCsvFileCheckBox";
            this.openCsvFileCheckBox.Size = new System.Drawing.Size(225, 19);
            this.openCsvFileCheckBox.TabIndex = 101;
            this.openCsvFileCheckBox.Text = "Open CSV Report File after generating";
            this.openCsvFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // reportDateTextBox
            // 
            this.reportDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportDateTextBox.Enabled = false;
            this.reportDateTextBox.Location = new System.Drawing.Point(939, 114);
            this.reportDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportDateTextBox.Name = "reportDateTextBox";
            this.reportDateTextBox.Size = new System.Drawing.Size(143, 23);
            this.reportDateTextBox.TabIndex = 90;
            // 
            // reportDateLabel
            // 
            this.reportDateLabel.AutoSize = true;
            this.reportDateLabel.Location = new System.Drawing.Point(843, 114);
            this.reportDateLabel.Name = "reportDateLabel";
            this.reportDateLabel.Size = new System.Drawing.Size(90, 15);
            this.reportDateLabel.TabIndex = 15;
            this.reportDateLabel.Text = "Report Date Tag";
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLabel.Location = new System.Drawing.Point(10, 121);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(52, 15);
            this.progressLabel.TabIndex = 14;
            this.progressLabel.Text = "progress";
            this.progressLabel.Visible = false;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressBar.Location = new System.Drawing.Point(5, 140);
            this.mainProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(639, 22);
            this.mainProgressBar.TabIndex = 1;
            this.mainProgressBar.Visible = false;
            // 
            // generateCsvReportButton
            // 
            this.generateCsvReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateCsvReportButton.Location = new System.Drawing.Point(909, 140);
            this.generateCsvReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateCsvReportButton.Name = "generateCsvReportButton";
            this.generateCsvReportButton.Size = new System.Drawing.Size(172, 22);
            this.generateCsvReportButton.TabIndex = 100;
            this.generateCsvReportButton.Text = "Generate CSV Report";
            this.generateCsvReportButton.UseVisualStyleBackColor = true;
            this.generateCsvReportButton.Click += new System.EventHandler(this.generateCsvReportButton_Click);
            // 
            // outputCsvReportFileButton
            // 
            this.outputCsvReportFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputCsvReportFileButton.Location = new System.Drawing.Point(1050, 89);
            this.outputCsvReportFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputCsvReportFileButton.Name = "outputCsvReportFileButton";
            this.outputCsvReportFileButton.Size = new System.Drawing.Size(32, 22);
            this.outputCsvReportFileButton.TabIndex = 80;
            this.outputCsvReportFileButton.Text = "...";
            this.outputCsvReportFileButton.UseVisualStyleBackColor = true;
            this.outputCsvReportFileButton.Click += new System.EventHandler(this.outputCsvReportFileButton_Click);
            // 
            // outputCsvReportFileTextBox
            // 
            this.outputCsvReportFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputCsvReportFileTextBox.Location = new System.Drawing.Point(221, 89);
            this.outputCsvReportFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputCsvReportFileTextBox.Name = "outputCsvReportFileTextBox";
            this.outputCsvReportFileTextBox.Size = new System.Drawing.Size(824, 23);
            this.outputCsvReportFileTextBox.TabIndex = 70;
            // 
            // outputCsvReportPathLabel
            // 
            this.outputCsvReportPathLabel.AutoSize = true;
            this.outputCsvReportPathLabel.Location = new System.Drawing.Point(75, 92);
            this.outputCsvReportPathLabel.Name = "outputCsvReportPathLabel";
            this.outputCsvReportPathLabel.Size = new System.Drawing.Size(128, 15);
            this.outputCsvReportPathLabel.TabIndex = 8;
            this.outputCsvReportPathLabel.Text = "Output CSV Report File";
            // 
            // publicCloudInstancesCiCsvPathButton
            // 
            this.publicCloudInstancesCiCsvPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.publicCloudInstancesCiCsvPathButton.Location = new System.Drawing.Point(1050, 63);
            this.publicCloudInstancesCiCsvPathButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicCloudInstancesCiCsvPathButton.Name = "publicCloudInstancesCiCsvPathButton";
            this.publicCloudInstancesCiCsvPathButton.Size = new System.Drawing.Size(32, 22);
            this.publicCloudInstancesCiCsvPathButton.TabIndex = 60;
            this.publicCloudInstancesCiCsvPathButton.Text = "...";
            this.publicCloudInstancesCiCsvPathButton.UseVisualStyleBackColor = true;
            this.publicCloudInstancesCiCsvPathButton.Click += new System.EventHandler(this.publicCloudInstancesCiCsvPathButton_Click);
            // 
            // sqlInstancesCiCsvPathButton
            // 
            this.sqlInstancesCiCsvPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlInstancesCiCsvPathButton.Location = new System.Drawing.Point(1050, 39);
            this.sqlInstancesCiCsvPathButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sqlInstancesCiCsvPathButton.Name = "sqlInstancesCiCsvPathButton";
            this.sqlInstancesCiCsvPathButton.Size = new System.Drawing.Size(32, 22);
            this.sqlInstancesCiCsvPathButton.TabIndex = 40;
            this.sqlInstancesCiCsvPathButton.Text = "...";
            this.sqlInstancesCiCsvPathButton.UseVisualStyleBackColor = true;
            this.sqlInstancesCiCsvPathButton.Click += new System.EventHandler(this.sqlInstancesCiCsvPathButton_Click);
            // 
            // windowsCiCsvPathButton
            // 
            this.windowsCiCsvPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsCiCsvPathButton.Location = new System.Drawing.Point(1050, 14);
            this.windowsCiCsvPathButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.windowsCiCsvPathButton.Name = "windowsCiCsvPathButton";
            this.windowsCiCsvPathButton.Size = new System.Drawing.Size(32, 22);
            this.windowsCiCsvPathButton.TabIndex = 20;
            this.windowsCiCsvPathButton.Text = "...";
            this.windowsCiCsvPathButton.UseVisualStyleBackColor = true;
            this.windowsCiCsvPathButton.Click += new System.EventHandler(this.windowsCiCsvPathButton_Click);
            // 
            // publicCloudInstancesCiCsvPathTextBox
            // 
            this.publicCloudInstancesCiCsvPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicCloudInstancesCiCsvPathTextBox.Location = new System.Drawing.Point(221, 64);
            this.publicCloudInstancesCiCsvPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicCloudInstancesCiCsvPathTextBox.Name = "publicCloudInstancesCiCsvPathTextBox";
            this.publicCloudInstancesCiCsvPathTextBox.Size = new System.Drawing.Size(824, 23);
            this.publicCloudInstancesCiCsvPathTextBox.TabIndex = 50;
            // 
            // sqlInstancesCiCsvPathTextBox
            // 
            this.sqlInstancesCiCsvPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlInstancesCiCsvPathTextBox.Location = new System.Drawing.Point(221, 40);
            this.sqlInstancesCiCsvPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sqlInstancesCiCsvPathTextBox.Name = "sqlInstancesCiCsvPathTextBox";
            this.sqlInstancesCiCsvPathTextBox.Size = new System.Drawing.Size(824, 23);
            this.sqlInstancesCiCsvPathTextBox.TabIndex = 30;
            // 
            // windowsCiCsvPathTextBox
            // 
            this.windowsCiCsvPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsCiCsvPathTextBox.Location = new System.Drawing.Point(221, 15);
            this.windowsCiCsvPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.windowsCiCsvPathTextBox.Name = "windowsCiCsvPathTextBox";
            this.windowsCiCsvPathTextBox.Size = new System.Drawing.Size(824, 23);
            this.windowsCiCsvPathTextBox.TabIndex = 10;
            // 
            // publicCloudInstancesCsvPathLabel
            // 
            this.publicCloudInstancesCsvPathLabel.AutoSize = true;
            this.publicCloudInstancesCsvPathLabel.Location = new System.Drawing.Point(5, 67);
            this.publicCloudInstancesCsvPathLabel.Name = "publicCloudInstancesCsvPathLabel";
            this.publicCloudInstancesCsvPathLabel.Size = new System.Drawing.Size(197, 15);
            this.publicCloudInstancesCsvPathLabel.TabIndex = 2;
            this.publicCloudInstancesCsvPathLabel.Text = "Public Cloud instances CIs CSV Path";
            // 
            // sqlInstancesCiCsvPathLabel
            // 
            this.sqlInstancesCiCsvPathLabel.AutoSize = true;
            this.sqlInstancesCiCsvPathLabel.Location = new System.Drawing.Point(55, 42);
            this.sqlInstancesCiCsvPathLabel.Name = "sqlInstancesCiCsvPathLabel";
            this.sqlInstancesCiCsvPathLabel.Size = new System.Drawing.Size(150, 15);
            this.sqlInstancesCiCsvPathLabel.TabIndex = 1;
            this.sqlInstancesCiCsvPathLabel.Text = "SQL Instances CIs CSV Path";
            // 
            // windowsCiCsvPathLabel
            // 
            this.windowsCiCsvPathLabel.AutoSize = true;
            this.windowsCiCsvPathLabel.Location = new System.Drawing.Point(80, 17);
            this.windowsCiCsvPathLabel.Name = "windowsCiCsvPathLabel";
            this.windowsCiCsvPathLabel.Size = new System.Drawing.Size(126, 15);
            this.windowsCiCsvPathLabel.TabIndex = 0;
            this.windowsCiCsvPathLabel.Text = "Windows CIs CSV Path";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCiCsvBackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.loadCiCsvBackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadCiCsvBackgroundWorker_RunWorkerCompleted);
            // 
            // reportCustomizationsGroupBox
            // 
            this.reportCustomizationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportCustomizationsGroupBox.Controls.Add(this.aagLabel);
            this.reportCustomizationsGroupBox.Controls.Add(this.materialsLabel);
            this.reportCustomizationsGroupBox.Controls.Add(this.aagDataGridView);
            this.reportCustomizationsGroupBox.Controls.Add(this.materialsDataGridView);
            this.reportCustomizationsGroupBox.Controls.Add(this.deleteTeamVmButton);
            this.reportCustomizationsGroupBox.Controls.Add(this.addTeamVmButton);
            this.reportCustomizationsGroupBox.Controls.Add(this.teamVmTextBox);
            this.reportCustomizationsGroupBox.Controls.Add(this.teamVMsListBox);
            this.reportCustomizationsGroupBox.Controls.Add(this.testVmList);
            this.reportCustomizationsGroupBox.Location = new System.Drawing.Point(6, 5);
            this.reportCustomizationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportCustomizationsGroupBox.Name = "reportCustomizationsGroupBox";
            this.reportCustomizationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportCustomizationsGroupBox.Size = new System.Drawing.Size(1071, 326);
            this.reportCustomizationsGroupBox.TabIndex = 1;
            this.reportCustomizationsGroupBox.TabStop = false;
            this.reportCustomizationsGroupBox.Text = "Report Customizations";
            // 
            // aagLabel
            // 
            this.aagLabel.AutoSize = true;
            this.aagLabel.Location = new System.Drawing.Point(468, 17);
            this.aagLabel.Name = "aagLabel";
            this.aagLabel.Size = new System.Drawing.Size(120, 15);
            this.aagLabel.TabIndex = 8;
            this.aagLabel.Text = "Active-Passive Nodes";
            // 
            // materialsLabel
            // 
            this.materialsLabel.AutoSize = true;
            this.materialsLabel.Location = new System.Drawing.Point(150, 17);
            this.materialsLabel.Name = "materialsLabel";
            this.materialsLabel.Size = new System.Drawing.Size(55, 15);
            this.materialsLabel.TabIndex = 7;
            this.materialsLabel.Text = "Materials";
            // 
            // aagDataGridView
            // 
            this.aagDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActiveNode,
            this.PassiveNodes});
            this.aagDataGridView.Location = new System.Drawing.Point(468, 34);
            this.aagDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aagDataGridView.Name = "aagDataGridView";
            this.aagDataGridView.RowHeadersWidth = 51;
            this.aagDataGridView.RowTemplate.Height = 29;
            this.aagDataGridView.Size = new System.Drawing.Size(597, 287);
            this.aagDataGridView.TabIndex = 160;
            this.aagDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.aagDataGridView_RowLeave);
            this.aagDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.aagDataGridView_UserDeletedRow);
            // 
            // ActiveNode
            // 
            this.ActiveNode.HeaderText = "Active Node";
            this.ActiveNode.MinimumWidth = 6;
            this.ActiveNode.Name = "ActiveNode";
            this.ActiveNode.Width = 125;
            // 
            // PassiveNodes
            // 
            this.PassiveNodes.HeaderText = "Passive Nodes";
            this.PassiveNodes.MinimumWidth = 6;
            this.PassiveNodes.Name = "PassiveNodes";
            this.PassiveNodes.Width = 300;
            // 
            // materialsDataGridView
            // 
            this.materialsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.Description});
            this.materialsDataGridView.Location = new System.Drawing.Point(150, 34);
            this.materialsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowHeadersWidth = 51;
            this.materialsDataGridView.RowTemplate.Height = 29;
            this.materialsDataGridView.Size = new System.Drawing.Size(313, 287);
            this.materialsDataGridView.TabIndex = 150;
            this.materialsDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.materialsDataGridView_UserAddedRow);
            this.materialsDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.materialsDataGridView_UserDeletedRow);
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.Width = 80;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 225;
            // 
            // deleteTeamVmButton
            // 
            this.deleteTeamVmButton.Location = new System.Drawing.Point(5, 62);
            this.deleteTeamVmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteTeamVmButton.Name = "deleteTeamVmButton";
            this.deleteTeamVmButton.Size = new System.Drawing.Size(131, 22);
            this.deleteTeamVmButton.TabIndex = 130;
            this.deleteTeamVmButton.Text = "Delete";
            this.deleteTeamVmButton.UseVisualStyleBackColor = true;
            this.deleteTeamVmButton.Click += new System.EventHandler(this.deleteTeamVmButton_Click);
            // 
            // addTeamVmButton
            // 
            this.addTeamVmButton.Location = new System.Drawing.Point(95, 34);
            this.addTeamVmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTeamVmButton.Name = "addTeamVmButton";
            this.addTeamVmButton.Size = new System.Drawing.Size(41, 22);
            this.addTeamVmButton.TabIndex = 120;
            this.addTeamVmButton.Text = "Add";
            this.addTeamVmButton.UseVisualStyleBackColor = true;
            this.addTeamVmButton.Click += new System.EventHandler(this.addTeamVmButton_Click);
            // 
            // teamVmTextBox
            // 
            this.teamVmTextBox.Location = new System.Drawing.Point(5, 34);
            this.teamVmTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamVmTextBox.Name = "teamVmTextBox";
            this.teamVmTextBox.Size = new System.Drawing.Size(85, 23);
            this.teamVmTextBox.TabIndex = 110;
            // 
            // teamVMsListBox
            // 
            this.teamVMsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.teamVMsListBox.FormattingEnabled = true;
            this.teamVMsListBox.ItemHeight = 15;
            this.teamVMsListBox.Location = new System.Drawing.Point(5, 87);
            this.teamVMsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamVMsListBox.Name = "teamVMsListBox";
            this.teamVMsListBox.Size = new System.Drawing.Size(132, 214);
            this.teamVMsListBox.TabIndex = 140;
            // 
            // testVmList
            // 
            this.testVmList.AutoSize = true;
            this.testVmList.Location = new System.Drawing.Point(10, 17);
            this.testVmList.Name = "testVmList";
            this.testVmList.Size = new System.Drawing.Size(61, 15);
            this.testVmList.TabIndex = 0;
            this.testVmList.Text = "Team VMs";
            // 
            // reportCustomizationTabControl
            // 
            this.reportCustomizationTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportCustomizationTabControl.Controls.Add(this.dataCustomizationTabPage);
            this.reportCustomizationTabControl.Controls.Add(this.formatCustomizationTabPage);
            this.reportCustomizationTabControl.Location = new System.Drawing.Point(10, 180);
            this.reportCustomizationTabControl.Name = "reportCustomizationTabControl";
            this.reportCustomizationTabControl.SelectedIndex = 0;
            this.reportCustomizationTabControl.Size = new System.Drawing.Size(1092, 381);
            this.reportCustomizationTabControl.TabIndex = 2;
            // 
            // dataCustomizationTabPage
            // 
            this.dataCustomizationTabPage.Controls.Add(this.reportCustomizationsGroupBox);
            this.dataCustomizationTabPage.Location = new System.Drawing.Point(4, 24);
            this.dataCustomizationTabPage.Name = "dataCustomizationTabPage";
            this.dataCustomizationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataCustomizationTabPage.Size = new System.Drawing.Size(1084, 336);
            this.dataCustomizationTabPage.TabIndex = 0;
            this.dataCustomizationTabPage.Text = "Report Data Cusomizations";
            this.dataCustomizationTabPage.UseVisualStyleBackColor = true;
            // 
            // formatCustomizationTabPage
            // 
            this.formatCustomizationTabPage.Controls.Add(this.groupBox2);
            this.formatCustomizationTabPage.Controls.Add(this.groupBox3);
            this.formatCustomizationTabPage.Controls.Add(this.windowsCsvCustomizationsGroupBox);
            this.formatCustomizationTabPage.Location = new System.Drawing.Point(4, 24);
            this.formatCustomizationTabPage.Name = "formatCustomizationTabPage";
            this.formatCustomizationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.formatCustomizationTabPage.Size = new System.Drawing.Size(1084, 353);
            this.formatCustomizationTabPage.TabIndex = 1;
            this.formatCustomizationTabPage.Text = "Report Format Customizations";
            this.formatCustomizationTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sqlInstanceCsvNameColumnTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvNameColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvInstanceNameColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvServerNameColumnTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvServerNameColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvInstanceNameColumnTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvCreatedOnFormatTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvEditionColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvInstallStatusColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvCreatedOnColumnTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvInstallStatusColumnTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvCreatedOnColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvInstallStatusValueLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvVersionColumnTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvInstallStatusValueTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvVersionColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvServiceNameColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvEditionColumnTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvServiceNameColumnTextBox);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvCreatedOnFormatLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvRecoveryServerColumnLabel);
            this.groupBox2.Controls.Add(this.sqlInstanceCsvRecoveryServerColumnTextBox);
            this.groupBox2.Location = new System.Drawing.Point(353, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 347);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Instances CIs CSV Customizations";
            // 
            // sqlInstanceCsvInstanceNameColumnLabel
            // 
            this.sqlInstanceCsvInstanceNameColumnLabel.AutoSize = true;
            this.sqlInstanceCsvInstanceNameColumnLabel.Location = new System.Drawing.Point(56, 196);
            this.sqlInstanceCsvInstanceNameColumnLabel.Name = "sqlInstanceCsvInstanceNameColumnLabel";
            this.sqlInstanceCsvInstanceNameColumnLabel.Size = new System.Drawing.Size(132, 15);
            this.sqlInstanceCsvInstanceNameColumnLabel.TabIndex = 35;
            this.sqlInstanceCsvInstanceNameColumnLabel.Text = "Instance Name Column";
            // 
            // sqlInstanceCsvServerNameColumnTextBox
            // 
            this.sqlInstanceCsvServerNameColumnTextBox.Location = new System.Drawing.Point(194, 222);
            this.sqlInstanceCsvServerNameColumnTextBox.Name = "sqlInstanceCsvServerNameColumnTextBox";
            this.sqlInstanceCsvServerNameColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvServerNameColumnTextBox.TabIndex = 34;
            // 
            // sqlInstanceCsvServerNameColumnLabel
            // 
            this.sqlInstanceCsvServerNameColumnLabel.AutoSize = true;
            this.sqlInstanceCsvServerNameColumnLabel.Location = new System.Drawing.Point(68, 225);
            this.sqlInstanceCsvServerNameColumnLabel.Name = "sqlInstanceCsvServerNameColumnLabel";
            this.sqlInstanceCsvServerNameColumnLabel.Size = new System.Drawing.Size(120, 15);
            this.sqlInstanceCsvServerNameColumnLabel.TabIndex = 33;
            this.sqlInstanceCsvServerNameColumnLabel.Text = "Server Name Column";
            // 
            // sqlInstanceCsvInstanceNameColumnTextBox
            // 
            this.sqlInstanceCsvInstanceNameColumnTextBox.Location = new System.Drawing.Point(194, 193);
            this.sqlInstanceCsvInstanceNameColumnTextBox.Name = "sqlInstanceCsvInstanceNameColumnTextBox";
            this.sqlInstanceCsvInstanceNameColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvInstanceNameColumnTextBox.TabIndex = 32;
            // 
            // sqlInstanceCsvCreatedOnFormatTextBox
            // 
            this.sqlInstanceCsvCreatedOnFormatTextBox.Location = new System.Drawing.Point(194, 311);
            this.sqlInstanceCsvCreatedOnFormatTextBox.Name = "sqlInstanceCsvCreatedOnFormatTextBox";
            this.sqlInstanceCsvCreatedOnFormatTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvCreatedOnFormatTextBox.TabIndex = 31;
            // 
            // sqlInstanceCsvEditionColumnLabel
            // 
            this.sqlInstanceCsvEditionColumnLabel.AutoSize = true;
            this.sqlInstanceCsvEditionColumnLabel.Location = new System.Drawing.Point(98, 138);
            this.sqlInstanceCsvEditionColumnLabel.Name = "sqlInstanceCsvEditionColumnLabel";
            this.sqlInstanceCsvEditionColumnLabel.Size = new System.Drawing.Size(90, 15);
            this.sqlInstanceCsvEditionColumnLabel.TabIndex = 30;
            this.sqlInstanceCsvEditionColumnLabel.Text = "Edition Column";
            // 
            // sqlInstanceCsvInstallStatusColumnLabel
            // 
            this.sqlInstanceCsvInstallStatusColumnLabel.AutoSize = true;
            this.sqlInstanceCsvInstallStatusColumnLabel.Location = new System.Drawing.Point(69, 22);
            this.sqlInstanceCsvInstallStatusColumnLabel.Name = "sqlInstanceCsvInstallStatusColumnLabel";
            this.sqlInstanceCsvInstallStatusColumnLabel.Size = new System.Drawing.Size(119, 15);
            this.sqlInstanceCsvInstallStatusColumnLabel.TabIndex = 16;
            this.sqlInstanceCsvInstallStatusColumnLabel.Text = "Install Status Column";
            // 
            // sqlInstanceCsvCreatedOnColumnTextBox
            // 
            this.sqlInstanceCsvCreatedOnColumnTextBox.Location = new System.Drawing.Point(194, 282);
            this.sqlInstanceCsvCreatedOnColumnTextBox.Name = "sqlInstanceCsvCreatedOnColumnTextBox";
            this.sqlInstanceCsvCreatedOnColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvCreatedOnColumnTextBox.TabIndex = 29;
            // 
            // sqlInstanceCsvInstallStatusColumnTextBox
            // 
            this.sqlInstanceCsvInstallStatusColumnTextBox.Location = new System.Drawing.Point(194, 19);
            this.sqlInstanceCsvInstallStatusColumnTextBox.Name = "sqlInstanceCsvInstallStatusColumnTextBox";
            this.sqlInstanceCsvInstallStatusColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvInstallStatusColumnTextBox.TabIndex = 17;
            // 
            // sqlInstanceCsvCreatedOnColumnLabel
            // 
            this.sqlInstanceCsvCreatedOnColumnLabel.AutoSize = true;
            this.sqlInstanceCsvCreatedOnColumnLabel.Location = new System.Drawing.Point(75, 285);
            this.sqlInstanceCsvCreatedOnColumnLabel.Name = "sqlInstanceCsvCreatedOnColumnLabel";
            this.sqlInstanceCsvCreatedOnColumnLabel.Size = new System.Drawing.Size(113, 15);
            this.sqlInstanceCsvCreatedOnColumnLabel.TabIndex = 28;
            this.sqlInstanceCsvCreatedOnColumnLabel.Text = "Created On Column";
            // 
            // sqlInstanceCsvInstallStatusValueLabel
            // 
            this.sqlInstanceCsvInstallStatusValueLabel.AutoSize = true;
            this.sqlInstanceCsvInstallStatusValueLabel.Location = new System.Drawing.Point(84, 51);
            this.sqlInstanceCsvInstallStatusValueLabel.Name = "sqlInstanceCsvInstallStatusValueLabel";
            this.sqlInstanceCsvInstallStatusValueLabel.Size = new System.Drawing.Size(104, 15);
            this.sqlInstanceCsvInstallStatusValueLabel.TabIndex = 18;
            this.sqlInstanceCsvInstallStatusValueLabel.Text = "Install Status Value";
            // 
            // sqlInstanceCsvVersionColumnTextBox
            // 
            this.sqlInstanceCsvVersionColumnTextBox.Location = new System.Drawing.Point(194, 164);
            this.sqlInstanceCsvVersionColumnTextBox.Name = "sqlInstanceCsvVersionColumnTextBox";
            this.sqlInstanceCsvVersionColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvVersionColumnTextBox.TabIndex = 27;
            // 
            // sqlInstanceCsvInstallStatusValueTextBox
            // 
            this.sqlInstanceCsvInstallStatusValueTextBox.Location = new System.Drawing.Point(194, 48);
            this.sqlInstanceCsvInstallStatusValueTextBox.Name = "sqlInstanceCsvInstallStatusValueTextBox";
            this.sqlInstanceCsvInstallStatusValueTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvInstallStatusValueTextBox.TabIndex = 19;
            // 
            // sqlInstanceCsvVersionColumnLabel
            // 
            this.sqlInstanceCsvVersionColumnLabel.AutoSize = true;
            this.sqlInstanceCsvVersionColumnLabel.Location = new System.Drawing.Point(97, 167);
            this.sqlInstanceCsvVersionColumnLabel.Name = "sqlInstanceCsvVersionColumnLabel";
            this.sqlInstanceCsvVersionColumnLabel.Size = new System.Drawing.Size(91, 15);
            this.sqlInstanceCsvVersionColumnLabel.TabIndex = 26;
            this.sqlInstanceCsvVersionColumnLabel.Text = "Version Column";
            // 
            // sqlInstanceCsvServiceNameColumnLabel
            // 
            this.sqlInstanceCsvServiceNameColumnLabel.AutoSize = true;
            this.sqlInstanceCsvServiceNameColumnLabel.Location = new System.Drawing.Point(63, 80);
            this.sqlInstanceCsvServiceNameColumnLabel.Name = "sqlInstanceCsvServiceNameColumnLabel";
            this.sqlInstanceCsvServiceNameColumnLabel.Size = new System.Drawing.Size(125, 15);
            this.sqlInstanceCsvServiceNameColumnLabel.TabIndex = 20;
            this.sqlInstanceCsvServiceNameColumnLabel.Text = "Service Name Column";
            // 
            // sqlInstanceCsvEditionColumnTextBox
            // 
            this.sqlInstanceCsvEditionColumnTextBox.Location = new System.Drawing.Point(194, 135);
            this.sqlInstanceCsvEditionColumnTextBox.Name = "sqlInstanceCsvEditionColumnTextBox";
            this.sqlInstanceCsvEditionColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvEditionColumnTextBox.TabIndex = 25;
            // 
            // sqlInstanceCsvServiceNameColumnTextBox
            // 
            this.sqlInstanceCsvServiceNameColumnTextBox.Location = new System.Drawing.Point(194, 77);
            this.sqlInstanceCsvServiceNameColumnTextBox.Name = "sqlInstanceCsvServiceNameColumnTextBox";
            this.sqlInstanceCsvServiceNameColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvServiceNameColumnTextBox.TabIndex = 21;
            // 
            // sqlInstanceCsvCreatedOnFormatLabel
            // 
            this.sqlInstanceCsvCreatedOnFormatLabel.AutoSize = true;
            this.sqlInstanceCsvCreatedOnFormatLabel.Location = new System.Drawing.Point(53, 314);
            this.sqlInstanceCsvCreatedOnFormatLabel.Name = "sqlInstanceCsvCreatedOnFormatLabel";
            this.sqlInstanceCsvCreatedOnFormatLabel.Size = new System.Drawing.Size(135, 15);
            this.sqlInstanceCsvCreatedOnFormatLabel.TabIndex = 24;
            this.sqlInstanceCsvCreatedOnFormatLabel.Text = "Created On Date Format";
            // 
            // sqlInstanceCsvRecoveryServerColumnLabel
            // 
            this.sqlInstanceCsvRecoveryServerColumnLabel.AutoSize = true;
            this.sqlInstanceCsvRecoveryServerColumnLabel.Location = new System.Drawing.Point(52, 111);
            this.sqlInstanceCsvRecoveryServerColumnLabel.Name = "sqlInstanceCsvRecoveryServerColumnLabel";
            this.sqlInstanceCsvRecoveryServerColumnLabel.Size = new System.Drawing.Size(136, 15);
            this.sqlInstanceCsvRecoveryServerColumnLabel.TabIndex = 22;
            this.sqlInstanceCsvRecoveryServerColumnLabel.Text = "Recovery Server Column";
            // 
            // sqlInstanceCsvRecoveryServerColumnTextBox
            // 
            this.sqlInstanceCsvRecoveryServerColumnTextBox.Location = new System.Drawing.Point(194, 106);
            this.sqlInstanceCsvRecoveryServerColumnTextBox.Name = "sqlInstanceCsvRecoveryServerColumnTextBox";
            this.sqlInstanceCsvRecoveryServerColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvRecoveryServerColumnTextBox.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pcdbCsvCreatedOnDateFormatTextBox);
            this.groupBox3.Controls.Add(this.pcdbCsvNameColumnLabel);
            this.groupBox3.Controls.Add(this.pcdbCsvInstallStatusColumnLabel);
            this.groupBox3.Controls.Add(this.pcdbCsvCreatedOnColumnTextBox);
            this.groupBox3.Controls.Add(this.pcdbCsvInstallStatusColumnTextBox);
            this.groupBox3.Controls.Add(this.pcdbCsvCreatedOnColumnLabel);
            this.groupBox3.Controls.Add(this.pcdbCsvInstallStatusValueLabel);
            this.groupBox3.Controls.Add(this.pcdbCsvInstallStatusValueTextBox);
            this.groupBox3.Controls.Add(this.pcdbCsvServiceNameColumnLabel);
            this.groupBox3.Controls.Add(this.pcdbCsvNameColumnTextBox);
            this.groupBox3.Controls.Add(this.pcdbCsvServiceNameColumnTextBox);
            this.groupBox3.Controls.Add(this.pcdbCsvCreatedOnDateFormatLabel);
            this.groupBox3.Controls.Add(this.pcdbCsvServiceInstanceColumnLabel);
            this.groupBox3.Controls.Add(this.pcdbCsvServiceInstanceColumnTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(731, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 347);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Public Cloud Instances CIs CSV Customization";
            // 
            // pcdbCsvCreatedOnDateFormatTextBox
            // 
            this.pcdbCsvCreatedOnDateFormatTextBox.Location = new System.Drawing.Point(174, 196);
            this.pcdbCsvCreatedOnDateFormatTextBox.Name = "pcdbCsvCreatedOnDateFormatTextBox";
            this.pcdbCsvCreatedOnDateFormatTextBox.Size = new System.Drawing.Size(172, 23);
            this.pcdbCsvCreatedOnDateFormatTextBox.TabIndex = 31;
            // 
            // pcdbCsvNameColumnLabel
            // 
            this.pcdbCsvNameColumnLabel.AutoSize = true;
            this.pcdbCsvNameColumnLabel.Location = new System.Drawing.Point(81, 141);
            this.pcdbCsvNameColumnLabel.Name = "pcdbCsvNameColumnLabel";
            this.pcdbCsvNameColumnLabel.Size = new System.Drawing.Size(85, 15);
            this.pcdbCsvNameColumnLabel.TabIndex = 30;
            this.pcdbCsvNameColumnLabel.Text = "Name Column";
            // 
            // pcdbCsvInstallStatusColumnLabel
            // 
            this.pcdbCsvInstallStatusColumnLabel.AutoSize = true;
            this.pcdbCsvInstallStatusColumnLabel.Location = new System.Drawing.Point(47, 25);
            this.pcdbCsvInstallStatusColumnLabel.Name = "pcdbCsvInstallStatusColumnLabel";
            this.pcdbCsvInstallStatusColumnLabel.Size = new System.Drawing.Size(119, 15);
            this.pcdbCsvInstallStatusColumnLabel.TabIndex = 16;
            this.pcdbCsvInstallStatusColumnLabel.Text = "Install Status Column";
            // 
            // pcdbCsvCreatedOnColumnTextBox
            // 
            this.pcdbCsvCreatedOnColumnTextBox.Location = new System.Drawing.Point(174, 167);
            this.pcdbCsvCreatedOnColumnTextBox.Name = "pcdbCsvCreatedOnColumnTextBox";
            this.pcdbCsvCreatedOnColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.pcdbCsvCreatedOnColumnTextBox.TabIndex = 29;
            // 
            // pcdbCsvInstallStatusColumnTextBox
            // 
            this.pcdbCsvInstallStatusColumnTextBox.Location = new System.Drawing.Point(172, 22);
            this.pcdbCsvInstallStatusColumnTextBox.Name = "pcdbCsvInstallStatusColumnTextBox";
            this.pcdbCsvInstallStatusColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.pcdbCsvInstallStatusColumnTextBox.TabIndex = 17;
            // 
            // pcdbCsvCreatedOnColumnLabel
            // 
            this.pcdbCsvCreatedOnColumnLabel.AutoSize = true;
            this.pcdbCsvCreatedOnColumnLabel.Location = new System.Drawing.Point(55, 170);
            this.pcdbCsvCreatedOnColumnLabel.Name = "pcdbCsvCreatedOnColumnLabel";
            this.pcdbCsvCreatedOnColumnLabel.Size = new System.Drawing.Size(113, 15);
            this.pcdbCsvCreatedOnColumnLabel.TabIndex = 28;
            this.pcdbCsvCreatedOnColumnLabel.Text = "Created On Column";
            // 
            // pcdbCsvInstallStatusValueLabel
            // 
            this.pcdbCsvInstallStatusValueLabel.AutoSize = true;
            this.pcdbCsvInstallStatusValueLabel.Location = new System.Drawing.Point(62, 54);
            this.pcdbCsvInstallStatusValueLabel.Name = "pcdbCsvInstallStatusValueLabel";
            this.pcdbCsvInstallStatusValueLabel.Size = new System.Drawing.Size(104, 15);
            this.pcdbCsvInstallStatusValueLabel.TabIndex = 18;
            this.pcdbCsvInstallStatusValueLabel.Text = "Install Status Value";
            // 
            // pcdbCsvInstallStatusValueTextBox
            // 
            this.pcdbCsvInstallStatusValueTextBox.Location = new System.Drawing.Point(172, 51);
            this.pcdbCsvInstallStatusValueTextBox.Name = "pcdbCsvInstallStatusValueTextBox";
            this.pcdbCsvInstallStatusValueTextBox.Size = new System.Drawing.Size(172, 23);
            this.pcdbCsvInstallStatusValueTextBox.TabIndex = 19;
            // 
            // pcdbCsvServiceNameColumnLabel
            // 
            this.pcdbCsvServiceNameColumnLabel.AutoSize = true;
            this.pcdbCsvServiceNameColumnLabel.Location = new System.Drawing.Point(41, 83);
            this.pcdbCsvServiceNameColumnLabel.Name = "pcdbCsvServiceNameColumnLabel";
            this.pcdbCsvServiceNameColumnLabel.Size = new System.Drawing.Size(125, 15);
            this.pcdbCsvServiceNameColumnLabel.TabIndex = 20;
            this.pcdbCsvServiceNameColumnLabel.Text = "Service Name Column";
            // 
            // pcdbCsvNameColumnTextBox
            // 
            this.pcdbCsvNameColumnTextBox.Location = new System.Drawing.Point(172, 138);
            this.pcdbCsvNameColumnTextBox.Name = "pcdbCsvNameColumnTextBox";
            this.pcdbCsvNameColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.pcdbCsvNameColumnTextBox.TabIndex = 25;
            // 
            // pcdbCsvServiceNameColumnTextBox
            // 
            this.pcdbCsvServiceNameColumnTextBox.Location = new System.Drawing.Point(172, 80);
            this.pcdbCsvServiceNameColumnTextBox.Name = "pcdbCsvServiceNameColumnTextBox";
            this.pcdbCsvServiceNameColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.pcdbCsvServiceNameColumnTextBox.TabIndex = 21;
            // 
            // pcdbCsvCreatedOnDateFormatLabel
            // 
            this.pcdbCsvCreatedOnDateFormatLabel.AutoSize = true;
            this.pcdbCsvCreatedOnDateFormatLabel.Location = new System.Drawing.Point(33, 199);
            this.pcdbCsvCreatedOnDateFormatLabel.Name = "pcdbCsvCreatedOnDateFormatLabel";
            this.pcdbCsvCreatedOnDateFormatLabel.Size = new System.Drawing.Size(135, 15);
            this.pcdbCsvCreatedOnDateFormatLabel.TabIndex = 24;
            this.pcdbCsvCreatedOnDateFormatLabel.Text = "Created On Date Format";
            // 
            // pcdbCsvServiceInstanceColumnLabel
            // 
            this.pcdbCsvServiceInstanceColumnLabel.AutoSize = true;
            this.pcdbCsvServiceInstanceColumnLabel.Location = new System.Drawing.Point(29, 112);
            this.pcdbCsvServiceInstanceColumnLabel.Name = "pcdbCsvServiceInstanceColumnLabel";
            this.pcdbCsvServiceInstanceColumnLabel.Size = new System.Drawing.Size(137, 15);
            this.pcdbCsvServiceInstanceColumnLabel.TabIndex = 22;
            this.pcdbCsvServiceInstanceColumnLabel.Text = "Service Instance Column";
            // 
            // pcdbCsvServiceInstanceColumnTextBox
            // 
            this.pcdbCsvServiceInstanceColumnTextBox.Location = new System.Drawing.Point(172, 109);
            this.pcdbCsvServiceInstanceColumnTextBox.Name = "pcdbCsvServiceInstanceColumnTextBox";
            this.pcdbCsvServiceInstanceColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.pcdbCsvServiceInstanceColumnTextBox.TabIndex = 23;
            // 
            // windowsCsvCustomizationsGroupBox
            // 
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvNameColumnLabel);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.createdOnDateFormatTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvNameColumnTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvCpuCountColumnLabel);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.CreatedOnColumnTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.CreatedOnColumnLabel);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvCpuCoreCountColumnTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvCpuCoreCountColumnLabel);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvCpuCountColumnTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.createdOnDateFormatLabel);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvServiceInstanceColumnTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvServiceInstanceColumnLabel);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvServiceNameColumnTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvServiceNameColumnLabel);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvInstallStatusValueTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvInstallStatusValueLabel);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvInstallStatusColumnNameTextBox);
            this.windowsCsvCustomizationsGroupBox.Controls.Add(this.winCsvInstallStatusColumnNameLabel);
            this.windowsCsvCustomizationsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsCsvCustomizationsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.windowsCsvCustomizationsGroupBox.Name = "windowsCsvCustomizationsGroupBox";
            this.windowsCsvCustomizationsGroupBox.Size = new System.Drawing.Size(344, 347);
            this.windowsCsvCustomizationsGroupBox.TabIndex = 0;
            this.windowsCsvCustomizationsGroupBox.TabStop = false;
            this.windowsCsvCustomizationsGroupBox.Text = "Windows CIs CSV Customizations";
            // 
            // winCsvNameColumnLabel
            // 
            this.winCsvNameColumnLabel.AutoSize = true;
            this.winCsvNameColumnLabel.Location = new System.Drawing.Point(75, 193);
            this.winCsvNameColumnLabel.Name = "winCsvNameColumnLabel";
            this.winCsvNameColumnLabel.Size = new System.Drawing.Size(85, 15);
            this.winCsvNameColumnLabel.TabIndex = 33;
            this.winCsvNameColumnLabel.Text = "Name Column";
            // 
            // createdOnDateFormatTextBox
            // 
            this.createdOnDateFormatTextBox.Location = new System.Drawing.Point(166, 248);
            this.createdOnDateFormatTextBox.Name = "createdOnDateFormatTextBox";
            this.createdOnDateFormatTextBox.Size = new System.Drawing.Size(172, 23);
            this.createdOnDateFormatTextBox.TabIndex = 15;
            // 
            // winCsvNameColumnTextBox
            // 
            this.winCsvNameColumnTextBox.Location = new System.Drawing.Point(166, 190);
            this.winCsvNameColumnTextBox.Name = "winCsvNameColumnTextBox";
            this.winCsvNameColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.winCsvNameColumnTextBox.TabIndex = 32;
            // 
            // winCsvCpuCountColumnLabel
            // 
            this.winCsvCpuCountColumnLabel.AutoSize = true;
            this.winCsvCpuCountColumnLabel.Location = new System.Drawing.Point(48, 135);
            this.winCsvCpuCountColumnLabel.Name = "winCsvCpuCountColumnLabel";
            this.winCsvCpuCountColumnLabel.Size = new System.Drawing.Size(112, 15);
            this.winCsvCpuCountColumnLabel.TabIndex = 14;
            this.winCsvCpuCountColumnLabel.Text = "CPU Count Column";
            // 
            // CreatedOnColumnTextBox
            // 
            this.CreatedOnColumnTextBox.Location = new System.Drawing.Point(166, 219);
            this.CreatedOnColumnTextBox.Name = "CreatedOnColumnTextBox";
            this.CreatedOnColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.CreatedOnColumnTextBox.TabIndex = 13;
            // 
            // CreatedOnColumnLabel
            // 
            this.CreatedOnColumnLabel.AutoSize = true;
            this.CreatedOnColumnLabel.Location = new System.Drawing.Point(47, 222);
            this.CreatedOnColumnLabel.Name = "CreatedOnColumnLabel";
            this.CreatedOnColumnLabel.Size = new System.Drawing.Size(113, 15);
            this.CreatedOnColumnLabel.TabIndex = 12;
            this.CreatedOnColumnLabel.Text = "Created On Column";
            // 
            // winCsvCpuCoreCountColumnTextBox
            // 
            this.winCsvCpuCoreCountColumnTextBox.Location = new System.Drawing.Point(166, 161);
            this.winCsvCpuCoreCountColumnTextBox.Name = "winCsvCpuCoreCountColumnTextBox";
            this.winCsvCpuCoreCountColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.winCsvCpuCoreCountColumnTextBox.TabIndex = 11;
            // 
            // winCsvCpuCoreCountColumnLabel
            // 
            this.winCsvCpuCoreCountColumnLabel.AutoSize = true;
            this.winCsvCpuCoreCountColumnLabel.Location = new System.Drawing.Point(20, 164);
            this.winCsvCpuCoreCountColumnLabel.Name = "winCsvCpuCoreCountColumnLabel";
            this.winCsvCpuCoreCountColumnLabel.Size = new System.Drawing.Size(140, 15);
            this.winCsvCpuCoreCountColumnLabel.TabIndex = 10;
            this.winCsvCpuCoreCountColumnLabel.Text = "CPU Core Count Column";
            // 
            // winCsvCpuCountColumnTextBox
            // 
            this.winCsvCpuCountColumnTextBox.Location = new System.Drawing.Point(166, 132);
            this.winCsvCpuCountColumnTextBox.Name = "winCsvCpuCountColumnTextBox";
            this.winCsvCpuCountColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.winCsvCpuCountColumnTextBox.TabIndex = 9;
            // 
            // createdOnDateFormatLabel
            // 
            this.createdOnDateFormatLabel.AutoSize = true;
            this.createdOnDateFormatLabel.Location = new System.Drawing.Point(25, 251);
            this.createdOnDateFormatLabel.Name = "createdOnDateFormatLabel";
            this.createdOnDateFormatLabel.Size = new System.Drawing.Size(135, 15);
            this.createdOnDateFormatLabel.TabIndex = 8;
            this.createdOnDateFormatLabel.Text = "Created On Date Format";
            // 
            // winCsvServiceInstanceColumnTextBox
            // 
            this.winCsvServiceInstanceColumnTextBox.Location = new System.Drawing.Point(166, 103);
            this.winCsvServiceInstanceColumnTextBox.Name = "winCsvServiceInstanceColumnTextBox";
            this.winCsvServiceInstanceColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.winCsvServiceInstanceColumnTextBox.TabIndex = 7;
            // 
            // winCsvServiceInstanceColumnLabel
            // 
            this.winCsvServiceInstanceColumnLabel.AutoSize = true;
            this.winCsvServiceInstanceColumnLabel.Location = new System.Drawing.Point(23, 106);
            this.winCsvServiceInstanceColumnLabel.Name = "winCsvServiceInstanceColumnLabel";
            this.winCsvServiceInstanceColumnLabel.Size = new System.Drawing.Size(137, 15);
            this.winCsvServiceInstanceColumnLabel.TabIndex = 6;
            this.winCsvServiceInstanceColumnLabel.Text = "Service Instance Column";
            // 
            // winCsvServiceNameColumnTextBox
            // 
            this.winCsvServiceNameColumnTextBox.Location = new System.Drawing.Point(166, 74);
            this.winCsvServiceNameColumnTextBox.Name = "winCsvServiceNameColumnTextBox";
            this.winCsvServiceNameColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.winCsvServiceNameColumnTextBox.TabIndex = 5;
            // 
            // winCsvServiceNameColumnLabel
            // 
            this.winCsvServiceNameColumnLabel.AutoSize = true;
            this.winCsvServiceNameColumnLabel.Location = new System.Drawing.Point(35, 77);
            this.winCsvServiceNameColumnLabel.Name = "winCsvServiceNameColumnLabel";
            this.winCsvServiceNameColumnLabel.Size = new System.Drawing.Size(125, 15);
            this.winCsvServiceNameColumnLabel.TabIndex = 4;
            this.winCsvServiceNameColumnLabel.Text = "Service Name Column";
            // 
            // winCsvInstallStatusValueTextBox
            // 
            this.winCsvInstallStatusValueTextBox.Location = new System.Drawing.Point(166, 45);
            this.winCsvInstallStatusValueTextBox.Name = "winCsvInstallStatusValueTextBox";
            this.winCsvInstallStatusValueTextBox.Size = new System.Drawing.Size(172, 23);
            this.winCsvInstallStatusValueTextBox.TabIndex = 3;
            // 
            // winCsvInstallStatusValueLabel
            // 
            this.winCsvInstallStatusValueLabel.AutoSize = true;
            this.winCsvInstallStatusValueLabel.Location = new System.Drawing.Point(56, 48);
            this.winCsvInstallStatusValueLabel.Name = "winCsvInstallStatusValueLabel";
            this.winCsvInstallStatusValueLabel.Size = new System.Drawing.Size(104, 15);
            this.winCsvInstallStatusValueLabel.TabIndex = 2;
            this.winCsvInstallStatusValueLabel.Text = "Install Status Value";
            // 
            // winCsvInstallStatusColumnNameTextBox
            // 
            this.winCsvInstallStatusColumnNameTextBox.Location = new System.Drawing.Point(166, 16);
            this.winCsvInstallStatusColumnNameTextBox.Name = "winCsvInstallStatusColumnNameTextBox";
            this.winCsvInstallStatusColumnNameTextBox.Size = new System.Drawing.Size(172, 23);
            this.winCsvInstallStatusColumnNameTextBox.TabIndex = 1;
            // 
            // winCsvInstallStatusColumnNameLabel
            // 
            this.winCsvInstallStatusColumnNameLabel.AutoSize = true;
            this.winCsvInstallStatusColumnNameLabel.Location = new System.Drawing.Point(41, 19);
            this.winCsvInstallStatusColumnNameLabel.Name = "winCsvInstallStatusColumnNameLabel";
            this.winCsvInstallStatusColumnNameLabel.Size = new System.Drawing.Size(119, 15);
            this.winCsvInstallStatusColumnNameLabel.TabIndex = 0;
            this.winCsvInstallStatusColumnNameLabel.Text = "Install Status Column";
            // 
            // sqlInstanceCsvNameColumnTextBox
            // 
            this.sqlInstanceCsvNameColumnTextBox.Location = new System.Drawing.Point(194, 253);
            this.sqlInstanceCsvNameColumnTextBox.Name = "sqlInstanceCsvNameColumnTextBox";
            this.sqlInstanceCsvNameColumnTextBox.Size = new System.Drawing.Size(172, 23);
            this.sqlInstanceCsvNameColumnTextBox.TabIndex = 37;
            // 
            // sqlInstanceCsvNameColumnLabel
            // 
            this.sqlInstanceCsvNameColumnLabel.AutoSize = true;
            this.sqlInstanceCsvNameColumnLabel.Location = new System.Drawing.Point(103, 256);
            this.sqlInstanceCsvNameColumnLabel.Name = "sqlInstanceCsvNameColumnLabel";
            this.sqlInstanceCsvNameColumnLabel.Size = new System.Drawing.Size(85, 15);
            this.sqlInstanceCsvNameColumnLabel.TabIndex = 36;
            this.sqlInstanceCsvNameColumnLabel.Text = "Name Column";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 573);
            this.Controls.Add(this.reportCustomizationTabControl);
            this.Controls.Add(this.cmdbGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "B-Report Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.cmdbGroupBox.ResumeLayout(false);
            this.cmdbGroupBox.PerformLayout();
            this.reportCustomizationsGroupBox.ResumeLayout(false);
            this.reportCustomizationsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aagDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            this.reportCustomizationTabControl.ResumeLayout(false);
            this.dataCustomizationTabPage.ResumeLayout(false);
            this.formatCustomizationTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.windowsCsvCustomizationsGroupBox.ResumeLayout(false);
            this.windowsCsvCustomizationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox cmdbGroupBox;
        private Label publicCloudInstancesCsvPathLabel;
        private Label sqlInstancesCiCsvPathLabel;
        private Label windowsCiCsvPathLabel;
        private Button generateCsvReportButton;
        private Button outputCsvReportFileButton;
        private TextBox outputCsvReportFileTextBox;
        private Label outputCsvReportPathLabel;
        private Button publicCloudInstancesCiCsvPathButton;
        private Button sqlInstancesCiCsvPathButton;
        private Button windowsCiCsvPathButton;
        private TextBox publicCloudInstancesCiCsvPathTextBox;
        private TextBox sqlInstancesCiCsvPathTextBox;
        private TextBox windowsCiCsvPathTextBox;
        private ProgressBar mainProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Label progressLabel;
        private GroupBox reportCustomizationsGroupBox;
        private ListBox teamVMsListBox;
        private Label testVmList;
        private Button addTeamVmButton;
        private TextBox teamVmTextBox;
        private Button deleteTeamVmButton;
        private DataGridView materialsDataGridView;
        private Label aagLabel;
        private Label materialsLabel;
        private DataGridView aagDataGridView;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ActiveNode;
        private DataGridViewTextBoxColumn PassiveNodes;
        private TextBox reportDateTextBox;
        private Label reportDateLabel;
        private CheckBox openCsvFileCheckBox;
        private ToolTip windowsCiToolTip;
        private TextBox reportMonthTextBox;
        private Label reportMonthLabel;
        private TextBox reportYearTextBox;
        private Label reportYearLabel;
        private TabControl reportCustomizationTabControl;
        private TabPage dataCustomizationTabPage;
        private TabPage formatCustomizationTabPage;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox windowsCsvCustomizationsGroupBox;
        private Label winCsvInstallStatusColumnNameLabel;
        private TextBox winCsvInstallStatusColumnNameTextBox;
        private TextBox winCsvInstallStatusValueTextBox;
        private Label winCsvInstallStatusValueLabel;
        private Label winCsvServiceNameColumnLabel;
        private TextBox winCsvServiceNameColumnTextBox;
        private TextBox winCsvServiceInstanceColumnTextBox;
        private Label winCsvServiceInstanceColumnLabel;
        private TextBox CreatedOnColumnTextBox;
        private Label CreatedOnColumnLabel;
        private TextBox winCsvCpuCoreCountColumnTextBox;
        private Label winCsvCpuCoreCountColumnLabel;
        private TextBox winCsvCpuCountColumnTextBox;
        private Label createdOnDateFormatLabel;
        private TextBox createdOnDateFormatTextBox;
        private Label winCsvCpuCountColumnLabel;
        private TextBox sqlInstanceCsvCreatedOnFormatTextBox;
        private Label sqlInstanceCsvEditionColumnLabel;
        private Label sqlInstanceCsvInstallStatusColumnLabel;
        private TextBox sqlInstanceCsvCreatedOnColumnTextBox;
        private TextBox sqlInstanceCsvInstallStatusColumnTextBox;
        private Label sqlInstanceCsvCreatedOnColumnLabel;
        private Label sqlInstanceCsvInstallStatusValueLabel;
        private TextBox sqlInstanceCsvVersionColumnTextBox;
        private TextBox sqlInstanceCsvInstallStatusValueTextBox;
        private Label sqlInstanceCsvVersionColumnLabel;
        private Label sqlInstanceCsvServiceNameColumnLabel;
        private TextBox sqlInstanceCsvEditionColumnTextBox;
        private TextBox sqlInstanceCsvServiceNameColumnTextBox;
        private Label sqlInstanceCsvCreatedOnFormatLabel;
        private Label sqlInstanceCsvRecoveryServerColumnLabel;
        private TextBox sqlInstanceCsvRecoveryServerColumnTextBox;
        private Label sqlInstanceCsvInstanceNameColumnLabel;
        private TextBox sqlInstanceCsvServerNameColumnTextBox;
        private Label sqlInstanceCsvServerNameColumnLabel;
        private TextBox sqlInstanceCsvInstanceNameColumnTextBox;
        private TextBox pcdbCsvCreatedOnDateFormatTextBox;
        private Label pcdbCsvNameColumnLabel;
        private Label pcdbCsvInstallStatusColumnLabel;
        private TextBox pcdbCsvCreatedOnColumnTextBox;
        private TextBox pcdbCsvInstallStatusColumnTextBox;
        private Label pcdbCsvCreatedOnColumnLabel;
        private Label pcdbCsvInstallStatusValueLabel;
        private TextBox pcdbCsvInstallStatusValueTextBox;
        private Label pcdbCsvServiceNameColumnLabel;
        private TextBox pcdbCsvNameColumnTextBox;
        private TextBox pcdbCsvServiceNameColumnTextBox;
        private Label pcdbCsvCreatedOnDateFormatLabel;
        private Label pcdbCsvServiceInstanceColumnLabel;
        private TextBox pcdbCsvServiceInstanceColumnTextBox;
        private Label winCsvNameColumnLabel;
        private TextBox winCsvNameColumnTextBox;
        private TextBox sqlInstanceCsvNameColumnTextBox;
        private Label sqlInstanceCsvNameColumnLabel;
    }
}