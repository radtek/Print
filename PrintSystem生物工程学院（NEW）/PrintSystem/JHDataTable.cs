using System;
using System.Collections.Generic;
using System.Data; 

namespace PrintSystem
{
    public class JHDataTable
    {

        public static DataTable JHDataTableBydwbmdep(string dwbm, string depcode)
        {
            DataTable dt = null;
            string sql = string.Format("select *  from View_BasAsset4 where DWBM ='{0}' and SYGLBM='{1}' ORDER BY RZRQ DESC ", dwbm, depcode);
            dt = DBUnity.AdapterToTab(sql);
            return dt;
        }


        public static DataTable JHAllDataTableByDWBM(string re, string dwbm)
        {
            DataTable dt = null;
            string sql = String.Format("select *  from View_BasAsset4 where (KPBH in ({0})) and DWBM='{1}'", re, dwbm);
            dt = DBUnity.AdapterToTab(sql);
            return dt;
        }

        public static DataTable JHDataTableBystrdwbm(string listassid, string tt, string dwbm)
        {
            DataTable dt = null;
            string sql = string.Format("select *  from View_BasAsset4 where  DWBM='{2}' and KPBH in ({0}) and MC='{1}'", listassid, tt, dwbm);
            dt = DBUnity.AdapterToTab(sql);
            return dt;
        }

        public static DataTable GetDepDt(string dwbm)
        {
            string sql = string.Format("select VCDEPTCODE as DepID,VCDEPTNAME as DepName from BASDEPTCODE where UNITCODE='{0}' and  VCDEPTNAME!='系统维护部'", dwbm);
            DataTable dt = DBUnity.AdapterToTab(sql);
            return dt;
        }

        public static DataTable JHViewdataBydwbm(string dwbm)
        {
            string str = string.Format("select *  from View_BasAsset4 where  DWBM='{0}'", dwbm);
            DataTable dt = DBUnity.AdapterToTab(str);
            return dt;
        }

        public static string GETCFDDNAMEBYCODE(string dwbm, string code)
        {
            string ss = "";
            string str = "select BLNAME from BasLocationCode where ORGANCODE='{0}' and BLCODE={1}";
            string sql = string.Format(str, dwbm, code);
            ss = DBUnity.ExecuteScalar(CommandType.Text, sql, null);
            return ss;
        }

        public static string GetDWMC(string dwbm)
        {
            string str = string.Format("select Unitname  from UNIT where  Unitcode='{0}'", dwbm);
            string swmc = DBUnity.ExecuteScalar(CommandType.Text, str, null);
            return swmc;
        }
    }

}

