using System.Diagnostics;

namespace B_reportGenerator
{
    public partial class MainForm : Form
    {
        private Config config = new Config();

        public MainForm()
        {
            InitializeComponent();
            loadDefaults();
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            config.saveConfig();
        }

        private void loadDefaults()
        {
#if DEBUG
            this.windowsCiCsvPathTextBox.Text = "C:\\Users\\k.ryakhovskiy\\Downloads\\b-report\\cmdb_ci_win_server.csv";
            this.sqlInstancesCiCsvPathTextBox.Text = "C:\\Users\\k.ryakhovskiy\\Downloads\\b-report\\cmdb_ci_db_mssql_instance.csv";
            this.publicCloudInstancesCiCsvPathTextBox.Text = "C:\\Users\\k.ryakhovskiy\\Downloads\\b-report\\cmdb_ci_cloud_database.csv";
            this.outputCsvReportFileTextBox.Text = 
                String.Format("C:\\Users\\k.ryakhovskiy\\Downloads\\b-report\\billingdata_hostname-{0}.csv", DateTime.Now.ToString("yyyyMM"));
#endif
            config.GetTeamVms().ForEach(vm => this.teamVMsListBox.Items.Add(vm));
            config.GetMaterials().ToList().ForEach(m => this.materialsDataGridView.Rows.Add(m.MaterialNumber, m.Description));
            config.GetAag().ToList().ForEach(i => this.aagDataGridView.Rows.Add(i.Key, string.Join(';', i.Value)));
            setCurrentReportDate();
        }

        private void setCurrentReportDate()
        {
            var date = DateTime.Now;
            var year = date.ToString("yyyy");
            var month = date.ToString("MM");
            this.reportYearTextBox.Text = year;
            this.reportMonthTextBox.Text = month;
            setReportDate(year, month);
        }

        private void setReportDate()
        {
            var year = this.reportYearTextBox.Text;
            var month = this.reportMonthTextBox.Text;
            setReportDate(year, month);
        }

        private void setReportDate(string year, string month)
        {
            string reportDateTag = String.Format("{0}{1}15", year, month);
            this.reportDateTextBox.Text = reportDateTag;
        }

        private void windowsCiCsvPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"; ;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                windowsCiCsvPathTextBox.Text = ofd.FileName;
            }
        }

        private void sqlInstancesCiCsvPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"; ;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sqlInstancesCiCsvPathTextBox.Text = ofd.FileName;
            }
        }

        private void publicCloudInstancesCiCsvPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"; ;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                publicCloudInstancesCiCsvPathTextBox.Text = ofd.FileName;
            }
        }

        private void outputCsvReportFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"; ;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                outputCsvReportFileTextBox.Text = sfd.FileName;
            }
        }

        private void generateCsvReportButton_Click(object sender, EventArgs e)
        {
            toggleProgressElements(false);
            mainProgressBar.Style = ProgressBarStyle.Marquee;

            string windowsCiFile = windowsCiCsvPathTextBox.Text;
            string sqlCiFile = sqlInstancesCiCsvPathTextBox.Text;
            string publicDbCiFile = publicCloudInstancesCiCsvPathTextBox.Text;
            string outputFile = outputCsvReportFileTextBox.Text;
            string date = reportDateTextBox.Text;
            ReportBackgroundWorker worker = new ReportBackgroundWorker(backgroundWorker, 
                windowsCiFile, sqlCiFile, publicDbCiFile, 
                outputFile, date);
            backgroundWorker.RunWorkerAsync(worker);
        }

        private void toggleProgressElements(bool enabled)
        {
            this.Enabled = enabled;
            progressLabel.Visible = !enabled;
            mainProgressBar.Visible = !enabled;
        }

        private void loadCiCsvBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (null == e) return;
            var worker = e.Argument as ReportBackgroundWorker;
            if (null == worker) return;
            worker.run();
        }

        private void loadCiCsvBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 0)
                mainProgressBar.Value = e.ProgressPercentage;
            if (null == e.UserState) return;
            progressLabel.Text = e.UserState.ToString();
        }

        private void loadCiCsvBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            toggleProgressElements(true);
            if (null != e.Error)
            {
                MessageBox.Show(String.Format("Processing error: {0}.\n{1}", e.Error.Message, e.Error.ToString()), 
                    "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (openCsvFileCheckBox.Checked)
                Process.Start("notepad.exe", outputCsvReportFileTextBox.Text);
        }

        private void addTeamVmButton_Click(object sender, EventArgs e)
        {
            string vm = teamVmTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(vm)) return;
            if (teamVMsListBox.Items.Contains(vm)) return;
            teamVMsListBox.Items.Add(vm);
            config.AddTeamVm(vm);
            teamVmTextBox.Text = "";
        }

        private void deleteTeamVmButton_Click(object sender, EventArgs e)
        {
            if (teamVMsListBox.Items.Count == 0) return;
            if (teamVMsListBox.SelectedIndex < 0) return;
            teamVMsListBox.Items.RemoveAt(teamVMsListBox.SelectedIndex);
        }

        private void materialsDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void materialsDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void aagDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            var active = e.Row.Cells["ActiveNode"].Value;
            if (null == active) return;
            config.DeleteAagItem(active.ToString());
        }

        private void aagDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            DataGridViewRow row = aagDataGridView.Rows[index];
            if (null == row) return;
            var obj = row.Cells["ActiveNode"].Value;
            if (null == obj)
            {
                obj = row.Cells["ActiveNode"].EditedFormattedValue;
                if (null == obj) return;
            }
            string active = obj.ToString();

            obj = row.Cells["PassiveNodes"].Value;
            if (null == obj)
            {
                obj = row.Cells["PassiveNodes"].EditedFormattedValue;
                if (null == obj) return;
            }
            string passive = obj.ToString();
            if (string.IsNullOrEmpty(active) || string.IsNullOrEmpty(passive)) return;
            this.config.AddAagItem(active, passive);
        }

        private void reportYearTextBox_Leave(object sender, EventArgs e)
        {
            setReportDate();
        }

        private void reportMonthTextBox_Leave(object sender, EventArgs e)
        {
            setReportDate();
        }
    }
}