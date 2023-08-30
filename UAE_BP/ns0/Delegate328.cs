using System;

namespace ns0
{
	// Token: 0x0200019A RID: 410
	internal sealed class Delegate328 : MulticastDelegate
	{
		// Token: 0x06000707 RID: 1799
		public extern Delegate328(object object_0, IntPtr intptr_0);

		// Token: 0x06000708 RID: 1800 RVA: 0x00005525 File Offset: 0x00003725
		static Delegate328()
		{
			Class24.smethod_0(33554888, 167772451, 16777215);
		}

		// Token: 0x06000709 RID: 1801
		public extern bool Invoke(object object_0, int int_0);

		// Token: 0x0600070A RID: 1802 RVA: 0x0000553B File Offset: 0x0000373B
		public static bool smethod_0(object object_0, int int_0)
		{
			return Delegate328.delegate328_0(object_0, int_0);
		}

		// Token: 0x04000324 RID: 804
		protected internal static readonly Delegate328 delegate328_0;
	}
}
