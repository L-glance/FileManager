using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_2._0
{
    public partial class FindForm : Form
    {
        public FindForm(string path)
        {
            InitializeComponent();
            findPathTextBox.Text = path;
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.isSearching = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            var result = Parallel.For(1, int.MaxValue, (a,state) => 
            {

            });
            //RecursiveCopy(findPathTextBox.Text);
            //void RecursiveCopy(string currentPath)
            //{
            //    foreach (string s1 in Directory.GetFiles(currentPath))
            //    {
            //    }
            //    foreach (string s in Directory.GetDirectories(currentPath))
            //    {
            //        RecursiveCopy(s);
            //    }
            //}
        }
    }

}
