using DailyManager.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyManager.DAO
{
    public class DailyDAO
    {
        OracleConnection? conn;
        Global g = new Global();

        public DailyDAO(OracleConnection conn)
        {
            this.conn = conn; 
        }

        #region["테이블 생성"] 
        public int createTable()
        {
            String sql = "CREATE TABLE DAILY(TITLE VARCHAR(20) NOT NULL PRIMARY KEY,CONTENT CLOB,STATUS VARCHAR(30),NOTE VARCHAR(50),WRITEDATE TIMESTAMP,MODIFYDATE TIMESTAMP)"; 
            OracleCommand ccmd = new OracleCommand(sql, conn);
            int result = ccmd.ExecuteNonQuery();
            ccmd.Dispose();
            return result; 

        }
        #endregion

        #region["테이블 존재 유무 검사"]
        public Boolean getTableExists(String tname)
        {
            Boolean existstatus = false;
            String sql = "select TNAME from TAB where TNAME = :tname";
            OracleCommand scmd = new OracleCommand(sql, conn);
            scmd.BindByName = true;
            scmd.Parameters.Add(new OracleParameter("tname", tname));
            OracleDataReader dr = scmd.ExecuteReader();
            string status = null;
            while (dr.Read())
            {
                status = dr["TNAME"].ToString();
            }
            if (string.IsNullOrEmpty(status))
            {
                existstatus = false;
            }
            else
            {
                existstatus = true;
            }
            dr.Close();
            scmd.Dispose();
            return existstatus;
        }
        #endregion

        public int createCalendar(DailyDTO dailydto)
        {
            String sql = "insert into daily (title, content, status, note, writedate, modifydate) values (:title, :content, :status, :note, :writedate, :modifydate)";
            OracleCommand icmd = new OracleCommand(sql, conn); 
            icmd.BindByName = true;
            icmd.Parameters.Add(new OracleParameter("title", dailydto.Title));
            icmd.Parameters.Add(new OracleParameter("content", dailydto.Content));
            icmd.Parameters.Add(new OracleParameter("status", dailydto.Status));
            icmd.Parameters.Add(new OracleParameter("note", dailydto.Note));
            icmd.Parameters.Add(new OracleParameter("writedate", DateTime.Parse(dailydto.Writedate)));  
            icmd.Parameters.Add(new OracleParameter("modifydate", DateTime.Parse(dailydto.Modifydate)));

            int result = icmd.ExecuteNonQuery();
            icmd.Dispose();
            return result; 
        }

        public int updateCalendar(DailyDTO dailydto)
        {
            String sql = "update daily set content=:content, status=:status, note=:note, modifydate=:modifydate where title=:title";
            OracleCommand ucmd = new OracleCommand(sql, conn);
            ucmd.BindByName = true;
            ucmd.Parameters.Add(new OracleParameter("content", dailydto.Content));
            ucmd.Parameters.Add(new OracleParameter("status", dailydto.Status));
            ucmd.Parameters.Add(new OracleParameter("note", dailydto.Note));
            ucmd.Parameters.Add(new OracleParameter("modifydate", DateTime.Parse(dailydto.Modifydate)));
            ucmd.Parameters.Add(new OracleParameter("title", dailydto.Title));

            int result = ucmd.ExecuteNonQuery();
            ucmd.Dispose(); 
            return result; 
        }
        
        public int deleteDaily(String title)
        {
            String sql = "delete from daily where title = :title";
            OracleCommand dcmd = new OracleCommand(sql, conn);
            dcmd.BindByName = true;
            dcmd.Parameters.Add(new OracleParameter("title", title));
            int result = dcmd.ExecuteNonQuery();
            dcmd.Dispose();
            return result; 

        }

        public Dictionary<String, String> getDailyListByTitle(String title)
        {
            Dictionary<String, String> dailylist = new Dictionary<String, String>();
            String sql = "select * from daily where title = :title";
            OracleCommand scmd = new OracleCommand(sql, conn);
            scmd.BindByName = true;
            scmd.Parameters.Add(new OracleParameter("title", title));
            OracleDataReader dr = scmd.ExecuteReader();
            while (dr.Read())
            {
                dailylist.Add("title", dr["title"]?.ToString());
                dailylist.Add("content", dr["content"]?.ToString());
                dailylist.Add("status", dr["status"]?.ToString());
                dailylist.Add("savedate", dr["writedate"]?.ToString());
                dailylist.Add("modifydate", dr["modifydate"]?.ToString());
            }
            dr.Close();
            scmd.Dispose();
            return dailylist;
        }

        
        public int getDailyCountByTitle(String title)
        {
            String sql = "select count(*) as dailynumber from daily where title = :title";
            OracleCommand scmd = new OracleCommand(sql, conn);
            scmd.BindByName = true;
            scmd.Parameters.Add(new OracleParameter("title", title));
            OracleDataReader dr = scmd.ExecuteReader();
            int count = 0;

            while(dr.Read())
            {
                count = Int32.Parse(dr["dailynumber"]?.ToString());
            }
            dr.Close();
            scmd.Dispose();
            return count;
        }
        
    }
}
