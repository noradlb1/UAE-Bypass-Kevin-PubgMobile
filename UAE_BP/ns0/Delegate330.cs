using System;

namespace ns0
{
	// Token: 0x0200019C RID: 412
	internal sealed class Delegate330 : MulticastDelegate
	{
		// Token: 0x0600070F RID: 1807
		public extern Delegate330(object object_0, IntPtr intptr_0);

		// Token: 0x06000710 RID: 1808 RVA: 0x0000556C File Offset: 0x0000376C
		static Delegate330()
		{
			Class24.smethod_0(33554890, 167772453, 16777215);
		}

		// Token: 0x06000711 RID: 1809
		public extern string Invoke(object object_0, int int_0, int int_1);

		// Token: 0x06000712 RID: 1810 RVA: 0x00005582 File Offset: 0x00003782
		public static string smethod_0(object object_0, int int_0, int int_1)
		{
			return Delegate330.delegate330_0(object_0, int_0, int_1);
		}

		// Token: 0x04000326 RID: 806
		protected internal static readonly Delegate330 delegate330_0;
	}
}
