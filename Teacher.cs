using System;
using System.Collections.Generic;
using System.Text;

namespace SDA_phase1
{
    class Teacher
    {
        public int ID { get; set; }
        public string tName { get; set; }
        public string tclass { get; set; }
        public string tsec { get; set; }

        public Teacher(int id, string tname,string tclass,string tsec)
        {
            this.ID = id;
            this.tName = tname;
            this.tclass = tclass;
            this.tsec = tsec;
            
        }

        public Teacher()
        {
        }
    }
}