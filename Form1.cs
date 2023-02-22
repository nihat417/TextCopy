using System.ComponentModel;
using System.Text;

namespace TextCopy
{
    public partial class Form1 : Form
    {
        BackgroundWorker backgroundWorker = null;
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
            thread = new Thread(CopyFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FileBtn1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            FileTxt1.Text = openFileDialog1.FileName.Trim();
        }

        private void FileBtn2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog(this);
            FileTxt2.Text = openFileDialog2.FileName.Trim();
        }

        private async void CopyFile()
        {
            string sourceFilePath = FileTxt1.Text;
            string destinationFilePath = FileTxt2.Text;
            int bufferSize = 1024;
            long totalBytes = new FileInfo(sourceFilePath).Length;
            long bytesCopied = 0;


            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {

                byte[] buffer = new byte[bufferSize];
                int bytesRead;


                while ((bytesRead = sourceStream.Read(buffer, 0, bufferSize)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                    bytesCopied += bytesRead;

                    int progress = (int)Math.Round((double)bytesCopied / totalBytes * 100);

                    Thread.Sleep(100);

                    backgroundWorker.ReportProgress(progress);
                }
            }
            await Task.Delay(2000);
        }



        private void CopyBtn_Click(object sender, EventArgs e)
        {
            thread.Start();
            progressBar1.Value = 30;
            Thread.Sleep(2000);
            progressBar1.Value = 90;
            Thread.Sleep(2000);
            progressBar1.Value = progressBar1.Maximum;
        }




        private void SuspendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Suspend();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AbortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Abort();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Resume();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        //private void CopyFile(string sourceFilePath, string destinationFilePath)
        //{
        //    int bufferSize = 1024;
        //    long totalBytes = new FileInfo(sourceFilePath).Length;
        //    long bytesCopied = 0;
        //
        //
        //    using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
        //    using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
        //    {
        //
        //        byte[] buffer = new byte[bufferSize];
        //        int bytesRead;
        //
        //
        //        while ((bytesRead = sourceStream.Read(buffer, 0, bufferSize)) > 0)
        //        {
        //            destinationStream.Write(buffer, 0, bytesRead);
        //            bytesCopied += bytesRead;
        //
        //            int progress = (int)Math.Round((double)bytesCopied / totalBytes * 100);
        //
        //            Thread.Sleep(100);
        //
        //            backgroundWorker.ReportProgress(progress);
        //        }
        //    }
        //}



        //private void CopyBtn_Click(object sender, EventArgs e)
        //{   
        //    string sourceFilePath = FileTxt1.Text;
        //    string destinationFilePath = FileTxt2.Text;
        //
        //    
        //    backgroundWorker = new BackgroundWorker();
        //    backgroundWorker.WorkerReportsProgress = true;
        //    backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
        //    backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
        //    backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
        //
        //    
        //    backgroundWorker.RunWorkerAsync(new string[] { sourceFilePath, destinationFilePath });
        //    
        //}
        //
        //private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    string sourceFilePath = ((string[])e.Argument)[0];
        //    string destinationFilePath = ((string[])e.Argument)[1];
        //
        //    
        //    CopyFile(sourceFilePath, destinationFilePath);
        //}
        //
        //private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    progressBar1.Value = e.ProgressPercentage;
        //}
        //
        //private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    MessageBox.Show("Sucsess");
        //}
    }
}