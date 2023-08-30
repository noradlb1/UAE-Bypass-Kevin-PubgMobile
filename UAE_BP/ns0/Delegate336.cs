using System;
using System.Net;

namespace ns0
{
	// Token: 0x020001A3 RID: 419
	internal sealed class Delegate336 : MulticastDelegate
	{
		// Token: 0x06000728 RID: 1832
		public extern Delegate336(object object_0, IntPtr intptr_0);

		// Token: 0x06000729 RID: 1833 RVA: 0x0000563F File Offset: 0x0000383F
		static Delegate336()
		{
			Class25.smethod_0(33554898, 167772458, 16777215);
		}

		// Token: 0x0600072A RID: 1834
		public extern HttpListener Invoke();

		// Token: 0x0600072B RID: 1835 RVA: 0x00005655 File Offset: 0x00003855
		public static HttpListener smethod_0()
		{
			return Delegate336.delegate336_0();
		}

		// Token: 0x0400032D RID: 813
		internal static readonly Delegate336 delegate336_0;
	}
}
