using System;
using System.Windows;

namespace ns0
{
	// Token: 0x02000199 RID: 409
	internal sealed class Delegate327 : MulticastDelegate
	{
		// Token: 0x06000703 RID: 1795
		public extern Delegate327(object object_0, IntPtr intptr_0);

		// Token: 0x06000704 RID: 1796 RVA: 0x00005501 File Offset: 0x00003701
		static Delegate327()
		{
			Class24.smethod_0(33554887, 167772450, 16777215);
		}

		// Token: 0x06000705 RID: 1797
		public extern void Invoke(object object_0, WindowState windowState_0);

		// Token: 0x06000706 RID: 1798 RVA: 0x00005517 File Offset: 0x00003717
		public static void smethod_0(object object_0, WindowState windowState_0)
		{
			Delegate327.delegate327_0(object_0, windowState_0);
		}

		// Token: 0x04000323 RID: 803
		internal static readonly Delegate327 delegate327_0;
	}
}
