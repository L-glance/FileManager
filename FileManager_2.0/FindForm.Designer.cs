namespace FileManager_2._0
{
    partial class FindForm
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
            this.findPathTextBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.findPropertyTextBox = new System.Windows.Forms.TextBox();
            this.findedFilesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // findPathTextBox
            // 
            this.findPathTextBox.Location = new System.Drawing.Point(12, 30);
            this.findPathTextBox.Name = "findPathTextBox";
            this.findPathTextBox.Size = new System.Drawing.Size(755, 27);
            this.findPathTextBox.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(461, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(129, 29);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // findPropertyTextBox
            // 
            this.findPropertyTextBox.Location = new System.Drawing.Point(12, 63);
            this.findPropertyTextBox.Name = "findPropertyTextBox";
            this.findPropertyTextBox.Size = new System.Drawing.Size(422, 27);
            this.findPropertyTextBox.TabIndex = 2;
            // 
            // findedFilesListBox
            // 
            this.findedFilesListBox.FormattingEnabled = true;
            this.findedFilesListBox.ItemHeight = 20;
            this.findedFilesListBox.Location = new System.Drawing.Point(12, 113);
            this.findedFilesListBox.Name = "findedFilesListBox";
            this.findedFilesListBox.Size = new System.Drawing.Size(755, 324);
            this.findedFilesListBox.TabIndex = 3;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findedFilesListBox);
            this.Controls.Add(this.findPropertyTextBox);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.findPathTextBox);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox findPathTextBox;
        private Button buttonSearch;
        private TextBox findPropertyTextBox;
        private ListBox findedFilesListBox;
    }
}