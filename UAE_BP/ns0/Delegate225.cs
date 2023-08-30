using System;

namespace ns0
{
	// Token: 0x0200012E RID: 302
	internal sealed class Delegate225 : MulticastDelegate
	{
		// Token: 0x06000566 RID: 1382
		public extern Delegate225(object object_0, IntPtr intptr_0);

		// Token: 0x06000567 RID: 1383 RVA: 0x000046E7 File Offset: 0x000028E7
		static Delegate225()
		{
			Class24.smethod_0(33554760, 167772367, 16777215);
		}

		// Token: 0x06000568 RID: 1384
		public extern bool Invoke(int int_0);

		// Token: 0x06000569 RID: 1385 RVA: 0x000046FD File Offset: 0x000028FD
		public static bool smethod_0(int int_0)
		{
			return Delegate225.delegate225_0(int_0);
		}

		// Token: 0x040002B8 RID: 696
		internal static readonly Delegate225 delegate225_0;
	}
}
