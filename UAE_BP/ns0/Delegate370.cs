using System;

namespace ns0
{
	// Token: 0x020001C6 RID: 454
	internal sealed class Delegate370 : MulticastDelegate
	{
		// Token: 0x060007B1 RID: 1969
		public extern Delegate370(object object_0, IntPtr intptr_0);

		// Token: 0x060007B2 RID: 1970 RVA: 0x00005AEE File Offset: 0x00003CEE
		static Delegate370()
		{
			Class24.smethod_0(33554937, 167772489, 16777215);
		}

		// Token: 0x060007B3 RID: 1971
		public extern void Invoke(object object_0, EventHandler eventHandler_0);

		// Token: 0x060007B4 RID: 1972 RVA: 0x00005B04 File Offset: 0x00003D04
		public static void smethod_0(object object_0, EventHandler eventHandler_0)
		{
			Delegate370.delegate370_0(object_0, eventHandler_0);
		}

		// Token: 0x04000350 RID: 848
		protected internal static readonly Delegate370 delegate370_0;
	}
}
