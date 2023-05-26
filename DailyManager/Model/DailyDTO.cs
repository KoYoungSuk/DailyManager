using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyManager.Model
{
    public class DailyDTO
    {
        String title;
        String content;
        String status;
        String note;
        String writedate;
        String modifydate;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Status { get => status; set => status = value; }
        public string Note { get => note; set => note = value; }
        public string Writedate { get => writedate; set => writedate = value; }
        public string Modifydate { get => modifydate; set => modifydate = value; }

        public DailyDTO(string title, string content, string status, string note, string writedate, string modifydate)
        {
            this.title = title;
            this.content = content;
            this.status = status;
            this.note = note;
            this.writedate = writedate;
            this.modifydate = modifydate;

        }
    }
}
