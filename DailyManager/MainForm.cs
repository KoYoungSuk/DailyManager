using DailyManager.DAO;
using DailyManager.Model;
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
    public partial class MainForm : Form
    {
        OracleConnection conn = null;
        Global g = new Global(); 

        public MainForm(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            label6.Text = g.checkOS();
            getCalendar(DateTime.Now.ToString("yyyy-MM-dd")); 
        }


        public void getCalendar(String title)
        {
           
            try
            {
                DailyDAO dailydao = new DailyDAO(conn);

                int count = dailydao.getDailyCountByTitle(title);

                Dictionary<string, string> dailylist = dailydao.getDailyListByTitle(title);

                if(count != 0) //일정 정보가 있음 
                {
                    textBox1.Text = title;
                    if (dailylist.ContainsKey("content"))
                    {
                        textBox2.Text = dailylist["content"];
                    }
                    if (dailylist.ContainsKey("savedate"))
                    {
                        textBox3.Text = dailylist["savedate"];
                    }
                    if (dailylist.ContainsKey("modifydate"))
                    {
                        textBox4.Text = dailylist["modifydate"];
                    }

                    String status = null;

                    if (dailylist.ContainsKey("status"))
                    {
                        status = dailylist["status"];
                    }


                    if (status.Equals("Yes")) //달성했음 
                    {
                        Yes_radiobtn.Checked = true;
                    }
                    else if (status.Equals("No")) //달성 안함 
                    {
                        No_radiobtn.Checked = true;
                    }

                    btn_Delete.Enabled = true; 
                    btn_Save.Text = "Modify"; //정보가 이미 존재하므로 수정 모드로 들어감 
                    groupBox1.Visible = true;
                    groupBox2.Visible = true; 
                }
                else //일정 정보가 없음 (작성 모드) 
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    Modify_radiobtn.Checked = true; 
                    No_radiobtn.Checked = true;
                    btn_Save.Text = "Save"; 
                    btn_Delete.Enabled = false;
                    groupBox1.Visible = false;
                    groupBox2.Visible = false; 
                }
            }
            catch(Exception ex)
            {
                g.errormessage(ex.Message);  
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(conn != null)
            {
                conn.Close(); 
            }
            Application.Exit(); 
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if(conn != null)
            {
                conn.Close(); 
            }
            Application.Exit(); 
        }

        private void closeXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(conn != null)
            {
                conn.Close();
            }
            Application.Exit(); 
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString(); 
            getCalendar(textBox1.Text);  
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            String title = textBox1.Text;
            String content = textBox2.Text;

            String status = String.Empty;

            if(btn_Save.Text.Equals("Save")) //저장 모드 
            {
                status = "No"; //처음 등록하는 일정은 달성 안한걸로. 
            }
            else //수정 모드
            {
                if(Yes_radiobtn.Checked) //달성 했음 
                {
                    status = "Yes"; 
                }
                else if(No_radiobtn.Checked) //달성 안했음 
                {
                    status = "No"; 
                }
            }
            try
            {
                DailyDTO dailydto = dailydto = new DailyDTO(title, content, status, null, DateTime.Now.ToString(), DateTime.Now.ToString());
                DailyDAO dailydao = new DailyDAO(conn);

                int result = 0;

                if(btn_Save.Text.Equals("Save"))
                {
                    result = dailydao.createCalendar(dailydto); 
                }
                else if(btn_Save.Text.Equals("Modify"))
                {
                    result = dailydao.updateCalendar(dailydto);
                }

                if(result == 0)
                {
                    g.errormessage("Unknown Error Message"); 
                }
                else
                {
                    g.informationmessage("Successfully Saved");

                    getCalendar(title); 
                }
            }
            catch(Exception ex)
            {
                g.errormessage(ex.Message); 
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            String title = textBox1.Text;

            try
            {
                DailyDAO dailydao = new DailyDAO(conn);
                int result = dailydao.deleteDaily(title);

                if(result == 0)
                {
                    g.errormessage("Unknown Error Message"); 
                }
                else
                {
                    g.informationmessage("Successfully Deleted");
                    getCalendar(DateTime.Now.ToString("yyyy-MM-dd")); 
                }
            }
            catch(Exception ex)
            {
                g.errormessage(ex.Message); 
            }
        }

        private void 월별계획달성여부체크ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForm cf = new CheckForm(conn);
            cf.Show(); 
        }

        private void aboutDailyManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show(); 
        }
    }
}
