using System;
using System.IO;

namespace DASendLog_FTP
{
    class GenSystemInfo
    {
        public event ShowMessage m_dgShowMsg;
        public event AddDelFilePath m_dgAddDelFilePath;

        string m_strSystemPath = "";
        string m_strDate = "";
        string m_strFileName = "{0}_{1}.txt";    // Report-{UID}-{DATE}.txt
        string m_strUID = "";
        string m_strName = "";
        string m_strPhone = "";
        string m_strMail = "";
        string m_strReport = "";

        public GenSystemInfo(string strPath, string strDate, string strUID, string strName, string strPhone, string strMail, string strReport)
        {
            m_strSystemPath = strPath;
            m_strDate = strDate;

            m_strUID = strUID.Replace(" ", "");
            m_strName = strName.Replace(" ", "");
            m_strPhone = strPhone.Replace(" ", "");
            m_strMail = strMail.Replace(" ", "");
            m_strReport = strReport;
        }

        public bool ExecGenSystemInfo()
        {
            if (!CheckUserData())
                return false;

            string strFile = m_strSystemPath + String.Format(m_strFileName, m_strUID, m_strDate);

            try
            {
                // Create file
                FileStream fileStream = new FileStream(@strFile, FileMode.Create);
                fileStream.Close();

                // Write to file
                if (File.Exists(@strFile))
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@strFile, true))
                    {
                        file.WriteLine("身分證號：" + m_strUID + "\r\n");
                        file.WriteLine("姓　　名：" + m_strName + "\r\n");
                        file.WriteLine("電　　話：" + m_strPhone + "\r\n");
                        file.WriteLine("電子信箱：" + m_strMail + "\r\n");
                        file.WriteLine("問題描述：" + m_strReport + "\r\n");

                        m_dgAddDelFilePath.Invoke(strFile);

                        return true;
                    }

                    
                }
                else
                {
                    string strMsg = String.Format("檔案寫入失敗：{0}", @strFile);
                    m_dgShowMsg.Invoke(strMsg);                    
                }
            }
            catch(Exception ex)
            {
                m_dgShowMsg.Invoke(ex.Message);                
            }

            return false;
        }

        bool CheckUserData()
        {
            if(String.IsNullOrEmpty(m_strUID))
            {
                m_dgShowMsg.Invoke("欄位「身分證號」不得為空值");                
                return false;
            }
            else if (String.IsNullOrEmpty(m_strName))
            {
                m_dgShowMsg.Invoke("欄位「姓名」不得為空值");                
                return false;
            }
            else if (String.IsNullOrEmpty(m_strPhone))
            {
                m_dgShowMsg.Invoke("欄位「電話」不得為空值");                
                return false;
            }
            else if (String.IsNullOrEmpty(m_strMail))
            {
                m_dgShowMsg.Invoke("欄位「電子信箱」不得為空值");                
                return false;
            }
            else if (String.IsNullOrEmpty(m_strReport))
            {
                m_dgShowMsg.Invoke("欄位「問題描述」不得為空值");                
                return false;
            }

            return true;
        }
    }
}
