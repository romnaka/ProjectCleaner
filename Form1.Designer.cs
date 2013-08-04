namespace ProjectCleaner
{
    partial class ProjectCleanerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectCleanerForm));
            this.ChooseProjectFolderTB = new System.Windows.Forms.TextBox();
            this.ChooseProjectFolderButton = new System.Windows.Forms.Button();
            this.ChooseProjectFoldetLabel = new System.Windows.Forms.Label();
            this.CleanProjectButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChooseProjectFolderFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ChooseProjectFolderTB
            // 
            this.ChooseProjectFolderTB.Location = new System.Drawing.Point(201, 15);
            this.ChooseProjectFolderTB.Name = "ChooseProjectFolderTB";
            this.ChooseProjectFolderTB.Size = new System.Drawing.Size(272, 20);
            this.ChooseProjectFolderTB.TabIndex = 0;
            // 
            // ChooseProjectFolderButton
            // 
            this.ChooseProjectFolderButton.Location = new System.Drawing.Point(479, 15);
            this.ChooseProjectFolderButton.Name = "ChooseProjectFolderButton";
            this.ChooseProjectFolderButton.Size = new System.Drawing.Size(27, 21);
            this.ChooseProjectFolderButton.TabIndex = 1;
            this.ChooseProjectFolderButton.Text = "...";
            this.ChooseProjectFolderButton.UseVisualStyleBackColor = true;
            this.ChooseProjectFolderButton.Click += new System.EventHandler(this.ChooseProjectFolderButton_Click);
            // 
            // ChooseProjectFoldetLabel
            // 
            this.ChooseProjectFoldetLabel.AutoSize = true;
            this.ChooseProjectFoldetLabel.Location = new System.Drawing.Point(12, 19);
            this.ChooseProjectFoldetLabel.Name = "ChooseProjectFoldetLabel";
            this.ChooseProjectFoldetLabel.Size = new System.Drawing.Size(183, 13);
            this.ChooseProjectFoldetLabel.TabIndex = 2;
            this.ChooseProjectFoldetLabel.Text = "Укажите путь к папке с проектом:";
            // 
            // CleanProjectButton
            // 
            this.CleanProjectButton.Location = new System.Drawing.Point(117, 64);
            this.CleanProjectButton.Name = "CleanProjectButton";
            this.CleanProjectButton.Size = new System.Drawing.Size(133, 23);
            this.CleanProjectButton.TabIndex = 3;
            this.CleanProjectButton.Text = "Почистить проект";
            this.CleanProjectButton.UseVisualStyleBackColor = true;
            this.CleanProjectButton.Click += new System.EventHandler(this.CleanProjectButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(274, 64);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(136, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProjectCleanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 114);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CleanProjectButton);
            this.Controls.Add(this.ChooseProjectFoldetLabel);
            this.Controls.Add(this.ChooseProjectFolderButton);
            this.Controls.Add(this.ChooseProjectFolderTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectCleanerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChooseProjectFolderTB;
        private System.Windows.Forms.Button ChooseProjectFolderButton;
        private System.Windows.Forms.Label ChooseProjectFoldetLabel;
        private System.Windows.Forms.Button CleanProjectButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FolderBrowserDialog ChooseProjectFolderFBD;
    }
}

