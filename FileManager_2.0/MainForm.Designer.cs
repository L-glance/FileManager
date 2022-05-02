namespace FileManager_2._0
{

    [Serializable]
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FilePathLeft = new System.Windows.Forms.TextBox();
            this.buttonBackLeft = new System.Windows.Forms.Button();
            this.DirectoriesAndFilesRight = new System.Windows.Forms.ListBox();
            this.FilePathRight = new System.Windows.Forms.TextBox();
            this.buttonCopyFilePathRight = new System.Windows.Forms.Button();
            this.buttonBackRight = new System.Windows.Forms.Button();
            this.buttonCopyFilePathLeft = new System.Windows.Forms.Button();
            this.DirectoriesAndFilesLeft = new System.Windows.Forms.ListBox();
            this.RenameButton = new System.Windows.Forms.Button();
            this.RenameLabel = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.labelMove = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.TextStyleComboBox = new System.Windows.Forms.ComboBox();
            this.ThemeColorComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePathLeft
            // 
            this.FilePathLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FilePathLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilePathLeft.ForeColor = System.Drawing.Color.White;
            this.FilePathLeft.Location = new System.Drawing.Point(76, 96);
            this.FilePathLeft.Name = "FilePathLeft";
            this.FilePathLeft.ReadOnly = true;
            this.FilePathLeft.Size = new System.Drawing.Size(465, 27);
            this.FilePathLeft.TabIndex = 1;
            // 
            // buttonBackLeft
            // 
            this.buttonBackLeft.ForeColor = System.Drawing.Color.White;
            this.buttonBackLeft.Location = new System.Drawing.Point(37, 95);
            this.buttonBackLeft.Name = "buttonBackLeft";
            this.buttonBackLeft.Size = new System.Drawing.Size(42, 29);
            this.buttonBackLeft.TabIndex = 2;
            this.buttonBackLeft.Text = "<=";
            this.buttonBackLeft.UseVisualStyleBackColor = false;
            this.buttonBackLeft.Click += new System.EventHandler(this.buttonBackLeft_Click);
            // 
            // DirectoriesAndFilesRight
            // 
            this.DirectoriesAndFilesRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectoriesAndFilesRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DirectoriesAndFilesRight.ForeColor = System.Drawing.Color.White;
            this.DirectoriesAndFilesRight.FormattingEnabled = true;
            this.DirectoriesAndFilesRight.ItemHeight = 20;
            this.DirectoriesAndFilesRight.Items.AddRange(new object[] {
            ""});
            this.DirectoriesAndFilesRight.Location = new System.Drawing.Point(680, 128);
            this.DirectoriesAndFilesRight.Name = "DirectoriesAndFilesRight";
            this.DirectoriesAndFilesRight.Size = new System.Drawing.Size(550, 462);
            this.DirectoriesAndFilesRight.TabIndex = 4;
            this.DirectoriesAndFilesRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DirectoriesAndFilesRight_MouseDoubleClick);
            // 
            // FilePathRight
            // 
            this.FilePathRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FilePathRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilePathRight.ForeColor = System.Drawing.Color.White;
            this.FilePathRight.Location = new System.Drawing.Point(719, 97);
            this.FilePathRight.Name = "FilePathRight";
            this.FilePathRight.ReadOnly = true;
            this.FilePathRight.Size = new System.Drawing.Size(465, 27);
            this.FilePathRight.TabIndex = 5;
            // 
            // buttonCopyFilePathRight
            // 
            this.buttonCopyFilePathRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyFilePathRight.ForeColor = System.Drawing.Color.White;
            this.buttonCopyFilePathRight.Location = new System.Drawing.Point(1136, 95);
            this.buttonCopyFilePathRight.Name = "buttonCopyFilePathRight";
            this.buttonCopyFilePathRight.Size = new System.Drawing.Size(94, 29);
            this.buttonCopyFilePathRight.TabIndex = 6;
            this.buttonCopyFilePathRight.Text = "Copy";
            this.buttonCopyFilePathRight.UseVisualStyleBackColor = false;
            this.buttonCopyFilePathRight.Click += new System.EventHandler(this.buttonCopyFilePathRight_Click);
            // 
            // buttonBackRight
            // 
            this.buttonBackRight.ForeColor = System.Drawing.Color.White;
            this.buttonBackRight.Location = new System.Drawing.Point(680, 96);
            this.buttonBackRight.Name = "buttonBackRight";
            this.buttonBackRight.Size = new System.Drawing.Size(42, 29);
            this.buttonBackRight.TabIndex = 7;
            this.buttonBackRight.Text = "<=";
            this.buttonBackRight.UseVisualStyleBackColor = false;
            this.buttonBackRight.Click += new System.EventHandler(this.buttonBackRight_Click);
            // 
            // buttonCopyFilePathLeft
            // 
            this.buttonCopyFilePathLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyFilePathLeft.ForeColor = System.Drawing.Color.White;
            this.buttonCopyFilePathLeft.Location = new System.Drawing.Point(506, 95);
            this.buttonCopyFilePathLeft.Name = "buttonCopyFilePathLeft";
            this.buttonCopyFilePathLeft.Size = new System.Drawing.Size(94, 29);
            this.buttonCopyFilePathLeft.TabIndex = 8;
            this.buttonCopyFilePathLeft.Text = "Copy";
            this.buttonCopyFilePathLeft.UseVisualStyleBackColor = false;
            this.buttonCopyFilePathLeft.Click += new System.EventHandler(this.buttonCopyFilePathLeft_Click);
            // 
            // DirectoriesAndFilesLeft
            // 
            this.DirectoriesAndFilesLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectoriesAndFilesLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DirectoriesAndFilesLeft.ForeColor = System.Drawing.Color.White;
            this.DirectoriesAndFilesLeft.FormattingEnabled = true;
            this.DirectoriesAndFilesLeft.ItemHeight = 20;
            this.DirectoriesAndFilesLeft.Items.AddRange(new object[] {
            ""});
            this.DirectoriesAndFilesLeft.Location = new System.Drawing.Point(50, 128);
            this.DirectoriesAndFilesLeft.Name = "DirectoriesAndFilesLeft";
            this.DirectoriesAndFilesLeft.Size = new System.Drawing.Size(550, 482);
            this.DirectoriesAndFilesLeft.TabIndex = 9;
            this.DirectoriesAndFilesLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DirectoriesAndFilesLeft_MouseDoubleClick);
            // 
            // RenameButton
            // 
            this.RenameButton.BackColor = System.Drawing.Color.Transparent;
            this.RenameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RenameButton.BackgroundImage")));
            this.RenameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RenameButton.Image = ((System.Drawing.Image)(resources.GetObject("RenameButton.Image")));
            this.RenameButton.Location = new System.Drawing.Point(616, 192);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(46, 48);
            this.RenameButton.TabIndex = 10;
            this.RenameButton.UseVisualStyleBackColor = false;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            this.RenameButton.MouseEnter += new System.EventHandler(this.RenameButton_MouseEnter);
            this.RenameButton.MouseLeave += new System.EventHandler(this.RenameButton_MouseLeave);
            // 
            // RenameLabel
            // 
            this.RenameLabel.AutoSize = true;
            this.RenameLabel.Location = new System.Drawing.Point(606, 237);
            this.RenameLabel.Name = "RenameLabel";
            this.RenameLabel.Size = new System.Drawing.Size(0, 20);
            this.RenameLabel.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(616, 483);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(46, 46);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = " ";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.buttonDelete_MouseEnter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.buttonDelete_MouseLeave);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Location = new System.Drawing.Point(606, 537);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(0, 20);
            this.DeleteLabel.TabIndex = 13;
            // 
            // buttonArchive
            // 
            this.buttonArchive.BackColor = System.Drawing.Color.Transparent;
            this.buttonArchive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonArchive.BackgroundImage")));
            this.buttonArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonArchive.ForeColor = System.Drawing.Color.Transparent;
            this.buttonArchive.Location = new System.Drawing.Point(616, 343);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(46, 46);
            this.buttonArchive.TabIndex = 14;
            this.buttonArchive.Text = " ";
            this.buttonArchive.UseVisualStyleBackColor = false;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.Color.Transparent;
            this.buttonMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMove.BackgroundImage")));
            this.buttonMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMove.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMove.Location = new System.Drawing.Point(616, 267);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(46, 46);
            this.buttonMove.TabIndex = 15;
            this.buttonMove.Text = " ";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            this.buttonMove.MouseEnter += new System.EventHandler(this.buttonMove_MouseEnter);
            this.buttonMove.MouseLeave += new System.EventHandler(this.buttonMove_MouseLeave);
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Location = new System.Drawing.Point(606, 309);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(0, 20);
            this.labelMove.TabIndex = 16;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopy.BackgroundImage")));
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCopy.ForeColor = System.Drawing.Color.White;
            this.buttonCopy.Location = new System.Drawing.Point(616, 410);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(46, 46);
            this.buttonCopy.TabIndex = 17;
            this.buttonCopy.Text = " ";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // TextStyleComboBox
            // 
            this.TextStyleComboBox.FormattingEnabled = true;
            this.TextStyleComboBox.Location = new System.Drawing.Point(1071, 12);
            this.TextStyleComboBox.Name = "TextStyleComboBox";
            this.TextStyleComboBox.Size = new System.Drawing.Size(169, 28);
            this.TextStyleComboBox.TabIndex = 19;
            this.TextStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.TextStyleComboBox_SelectedIndexChanged);
            // 
            // ThemeColorComboBox
            // 
            this.ThemeColorComboBox.FormattingEnabled = true;
            this.ThemeColorComboBox.Location = new System.Drawing.Point(881, 12);
            this.ThemeColorComboBox.Name = "ThemeColorComboBox";
            this.ThemeColorComboBox.Size = new System.Drawing.Size(169, 28);
            this.ThemeColorComboBox.TabIndex = 20;
            this.ThemeColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeColorComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1069, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 31);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(881, 60);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(169, 31);
            this.buttonDownload.TabIndex = 22;
            this.buttonDownload.Text = "download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.ThemeColorComboBox);
            this.Controls.Add(this.TextStyleComboBox);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.labelMove);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.DeleteLabel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.RenameLabel);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.DirectoriesAndFilesLeft);
            this.Controls.Add(this.buttonCopyFilePathLeft);
            this.Controls.Add(this.buttonBackRight);
            this.Controls.Add(this.buttonCopyFilePathRight);
            this.Controls.Add(this.FilePathRight);
            this.Controls.Add(this.DirectoriesAndFilesRight);
            this.Controls.Add(this.buttonBackLeft);
            this.Controls.Add(this.FilePathLeft);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "FileManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonBackLeft;
        private Button buttonCopyFilePathRight;
        private Button buttonBackRight;
        private Button buttonCopyFilePathLeft;
        private Button RenameButton;
        private Label RenameLabel;
        private Button buttonDelete;
        private Label DeleteLabel;
        private Button buttonArchive;
        private Button buttonMove;
        private TextBox FilePathLeft;
        private ListBox DirectoriesAndFilesRight;
        private TextBox FilePathRight;
        private ListBox DirectoriesAndFilesLeft;
        private Label labelMove;
        private Button buttonCopy;
        private ComboBox TextStyleComboBox;
        private ComboBox ThemeColorComboBox;
        private Button searchButton;
        private Button buttonDownload;
    }
}