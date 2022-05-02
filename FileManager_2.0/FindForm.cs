using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_2._0
{
    public partial class FindForm : Form
    {
        public FindForm(string path)
        {
            InitializeComponent();
            // путь по которому мы будем искать
            findPathTextBox.Text = path;
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.isSearching = false;
        }

        List<string> finded = new List<string>();
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            findedFilesListBox.Items.Clear();
            finded.Clear();
            if (File.Exists(findPathTextBox.Text))
            {
                string s = File.ReadAllText(findPathTextBox.Text);
                Regex regexF = new Regex(findPropertyTextBox.Text);
                MatchCollection temp = regexF.Matches(new DirectoryInfo(s).Name);
                foreach (Match match in temp)
                {
                    finded.Add(match.Groups[0].Value);
                }
            }
            else
            {
                Recursive(findPathTextBox.Text);
                void Recursive(string currentPath)
                {
                    Parallel.ForEach(Directory.GetDirectories(currentPath), s =>
                    {
                        Regex regexF = new Regex(findPropertyTextBox.Text);
                        MatchCollection temp = regexF.Matches(new DirectoryInfo(s).Name);
                        if (temp.Count > 0) finded.Add(new DirectoryInfo(s).Name);
                        Recursive(s);
                    });
                    Parallel.ForEach(Directory.GetFiles(currentPath), s =>
                    {
                        Regex regexF = new Regex(findPropertyTextBox.Text);
                        MatchCollection temp = regexF.Matches(new DirectoryInfo(s).Name);
                        if (temp.Count > 0) finded.Add(new DirectoryInfo(s).Name);

                    });
                }
            }
            string[] finded2 = new string[finded.Count];
            for (var i = 0; i < finded.Count; i++) { finded2[i] = finded[i]; }
            findedFilesListBox.Items.AddRange(finded2);
        }
    }

}
