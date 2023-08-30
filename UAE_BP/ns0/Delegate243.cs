using System;

namespace ns0
{
	// Token: 0x02000140 RID: 320
	internal sealed class Delegate243 : MulticastDelegate
	{
		// Token: 0x060005AE RID: 1454
		public extern Delegate243(object object_0, IntPtr intptr_0);

		// Token: 0x060005AF RID: 1455 RVA: 0x0000496C File Offset: 0x00002B6C
		static Delegate243()
		{
			Class24.smethod_0(33554780, 167772382, 16777215);
		}

		// Token: 0x060005B0 RID: 1456
		public extern bool Invoke(string string_0, string string_1);

		// Token: 0x060005B1 RID: 1457 RVA: 0x00004982 File Offset: 0x00002B82
		public static bool smethod_0(string string_0, string string_1)
		{
			return Delegate243.delegate243_0(string_0, string_1);
		}

		// Token: 0x040002CA RID: 714
		internal static readonly Delegate243 delegate243_0;
	}
}
