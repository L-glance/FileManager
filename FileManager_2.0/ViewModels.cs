using System.Linq;
using System.Diagnostics;
namespace FileManager_2._0
{
    internal class ViewModels
    {
        public ViewModels(ListBox DirAndFiLeft, ListBox DirAndFiRight, TextBox PathFiLeft,TextBox PathFiRight)
        {
        }
        internal static void GoToFileorFolder(TextBox FilePath, object sender, ListBox DirectoriesAndFiles)
        {
            #region Work With FilePath
            string TempFilePath = FilePath.Text;
            if ((sender as ListBox)?.SelectedItem == null) return;
            FilePath.Text += (sender as ListBox)?.SelectedItem?.ToString();
            if (File.Exists(FilePath.Text))
            {
                Process.Start(new ProcessStartInfo(FilePath.Text) { UseShellExecute = true });
                FilePath.Text = TempFilePath;
                return;
            }
            if (!FilePath.Text[FilePath.Text.Length - 1].Equals('\\')) FilePath.Text += @"\";
            DirectoriesAndFiles.Items.Clear();
            #endregion
            #region OuputDirectory
            UpdateDir(FilePath, DirectoriesAndFiles);
            #endregion
        }
        internal static void GoBack(TextBox FilePath, ListBox DirectoriesAndFiles)
        {
            if (FilePath.Text == "") return;
            DirectoriesAndFiles.Items.Clear();

            var drparent = (new DirectoryInfo(FilePath.Text)).Parent;
            if (drparent == null) { InitializeMainLogicalDisk(FilePath, DirectoriesAndFiles); return; }
            FilePath.Text = drparent?.FullName + @"\";
            UpdateDir(FilePath, DirectoriesAndFiles);
        }
        internal static void InitializeMainLogicalDisk(TextBox FilePath, ListBox DirectoriesAndFiles)
        {
            DirectoriesAndFiles.Items.Clear();
            FilePath.Text = String.Empty;
            foreach (var logicalDisk in Directory.GetLogicalDrives()) DirectoriesAndFiles.Items.Add(logicalDisk);
        }
        internal static void UpdateDir(TextBox FilePath, ListBox DirectoriesAndFiles)
        {
            if(FilePath.Text == String.Empty) return;

            DirectoriesAndFiles.Items.Clear();
            List<string> dirAndFi = new DirectoryInfo(FilePath.Text)
              .EnumerateFiles()
              .Where(fi => (fi.Attributes & FileAttributes.Hidden) == 0)
              .Select(fi => fi.Name)
              .Union(new DirectoryInfo(FilePath.Text)
                .EnumerateDirectories()
                .Where(dir => (dir.Attributes & FileAttributes.Hidden)  == 0)
                .Select(dir => dir.Name)).ToList();

            dirAndFi.Sort();
            foreach (var item in dirAndFi) DirectoriesAndFiles.Items.Add(item);
        }
        internal static void UpdateLeftAndRightDirectory(TextBox FilePathLeft, ListBox DirectoriesAndFilesLeft, TextBox FilePathRight, ListBox DirectoriesAndFilesRight)
        {
            UpdateDir(FilePathLeft, DirectoriesAndFilesLeft);
            UpdateDir(FilePathRight, DirectoriesAndFilesRight);
        }
        internal static void Rename(ListBox DirectoriesAndFiles, TextBox FilePath)
        {

            
            
        }

        internal static void Delete(ListBox DirectoriesAndFiles, TextBox FilePath)
        {

        }
        internal static void Move(ListBox DirectoriesAndFiles, TextBox FirstPath,TextBox SecondPath ,ListBox DirectoriesAndFilesTwo)
        {
            //var moveWindow = new MoveForm(SecondPath);
            //moveWindow.ShowDialog();
            //if (moveWindow.isAccepted)
            //{

            //    string NewPath = moveWindow.comboBoxPathToChoose.Text.ToString() ;
            //    string OldPath = FirstPath.Text + DirectoriesAndFiles.SelectedItem.ToString();
                
                
            //    if (Directory.Exists(OldPath))
            //    {
            //        Directory.Move(OldPath, NewPath);
            //        UpdateDir(FirstPath, DirectoriesAndFiles);
            //    }
            //    if (File.Exists(OldPath))
            //    {
            //        File.Move(OldPath, NewPath);
            //        UpdateDir(FirstPath, DirectoriesAndFiles);
            //        UpdateDir(SecondPath, DirectoriesAndFilesTwo);
            //    }
            //}
        }
    }
}