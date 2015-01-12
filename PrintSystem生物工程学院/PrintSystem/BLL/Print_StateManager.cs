//============================================================
// Producnt name:		Auto Generate
// Version: 			1.0
// Coded by:			Wu Di (wd_kk@qq.com)
// Auto generated at: 	2014-07-25 11:49:13
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data; 

namespace  PrintSystem
{

    public static partial class Print_StateManager
    {
        public static Print_State AddPrint_State(Print_State print_State)
        {
            return Print_StateService.AddPrint_State(print_State);
        }

        public static bool DeletePrint_State(Print_State print_State)
        {
            return Print_StateService.DeletePrint_State(print_State);
        }

        public static bool DeletePrint_StateByID(int ptintID)
        {
            return Print_StateService.DeletePrint_StateByPtintID(ptintID);
        }

		public static bool ModifyPrint_State(Print_State print_State)
        {
            return Print_StateService.ModifyPrint_State(print_State);
        }
        
        public static DataTable GetAllPrint_State()
        {
            return Print_StateService.GetAllPrint_State();
        }

        public static Print_State GetPrint_StateByPtintID(int ptintID)
        {
            return Print_StateService.GetPrint_StateByPtintID(ptintID);
        }

    }
}
