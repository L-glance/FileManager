namespace FileManager_2._0
{
    partial class MoveForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.comboBoxPathToChoose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(236, 158);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(85, 158);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(94, 29);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Ok";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // comboBoxPathToChoose
            // 
            this.comboBoxPathToChoose.FormattingEnabled = true;
            this.comboBoxPathToChoose.Location = new System.Drawing.Point(46, 38);
            this.comboBoxPathToChoose.Name = "comboBoxPathToChoose";
            this.comboBoxPathToChoose.Size = new System.Drawing.Size(347, 28);
            this.comboBoxPathToChoose.TabIndex = 4;
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 223);
            this.Controls.Add(this.comboBoxPathToChoose);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Name = "MoveForm";
            this.Text = "MoveForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoveForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonCancel;
        private Button buttonAccept;
        internal ComboBox comboBoxPathToChoose;
    }
}