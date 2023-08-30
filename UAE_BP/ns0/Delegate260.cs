using System;
using System.Net;

namespace ns0
{
	// Token: 0x02000151 RID: 337
	internal sealed class Delegate260 : MulticastDelegate
	{
		// Token: 0x060005F2 RID: 1522
		public extern Delegate260(object object_0, IntPtr intptr_0);

		// Token: 0x060005F3 RID: 1523 RVA: 0x00004BC9 File Offset: 0x00002DC9
		static Delegate260()
		{
			Class24.smethod_0(33554797, 167772395, 16777215);
		}

		// Token: 0x060005F4 RID: 1524
		public extern HttpListenerContext Invoke(object object_0);

		// Token: 0x060005F5 RID: 1525 RVA: 0x00004BDF File Offset: 0x00002DDF
		public static HttpListenerContext smethod_0(object object_0)
		{
			return Delegate260.delegate260_0(object_0);
		}

		// Token: 0x040002DB RID: 731
		protected internal static readonly Delegate260 delegate260_0;
	}
}
