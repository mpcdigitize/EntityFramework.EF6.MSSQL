﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.EF6.MSSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // string fullPath = @"H:\My Documents\Visual Studio 2015\Projects\EntityFramework.EF6.MSSQL\EntityFramework.EF6.MSSQL\App_Data";


            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relative = @"..\..\App_Data\";
            string absolute = Path.GetFullPath(Path.Combine(baseDirectory, relative));
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);


            //string fullPath = 
            //AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);

            Console.WriteLine(absolute);

            using (var ctx = new SchoolContext())
            {
                
             
              //  Console.ReadLine();

                Student stud = new Student() { StudentName = "New Student" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
