using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0
{
	// Token: 0x02000033 RID: 51
	internal sealed class Class15
	{
		// Token: 0x06000174 RID: 372 RVA: 0x0000E074 File Offset: 0x0000C274
		static Class15()
		{
			if (Class15.byte_0 == null)
			{
				string text = "VUFFX0JQJA==";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				Class15.byte_0 = Class21.smethod_3(97L, manifestResourceStream);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		internal static string smethod_0(int int_1)
		{
			int num;
			if ((Class15.byte_0[int_1] & 128) == 0)
			{
				num = (int)Class15.byte_0[int_1];
				int_1++;
			}
			else if ((Class15.byte_0[int_1] & 64) == 0)
			{
				num = ((int)Class15.byte_0[int_1] & -129) << 8;
				num |= (int)Class15.byte_0[int_1 + 1];
				int_1 += 2;
			}
			else
			{
				num = ((int)Class15.byte_0[int_1] & -193) << 24;
				num |= (int)Class15.byte_0[int_1 + 1] << 16;
				num |= (int)Class15.byte_0[int_1 + 2] << 8;
				num |= (int)Class15.byte_0[int_1 + 3];
				int_1 += 4;
			}
			if (num < 1)
			{
				return string.Empty;
			}
			string @string = Encoding.Unicode.GetString(Class15.byte_0, int_1, num);
			return string.Intern(@string);
		}

		// Token: 0x0400014B RID: 331
		internal static readonly byte[] byte_0;

		// Token: 0x0400014C RID: 332
		internal readonly int int_0;
	}
}
