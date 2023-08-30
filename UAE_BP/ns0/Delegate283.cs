using System;
using System.Net;

namespace ns0
{
	// Token: 0x02000168 RID: 360
	internal sealed class Delegate283 : MulticastDelegate
	{
		// Token: 0x0600064E RID: 1614
		public extern Delegate283(object object_0, IntPtr intptr_0);

		// Token: 0x0600064F RID: 1615 RVA: 0x00004EEB File Offset: 0x000030EB
		static Delegate283()
		{
			Class25.smethod_0(33554822, 167772412, 16777215);
		}

		// Token: 0x06000650 RID: 1616
		public extern WebClient Invoke();

		// Token: 0x06000651 RID: 1617 RVA: 0x00004F01 File Offset: 0x00003101
		public static WebClient smethod_0()
		{
			return Delegate283.delegate283_0();
		}

		// Token: 0x040002F2 RID: 754
		internal static readonly Delegate283 delegate283_0;
	}
}
