using System;
using System.Diagnostics;

namespace TestLoader.Classes
{
	// Token: 0x0200000A RID: 10
	public class ProcessKiller
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000024AC File Offset: 0x000006AC
		public static void Kill(Process process)
		{
			process.Kill();
		}
	}
}
