
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DailyManager
{
    public class Global
    {
        #region["데이터베이스 연결 정보 스트링(파라미터로 받아와서 리턴)"]
        public String connectionString(String address, String port, String sid, String id, String pw)
        {
            String connstr = String.Format("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={2})));User Id={3};Password={4}", address, port, sid, id, pw);
            return connstr;
        }
        #endregion

        #region["OS 버전 확인"]
        public String checkOS()
        {
            string HKLMWinNTCurrent = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string osName = Registry.GetValue(HKLMWinNTCurrent, "productName", "").ToString();
            string osBuild = Registry.GetValue(HKLMWinNTCurrent, "CurrentBuildNumber", "").ToString();
            String label;
            String[] osName_arr = osName.Split(' ');
            if (osName_arr[1].Equals("10"))
            {
                if (Int32.Parse(osBuild) > 21000)
                {
                    label = "Your Operating System : Windows 11 " + osName_arr[2] + " Build: " + osBuild;
                }
                else
                {
                    label = "Your Operating System : " + osName + " Build: " + osBuild;
                }
            }
            else
            {
                label = "Your Operating System : " + osName + " Build: " + osBuild;
            }
            return label;
        }
        #endregion

        #region["오류 메시지"] 
        public DialogResult errormessage(String errormsg)
        {
            return MessageBox.Show(errormsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region["정보 메시지"] 
        public DialogResult informationmessage(String msg)
        {
            return MessageBox.Show(msg, "MyDiary", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        #endregion

    }
}
