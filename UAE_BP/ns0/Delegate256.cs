using System;

namespace ns0
{
	// Token: 0x0200014D RID: 333
	internal sealed class Delegate256 : MulticastDelegate
	{
		// Token: 0x060005E2 RID: 1506
		public extern Delegate256(object object_0, IntPtr intptr_0);

		// Token: 0x060005E3 RID: 1507 RVA: 0x00004B3C File Offset: 0x00002D3C
		static Delegate256()
		{
			Class24.smethod_0(33554793, 167772392, 16777215);
		}

		// Token: 0x060005E4 RID: 1508
		public extern bool Invoke(string string_0, string string_1);

		// Token: 0x060005E5 RID: 1509 RVA: 0x00004B52 File Offset: 0x00002D52
		public static bool smethod_0(string string_0, string string_1)
		{
			return Delegate256.delegate256_0(string_0, string_1);
		}

		// Token: 0x040002D7 RID: 727
		internal static readonly Delegate256 delegate256_0;
	}
}
