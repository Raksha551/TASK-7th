using Evaluation2_Screens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP_TASK_7
{
    public class DataBaseHelper
    {
        public class columnNames_DB
        {
            public string CheckpointID { get; set; }
            public string CheckpointItem { get; set; } = string.Empty;
            public string Requirement { get; set; }
            public string Method { get; set; }
            public List<childClass> innerlistviewdata { get; set; } = new List<childClass>();
            public string Instrument { get; set; }
            public string ActionPlan { get; set; }
           
            public int tdColSpan { get; set; } = 1;
            public int RowSpan { get; set; } = 1;
            public bool tdVisible { get; set; } = true;
            public bool IsHeaderRow { get; set; } = true;
            
        }

        public class childClass
        {
            public string dynamic_dates { get; set; }          
            public int tdColSpan { get; set; } = 1;
            public bool tdVisible { get; set; } = true;
            public int rowspan { get; set; } = 1;
        }
        public class MonthYear
        {
            public static int selectedMonth { get; set; }
            public static int selectedYear { get; set; }
        }
        DataTable frontenddt = new DataTable("Output1");
        DataTable approvedt = new DataTable("Output2");
        DataTable calendardt = new DataTable("Output3");
        public DataTable frontEndTable()
        {
            try
            {

                // Add columns to the DataTable
                frontenddt.Columns.Add("CheckpointID", typeof(int));
                frontenddt.Columns.Add("CheckpointItem", typeof(string));
                frontenddt.Columns.Add("Requirement", typeof(string));

                frontenddt.Columns.Add("Method", typeof(string));
                frontenddt.Columns.Add("Instrument", typeof(string));
                frontenddt.Columns.Add("ActionPlan", typeof(string));
              

                int DaysInMonth = DateTime.DaysInMonth(MonthYear.selectedYear,MonthYear.selectedMonth);
                for(int day=1; day <= DaysInMonth; day++)
                {
                    string columnName = new DateTime(MonthYear.selectedYear, MonthYear.selectedMonth, day).ToString("dd-MM-yyyy");
                    frontenddt.Columns.Add(columnName, typeof(string));
                }

                // Add rows to the DataTable
                frontenddt.Rows.Add(1, "General Cleanliness", "M/C should be free from Dirt", "hello.png", "bolt.png", "cleaning","OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(2, "Check for oil leakage", "It should be free from leakage", "eye.png", "handkerchief.png", "Tightening", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(3, "General Cleanliness", "M/C should be free from Dirt", "hello.png", "bolt.png", "cleaning", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(4, "Check for oil leakage", "It should be free from leakage", "eye.png", "handkerchief.png", "Tightening", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(5, "General Cleanliness", "M/C should be free from Dirt", "hello.png", "bolt.png", "cleaning", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(6, "Check for oil leakage", "It should be free from leakage", "eye.png", "handkerchief.png", "Tightening", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(7, "General Cleanliness", "M/C should be free from Dirt", "hello.png", "bolt.png", "cleaning", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(8, "Check for oil leakage", "It should be free from leakage", "eye.png", "handkerchief.png", "Tightening", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(9, "General Cleanliness", "M/C should be free from Dirt", "hello.png", "bolt.png", "cleaning", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
                frontenddt.Rows.Add(10, "Check for oil leakage", "It should be free from leakage", "eye.png", "handkerchief.png", "Tightening", "OK", "OK", "OK", "OK", "OK", "OK", "OK", "OK");
              
                // Print the DataTable contents
                foreach (DataRow row in frontenddt.Rows)
                {
                    Console.WriteLine("EmployeeID: {0}, FirstName: {1}, LastName: {2}, Department: {3}",
                                      row["EmployeeID"], row["FirstName"], row["LastName"], row["Department"]);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorLog("frontEndTable : " + ex.Message);
            }
            return frontenddt;
        }
        public DataTable approvalTable()
        {
            try
            {

                // Add columns to the DataTable
                approvedt.Columns.Add("Date", typeof(DateTime));
                approvedt.Columns.Add("OperatorID", typeof(string));
                approvedt.Columns.Add("OperatorTS", typeof(DateTime));
                approvedt.Columns.Add("SupervisorID", typeof(string));
                approvedt.Columns.Add("SupervisorTS", typeof(DateTime));
              

                // Add rows to the DataTable
                approvedt.Rows.Add( "01-01-2024", "OP01", "01-01-2024 03:12:22", "SP01", "01-01-2024 03:12:22");
                approvedt.Rows.Add( "02-01-2024", "OP02", "02-01-2024 02:12:22", "SP02", "02-01-2024 05:12:22");
                approvedt.Rows.Add( "03-01-2024", "OP03", "03-01-2024 09:12:22", "SP03", "03-01-2024 04:12:22");
                approvedt.Rows.Add( "04-01-2024", "OP04", "04-01-2024 11:12:22", "SP04", "04-01-2024 06:12:22");
                approvedt.Rows.Add( "05-01-2024", "OP05", "05-01-2024 07:12:22", "SP05", "05-01-2024 03:12:22");
                approvedt.Rows.Add("06-01-2024", "OP01", "01-01-2024 03:12:22", "SP06", "06-01-2024 03:12:22");
                approvedt.Rows.Add("07-01-2024", "OP02", "02-01-2024 02:12:22", "SP07", "07-01-2024 05:12:22");
                approvedt.Rows.Add("08-01-2024", "OP03", "03-01-2024 09:12:22", "SP08", "08-01-2024 04:12:22");
             
                // Print the DataTable contents
                foreach (DataRow row in frontenddt.Rows)
                {
                   
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorLog("approvalTable : " + ex.Message);
            }
            return approvedt;
        }

        public DataTable calendartable()
        {
            try
            {

                // Add columns to the DataTable
                calendardt.Columns.Add("Date", typeof(DateTime));
                calendardt.Columns.Add("Reason", typeof(string));



                // Add rows to the DataTable
                calendardt.Rows.Add("05-01-2024", "SUNDAY");
                calendardt.Rows.Add("12-01-2024", "SUNDAY");
                calendardt.Rows.Add("14-01-2024", "FESTIVAL");
                calendardt.Rows.Add("19-01-2024", "SUNDAY");
                calendardt.Rows.Add("26-01-2024", "SUNDAY");



                // Print the DataTable contents
                foreach (DataRow row in frontenddt.Rows)
                {
                   
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorLog("calendartable : " + ex.Message);
            }
            return calendardt;

        }
    }

  
    
}
