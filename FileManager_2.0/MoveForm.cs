using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_2._0
{
    public partial class MoveForm : Form
    {
        public bool isAccepted;
        public TextBox TextBoxNewFilePath;
        public MoveForm(TextBox FilePath)
        {
            InitializeComponent();
            this.TextBoxNewFilePath = FilePath;
            InitializeListBoxWithDirectories();
        }
        private void InitializeListBoxWithDirectories()
        {
            if (TextBoxNewFilePath.Text == "") return;
            List<string> dirAndFi = new DirectoryInfo(TextBoxNewFilePath.Text)
                 .EnumerateDirectories()
                 .Where(dir => (dir.Attributes & FileAttributes.Hidden) == 0)
                 .Select(dir => dir.FullName).ToList();

            dirAndFi.Sort();
            comboBoxPathToChoose.Text = TextBoxNewFilePath.Text;
            foreach (var item in dirAndFi) comboBoxPathToChoose.Items.Add(item);
        }
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            TextBoxNewFilePath.Text = comboBoxPathToChoose.Text;
            isAccepted = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            TextBoxNewFilePath.Text = String.Empty;
            isAccepted = false;
            this.Close();
        }
        
        private void MoveForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MessageBox.Show("Enter");
            }
        }
    }
}
