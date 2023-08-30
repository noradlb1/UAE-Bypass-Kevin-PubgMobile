using System;
using System.Net;

namespace ns0
{
	// Token: 0x02000195 RID: 405
	internal sealed class Delegate323 : MulticastDelegate
	{
		// Token: 0x060006F3 RID: 1779
		public extern Delegate323(object object_0, IntPtr intptr_0);

		// Token: 0x060006F4 RID: 1780 RVA: 0x00005473 File Offset: 0x00003673
		static Delegate323()
		{
			Class24.smethod_0(33554882, 167772446, 16777215);
		}

		// Token: 0x060006F5 RID: 1781
		public extern HttpStatusCode Invoke(object object_0);

		// Token: 0x060006F6 RID: 1782 RVA: 0x00005489 File Offset: 0x00003689
		public static HttpStatusCode smethod_0(object object_0)
		{
			return Delegate323.delegate323_0(object_0);
		}

		// Token: 0x0400031F RID: 799
		protected internal static readonly Delegate323 delegate323_0;
	}
}
