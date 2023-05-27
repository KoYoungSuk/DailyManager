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

                /*
                 *  
SELECT COUNT(*) FROM DAILY WHERE TITLE LIKE 'YEARMONTH%' AND STATUS = 'YES'


SELECT COUNT(*) FROM DAILY WHERE TITLE LIKE 'YEARMONTH%' AND STATUS = 'NO'

SELECT COUNT(*) FROM DAILY WHERE TITLE LIKE 'YEARMONTH%' AND STATUS = NULL 
                 *
                 **/
            }
            catch (Exception ex)
            {
                g.errormessage(ex.Message); 
            }
        }
    }
}
