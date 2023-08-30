using System;

namespace ns0
{
	// Token: 0x02000120 RID: 288
	internal sealed class Delegate212 : MulticastDelegate
	{
		// Token: 0x06000531 RID: 1329
		public extern Delegate212(object object_0, IntPtr intptr_0);

		// Token: 0x06000532 RID: 1330 RVA: 0x0000451B File Offset: 0x0000271B
		static Delegate212()
		{
			Class24.smethod_0(33554745, 167772356, 16777215);
		}

		// Token: 0x06000533 RID: 1331
		public extern void Invoke(object object_0, ResolveEventHandler resolveEventHandler_0);

		// Token: 0x06000534 RID: 1332 RVA: 0x00004531 File Offset: 0x00002731
		public static void smethod_0(object object_0, ResolveEventHandler resolveEventHandler_0)
		{
			Delegate212.delegate212_0(object_0, resolveEventHandler_0);
		}

		// Token: 0x040002AA RID: 682
		protected internal static readonly Delegate212 delegate212_0;
	}
}
