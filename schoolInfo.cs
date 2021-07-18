using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SDA_phase1
{
    class SchoolInfo
    {
        private readonly string path;
        StreamWriter writer;
        public SchoolInfo()
        {
            path = @"C:\SchoolInfo.txt";
           
        }

        public void AddNewItem(int id,string tname,string tclass,string tsec)
        {
            writer = File.AppendText(path);
            string value = id+"-"+tname+"-"+tclass+"-"+tsec+"\n";
            writer.Write(value);
            
            Console.WriteLine("Added information sucessfully");
            writer.Close();
        }


        public Teacher GetSchool(int id)
        {
            string[] lines = File.ReadAllLines(path);
            foreach(string s in lines)
            {
                string[] line = s.Split("-");
                if (int.Parse(line[0]) == id)
                {
                    Teacher t1 = new Teacher(int.Parse(line[0]), line[1], line[2],line[3]);
                    return t1;
                }

            }

            return null;
        }

        public void update(int oldID,int newID ,string tname,string tclass,string tsec)
        {
            string[] lines = File.ReadAllLines(path);
            bool status = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split("-");
                if (int.Parse(line[0]) == oldID)
                {
                    lines[i] = newID + "-" +tname+"-"+ tclass +"-"+ tsec;
                    status = true;
                }
            }
            if (status)
            {
                File.WriteAllLines(path, lines);
                Console.WriteLine("Update information sucissfully!");
            }
           

        }

        
    }
}