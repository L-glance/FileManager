namespace FileManager_2._0
{
    partial class RenameWindow
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
            this.TextBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonAcceptNewPath = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxNewName
            // 
            this.TextBoxNewName.Location = new System.Drawing.Point(12, 47);
            this.TextBoxNewName.Name = "TextBoxNewName";
            this.TextBoxNewName.Size = new System.Drawing.Size(466, 27);
            this.TextBoxNewName.TabIndex = 0;
            this.TextBoxNewName.Text = "Введите новое имя";
            this.TextBoxNewName.Click += new System.EventHandler(this.TextBoxNewName_Click);
            // 
            // buttonAcceptNewPath
            // 
            this.buttonAcceptNewPath.Location = new System.Drawing.Point(134, 156);
            this.buttonAcceptNewPath.Name = "buttonAcceptNewPath";
            this.buttonAcceptNewPath.Size = new System.Drawing.Size(94, 29);
            this.buttonAcceptNewPath.TabIndex = 1;
            this.buttonAcceptNewPath.Text = "ok";
            this.buttonAcceptNewPath.UseVisualStyleBackColor = true;
            this.buttonAcceptNewPath.Click += new System.EventHandler(this.buttonAcceptNewPath_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(251, 156);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(94, 29);
            this.buttonCansel.TabIndex = 2;
            this.buttonCansel.Text = "Cancel";
            this.buttonCansel.UseVisualStyleBackColor = true;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // RenameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 238);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonAcceptNewPath);
            this.Controls.Add(this.TextBoxNewName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "RenameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox TextBoxNewName;
        private Button buttonAcceptNewPath;
        private Button buttonCansel;
    }
}