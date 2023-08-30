using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x0200003B RID: 59
	internal sealed class Class21
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x0000EDD4 File Offset: 0x0000CFD4
		static Class21()
		{
			Class21.int_0 = int.MaxValue;
			Class21.int_1 = int.MinValue;
			Class21.memoryStream_0 = new MemoryStream(0);
			Class21.memoryStream_1 = new MemoryStream(0);
			Class21.object_0 = new object();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000EE2C File Offset: 0x0000D02C
		private static string smethod_0(Assembly assembly_0)
		{
			string text = assembly_0.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000EE58 File Offset: 0x0000D058
		private static byte[] smethod_1(Assembly assembly_0)
		{
			try
			{
				string fullName = assembly_0.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
				{
					num = fullName.IndexOf("publickeytoken=");
				}
				if (num < 0)
				{
					return Class43.byte_0;
				}
				num += 15;
				if (fullName[num] != 'n')
				{
					if (fullName[num] != 'N')
					{
						string s = fullName.Substring(num, 16);
						long value = long.Parse(s, NumberStyles.HexNumber);
						byte[] bytes = BitConverter.GetBytes(value);
						Array.Reverse(bytes);
						return bytes;
					}
				}
				return Class43.byte_0;
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000EF00 File Offset: 0x0000D100
		internal static byte[] smethod_2(Stream stream_0)
		{
			byte[] result;
			lock (Class21.object_0)
			{
				result = Class21.smethod_4(97L, stream_0);
			}
			return result;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000EF44 File Offset: 0x0000D144
		internal static byte[] smethod_3(long long_0, Stream stream_0)
		{
			byte[] result;
			try
			{
				result = Class21.smethod_2(stream_0);
			}
			catch
			{
				result = Class21.smethod_4(97L, stream_0);
			}
			return result;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000EF80 File Offset: 0x0000D180
		internal static byte[] smethod_4(long long_0, object object_1)
		{
			Stream stream = object_1 as Stream;
			Stream stream2 = stream;
			MemoryStream memoryStream = Class39.memoryStream_0;
			for (int i = 1; i < 4; i++)
			{
				stream.ReadByte();
			}
			ushort num = (ushort)stream.ReadByte();
			num = ~num;
			if ((num & 2) != 0)
			{
				DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = new byte[8];
				stream.Read(array, 0, 8);
				descryptoServiceProvider.IV = array;
				byte[] array2 = new byte[8];
				stream.Read(array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					if (array3[j] != 0)
					{
						flag = false;
						IL_9A:
						if (flag)
						{
							array2 = Class21.smethod_1(Assembly.GetExecutingAssembly());
						}
						descryptoServiceProvider.Key = array2;
						if (Class21.memoryStream_0 == null)
						{
							if (Class21.int_0 == 2147483647)
							{
								Class21.memoryStream_0.Capacity = (int)stream.Length;
							}
							else
							{
								Class21.memoryStream_0.Capacity = Class21.int_0;
							}
						}
						Class21.memoryStream_0.Position = 0L;
						ICryptoTransform cryptoTransform = descryptoServiceProvider.CreateDecryptor();
						int inputBlockSize = cryptoTransform.InputBlockSize;
						int outputBlockSize = cryptoTransform.OutputBlockSize;
						byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
						byte[] array5 = new byte[cryptoTransform.InputBlockSize];
						int num2 = (int)stream.Position;
						while ((long)(num2 + inputBlockSize) < stream.Length)
						{
							stream.Read(array5, 0, inputBlockSize);
							int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
							Class21.memoryStream_0.Write(array4, 0, count);
							num2 += inputBlockSize;
						}
						stream.Read(array5, 0, (int)(stream.Length - (long)num2));
						byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream.Length - (long)num2));
						Class21.memoryStream_0.Write(array6, 0, array6.Length);
						stream2 = Class21.memoryStream_0;
						stream2.Position = 0L;
						memoryStream = Class21.memoryStream_0;
						goto IL_1D5;
					}
				}
				goto IL_9A;
			}
			IL_1D5:
			if ((num & 8) != 0)
			{
				if (Class21.memoryStream_1 == null)
				{
					if (Class21.int_1 == -2147483648)
					{
						Class21.memoryStream_1.Capacity = (int)stream2.Length * 2;
					}
					else
					{
						Class21.memoryStream_1.Capacity = Class21.int_1;
					}
				}
				Class21.memoryStream_1.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
				int num3 = 1000;
				byte[] buffer = new byte[1000];
				int num4;
				do
				{
					num4 = deflateStream.Read(buffer, 0, num3);
					if (num4 > 0)
					{
						Class21.memoryStream_1.Write(buffer, 0, num4);
					}
				}
				while (num4 >= num3);
				memoryStream = Class21.memoryStream_1;
			}
			if (memoryStream != null)
			{
				return memoryStream.ToArray();
			}
			byte[] array7 = new byte[stream.Length - stream.Position];
			stream.Read(array7, 0, array7.Length);
			return array7;
		}

		// Token: 0x04000173 RID: 371
		private static readonly object object_0;

		// Token: 0x04000174 RID: 372
		private static readonly int int_0;

		// Token: 0x04000175 RID: 373
		private static readonly int int_1;

		// Token: 0x04000176 RID: 374
		private static readonly MemoryStream memoryStream_0 = Class39.memoryStream_0;

		// Token: 0x04000177 RID: 375
		private static readonly MemoryStream memoryStream_1 = Class39.memoryStream_0;

		// Token: 0x04000178 RID: 376
		private static readonly byte byte_0;
	}
}
