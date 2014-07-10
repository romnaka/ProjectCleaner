using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectCleaner
{
    /// <summary>
    /// Form class
    /// </summary>
    public partial class ProjectCleanerForm : Form
    {
        public ProjectCleanerForm()
        {
            InitializeComponent();
        }

        private void EnableComponents(bool isEnabled)
        {
            ChooseProjectFolderButton.Enabled = isEnabled;
            ChooseProjectFolderTB.Enabled = isEnabled;
            CleanProjectButton.Enabled = isEnabled;
        }

        private void ChooseProjectFolderButton_Click(object sender, EventArgs e)
        {
            if (ChooseProjectFolderFBD.ShowDialog() == DialogResult.OK)
                ChooseProjectFolderTB.Text = ChooseProjectFolderFBD.SelectedPath;
        }

        private void CleanProjectButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(ChooseProjectFolderTB.Text))
            {
                MessageBox.Show("Выберите существующую папку!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnableComponents(false);
                try
                {
                    Cleaner.Clean(ChooseProjectFolderTB.Text);
                    MessageBox.Show("Почищено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Закройте приложения, которые используют файлы проекта!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                EnableComponents(true);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
