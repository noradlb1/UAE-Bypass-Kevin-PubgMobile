using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace ns0
{
	// Token: 0x0200000C RID: 12
	public static class GClass6
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000802C File Offset: 0x0000622C
		public static string smethod_0(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			foreach (byte b in byte_0)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00008074 File Offset: 0x00006274
		public static byte[] smethod_1(string string_0)
		{
			byte[] result;
			try
			{
				int length = string_0.Length;
				byte[] array = new byte[length / 2];
				for (int i = 0; i < length; i += 2)
				{
					array[i / 2] = Convert.ToByte(string_0.Substring(i, 2), 16);
				}
				result = array;
			}
			catch
			{
				Console.WriteLine("\n\n  The session has ended, open program again.");
				Thread.Sleep(3500);
				Environment.Exit(0);
				result = Class43.byte_0;
			}
			return result;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000080EC File Offset: 0x000062EC
		public static string smethod_2(string string_0, byte[] byte_0, byte[] byte_1)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = byte_0;
			aes.IV = byte_1;
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateEncryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						byte[] bytes = Encoding.Default.GetBytes(string_0);
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.FlushFinalBlock();
						byte[] byte_2 = memoryStream.ToArray();
						result = GClass6.smethod_0(byte_2);
					}
				}
			}
			return result;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000081A8 File Offset: 0x000063A8
		public static string smethod_3(string string_0, byte[] byte_0, byte[] byte_1)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = byte_0;
			aes.IV = byte_1;
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateDecryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						byte[] array = GClass6.smethod_1(string_0);
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.FlushFinalBlock();
						byte[] array2 = memoryStream.ToArray();
						@string = Encoding.Default.GetString(array2, 0, array2.Length);
					}
				}
			}
			return @string;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00008268 File Offset: 0x00006468
		public static string smethod_4()
		{
			return Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-", StringComparison.Ordinal));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000233F File Offset: 0x0000053F
		public static string smethod_5(string string_0)
		{
			return GClass6.smethod_0(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(string_0)));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000082B0 File Offset: 0x000064B0
		public static string smethod_6(string string_0, string string_1, string string_2)
		{
			byte[] bytes = Encoding.Default.GetBytes(GClass6.smethod_0(string_1).Substring(0, 32));
			byte[] bytes2 = Encoding.Default.GetBytes(GClass6.smethod_0(string_2).Substring(0, 16));
			return GClass6.smethod_2(string_0, bytes, bytes2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000082FC File Offset: 0x000064FC
		public static string smethod_7(string string_0, string string_1, string string_2)
		{
			byte[] bytes = Encoding.Default.GetBytes(GClass6.smethod_0(string_1).Substring(0, 32));
			byte[] bytes2 = Encoding.Default.GetBytes(GClass6.smethod_0(string_2).Substring(0, 16));
			return GClass6.smethod_3(string_0, bytes, bytes2);
		}
	}
}
