//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Drawing;
//using Spire.Xls;


//namespace Project1
//{
//    class Class2
//    {



//        static void Main(string[] args)
//        {


//            //Create a workbook

//            Workbook workbook = new Workbook();



//            //Initialize the worksheet

//            Worksheet sheet = workbook.Worksheets[0];



//            //Specify the version

//            workbook.Version = ExcelVersion.Version2007;



//            //Define the number of the colors

//            int maxColor = Enum.GetValues(typeof(ExcelColors)).Length;



//            //Create a random object

//            Random random = new Random((int)System.DateTime.Now.Ticks);



//            for (int i = 2; i < 40; i++)
//            {

//                //Random backKnownColor

//                ExcelColors backKnownColor = (ExcelColors)(random.Next(1, maxColor / 2));

//                sheet.Range["A1"].Text = "Color Name";

//                sheet.Range["B1"].Text = "Red";

//                sheet.Range["C1"].Text = "Green";

//                sheet.Range["D1"].Text = "Blue";



//                //Merge the sheet"E1-K1"

//                sheet.Range["E1:K1"].Merge();

//                sheet.Range["E1:K1"].Text = "Gradient";

//                sheet.Range["A1:K1"].Style.Font.IsBold = true;

//                sheet.Range["A1:K1"].Style.Font.Size = 11;



//                //Set the text of color in sheetA-sheetD

//                string colorName = backKnownColor.ToString();

//                sheet.Range[string.Format("A{0}", i)].Text = colorName;

//                sheet.Range[string.Format("B{0}", i)].Text = workbook.GetPaletteColor(backKnownColor).R.ToString();

//                sheet.Range[string.Format("C{0}", i)].Text = workbook.GetPaletteColor(backKnownColor).G.ToString();

//                sheet.Range[string.Format("D{0}", i)].Text = workbook.GetPaletteColor(backKnownColor).B.ToString();



//                //Merge the sheets

//                sheet.Range[string.Format("E{0}:K{0}", i)].Merge();



//                //Set the text of sheetE-sheetK

//                sheet.Range[string.Format("E{0}:K{0}", i)].Text = colorName;



//                //Set the interior of the color

//                sheet.Range[string.Format("E{0}:K{0}", i)].Style.Interior.FillPattern = ExcelPatternType.Gradient;

//                sheet.Range[string.Format("E{0}:K{0}", i)].Style.Interior.Gradient.BackKnownColor = backKnownColor;

//                sheet.Range[string.Format("E{0}:K{0}", i)].Style.Interior.Gradient.ForeKnownColor = ExcelColors.White;

//                sheet.Range[string.Format("E{0}:K{0}", i)].Style.Interior.Gradient.GradientStyle = GradientStyleType.Vertical;

//                sheet.Range[string.Format("E{0}:K{0}", i)].Style.Interior.Gradient.GradientVariant = GradientVariantsType.ShadingVariants1;

//            }



//            //AutoFit Column

//            sheet.AutoFitColumn(1);



//            //Save the file

//            workbook.SaveToFile("Sample.xls");



//            //Launch the file

//            System.Diagnostics.Process.Start("Sample.xls");

//        }


//    }
//}
