using System;
using System.Management;
using Testloader.Classes;

namespace TestLoader.Classes
{
	// Token: 0x02000008 RID: 8
	public class AutoProcessDetector
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002348 File Offset: 0x00000548
		public static void Start()
		{
			try
			{
				for (;;)
				{
					WqlEventQuery query = new WqlEventQuery("__InstanceCreationEvent", new TimeSpan(0, 0, 1), "TargetInstance isa \"Win32_Process\"");
					ProcessFinder.FindByHash(Utils.HashList);
					ManagementBaseObject managementBaseObject = new ManagementEventWatcher
					{
						Query = query,
						Options = 
						{
							Timeout = new TimeSpan(10, 0, 0)
						}
					}.WaitForNextEvent();
					Console.WriteLine("{0} task has been started, way: {1}", ((ManagementBaseObject)managementBaseObject["TargetInstance"])["Name"], ((ManagementBaseObject)managementBaseObject["TargetInstance"])["ExecutablePath"]);
					ProcessFinder.FindByHash(Utils.HashList);
				}
			}
			catch (TimeoutException)
			{
				Console.WriteLine("Zaman aşımı!");
			}
			catch
			{
			}
		}
	}
}
