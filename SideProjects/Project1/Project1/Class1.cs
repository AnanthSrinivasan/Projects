using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Spire.License.V1_2;
using Spire.Xls;
using Spire.Pdf;

namespace Project1
{
    class Class1
    {
        private static int itr = 1;
        private static int counter = 1;


        static void Main(string[] args)
        {
            //Load File and Initialize Worksheet
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"C:\Users\amanoharan\Documents\Visual Studio 2010\Projects\Project1\xls_files\employee.xlsx");
            Worksheet employee_sheet = workbook.Worksheets[0];
            Worksheet emp_qual_sheet = workbook.Worksheets[1];

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            Random gen = new Random();
            var rand_num = new Random();
            string[] dept_names = { "DEV", "QA", "RM", "DBA", "HR", "ADM", "ENG", "NT", "TECH", "ELEC" };

            //Employee sheet
            for (int i = 2; i < 10; i++)
            {
                var emp_name = new string(
                    Enumerable.Repeat(chars, 8)
                              .Select(s => s[random.Next(s.Length)])
                              .ToArray());

                int range = ((System.TimeSpan)(DateTime.Today - start)).Days;
                DateTime rand_date = start.AddDays(gen.Next(range));

                var emp_dept = dept_names[new Random().Next(0, dept_names.Length)];

                employee_sheet.Range[string.Format("A{0}", i)].Value = (i - 1).ToString();
                employee_sheet.Range[string.Format("B{0}", i)].Value = emp_name;
                employee_sheet.Range[string.Format("C{0}", i)].Value = (0).ToString();
                employee_sheet.Range[string.Format("E{0}", i)].Value = rand_date.ToString();
                employee_sheet.Range[string.Format("D{0}", i)].Value = rand_num.Next(40000, 90000).ToString();
                employee_sheet.Range[string.Format("F{0}", i)].Value = rand_num.Next(1, 10).ToString();
                employee_sheet.Range[string.Format("G{0}", i)].Value = emp_dept;
                employee_sheet.Range[string.Format("H{0}", i)].Value = emp_name + "@paypal.com";

                if (i > 11)
                {
                    employee_sheet.Range[string.Format("C{0}", i)].Value = rand_num.Next(1, 10).ToString();
                }

                //Emp - Qual sheet
                    emp_qual_sheet.Range[string.Format("A{0}", itr)].Value = (counter).ToString();
                    emp_qual_sheet.Range[string.Format("A{0}", itr + 1)].Value = (counter).ToString();
                    emp_qual_sheet.Range[string.Format("A{0}", itr + 2)].Value = (counter).ToString();

                    emp_qual_sheet.Range[string.Format("B{0}", itr)].Value = get_random_number_from_array().ToString();
                    emp_qual_sheet.Range[string.Format("B{0}", itr + 1)].Value = get_random_number_from_array().ToString();
                    emp_qual_sheet.Range[string.Format("B{0}", itr + 2)].Value = get_random_number_from_array().ToString();

                    //emp_qual_sheet.Range[string.Format("C{0}", itr)].Value = rand_date.ToString();
                    //emp_qual_sheet.Range[string.Format("D{0}", itr)].Value = rand_date.ToString();

                itr = itr + 3;
                counter++;
            }


            //Save and Launch File
            workbook.SaveToFile(@"C:\Users\amanoharan\Documents\Visual Studio 2010\Projects\Project1\xls_files\employee.xlsx", ExcelVersion.Version2010);
            System.Diagnostics.Process.Start(workbook.FileName);

        }

        static public int get_random_number_from_array()
        {
            int[] quals = {504, 131, 919, 309, 832, 633, 646, 631, 711, 507, 381, 898, 910, 267, 494, 416, 525, 565, 522, 905 };
            int[] a = new int[20];
            int[] b = new int[20];

            //int no = 0;
            //int count = quals.Length;
            Random RandomNumber = new Random();

            int mynum = quals[RandomNumber.Next(quals.Length)];

            return mynum;
        }
    }
}



            ////Insert Blank Column
            //employee_sheet.InsertColumn(1);

            ////Insert Column with Copying Data from Other Columns
            //employee_sheet.InsertColumn(7, 2);
            //employee_sheet.Copy(employee_sheet.Range["D1:E21"], employee_sheet.Range["G1:H21"], true);

            ////Set Style for New Columns
            //employee_sheet.Range["G1:H21"].Style.Font.IsBold = true;
            //employee_sheet.Range["G1:H21"].Style.Color = Color.LightCyan;

//Set Style for New Rows
//employee_sheet.Range["A6:G16"].Style.Color = Color.LightCyan;
//employee_sheet.Range["A6:G16"].Style.Font.IsBold = true;
