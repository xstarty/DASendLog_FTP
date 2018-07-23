using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace DASendLog_FTP
{   
    public partial class LogForm : Form
    {                
        string m_strSystemPath = System.Environment.CurrentDirectory + "\\LOG\\";
        string m_strDate = "";
        string m_strZipFileName = "";
        string m_strDateFormat = "yyyyMMddHHmmssfff";
        List<string> m_DelList = new List<string>();

        enum SendButtonType
        {
            Ready = 0,
            UserInfo,
            Picture,
            Zip,
            FTP
        }

        public LogForm()
        {
            InitializeComponent();            
        }

        ///////////////////////////////////////////////////////////////////////////////

        private void button_SelectPicture_Click(object sender, EventArgs e)
        {
            SelectPicture();
        }

        private void button_PrintScreen_Click(object sender, EventArgs e)
        {
            // Mini to print screen
            this.WindowState = FormWindowState.Minimized;
            timerPicture.Enabled = true;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            button_Send.Enabled = false;

            SendLog();

            button_Send.Enabled = true;
        }

        private void timerPicture_Tick(object sender, EventArgs e)
        {
            PrinterScreen();
        }

        ///////////////////////////////////////////////////////////////////////////////

        void SelectPicture()
        {
            // Select picture
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "請選擇問題截圖圖檔";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                if ((myStream = dialog.OpenFile()) != null)
                {
                    foreach (string strFilename in dialog.FileNames)
                    {
                        checkedListBox_PictureList.Items.Add(strFilename);                        
                    }
                    myStream.Close();
                }

                for (int i = 0; i < checkedListBox_PictureList.Items.Count; i++)
                {
                    checkedListBox_PictureList.SetItemChecked(i, true);
                }
            }
        }

        void PrinterScreen()
        {
            // Print screeen and copy to log folder
            if (this.WindowState == FormWindowState.Minimized)
            {
                SetCurrencyTime();
                string strFile = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + String.Format("\\{0}_{1}.jpg", textBox_UID.Text, m_strDate);    // Save to desktop

                int screenLeft = SystemInformation.VirtualScreen.Left;
                int screenTop = SystemInformation.VirtualScreen.Top;
                int screenWidth = SystemInformation.VirtualScreen.Width;
                int screenHeight = SystemInformation.VirtualScreen.Height;

                // Create a bitmap of the appropriate size to receive the screenshot.
                using (Bitmap bmp = new Bitmap(screenWidth, screenHeight))
                {
                    // Draw the screenshot into our bitmap.
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                    }

                    // Do something with the Bitmap here, like save it to a file:
                    bmp.Save(strFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                checkedListBox_PictureList.Items.Add(strFile);
                checkedListBox_PictureList.SetItemChecked(checkedListBox_PictureList.Items.Count - 1, true);

                this.WindowState = FormWindowState.Normal;
                timerPicture.Enabled = false;

                string strMsg = string.Format("已截圖完成，檔案儲存至 {0}", strFile);
                ExecShowMessage(strMsg);
            }
        }

        void SendLog()
        {
            bool bReady = true;

            SetCurrencyTime();

            // Create user report
            ConvertSendButtonType(SendButtonType.UserInfo);
            bReady &= PrepareUserInfo();

            // Copy picture
            ConvertSendButtonType(SendButtonType.Picture);
            bReady &= PreparePicture();

            // Create zip file
            ConvertSendButtonType(SendButtonType.Zip);
            bReady &= PrepareZipFile(); 

            if(bReady)
            {
                ConvertSendButtonType(SendButtonType.FTP);
                ExecSendLog();                
            }

            ConvertSendButtonType(SendButtonType.Ready);

            ClearGenFile();
        }

        bool PrepareUserInfo()  // Create user report
        {
            GenSystemInfo SystemInfo = new GenSystemInfo(m_strSystemPath, m_strDate, textBox_UID.Text, textBox_Name.Text, textBox_Phone.Text, textBox_Mail.Text, textBox_Report.Text);
            if(SystemInfo != null)
            {
                SystemInfo.m_dgShowMsg += new ShowMessage(ExecShowMessage);
                SystemInfo.m_dgAddDelFilePath += new AddDelFilePath(ExecAddDelFilePath);
                return SystemInfo.ExecGenSystemInfo();
            }                
            else
                return false;
        }

        bool PreparePicture()   // Copy picture
        {            
            /* don't copy now
            int nSelCount = checkedListBox_PictureList.CheckedItems.Count;

            for (int i = 0; i < nSelCount; i++)
            {
                string strFile = checkedListBox_PictureList.CheckedItems[i].ToString();
                string strFileName = strFile.Substring(strFile.LastIndexOf('\\') + 1, strFile.Length - strFile.LastIndexOf('\\') - 1);

                // File name conflict
                while (File.Exists(m_strSystemPath + strFileName))
                {
                    string strFileTemp = strFileName;                    
                    strFileTemp = strFileTemp.Insert(strFileTemp.LastIndexOf('.'), DateTime.Now.ToString(m_strDateFormat));

                    if (!File.Exists(m_strSystemPath + strFileTemp))
                    {
                        strFileName = strFileTemp;
                        break;
                    }                        
                }

                // Copy file
                try
                {
                    File.Copy(strFile, m_strSystemPath + strFileName);

                    ExecAddDelFilePath(m_strSystemPath + strFileName);
                }
                catch (IOException ex)
                {
                    ExecShowMessage(ex.Message);
                    return false;
                }
            }
            */

            return true;
        }

        bool PrepareZipFile()   // Create zip file
        { 
            try
            {
                m_strZipFileName = m_strSystemPath + textBox_UID.Text + "_" + m_strDate + ".zip";

                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile(m_strZipFileName, Encoding.GetEncoding("Big5")))
                {
                    // Add log file
                    foreach (string strFname in System.IO.Directory.GetFiles(m_strSystemPath, "*.*", System.IO.SearchOption.AllDirectories))
                    {
                        if (String.Compare(Path.GetExtension(strFname), ".zip", true) == 0)
                            continue;

                        // Add the file to the Zip archive's root folder.
                        zip.AddFile(@strFname);
                    }

                    // Add picture
                    int nSelCount = checkedListBox_PictureList.CheckedItems.Count;
                    for (int i = 0; i < nSelCount; i++)
                    {
                        string strFile = checkedListBox_PictureList.CheckedItems[i].ToString();
                        
                        // Add the file to the Zip archive's root folder.
                        zip.AddFile(strFile);
                    }

                    // Save the Zip file.
                    zip.Save();

                    ExecAddDelFilePath(m_strZipFileName);
                }
            }
            catch(Exception ex)
            {
                m_strZipFileName = "";

                ExecShowMessage(ex.Message);
                return false;
            }

            return true;
        }

        bool ExecSendLog()
        {
            FTPUpload FTP = new FTPUpload();
            if (FTP != null)
            {
                FTP.m_dgShowMsg += new ShowMessage(ExecShowMessage);
                FTP.Upload(m_strZipFileName);
            }                

            return true;
        }

        ///////////////////////////////////////////////////////////////////////////////

        void SetCurrencyTime()
        {            
            m_strDate = DateTime.Now.ToString(m_strDateFormat);
        }

        void ConvertSendButtonType(SendButtonType eType)
        {
            switch(eType)
            {
                case SendButtonType.Ready:
                    button_Send.Text = "送出問題回報";
                    button_Send.Enabled = true;
                    break;
                case SendButtonType.UserInfo:
                    button_Send.Text = "文件處理中…";                    
                    button_Send.Enabled = false;
                    break;
                case SendButtonType.Picture:
                    button_Send.Text = "圖片處理中…";
                    button_Send.Enabled = false;
                    break;
                case SendButtonType.Zip:
                    button_Send.Text = "檔案壓縮中…";
                    button_Send.Enabled = false;
                    break;
                case SendButtonType.FTP:
                    button_Send.Text = "檔案上傳中…";
                    button_Send.Enabled = false;
                    break;
            }

            Application.DoEvents(); // Let button text update
        }

        void ClearGenFile()
        {
            if (m_DelList == null)
                return;

            foreach (string myStringList in m_DelList)
            {
                try
                {
                    if (File.Exists(myStringList))
                    {
                        File.Delete(myStringList);
                    }
                }
                catch(Exception ex)
                {
                    ExecShowMessage(ex.Message);
                }
            }

            m_DelList.Clear();
        }

        ///////////////////////////////////////////////////////////////////////////////

        public void ExecShowMessage(string strMsg)
        {
            MessageBox.Show(strMsg, this.Text);
        }

        public void ExecAddDelFilePath(string strPath)
        {
            if (m_DelList != null)
                m_DelList.Add(strPath);
        }
    }
}
