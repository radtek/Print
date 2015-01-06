//============================================================
// Producnt name:		Auto Generate
// Version: 			1.0
// Coded by:			Wu Di (wd_kk@qq.com)
// Auto generated at: 	2014-07-25 11:49:12
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; 

namespace PrintSystem
{
	public static partial class Print_StateService
	{
        public static Print_State AddPrint_State(Print_State print_State)
		{
            string sql =
				"INSERT Print_State (PrintBH, PrintState, PrintTimes)" +
				"VALUES (@PrintBH, @PrintState, @PrintTimes)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@PrintBH", print_State.PrintBH),
					new SqlParameter("@PrintState", print_State.PrintState),
					new SqlParameter("@PrintTimes", print_State.PrintTimes)
				};
			
                string IdStr = DBUnity.ExecuteScalar(CommandType.Text, sql, para);
                int newId = Convert.ToInt32(IdStr);
                return GetPrint_StateByPtintID(newId);

            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static bool DeletePrint_State(Print_State print_State)
		{
			return DeletePrint_StateByPtintID( print_State.PtintID );
		}

        public static bool DeletePrint_StateByPtintID(int ptintID)
		{
            string sql = "DELETE Print_State WHERE PtintID = @PtintID";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@PtintID", ptintID)
				};
			
                int t = DBUnity.ExecuteNonQuery(CommandType.Text, sql, para);
                
                if(t>0)
                {
                    return true;
                }
                else
                {
                    return false;    
                }
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
					


        public static bool ModifyPrint_State(Print_State print_State)
        {
            string sql =
                "UPDATE Print_State " +
                "SET " +
	                "PrintBH = @PrintBH, " +
	                "PrintState = @PrintState, " +
	                "PrintTimes = @PrintTimes " +
                "WHERE PtintID = @PtintID";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@PtintID", print_State.PtintID),
					new SqlParameter("@PrintBH", print_State.PrintBH),
					new SqlParameter("@PrintState", print_State.PrintState),
					new SqlParameter("@PrintTimes", print_State.PrintTimes)
				};

                int t = DBUnity.ExecuteNonQuery(CommandType.Text, sql, para);
                if(t>0)
                {
                    return true;
                }
                else
                {
                    return false;    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		


        public static DataTable GetAllPrint_State()
        {
            string sqlAll = "SELECT * FROM Print_State";
			return GetPrint_StateBySql( sqlAll );
        }
		

        public static Print_State GetPrint_StateByPtintID(int ptintID)
        {
            string sql = "SELECT * FROM Print_State WHERE PtintID = @PtintID";

            try
            {
                SqlParameter para = new SqlParameter("@PtintID", ptintID);
                DataTable dt = DBUnity.AdapterToTab(sql, para);
                
                if(dt.Rows.Count > 0)
                {
                    Print_State print_State = new Print_State();

                    print_State.PtintID = dt.Rows[0]["PtintID"] == DBNull.Value ? 0 : (int)dt.Rows[0]["PtintID"];
                    print_State.PrintBH = dt.Rows[0]["PrintBH"] == DBNull.Value ? "" : (string)dt.Rows[0]["PrintBH"];
                    print_State.PrintState = dt.Rows[0]["PrintState"] == DBNull.Value ? "" : (string)dt.Rows[0]["PrintState"];
                    print_State.PrintTimes = dt.Rows[0]["PrintTimes"] == DBNull.Value ? 0 : (int)dt.Rows[0]["PrintTimes"];
                    
                    return print_State;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
	

      

        private static DataTable GetPrint_StateBySql(string safeSql)
        {

			try
			{
				DataTable dt = DBUnity.AdapterToTab(safeSql);
                return dt;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static DataTable GetPrint_StateBySql(string sql, params SqlParameter[] values)
        {

			try
			{
				DataTable dt = DBUnity.AdapterToTab(sql, values);
                return dt;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
			
        }
		
	}
}
