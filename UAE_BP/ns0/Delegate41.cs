using System;
using System.Net;

namespace ns0
{
	// Token: 0x0200006D RID: 109
	internal sealed class Delegate41 : MulticastDelegate
	{
		// Token: 0x0600027D RID: 637
		public extern Delegate41(object object_0, IntPtr intptr_0);

		// Token: 0x0600027E RID: 638 RVA: 0x00002D8E File Offset: 0x00000F8E
		static Delegate41()
		{
			Class24.smethod_0(33554542, 167772201, 16777215);
		}

		// Token: 0x0600027F RID: 639
		public extern WebResponse Invoke(object object_0);

		// Token: 0x06000280 RID: 640 RVA: 0x00002DA4 File Offset: 0x00000FA4
		public static WebResponse smethod_0(object object_0)
		{
			return Delegate41.delegate41_0(object_0);
		}

		// Token: 0x040001F7 RID: 503
		protected internal static readonly Delegate41 delegate41_0;
	}
}
