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
    public partial class RenameWindow : Form
    {
        public bool isAccepted;
        public RenameWindow(ListBox DirAndFi)
        {
            InitializeComponent();
            TextBoxNewName.Text =DirAndFi.SelectedItem.ToString();
        }

        private void TextBoxNewName_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAcceptNewPath_Click(object sender, EventArgs e)
        {
            this.Close();
            isAccepted = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            isAccepted = false;
        }

    }
}
