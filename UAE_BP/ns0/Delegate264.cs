using System;
using System.Net;

namespace ns0
{
	// Token: 0x02000155 RID: 341
	internal sealed class Delegate264 : MulticastDelegate
	{
		// Token: 0x06000602 RID: 1538
		public extern Delegate264(object object_0, IntPtr intptr_0);

		// Token: 0x06000603 RID: 1539 RVA: 0x00004C53 File Offset: 0x00002E53
		static Delegate264()
		{
			Class24.smethod_0(33554801, 167772399, 16777215);
		}

		// Token: 0x06000604 RID: 1540
		public extern HttpListenerResponse Invoke(object object_0);

		// Token: 0x06000605 RID: 1541 RVA: 0x00004C69 File Offset: 0x00002E69
		public static HttpListenerResponse smethod_0(object object_0)
		{
			return Delegate264.delegate264_0(object_0);
		}

		// Token: 0x040002DF RID: 735
		protected internal static readonly Delegate264 delegate264_0;
	}
}
