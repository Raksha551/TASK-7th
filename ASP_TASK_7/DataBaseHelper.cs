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
                frontenddt.Columns.Add("01-01-2024", typeof(string));
                frontenddt.Columns.Add("02-01-2024", typeof(string));
                frontenddt.Columns.Add("03-01-2024", typeof(string));
                frontenddt.Columns.Add("04-01-2024", typeof(string));
                frontenddt.Columns.Add("05-01-2024", typeof(string));
                frontenddt.Columns.Add("06-01-2024", typeof(string));
                frontenddt.Columns.Add("07-01-2024", typeof(string));
                frontenddt.Columns.Add("08-01-2024", typeof(string));
                frontenddt.Columns.Add("09-01-2024", typeof(string));
                frontenddt.Columns.Add("10-01-2024", typeof(string));
                frontenddt.Columns.Add("11-01-2024", typeof(string));
                frontenddt.Columns.Add("12-01-2024", typeof(string));
                frontenddt.Columns.Add("13-01-2024", typeof(string));
                frontenddt.Columns.Add("14-01-2024", typeof(string));
                frontenddt.Columns.Add("15-01-2024", typeof(string));
                frontenddt.Columns.Add("16-01-2024", typeof(string));
                frontenddt.Columns.Add("17-01-2024", typeof(string));
                frontenddt.Columns.Add("18-01-2024", typeof(string));
                frontenddt.Columns.Add("19-01-2024", typeof(string));
                frontenddt.Columns.Add("20-01-2024", typeof(string));
                frontenddt.Columns.Add("21-01-2024", typeof(string));
                frontenddt.Columns.Add("22-01-2024", typeof(string));
                frontenddt.Columns.Add("23-01-2024", typeof(string));
                frontenddt.Columns.Add("24-01-2024", typeof(string));
                frontenddt.Columns.Add("25-01-2024", typeof(string));
                frontenddt.Columns.Add("26-01-2024", typeof(string));
                frontenddt.Columns.Add("27-01-2024", typeof(string));
                frontenddt.Columns.Add("28-01-2024", typeof(string));
                frontenddt.Columns.Add("29-01-2024", typeof(string));
                frontenddt.Columns.Add("30-01-2024", typeof(string));
                frontenddt.Columns.Add("31-01-2024", typeof(string));




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
                approvedt.Rows.Add("09-01-2024");
                approvedt.Rows.Add("10-01-2024");
                approvedt.Rows.Add("11-01-2024");
                approvedt.Rows.Add("12-01-2024");
                approvedt.Rows.Add("13-01-2024");
                approvedt.Rows.Add("14-01-2024");
                approvedt.Rows.Add("15-01-2024");
                approvedt.Rows.Add("16-01-2024");
                approvedt.Rows.Add("17-01-2024");
                approvedt.Rows.Add("18-01-2024");
                approvedt.Rows.Add("19-01-2024");
                approvedt.Rows.Add("20-01-2024");
                approvedt.Rows.Add("21-01-2024");
                approvedt.Rows.Add("22-01-2024");
                approvedt.Rows.Add("23-01-2024");
                approvedt.Rows.Add("24-01-2024");
                approvedt.Rows.Add("25-01-2024");
                approvedt.Rows.Add("26-01-2024");
                approvedt.Rows.Add("27-01-2024");
                approvedt.Rows.Add("28-01-2024");
                approvedt.Rows.Add("29-01-2024");
                approvedt.Rows.Add("30-01-2024");
                approvedt.Rows.Add("31-01-2024");

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