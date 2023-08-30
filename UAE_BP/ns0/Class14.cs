using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0
{
	// Token: 0x0200002F RID: 47
	internal sealed class Class14
	{
		// Token: 0x0600015E RID: 350 RVA: 0x0000DE24 File Offset: 0x0000C024
		static Class14()
		{
			if (Class14.byte_0 == null)
			{
				string text = "VUFFX0JQJQ==";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				Class14.byte_0 = Class21.smethod_3(97L, manifestResourceStream);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000025FE File Offset: 0x000007FE
		internal static int smethod_0(int int_2)
		{
			return BitConverter.ToInt32(Class14.byte_0, int_2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000260B File Offset: 0x0000080B
		internal static long smethod_1(int int_2)
		{
			return BitConverter.ToInt64(Class14.byte_0, int_2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002618 File Offset: 0x00000818
		internal static float smethod_2(int int_2)
		{
			return BitConverter.ToSingle(Class14.byte_0, int_2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002625 File Offset: 0x00000825
		internal static double smethod_3(int int_2)
		{
			return BitConverter.ToDouble(Class14.byte_0, int_2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000DE78 File Offset: 0x0000C078
		internal static void smethod_4(Array array_0, int int_2)
		{
			int num;
			if ((Class14.byte_0[int_2] & 128) == 0)
			{
				num = (int)Class14.byte_0[int_2];
				int_2++;
			}
			else if ((Class14.byte_0[int_2] & 64) == 0)
			{
				num = ((int)Class14.byte_0[int_2] & -129) << 8;
				num |= (int)Class14.byte_0[int_2 + 1];
				int_2 += 2;
			}
			else
			{
				num = ((int)Class14.byte_0[int_2] & -193) << 24;
				num |= (int)Class14.byte_0[int_2 + 1] << 16;
				num |= (int)Class14.byte_0[int_2 + 2] << 8;
				num |= (int)Class14.byte_0[int_2 + 3];
				int_2 += 4;
			}
			if (num < 1)
			{
				return;
			}
			Buffer.BlockCopy(Class14.byte_0, int_2, array_0, 0, num);
		}

		// Token: 0x04000140 RID: 320
		internal static readonly byte[] byte_0;

		// Token: 0x04000141 RID: 321
		internal readonly int int_0;

		// Token: 0x04000142 RID: 322
		internal readonly int int_1;
	}
}
