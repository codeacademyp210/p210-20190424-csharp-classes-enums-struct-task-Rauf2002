using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin :");
            Student std1 = new Student();
            std1.stdName = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin :");
            std1.stdSurname = Console.ReadLine();
            Console.WriteLine("Qrupunuzu daxil edin :");

            std1.grp_name = Console.ReadLine();


            Console.WriteLine("Salam {0} {1}. Qrupunuz : {2} ", std1.stdName, std1.stdSurname,std1.grp_name);

            Console.ReadLine();
        }

        class Group
        {
            public static string GroupName;
            public string GetGroup()
            {
                return GroupName;
            }
        }

        class Student
        {
            public string stdName { get; set; }
            public string stdSurname { get; set; }

            string stdGroup = Group.GroupName;
            public string grp_name
            {
                get
                {
                    return stdGroup;
                }
                set
                {
                    stdGroup = value;
                }
            }
        }
    }
}
