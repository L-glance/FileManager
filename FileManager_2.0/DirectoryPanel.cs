
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.IO.Compression;
using System.Text;

namespace FileManager_2._0
{
    internal class DirectoryPanel
    {
        TextBox CurrentPath;
        ListBox ListFiAndDir;
        public DirectoryPanel(TextBox CurrentPath,ListBox ListFiAndDir)
        {
            this.CurrentPath = CurrentPath;
            this.ListFiAndDir = ListFiAndDir;
        }

        public void Compress()
        {
            string OldPath = CurrentPath.Text +"\\"+ ListFiAndDir.SelectedItem.ToString();
            string newPath = OldPath + ".zip";

            if (File.Exists(CurrentPath.Text + ListFiAndDir.SelectedItem.ToString()))
            {
                var outputStream = new FileStream(newPath, FileMode.Create, FileAccess.ReadWrite);
                var archive = new ZipArchive(outputStream, ZipArchiveMode.Create, true, Encoding.UTF8);
                var entryStream = archive.CreateEntry(Path.GetFileName(OldPath)).Open();
                var inputStream = new FileStream(OldPath, FileMode.Open, FileAccess.Read);
                inputStream.CopyTo(entryStream);
            }
            else
            {
                ZipFile.CreateFromDirectory(OldPath, OldPath+".zip");
            }
            UpdateCurrentPathDirectory();
        }
        public void Copy(DirectoryPanel otherPanel)
        {
            string OldPath = CurrentPath.Text + "\\" +ListFiAndDir.SelectedItem.ToString();
            if (File.Exists(OldPath))
            {
                string newPath;

                if (otherPanel.ListFiAndDir.SelectedItem == null) { newPath = otherPanel.CurrentPath.Text + "\\" + ListFiAndDir.SelectedItem.ToString(); }
                else newPath = otherPanel.CurrentPath.Text + "\\" + otherPanel.ListFiAndDir.SelectedItem.ToString() + ListFiAndDir.SelectedItem.ToString();

                File.Copy(OldPath, newPath, false);
                UpdateCurrentPathDirectory();
                otherPanel.UpdateCurrentPathDirectory();
            }
            else if (Directory.Exists(OldPath))
            {
                string newPath;
                if (otherPanel.ListFiAndDir.SelectedItem == null) { newPath = otherPanel.CurrentPath.Text + "\\" + ListFiAndDir.SelectedItem.ToString(); }
                else newPath = otherPanel.CurrentPath.Text + "\\" + otherPanel.ListFiAndDir.SelectedItem.ToString() + ListFiAndDir.SelectedItem.ToString();

                RecursiveCopy(OldPath, newPath);
                void RecursiveCopy(string currentPath, string newPath)
                {
                    Directory.CreateDirectory(newPath);
                    foreach (string s1 in Directory.GetFiles(currentPath))
                    {
                        string s2 = newPath + "\\" + Path.GetFileName(s1);
                        File.Copy(s1, s2,true);
                    }
                    foreach (string s in Directory.GetDirectories(currentPath))
                    {
                        RecursiveCopy(s, newPath + "\\" + Path.GetFileName(s));
                    }
                }
                UpdateCurrentPathDirectory();
                otherPanel.UpdateCurrentPathDirectory();
            }
        }
        public void Delete()
        {
            if (File.Exists(CurrentPath.Text + "\\" + ListFiAndDir.SelectedItem.ToString()))
            {
                FileSystem.DeleteFile(CurrentPath.Text + "\\"+ ListFiAndDir.SelectedItem.ToString(),UIOption.OnlyErrorDialogs,RecycleOption.SendToRecycleBin);
            }else if(Directory.Exists(CurrentPath.Text + "\\"+ ListFiAndDir.SelectedItem.ToString()))
            {
                FileSystem.DeleteDirectory(CurrentPath.Text + "\\" + ListFiAndDir.SelectedItem.ToString(), UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            }
            UpdateCurrentPathDirectory();

        }
        public void Rename()
        {
            RenameWindow renameWindow = new RenameWindow(ListFiAndDir);
            renameWindow.ShowDialog();
            if (renameWindow.isAccepted)
            {
                string OldPath = CurrentPath.Text + ListFiAndDir.SelectedItem.ToString();
                string NewPath = CurrentPath.Text + renameWindow.TextBoxNewName.Text + (new FileInfo(ListFiAndDir.SelectedItem.ToString())).Extension;

                if (Directory.Exists(OldPath))
                {
                    Directory.Move(OldPath, NewPath);
                    UpdateCurrentPathDirectory();
                }
                if (File.Exists(OldPath))
                {
                    File.Move(OldPath, NewPath);
                    UpdateCurrentPathDirectory();
                }
            }
        }
        public void Move(DirectoryPanel otherPanel)
        {
            MoveForm movingform = new MoveForm(otherPanel.CurrentPath);
            movingform.ShowDialog();
            if (!movingform.isAccepted) return;

           
            string OldPath = CurrentPath.Text +"\\"+ ListFiAndDir.SelectedItem.ToString();
            if (File.Exists(OldPath))
            {
                string newPath = movingform.TextBoxNewFilePath.Text + ListFiAndDir.SelectedItem.ToString();
                File.Move(OldPath,newPath);
                UpdateCurrentPathDirectory();
                otherPanel.UpdateCurrentPathDirectory();
            }
            else if(Directory.Exists(OldPath))
            {
                string newPath = movingform.TextBoxNewFilePath.Text +@"\"+ ListFiAndDir.SelectedItem.ToString();
                try
                { 
                Directory.Move(OldPath,newPath);
                }
                catch (Exception ex)
                {

                }
                UpdateCurrentPathDirectory();
                otherPanel.UpdateCurrentPathDirectory();
            }
        }
        public void UpdateLogicalDisk()
        {
            ListFiAndDir.Items.Clear();
            CurrentPath.Text = String.Empty;
            ListFiAndDir.Items.AddRange(Directory.GetLogicalDrives());
        }
        public void GoParentDir()
        {
            if (CurrentPath.Text == String.Empty) return;

            ListFiAndDir.Items.Clear();
            DirectoryInfo? parentDir = new DirectoryInfo(CurrentPath.Text).Parent;

            if(parentDir == null) { UpdateLogicalDisk(); return; }
            CurrentPath.Text = parentDir.FullName + @"\";
            UpdateCurrentPathDirectory();
        }
        public void OpenSelectedItem()
        {
            if (ListFiAndDir.SelectedItem == null) return;
            string FullPath = Path.Combine(CurrentPath.Text, ListFiAndDir.SelectedItem.ToString());
            
            if (File.Exists(FullPath))
            {
                Process.Start(new ProcessStartInfo(FullPath) { UseShellExecute = true });
                return;
            }
            if (Directory.Exists(FullPath))
            {
                CurrentPath.Text = FullPath;
                UpdateCurrentPathDirectory();
            }
        }
        public void UpdateCurrentPathDirectory()
        {
            if (CurrentPath.Text == String.Empty) return;

            ListFiAndDir.Items.Clear();
            string[] dirAndFi = new DirectoryInfo(CurrentPath.Text)
              .EnumerateFiles()
              .Where(fi => (fi.Attributes & FileAttributes.Hidden) == 0)
              .Select(fi => fi.Name)
              .Union(new DirectoryInfo(CurrentPath.Text)
                .EnumerateDirectories()
                .Where(dir => (dir.Attributes & FileAttributes.Hidden) == 0)
                .Select(dir => dir.Name)).ToArray();
            //dirAndFi.Sort();
            Array.Sort(dirAndFi);
            ListFiAndDir.Items.AddRange(dirAndFi);
        }
        public void CopyCurrentPath()
        {
            if (CurrentPath.Text == null) return;
            Clipboard.SetText(CurrentPath.Text);
        }
    }
}
