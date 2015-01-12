using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Common;

namespace PrintSystem
{
    public class Print_StateLogic
    {

        public static int GetIDByBH(string KPBH)
        {
            DataTable dt = new DataTable();
            int t = 0;
            try
            {
                string sqlStr = "select PtintID from  dbo.Print_State where PrintBH='{0}'";
                sqlStr = string.Format(sqlStr, KPBH);
                t = common.IntSafeConvert(DBUnity.ExecuteScalar(CommandType.Text, sqlStr, null));
            }
            catch (Exception ex)
            {
                
            }
            return t;
        }
    }
}
