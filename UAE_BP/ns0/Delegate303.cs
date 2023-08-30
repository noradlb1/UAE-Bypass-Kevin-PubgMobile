using System;
using System.Windows;

namespace ns0
{
	// Token: 0x0200017E RID: 382
	internal sealed class Delegate303 : MulticastDelegate
	{
		// Token: 0x060006A0 RID: 1696
		public extern Delegate303(object object_0, IntPtr intptr_0);

		// Token: 0x060006A1 RID: 1697 RVA: 0x000051B1 File Offset: 0x000033B1
		static Delegate303()
		{
			Class24.smethod_0(33554850, 167772428, 16777215);
		}

		// Token: 0x060006A2 RID: 1698
		public extern void Invoke(object object_0, StartupEventHandler startupEventHandler_0);

		// Token: 0x060006A3 RID: 1699 RVA: 0x000051C7 File Offset: 0x000033C7
		public static void smethod_0(object object_0, StartupEventHandler startupEventHandler_0)
		{
			Delegate303.delegate303_0(object_0, startupEventHandler_0);
		}

		// Token: 0x04000308 RID: 776
		internal static readonly Delegate303 delegate303_0;
	}
}
