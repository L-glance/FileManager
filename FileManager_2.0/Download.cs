using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace FileManager_2._0
{
    public partial class Download : Form
    {
        public static CancellationTokenSource cts;
        public Download()
        {
            InitializeComponent();
            
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            string f = linkTextBox.Text.Substring(linkTextBox.Text.LastIndexOf('.'),4);
            string path = @"C:\Users\admin\Downloads\" + newFileNameTextBox.Text + f;
            await Task.Run(() => DownloadFile(linkTextBox.Text, path));
        }
        public int DownloadFile(String remoteFilename,String localFilename)
        {
            int bytesProcessed = 0;
            Stream remoteStream = null;
            Stream localStream = null;
            WebResponse response = null;
            Stopwatch sw = Stopwatch.StartNew();

            try
            {
                WebRequest request = WebRequest.Create(remoteFilename);
                if (request != null)
                {
                    response = request.GetResponse();
                    if (response != null)
                    {
                        remoteStream = response.GetResponseStream();

                        localStream = File.Create(localFilename);

                        byte[] buffer = new byte[2048];
                        int bytesRead;
                        cts = new CancellationTokenSource();
                        var token = cts.Token;
                        do
                        {

                            bytesRead = remoteStream.Read(buffer, 0, buffer.Length);
                            localStream.Write(buffer, 0, bytesRead);

                            SetText((sw.ElapsedMilliseconds / 1000 +","+ sw.ElapsedMilliseconds % 1000).ToString());
                            bytesProcessed += bytesRead;
                            if (token.IsCancellationRequested)
                            {
                                token.ThrowIfCancellationRequested();
                            }

                        } while (bytesRead > 0);
                        MessageBox.Show("Скачивание завершено");
                    }
                }
            }
            
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
                File.Delete(localFilename);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (response != null) response.Close();
                if (remoteStream != null) remoteStream.Close();
                if (localStream != null) localStream.Close();
                cts.Dispose();
            }
            
            return bytesProcessed;
        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (timePassed.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.timePassed.Text = text;
            }
        }
        private void buttonCanselDownload_Click(object sender, EventArgs e)
        {
            try
            {
                cts.Cancel();

            }catch(Exception ex) { }
        }
    }
}
