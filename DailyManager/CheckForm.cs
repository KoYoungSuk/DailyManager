using DailyManager.DAO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyManager
{
    public partial class CheckForm : Form
    {
        OracleConnection conn = null;
        Global g = new Global(); 
        public CheckForm(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;

            String fulldate = DateTime.Now.ToString("yyyy-MM-dd");  //2023-05-27
            String todayyear = fulldate.Split('-')[0];
            String todaymonth = fulldate.Split('-')[1];

            textBox1.Text = todayyear;
            textBox2.Text = todaymonth; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String year = textBox1.Text;
                String month = textBox2.Text;

                String yearmonth = year + "-" + month;

                int year_int = Int32.Parse(year);
                int month_int = Int32.Parse(month);
                int totaldays = 0;
                Boolean leapyear = false;

                //윤년 체크 
                if((year_int % 4 == 0 && year_int % 100 != 0) || year_int % 400 == 0)
                {
                    leapyear = true; 
                }

                System.Diagnostics.Debug.WriteLine("month_int: " + month_int); 
                switch(month_int)
                {
                    case 1:
                        totaldays = 31; 
                        break;
                    case 2:
                        if (leapyear)
                        {
                            totaldays = 29;  //윤년 
                        }
                        else
                        {
                            totaldays = 28; 
                        }
                        break;
                    case 3:
                        totaldays = 31; 
                        break;
                    case 4:
                        totaldays = 30; 
                        break;
                    case 5:
                        totaldays = 31; 
                        break;
                    case 6:
                        totaldays = 30; 
                        break;
                    case 7:
                        totaldays = 31; 
                        break;
                    case 8:
                        totaldays = 31; 
                        break;
                    case 9:
                        totaldays = 30; 
                        break;
                    case 10:
                        totaldays = 31; 
                        break;
                    case 11:
                        totaldays = 30; 
                        break;
                    case 12:
                        totaldays = 31; 
                        break;
                    default:
                        break; 
                }

                DailyDAO dailydao = new DailyDAO(conn);
                int yesdays = dailydao.getYesDays(yearmonth);
                int nodays = dailydao.getNoDays(yearmonth);
                int nulldays = totaldays - (yesdays + nodays);

                DateLabel.Text = "날짜: " + yearmonth + ""; 
                CheckDates.Text = "달성 일수: " + yesdays + ""; //계획 달성일수 
                UnCheckDates.Text = "미달성 일수: " + nodays + ""; //계획 미달성일수 
                NoDateLabel.Text = "계획 미등록 일수: " + nulldays + ""; //계획을 등록하지 않은 일수 
            }
            catch (Exception ex)
            {
                g.errormessage(ex.Message); 
            }
        }
    }
}
