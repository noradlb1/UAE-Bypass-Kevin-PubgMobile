using System;
using System.Collections.Specialized;

namespace ns0
{
	// Token: 0x02000139 RID: 313
	internal sealed class Delegate236 : MulticastDelegate
	{
		// Token: 0x06000592 RID: 1426
		public extern Delegate236(object object_0, IntPtr intptr_0);

		// Token: 0x06000593 RID: 1427 RVA: 0x00004871 File Offset: 0x00002A71
		static Delegate236()
		{
			Class24.smethod_0(33554773, 167772376, 16777215);
		}

		// Token: 0x06000594 RID: 1428
		public extern byte[] Invoke(object object_0, string string_0, NameValueCollection nameValueCollection_0);

		// Token: 0x06000595 RID: 1429 RVA: 0x00004887 File Offset: 0x00002A87
		public static byte[] smethod_0(object object_0, string string_0, NameValueCollection nameValueCollection_0)
		{
			return Delegate236.delegate236_0(object_0, string_0, nameValueCollection_0);
		}

		// Token: 0x040002C3 RID: 707
		protected internal static readonly Delegate236 delegate236_0;
	}
}
