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
            this.cmdbGroupBox.SuspendLayout();
            this.reportCustomizationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aagDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
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
            this.cmdbGroupBox.Location = new System.Drawing.Point(12, 12);
            this.cmdbGroupBox.Name = "cmdbGroupBox";
            this.cmdbGroupBox.Size = new System.Drawing.Size(1248, 222);
            this.cmdbGroupBox.TabIndex = 0;
            this.cmdbGroupBox.TabStop = false;
            this.cmdbGroupBox.Text = "CMDB";
            // 
            // reportMonthTextBox
            // 
            this.reportMonthTextBox.Location = new System.Drawing.Point(856, 152);
            this.reportMonthTextBox.Name = "reportMonthTextBox";
            this.reportMonthTextBox.Size = new System.Drawing.Size(49, 27);
            this.reportMonthTextBox.TabIndex = 105;
            this.reportMonthTextBox.Leave += new System.EventHandler(this.reportMonthTextBox_Leave);
            // 
            // reportMonthLabel
            // 
            this.reportMonthLabel.AutoSize = true;
            this.reportMonthLabel.Location = new System.Drawing.Point(749, 155);
            this.reportMonthLabel.Name = "reportMonthLabel";
            this.reportMonthLabel.Size = new System.Drawing.Size(101, 20);
            this.reportMonthLabel.TabIndex = 104;
            this.reportMonthLabel.Text = "Report Month";
            // 
            // reportYearTextBox
            // 
            this.reportYearTextBox.Location = new System.Drawing.Point(662, 152);
            this.reportYearTextBox.Name = "reportYearTextBox";
            this.reportYearTextBox.Size = new System.Drawing.Size(74, 27);
            this.reportYearTextBox.TabIndex = 103;
            this.reportYearTextBox.Leave += new System.EventHandler(this.reportYearTextBox_Leave);
            // 
            // reportYearLabel
            // 
            this.reportYearLabel.AutoSize = true;
            this.reportYearLabel.Location = new System.Drawing.Point(570, 155);
            this.reportYearLabel.Name = "reportYearLabel";
            this.reportYearLabel.Size = new System.Drawing.Size(86, 20);
            this.reportYearLabel.TabIndex = 102;
            this.reportYearLabel.Text = "Report Year";
            // 
            // openCsvFileCheckBox
            // 
            this.openCsvFileCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openCsvFileCheckBox.AutoSize = true;
            this.openCsvFileCheckBox.Checked = true;
            this.openCsvFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openCsvFileCheckBox.Location = new System.Drawing.Point(749, 190);
            this.openCsvFileCheckBox.Name = "openCsvFileCheckBox";
            this.openCsvFileCheckBox.Size = new System.Drawing.Size(284, 24);
            this.openCsvFileCheckBox.TabIndex = 101;
            this.openCsvFileCheckBox.Text = "Open CSV Report File after generating";
            this.openCsvFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // reportDateTextBox
            // 
            this.reportDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportDateTextBox.Enabled = false;
            this.reportDateTextBox.Location = new System.Drawing.Point(1073, 152);
            this.reportDateTextBox.Name = "reportDateTextBox";
            this.reportDateTextBox.Size = new System.Drawing.Size(163, 27);
            this.reportDateTextBox.TabIndex = 90;
            // 
            // reportDateLabel
            // 
            this.reportDateLabel.AutoSize = true;
            this.reportDateLabel.Location = new System.Drawing.Point(950, 155);
            this.reportDateLabel.Name = "reportDateLabel";
            this.reportDateLabel.Size = new System.Drawing.Size(117, 20);
            this.reportDateLabel.TabIndex = 15;
            this.reportDateLabel.Text = "Report Date Tag";
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLabel.Location = new System.Drawing.Point(12, 161);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(66, 20);
            this.progressLabel.TabIndex = 14;
            this.progressLabel.Text = "progress";
            this.progressLabel.Visible = false;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressBar.Location = new System.Drawing.Point(6, 187);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(730, 29);
            this.mainProgressBar.TabIndex = 1;
            this.mainProgressBar.Visible = false;
            // 
            // generateCsvReportButton
            // 
            this.generateCsvReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateCsvReportButton.Location = new System.Drawing.Point(1039, 187);
            this.generateCsvReportButton.Name = "generateCsvReportButton";
            this.generateCsvReportButton.Size = new System.Drawing.Size(197, 29);
            this.generateCsvReportButton.TabIndex = 100;
            this.generateCsvReportButton.Text = "Generate CSV Report";
            this.generateCsvReportButton.UseVisualStyleBackColor = true;
            this.generateCsvReportButton.Click += new System.EventHandler(this.generateCsvReportButton_Click);
            // 
            // outputCsvReportFileButton
            // 
            this.outputCsvReportFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputCsvReportFileButton.Location = new System.Drawing.Point(1200, 119);
            this.outputCsvReportFileButton.Name = "outputCsvReportFileButton";
            this.outputCsvReportFileButton.Size = new System.Drawing.Size(36, 29);
            this.outputCsvReportFileButton.TabIndex = 80;
            this.outputCsvReportFileButton.Text = "...";
            this.outputCsvReportFileButton.UseVisualStyleBackColor = true;
            this.outputCsvReportFileButton.Click += new System.EventHandler(this.outputCsvReportFileButton_Click);
            // 
            // outputCsvReportFileTextBox
            // 
            this.outputCsvReportFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputCsvReportFileTextBox.Location = new System.Drawing.Point(253, 119);
            this.outputCsvReportFileTextBox.Name = "outputCsvReportFileTextBox";
            this.outputCsvReportFileTextBox.Size = new System.Drawing.Size(941, 27);
            this.outputCsvReportFileTextBox.TabIndex = 70;
            // 
            // outputCsvReportPathLabel
            // 
            this.outputCsvReportPathLabel.AutoSize = true;
            this.outputCsvReportPathLabel.Location = new System.Drawing.Point(86, 123);
            this.outputCsvReportPathLabel.Name = "outputCsvReportPathLabel";
            this.outputCsvReportPathLabel.Size = new System.Drawing.Size(161, 20);
            this.outputCsvReportPathLabel.TabIndex = 8;
            this.outputCsvReportPathLabel.Text = "Output CSV Report File";
            // 
            // publicCloudInstancesCiCsvPathButton
            // 
            this.publicCloudInstancesCiCsvPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.publicCloudInstancesCiCsvPathButton.Location = new System.Drawing.Point(1200, 84);
            this.publicCloudInstancesCiCsvPathButton.Name = "publicCloudInstancesCiCsvPathButton";
            this.publicCloudInstancesCiCsvPathButton.Size = new System.Drawing.Size(36, 29);
            this.publicCloudInstancesCiCsvPathButton.TabIndex = 60;
            this.publicCloudInstancesCiCsvPathButton.Text = "...";
            this.publicCloudInstancesCiCsvPathButton.UseVisualStyleBackColor = true;
            this.publicCloudInstancesCiCsvPathButton.Click += new System.EventHandler(this.publicCloudInstancesCiCsvPathButton_Click);
            // 
            // sqlInstancesCiCsvPathButton
            // 
            this.sqlInstancesCiCsvPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlInstancesCiCsvPathButton.Location = new System.Drawing.Point(1200, 52);
            this.sqlInstancesCiCsvPathButton.Name = "sqlInstancesCiCsvPathButton";
            this.sqlInstancesCiCsvPathButton.Size = new System.Drawing.Size(36, 29);
            this.sqlInstancesCiCsvPathButton.TabIndex = 40;
            this.sqlInstancesCiCsvPathButton.Text = "...";
            this.sqlInstancesCiCsvPathButton.UseVisualStyleBackColor = true;
            this.sqlInstancesCiCsvPathButton.Click += new System.EventHandler(this.sqlInstancesCiCsvPathButton_Click);
            // 
            // windowsCiCsvPathButton
            // 
            this.windowsCiCsvPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsCiCsvPathButton.Location = new System.Drawing.Point(1200, 19);
            this.windowsCiCsvPathButton.Name = "windowsCiCsvPathButton";
            this.windowsCiCsvPathButton.Size = new System.Drawing.Size(36, 29);
            this.windowsCiCsvPathButton.TabIndex = 20;
            this.windowsCiCsvPathButton.Text = "...";
            this.windowsCiCsvPathButton.UseVisualStyleBackColor = true;
            this.windowsCiCsvPathButton.Click += new System.EventHandler(this.windowsCiCsvPathButton_Click);
            // 
            // publicCloudInstancesCiCsvPathTextBox
            // 
            this.publicCloudInstancesCiCsvPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicCloudInstancesCiCsvPathTextBox.Location = new System.Drawing.Point(253, 86);
            this.publicCloudInstancesCiCsvPathTextBox.Name = "publicCloudInstancesCiCsvPathTextBox";
            this.publicCloudInstancesCiCsvPathTextBox.Size = new System.Drawing.Size(941, 27);
            this.publicCloudInstancesCiCsvPathTextBox.TabIndex = 50;
            // 
            // sqlInstancesCiCsvPathTextBox
            // 
            this.sqlInstancesCiCsvPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlInstancesCiCsvPathTextBox.Location = new System.Drawing.Point(253, 53);
            this.sqlInstancesCiCsvPathTextBox.Name = "sqlInstancesCiCsvPathTextBox";
            this.sqlInstancesCiCsvPathTextBox.Size = new System.Drawing.Size(941, 27);
            this.sqlInstancesCiCsvPathTextBox.TabIndex = 30;
            // 
            // windowsCiCsvPathTextBox
            // 
            this.windowsCiCsvPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsCiCsvPathTextBox.Location = new System.Drawing.Point(253, 20);
            this.windowsCiCsvPathTextBox.Name = "windowsCiCsvPathTextBox";
            this.windowsCiCsvPathTextBox.Size = new System.Drawing.Size(941, 27);
            this.windowsCiCsvPathTextBox.TabIndex = 10;
            // 
            // publicCloudInstancesCsvPathLabel
            // 
            this.publicCloudInstancesCsvPathLabel.AutoSize = true;
            this.publicCloudInstancesCsvPathLabel.Location = new System.Drawing.Point(6, 89);
            this.publicCloudInstancesCsvPathLabel.Name = "publicCloudInstancesCsvPathLabel";
            this.publicCloudInstancesCsvPathLabel.Size = new System.Drawing.Size(241, 20);
            this.publicCloudInstancesCsvPathLabel.TabIndex = 2;
            this.publicCloudInstancesCsvPathLabel.Text = "Public Cloud instances CIs CSV Path";
            // 
            // sqlInstancesCiCsvPathLabel
            // 
            this.sqlInstancesCiCsvPathLabel.AutoSize = true;
            this.sqlInstancesCiCsvPathLabel.Location = new System.Drawing.Point(63, 56);
            this.sqlInstancesCiCsvPathLabel.Name = "sqlInstancesCiCsvPathLabel";
            this.sqlInstancesCiCsvPathLabel.Size = new System.Drawing.Size(184, 20);
            this.sqlInstancesCiCsvPathLabel.TabIndex = 1;
            this.sqlInstancesCiCsvPathLabel.Text = "SQL Instances CIs CSV Path";
            // 
            // windowsCiCsvPathLabel
            // 
            this.windowsCiCsvPathLabel.AutoSize = true;
            this.windowsCiCsvPathLabel.Location = new System.Drawing.Point(92, 23);
            this.windowsCiCsvPathLabel.Name = "windowsCiCsvPathLabel";
            this.windowsCiCsvPathLabel.Size = new System.Drawing.Size(155, 20);
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
            this.reportCustomizationsGroupBox.Location = new System.Drawing.Point(12, 240);
            this.reportCustomizationsGroupBox.Name = "reportCustomizationsGroupBox";
            this.reportCustomizationsGroupBox.Size = new System.Drawing.Size(1248, 439);
            this.reportCustomizationsGroupBox.TabIndex = 1;
            this.reportCustomizationsGroupBox.TabStop = false;
            this.reportCustomizationsGroupBox.Text = "Report Customizations";
            // 
            // aagLabel
            // 
            this.aagLabel.AutoSize = true;
            this.aagLabel.Location = new System.Drawing.Point(535, 23);
            this.aagLabel.Name = "aagLabel";
            this.aagLabel.Size = new System.Drawing.Size(149, 20);
            this.aagLabel.TabIndex = 8;
            this.aagLabel.Text = "Active-Passive Nodes";
            // 
            // materialsLabel
            // 
            this.materialsLabel.AutoSize = true;
            this.materialsLabel.Location = new System.Drawing.Point(171, 23);
            this.materialsLabel.Name = "materialsLabel";
            this.materialsLabel.Size = new System.Drawing.Size(70, 20);
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
            this.aagDataGridView.Location = new System.Drawing.Point(535, 46);
            this.aagDataGridView.Name = "aagDataGridView";
            this.aagDataGridView.RowHeadersWidth = 51;
            this.aagDataGridView.RowTemplate.Height = 29;
            this.aagDataGridView.Size = new System.Drawing.Size(701, 387);
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
            this.materialsDataGridView.Location = new System.Drawing.Point(171, 46);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowHeadersWidth = 51;
            this.materialsDataGridView.RowTemplate.Height = 29;
            this.materialsDataGridView.Size = new System.Drawing.Size(358, 387);
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
            this.deleteTeamVmButton.Location = new System.Drawing.Point(6, 82);
            this.deleteTeamVmButton.Name = "deleteTeamVmButton";
            this.deleteTeamVmButton.Size = new System.Drawing.Size(150, 29);
            this.deleteTeamVmButton.TabIndex = 130;
            this.deleteTeamVmButton.Text = "Delete";
            this.deleteTeamVmButton.UseVisualStyleBackColor = true;
            this.deleteTeamVmButton.Click += new System.EventHandler(this.deleteTeamVmButton_Click);
            // 
            // addTeamVmButton
            // 
            this.addTeamVmButton.Location = new System.Drawing.Point(109, 46);
            this.addTeamVmButton.Name = "addTeamVmButton";
            this.addTeamVmButton.Size = new System.Drawing.Size(47, 29);
            this.addTeamVmButton.TabIndex = 120;
            this.addTeamVmButton.Text = "Add";
            this.addTeamVmButton.UseVisualStyleBackColor = true;
            this.addTeamVmButton.Click += new System.EventHandler(this.addTeamVmButton_Click);
            // 
            // teamVmTextBox
            // 
            this.teamVmTextBox.Location = new System.Drawing.Point(6, 46);
            this.teamVmTextBox.Name = "teamVmTextBox";
            this.teamVmTextBox.Size = new System.Drawing.Size(97, 27);
            this.teamVmTextBox.TabIndex = 110;
            // 
            // teamVMsListBox
            // 
            this.teamVMsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.teamVMsListBox.FormattingEnabled = true;
            this.teamVMsListBox.ItemHeight = 20;
            this.teamVMsListBox.Location = new System.Drawing.Point(6, 116);
            this.teamVMsListBox.Name = "teamVMsListBox";
            this.teamVMsListBox.Size = new System.Drawing.Size(150, 304);
            this.teamVMsListBox.TabIndex = 140;
            // 
            // testVmList
            // 
            this.testVmList.AutoSize = true;
            this.testVmList.Location = new System.Drawing.Point(12, 23);
            this.testVmList.Name = "testVmList";
            this.testVmList.Size = new System.Drawing.Size(77, 20);
            this.testVmList.TabIndex = 0;
            this.testVmList.Text = "Team VMs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 691);
            this.Controls.Add(this.reportCustomizationsGroupBox);
            this.Controls.Add(this.cmdbGroupBox);
            this.Name = "MainForm";
            this.Text = "B-Report Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.cmdbGroupBox.ResumeLayout(false);
            this.cmdbGroupBox.PerformLayout();
            this.reportCustomizationsGroupBox.ResumeLayout(false);
            this.reportCustomizationsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aagDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
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
    }
}