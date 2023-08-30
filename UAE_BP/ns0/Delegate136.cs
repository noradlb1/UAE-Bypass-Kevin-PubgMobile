using System;
using System.Net;

namespace ns0
{
	// Token: 0x020000D1 RID: 209
	internal sealed class Delegate136 : MulticastDelegate
	{
		// Token: 0x060003FE RID: 1022
		public extern Delegate136(object object_0, IntPtr intptr_0);

		// Token: 0x060003FF RID: 1023 RVA: 0x00003AA9 File Offset: 0x00001CA9
		static Delegate136()
		{
			Class24.smethod_0(33554655, 167772286, 16777215);
		}

		// Token: 0x06000400 RID: 1024
		public extern WebHeaderCollection Invoke(object object_0);

		// Token: 0x06000401 RID: 1025 RVA: 0x00003ABF File Offset: 0x00001CBF
		public static WebHeaderCollection smethod_0(object object_0)
		{
			return Delegate136.delegate136_0(object_0);
		}

		// Token: 0x0400025B RID: 603
		protected internal static readonly Delegate136 delegate136_0;
	}
}
