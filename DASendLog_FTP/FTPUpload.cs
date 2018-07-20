using System;
using System.Configuration;
using System.Net;

namespace DASendLog_FTP
{
    class FTPUpload
    {
        public event ShowMessage m_dgShowMsg;

        public bool Upload(string strZipFilePath)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string strFileName = strZipFilePath.Substring(strZipFilePath.LastIndexOf('\\') + 1, strZipFilePath.Length - strZipFilePath.LastIndexOf('\\') - 1);

                    client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["FTP_User"], ConfigurationManager.AppSettings["FTP_Password"]);
                    byte[] rawResponse = client.UploadFile(ConfigurationManager.AppSettings["FTP_Url"] + "\\" + strFileName, strZipFilePath);

                    string strReturn = System.Text.Encoding.ASCII.GetString(rawResponse);
                    if(!string.IsNullOrEmpty(strReturn))
                    {
                        string strMsg = "Remote Response: " + strReturn;
                        m_dgShowMsg.Invoke(strMsg);

                        return false;
                    }
                    else
                        m_dgShowMsg.Invoke("已上傳回報");                    
                }
            }
            catch(Exception ex)
            {                
                m_dgShowMsg.Invoke(ex.Message);
                return false;
            }

            return true;
        }
    }
}
