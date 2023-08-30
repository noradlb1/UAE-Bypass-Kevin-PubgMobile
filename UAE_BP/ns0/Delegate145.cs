using System;

namespace ns0
{
	// Token: 0x020000DA RID: 218
	internal sealed class Delegate145 : MulticastDelegate
	{
		// Token: 0x06000422 RID: 1058
		public extern Delegate145(object object_0, IntPtr intptr_0);

		// Token: 0x06000423 RID: 1059 RVA: 0x00003BE8 File Offset: 0x00001DE8
		static Delegate145()
		{
			Class24.smethod_0(33554666, 167772295, 16777215);
		}

		// Token: 0x06000424 RID: 1060
		public extern bool Invoke(object object_0);

		// Token: 0x06000425 RID: 1061 RVA: 0x00003BFE File Offset: 0x00001DFE
		public static bool smethod_0(object object_0)
		{
			return Delegate145.delegate145_0(object_0);
		}

		// Token: 0x04000264 RID: 612
		protected internal static readonly Delegate145 delegate145_0;
	}
}
