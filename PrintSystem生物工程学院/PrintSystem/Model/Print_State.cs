//============================================================
// Producnt name:		Auto Generate
// Version: 			1.0
// Coded by:			Wu Di (wd_kk@qq.com)
// Auto generated at: 	2014-07-25 11:49:11
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace PrintSystem
{
	
	[Serializable()]
	public class Print_State
	{
	
		private int ptintID; 
		private string printBH = String.Empty;
		private string printState = String.Empty;
		private int printTimes;

		
		public Print_State() { }
		
		
		public int PtintID
		{
			get { return this.ptintID; }
			set { this.ptintID = value; }
		}
		
        
		
		
		
		public string PrintBH
		{
			get { return this.printBH; }
			set { this.printBH = value; }
		}		
		
		
		public string PrintState
		{
			get { return this.printState; }
			set { this.printState = value; }
		}		
		
		
		public int PrintTimes
		{
			get { return this.printTimes; }
			set { this.printTimes = value; }
		}		
		
	}
}
