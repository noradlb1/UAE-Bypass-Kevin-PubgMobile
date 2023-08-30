using System;

namespace ns0
{
	// Token: 0x020001A8 RID: 424
	internal sealed class Delegate341 : MulticastDelegate
	{
		// Token: 0x0600073C RID: 1852
		public extern Delegate341(object object_0, IntPtr intptr_0);

		// Token: 0x0600073D RID: 1853 RVA: 0x000056EE File Offset: 0x000038EE
		static Delegate341()
		{
			Class24.smethod_0(33554903, 167772462, 16777215);
		}

		// Token: 0x0600073E RID: 1854
		public extern bool Invoke(string string_0);

		// Token: 0x0600073F RID: 1855 RVA: 0x00005704 File Offset: 0x00003904
		public static bool smethod_0(string string_0)
		{
			return Delegate341.delegate341_0(string_0);
		}

		// Token: 0x04000332 RID: 818
		internal static readonly Delegate341 delegate341_0;
	}
}
