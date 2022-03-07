using System;
using System.Windows.Forms;

namespace TestLoader
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000022E8 File Offset: 0x000004E8
		[STAThread]
		private static void Main(string[] args)
		{
			foreach (string a in args)
			{
				bool flag = a != "-79952";
				bool flag2 = flag;
				if (flag2)
				{
					Environment.Exit(0);
					Application.Exit();
					break;
				}
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Loader());
			}
		}
	}
}
