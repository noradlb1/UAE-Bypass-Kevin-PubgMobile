using System;
using System.Globalization;

namespace ns0
{
	// Token: 0x020000A6 RID: 166
	internal sealed class Delegate95 : MulticastDelegate
	{
		// Token: 0x06000358 RID: 856
		public extern Delegate95(object object_0, IntPtr intptr_0);

		// Token: 0x06000359 RID: 857 RVA: 0x00003508 File Offset: 0x00001708
		static Delegate95()
		{
			Class24.smethod_0(33554607, 167772248, 16777215);
		}

		// Token: 0x0600035A RID: 858
		public extern object Invoke(object object_0, string string_0, CultureInfo cultureInfo_0);

		// Token: 0x0600035B RID: 859 RVA: 0x0000351E File Offset: 0x0000171E
		public static object smethod_0(object object_0, string string_0, CultureInfo cultureInfo_0)
		{
			return Delegate95.delegate95_0(object_0, string_0, cultureInfo_0);
		}

		// Token: 0x04000230 RID: 560
		protected internal static readonly Delegate95 delegate95_0;
	}
}
