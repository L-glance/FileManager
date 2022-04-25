using System.Runtime.Serialization.Formatters.Binary;
namespace FileManager_2._0
{
    public partial class MainForm: Form
    {
        DirectoryPanel LeftDirPanel;
        DirectoryPanel RightDirPanel;
        public static bool isSearching;
        public MainForm()
        {

            #region DeSerialization
            try
            {
                var formater = new BinaryFormatter();
                using (FileStream fs = new FileStream("configGUI.txt", FileMode.OpenOrCreate))
                {
                    GUI.GetInstance((GUI)formater.Deserialize(fs));
                }

            }
            catch (Exception ex) { }
            #endregion
            InitializeComponent();
            InitializeStyleViewComponent();

            LeftDirPanel = new DirectoryPanel(FilePathLeft, DirectoriesAndFilesLeft);
            RightDirPanel = new DirectoryPanel(FilePathRight, DirectoriesAndFilesRight);
            LeftDirPanel.UpdateLogicalDisk();
            RightDirPanel.UpdateLogicalDisk();
        }
        private void InitializeStyleViewComponent()
        {
            
            TextStyleComboBox.Text = GUI.GetInstance().CurrentFontName;
            TextStyleComboBox.Items.AddRange(GUI.GetInstance().Fonts);
            TextStyleComboBox_SelectedIndexChanged(TextStyleComboBox,null);

            ThemeColorComboBox.Text = GUI.GetInstance().CurrentColorThemeName;
            ThemeColorComboBox.Items.AddRange(GUI.GetInstance().ColorThemeName);
            ThemeColorComboBox_SelectedIndexChanged(ThemeColorComboBox,null);
        }
        public void InitializeColourfulComponent()
        {
            Color ForeColor;
            int red = GUI.GetInstance().rgb[0];
            int green = GUI.GetInstance().rgb[1];
            int blue = GUI.GetInstance().rgb[2];

            if (red + green + blue > 250) ForeColor = Color.Black;
            else ForeColor = Color.White;

            buttonCopyFilePathLeft.BackColor = System.Drawing.Color.FromArgb(red,green,blue);
            buttonCopyFilePathRight.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
            DirectoriesAndFilesLeft.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
            DirectoriesAndFilesRight.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
            buttonBackLeft.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
            buttonBackRight.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
            searchButton.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
            this.BackColor = System.Drawing.Color.FromArgb(Math.Max(red-30,0), Math.Max(green-30,0), blue);
            FilePathLeft.BackColor = System.Drawing.Color.FromArgb(red + 10, green, blue);
            FilePathRight.BackColor = System.Drawing.Color.FromArgb(red + 10, green, blue);

            buttonCopyFilePathLeft.ForeColor = ForeColor;
            buttonCopyFilePathRight.ForeColor = ForeColor;
            DirectoriesAndFilesLeft.ForeColor = ForeColor;
            DirectoriesAndFilesRight.ForeColor = ForeColor;
            buttonBackLeft.ForeColor = ForeColor;
            buttonBackRight.ForeColor= ForeColor;
            FilePathRight.ForeColor = ForeColor;
            FilePathLeft.ForeColor= ForeColor;
            searchButton.ForeColor= ForeColor;
        }
        private void RenameButton_MouseEnter(object sender, EventArgs e) => RenameLabel.Text = "Переименовать";
        private void RenameButton_MouseLeave(object sender, EventArgs e) => RenameLabel.Text = "";
        private void buttonDelete_MouseEnter(object sender, EventArgs e) => DeleteLabel.Text = "Удалить";
        private void buttonDelete_MouseLeave(object sender, EventArgs e) => DeleteLabel.Text = "";
        private void buttonDelete_Click(object sender, EventArgs e) 
        {
            if (DirectoriesAndFilesRight.SelectedItem == null && DirectoriesAndFilesLeft.SelectedItem == null) return;
            if (DirectoriesAndFilesLeft.SelectedItem != null) LeftDirPanel.Delete();
            else RightDirPanel.Delete();
            RightDirPanel.UpdateCurrentPathDirectory();
            LeftDirPanel.UpdateCurrentPathDirectory();
        }
        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (DirectoriesAndFilesRight.SelectedItem == null && DirectoriesAndFilesLeft.SelectedItem == null) return;
            if (DirectoriesAndFilesLeft.SelectedItem != null) LeftDirPanel.Rename();
            else  RightDirPanel.Rename();
        }
        private void DirectoriesAndFilesLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LeftDirPanel.OpenSelectedItem();
        }
        private void DirectoriesAndFilesRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RightDirPanel.OpenSelectedItem();
        }
        private void buttonBackLeft_Click(object sender, EventArgs e)
        {
            LeftDirPanel.GoParentDir();
        }
        private void buttonBackRight_Click(object sender, EventArgs e)
        {
            RightDirPanel.GoParentDir();
        }
        private void buttonCopyFilePathRight_Click(object sender, EventArgs e)
        {
            RightDirPanel.CopyCurrentPath();
        }
        private void buttonCopyFilePathLeft_Click(object sender, EventArgs e)
        {
            LeftDirPanel.CopyCurrentPath();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (DirectoriesAndFilesRight.SelectedItem == null && DirectoriesAndFilesLeft.SelectedItem == null) return;
            if (DirectoriesAndFilesLeft.SelectedItem != null) LeftDirPanel.Move(RightDirPanel);
            if (DirectoriesAndFilesRight.SelectedItem != null) RightDirPanel.Move(LeftDirPanel);
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {

                if (DirectoriesAndFilesLeft.SelectedItem == null)
                {
                    DirectoriesAndFilesLeft.SelectedItem = DirectoriesAndFilesLeft.Items[0];
                    DirectoriesAndFilesRight.SelectedItem = null;
                }
                else
                {
                    DirectoriesAndFilesRight.SelectedItem = DirectoriesAndFilesRight.Items[0];
                    DirectoriesAndFilesLeft.SelectedItem = null;
                }
            }
        }
        private void buttonMove_MouseEnter(object sender, EventArgs e)
        {
            labelMove.Text = "Переместить";
        }
        private void buttonMove_MouseLeave(object sender, EventArgs e)
        {
            labelMove.Text = string.Empty;
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (DirectoriesAndFilesRight.SelectedItem == null && DirectoriesAndFilesLeft.SelectedItem == null) return;
            if (DirectoriesAndFilesLeft.SelectedItem != null)
            {
                LeftDirPanel.Copy(RightDirPanel);
            }
            else RightDirPanel.Copy(LeftDirPanel);
        }
        private void buttonArchive_Click(object sender, EventArgs e)
        {
            if (DirectoriesAndFilesRight.SelectedItem == null && DirectoriesAndFilesLeft.SelectedItem == null) return;
            if (DirectoriesAndFilesLeft.SelectedItem != null) LeftDirPanel.Compress();
            else RightDirPanel.Compress();
        }


        private void ChangeColorTheme(int red,int green,int blue)
        {
            GUI.GetInstance().rgb[0] = red;
            GUI.GetInstance().rgb[1] = green;
            GUI.GetInstance().rgb[2] = blue;
            InitializeColourfulComponent();
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Serilization
            BinaryFormatter? formater = new BinaryFormatter();
            using (FileStream fs = new FileStream("configGUI.txt", FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, GUI.GetInstance());
            }
            #endregion
            Application.Exit();
        }

        private void ThemeColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI.GetInstance().CurrentColorThemeName = ((ComboBox)sender).Text;
            switch(((ComboBox)sender).Text)
            {
                case "Dark":
                    ChangeColorTheme(50, 50, 50);
                    break;
                case "Dracula":
                    ChangeColorTheme(90,60,90);
                    break;
                case "Cheerful Spring":
                    ChangeColorTheme(225, 236, 173);
                    break;
                case "Blue Moon":
                    ChangeColorTheme(180,217,244);
                    break;
                case "Blood Moon":
                    ChangeColorTheme(140, 0, 0);
                    break;
                default:
                    break;
            }
        }

        private void TextStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI.GetInstance().CurrentFontName = ((ComboBox)sender).Text;
            string currentFont = TextStyleComboBox.Text;
            buttonCopyFilePathLeft.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonCopyFilePathRight.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DirectoriesAndFilesLeft.Font =  new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DirectoriesAndFilesRight.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonBackLeft.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonBackRight.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TextStyleComboBox.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ThemeColorComboBox.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FilePathLeft.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FilePathRight.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            searchButton.Font = new System.Drawing.Font(currentFont, 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(!isSearching) new FindForm(LeftDirPanel.CurrentPath.Text).Show();
            isSearching = true;
        }
    }
}