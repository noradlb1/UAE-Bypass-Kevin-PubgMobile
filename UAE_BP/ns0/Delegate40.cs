using System;

namespace ns0
{
	// Token: 0x0200006C RID: 108
	internal sealed class Delegate40 : MulticastDelegate
	{
		// Token: 0x06000279 RID: 633
		public extern Delegate40(object object_0, IntPtr intptr_0);

		// Token: 0x0600027A RID: 634 RVA: 0x00002D6B File Offset: 0x00000F6B
		static Delegate40()
		{
			Class24.smethod_0(33554541, 167772200, 16777215);
		}

		// Token: 0x0600027B RID: 635
		public extern int Invoke(object object_0);

		// Token: 0x0600027C RID: 636 RVA: 0x00002D81 File Offset: 0x00000F81
		public static int smethod_0(object object_0)
		{
			return Delegate40.delegate40_0(object_0);
		}

		// Token: 0x040001F6 RID: 502
		protected internal static readonly Delegate40 delegate40_0;
	}
}
