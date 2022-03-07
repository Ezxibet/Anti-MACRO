using System;
using System.IO;
using System.Security.Cryptography;

namespace TestLoader.Classes
{
	// Token: 0x02000009 RID: 9
	public class CalculateMD5
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0000242C File Offset: 0x0000062C
		public static string Calculate(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}
	}
}
