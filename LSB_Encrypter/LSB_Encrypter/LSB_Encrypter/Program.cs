using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LSB_Encrypter
{
	public static class world
	{
		public static string foo { get; set; }
		public static bool infoo = false;
	}
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
