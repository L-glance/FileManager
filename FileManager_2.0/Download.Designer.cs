namespace FileManager_2._0
{
    partial class Download
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
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonCanselDownload = new System.Windows.Forms.Button();
            this.newFileNameTextBox = new System.Windows.Forms.TextBox();
            this.timePassed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(38, 68);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(726, 27);
            this.linkTextBox.TabIndex = 0;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(38, 133);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(205, 29);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "скачать";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonCanselDownload
            // 
            this.buttonCanselDownload.Location = new System.Drawing.Point(38, 186);
            this.buttonCanselDownload.Name = "buttonCanselDownload";
            this.buttonCanselDownload.Size = new System.Drawing.Size(205, 29);
            this.buttonCanselDownload.TabIndex = 2;
            this.buttonCanselDownload.Text = "Отменить загрузку";
            this.buttonCanselDownload.UseVisualStyleBackColor = true;
            this.buttonCanselDownload.Click += new System.EventHandler(this.buttonCanselDownload_Click);
            // 
            // newFileNameTextBox
            // 
            this.newFileNameTextBox.Location = new System.Drawing.Point(329, 135);
            this.newFileNameTextBox.Name = "newFileNameTextBox";
            this.newFileNameTextBox.Size = new System.Drawing.Size(435, 27);
            this.newFileNameTextBox.TabIndex = 3;
            // 
            // timePassed
            // 
            this.timePassed.AutoSize = true;
            this.timePassed.Location = new System.Drawing.Point(249, 137);
            this.timePassed.Name = "timePassed";
            this.timePassed.Size = new System.Drawing.Size(50, 20);
            this.timePassed.TabIndex = 4;
            this.timePassed.Text = "label1";
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timePassed);
            this.Controls.Add(this.newFileNameTextBox);
            this.Controls.Add(this.buttonCanselDownload);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.linkTextBox);
            this.Name = "Download";
            this.Text = "Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox linkTextBox;
        private Button buttonDownload;
        private Button buttonCanselDownload;
        private TextBox newFileNameTextBox;
        public Label timePassed;
    }
}