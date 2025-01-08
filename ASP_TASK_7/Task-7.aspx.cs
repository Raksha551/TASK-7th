using Evaluation2_Screens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ASP_TASK_7.DataBaseHelper;
using Newtonsoft.Json;
namespace ASP_TASK_7
{
    public partial class Task_7 : System.Web.UI.Page
    { 
        DataBaseHelper db=new DataBaseHelper();
        DataTable dt_frontend=new DataTable();
        DataTable dt_calendar = new DataTable();
        DataTable dt_approve = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
               
            }
        }

     public void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
              
                dt_frontend = db.frontEndTable();
                dt_calendar = db.calendartable();
                dt_approve = db.approvalTable();

                int selectedYear = Convert.ToInt32(year.Text); 
                int selectedMonth = Convert.ToInt32(month.Text);
                int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);  
                bool isLeapYear = DateTime.IsLeapYear(selectedYear);

                List<DataBaseHelper.columnNames_DB> list = new List<DataBaseHelper.columnNames_DB>();

                if (dt_frontend != null && dt_frontend.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt_frontend.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                           
                            DataBaseHelper.columnNames_DB Row1 = new DataBaseHelper.columnNames_DB
                            {
                                CheckpointID = "Sl No.",
                                CheckpointItem = "Checkpoint Desc.",
                                Requirement = "Requirement",
                                Method = "Method", // Static name for Method
                                Instrument = "Instruments", 
                                ActionPlan = "Action Plan",
                                RowSpan = 2,
                                tdVisible = true,
                                IsHeaderRow = true
                            };

                            List<DataBaseHelper.childClass> dynValues_Row1 = new List<DataBaseHelper.childClass>();
                            for (int day = 1; day <= daysInMonth; day++)
                            {
                                dynValues_Row1.Add(new DataBaseHelper.childClass { dynamic_dates = "" }); // Blank for first row
                            }
                            Row1.innerlistviewdata = dynValues_Row1;
                            list.Add(Row1);

                            // Row 2: Dynamic Date Headers
                            DataBaseHelper.columnNames_DB Row2 = new DataBaseHelper.columnNames_DB
                            {
                                tdVisible = false,
                                IsHeaderRow = true 
                            };

                            List<DataBaseHelper.childClass> dynValues_Row2 = new List<DataBaseHelper.childClass>();
                            for (int day = 1; day <= daysInMonth; day++)
                            {
                                dynValues_Row2.Add(new DataBaseHelper.childClass
                                {
                                    dynamic_dates = day.ToString() 
                                });
                            }
                            Row2.innerlistviewdata = dynValues_Row2;
                            list.Add(Row2);
                        }
                        else
                        {
                            // Data rows
                            DataBaseHelper.columnNames_DB Data = new DataBaseHelper.columnNames_DB
                            {
                                CheckpointID = dt_frontend.Rows[i - 1]["CheckpointID"].ToString(),
                                CheckpointItem = dt_frontend.Rows[i - 1]["CheckpointItem"].ToString(),
                                Requirement = dt_frontend.Rows[i - 1]["Requirement"].ToString(),
                                Method = "./DataImages/" + dt_frontend.Rows[i - 1]["Method"].ToString(),
                                Instrument = "./DataImages/" + dt_frontend.Rows[i - 1]["Instrument"].ToString(),
                                ActionPlan = dt_frontend.Rows[i - 1]["ActionPlan"].ToString(),
                                IsHeaderRow = false // Indicate it's a data row
                            };

                            List<DataBaseHelper.childClass> dynValues = new List<DataBaseHelper.childClass>();
                            for (int j = 6; j < dt_frontend.Columns.Count; j++)
                            {
                                string columnName = dt_frontend.Columns[j].ColumnName;
                                string dateValue = Convert.ToDateTime(columnName).ToString("dd-MM-yyyy");

                                string calendarValue = "";  
                                bool isDateMatched = false;

                                
                                foreach (DataRow row in dt_calendar.Rows)
                                {
                                    string calendarDate = Convert.ToDateTime(row["Date"]).ToString("dd-MM-yyyy");
                                    if (calendarDate == dateValue)
                                    {
                                        calendarValue = row["Reason"].ToString();  
                                        isDateMatched = true;
                                        break;
                                    }
                                }
                                if (isDateMatched)
                                {
                                   
                                        dynValues.Add(new DataBaseHelper.childClass
                                        {
                                            dynamic_dates = calendarValue,  // Set "SUNDAY" or "FESTIVAL"
                                           // rowspan = 10,
                                            tdVisible = true
                                        });
                                    
                                  
                                      
                                    
                                }
                                else
                                {
                                    dynValues.Add(new DataBaseHelper.childClass
                                    {
                                        dynamic_dates = dt_frontend.Rows[i - 1][j].ToString()
                                    });
                                }
                            }

                            Data.innerlistviewdata = dynValues;
                            list.Add(Data);
                        }

                    }
                    DataBaseHelper.columnNames_DB operatorRow = new DataBaseHelper.columnNames_DB
                    {
                        CheckpointID = "Checked by sign",
                        CheckpointItem = "", 
                        Requirement = "",
                        Method = "",
                        Instrument = "",
                        ActionPlan = "",
                        IsHeaderRow = false,
                        tdVisible = true,
                        tdColSpan = 6 
                    };

                    List<DataBaseHelper.childClass> operatorIdValues = new List<DataBaseHelper.childClass>();

                    for (int j = 6; j < dt_frontend.Columns.Count; j++)
                    {
                        string columnName = dt_frontend.Columns[j].ColumnName; 
                        string operatorID = null;

                       
                        DataRow calendarRow = dt_calendar.AsEnumerable()
                            .FirstOrDefault(row => Convert.ToDateTime(row["Date"]).ToString("dd-MM-yyyy") == columnName);

                        if (calendarRow != null)
                        {
                            // Replace with the reason (SUNDAY/FESTIVAL) if a match is found
                            operatorID = calendarRow["Reason"].ToString();
                        }
                        else
                        {
                            
                            DataRow approvalRow = dt_approve.AsEnumerable()
                                .FirstOrDefault(row => Convert.ToDateTime(row["Date"]).ToString("dd-MM-yyyy") == columnName);

                            if (approvalRow != null)
                            {
                                operatorID = approvalRow["OperatorID"].ToString();
                            }
                        }

                       
                        operatorIdValues.Add(new DataBaseHelper.childClass
                        {
                            dynamic_dates = operatorID ?? " " 
                        });
                    }

                    operatorRow.innerlistviewdata = operatorIdValues;
                    list.Add(operatorRow);


                  
                    DataBaseHelper.columnNames_DB buttonRow = new DataBaseHelper.columnNames_DB
                    {
                        CheckpointID = "Verified by sign",
                        CheckpointItem = "", 
                        Requirement = "",
                        Method = "",
                        Instrument = "",
                        ActionPlan = "",
                        IsHeaderRow = false,
                        tdVisible = true,
                        tdColSpan = 6
                    };

                  

                    List<DataBaseHelper.childClass> buttonValues = new List<DataBaseHelper.childClass>();

                    for (int j = 6; j < dt_frontend.Columns.Count; j++)
                    {
                        string columnName = dt_frontend.Columns[j].ColumnName;
                        string displayValue = null;


                        DataRow calendarRow = dt_calendar.AsEnumerable()
                            .FirstOrDefault(row => Convert.ToDateTime(row["Date"]).ToString("dd-MM-yyyy") == columnName);

                        if (calendarRow != null)
                        {                           
                            displayValue = calendarRow["Reason"].ToString();
                        }
                        else
                        {
                           
                            DataRow approvalRow = dt_approve.AsEnumerable()
                                .FirstOrDefault(row => Convert.ToDateTime(row["Date"]).ToString("dd-MM-yyyy") == columnName);

                            if (approvalRow != null)
                            {
                                string operatorID = approvalRow["OperatorID"].ToString();
                                displayValue = $"<button id='{columnName}' style='width:100%; height:45px;color:white;background-color:deepskyblue;' onclick='handleButtonClick(this)'>Approved</button>";
                            }
                        }
               
                        buttonValues.Add(new DataBaseHelper.childClass
                        {
                            dynamic_dates = displayValue ?? "" 
                        });
                    }

                    buttonRow.innerlistviewdata = buttonValues;
                    list.Add(buttonRow);


                    // Bind to ListView
                    listview1.DataSource = list;
                    listview1.DataBind();
                }

            }


            catch (Exception ex)
            {
                Logger.WriteErrorLog(ex);
            }
        }

    }
}