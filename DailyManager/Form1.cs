using DailyManager.DAO;
using Oracle.ManagedDataAccess.Client;

namespace DailyManager
{
    public partial class Form1 : Form
    {
        OracleConnection conn = null;
        Global g = new Global(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(conn != null)
            {
                conn.Close(); 
            }
            Application.Exit(); 
        }

        private void DBPw_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //koyoungsuk2.dyndns.org:1521/xe
                Boolean check = false; 
                String fulladdress = DBAddress_txt.Text;
                String dbid = DBID_txt.Text;
                String dbpw = DBPw_txt.Text;
                String addressandport = fulladdress.Split('/')[0];
                String sid = fulladdress.Split('/')[1];
                String address = addressandport.Split(':')[0];
                String port = addressandport.Split(':')[1];

                String connstr = g.connectionString(address, port, sid, dbid, dbpw); 

                conn = new OracleConnection(connstr);
                conn.Open();

                DailyDAO dailydao = new DailyDAO(conn); 

                if(dailydao.getTableExists("DAILY")) //테이블이 존재함 
                {
                    check = true; 
                }
                else
                {
                    //테이블이 존재하지 않으면 새로 만든다. 
                    DialogResult dr = g.informationmessage("You need to create Table. continue?");

                    if(dr == DialogResult.OK)
                    {
                        int result = dailydao.createTable();
                        if(result != 0)
                        {
                            g.informationmessage("Table is successfully created."); 
                            check = true;  
                        }
                        else
                        {
                            g.errormessage("Unknown Error Message");  
                        }
                    }
                    else
                    {
                        g.errormessage("You need to create Table."); 
                    }
                }

                if(check)
                {
                    MainForm mf = new MainForm(conn);
                    mf.Show();
                    this.Hide(); 
                }
                
            }
            catch(Exception ex)
            {
                g.errormessage(ex.Message);  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}