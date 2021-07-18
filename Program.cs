using System;

namespace SDA_phase1
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolInfo SI = new SchoolInfo();
            Console.WriteLine("\t-----Welcome in the RAINBOW School System-----");
            bool status = true;
            while (status)
            {
                 Console.WriteLine("Please Enter your choise:");
                Console.WriteLine(" Press 1 to Add New Teacher Data in System \nPress  2 to Search for a teacher in The System \n Press 3 to Update teacher Data in the system \n Press 4 to Exit");
                int Userchose = 0;
                try {
                    int chose = int.Parse(Console.ReadLine());
                    Userchose = chose;
                }catch(Exception ex)
                {
                    Console.WriteLine($"{ex}");
                    Console.WriteLine("Please Enter The Number for Chose");
                }
                switch (Userchose)
                {
                    case 1:
                       
                        try
                        {
                            Console.WriteLine("insertion a new teacher to the system:");
                            Console.WriteLine("Please Enter the teacher ID");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enterthe teacher Name");
                            string tname = Console.ReadLine();
                            Console.WriteLine("Please the teacher Class Name");
                            string tclass = Console.ReadLine();
                            Console.WriteLine("Please Enter the teacher Section Name");
                            string tsec = Console.ReadLine();
                            SI.AddNewItem(id, tname,tclass, tsec);
                            
                        }
                        catch(Exception e)
                    {
                            Console.WriteLine($"{e}");
                            Console.WriteLine("Please Enter The Number for ID ");
                    }
                       
                      


                        break;

                    case 2:
                        Console.WriteLine("Please Enter the ID which you want to search for it");
                        int idSearch = int.Parse(Console.ReadLine());
                        Teacher search = SI.GetSchool(idSearch);
                        if (search != null)
                        {
                            Console.WriteLine("your searching results as:");
                            Console.WriteLine($"The ID: {search.ID}\nThe Name: {search.tName}\nThe Class: {search.tclass}\nThe Section: {search.tsec}");
                        }
                        else
                        {
                            Console.WriteLine("The ID you are entered we not find it!!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please Enter the ID How wint to search");
                        int SearchID = int.Parse(Console.ReadLine());
                        Teacher t1 = SI.GetSchool(SearchID );
                        if (t1 != null)
                        {
                            Console.WriteLine($"The ID: {t1.ID}\nTheName: {t1.tName}\nThe Class: {t1.tclass}\nThe Section: {t1.tsec}");
                            int oldID = t1.ID;
                            Console.WriteLine("Please Enter new teacher ID");
                            int newID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enter new teacher Name ");
                            string new_tname = Console.ReadLine();
                            Console.WriteLine("Please Enter new teacher Class");
                            string new_tclass = Console.ReadLine();
                            Console.WriteLine("Please Enter new teacher Section");
                            string new_tsec = Console.ReadLine();
                            SI.update(oldID, newID, new_tname,new_tclass, new_tsec);
                        }
                        else
                        {
                            Console.WriteLine("Can not foun any data in this id " + SearchID);
                        }
                        break;
                    case 4:
                        status = false;
                        break;
                    default:
                        Console.WriteLine("Plase choose a correct choise!! ");
                        
                        break;

                }
            }
        }
    }
}
