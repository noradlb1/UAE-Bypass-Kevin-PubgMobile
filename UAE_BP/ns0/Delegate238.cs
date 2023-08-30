using System;
using System.Windows.Threading;

namespace ns0
{
	// Token: 0x0200013B RID: 315
	internal sealed class Delegate238 : MulticastDelegate
	{
		// Token: 0x0600059A RID: 1434
		public extern Delegate238(object object_0, IntPtr intptr_0);

		// Token: 0x0600059B RID: 1435 RVA: 0x000048B9 File Offset: 0x00002AB9
		static Delegate238()
		{
			Class24.smethod_0(33554775, 167772378, 16777215);
		}

		// Token: 0x0600059C RID: 1436
		public extern object Invoke(object object_0, DispatcherPriority dispatcherPriority_0, Delegate delegate_0);

		// Token: 0x0600059D RID: 1437 RVA: 0x000048CF File Offset: 0x00002ACF
		public static object smethod_0(object object_0, DispatcherPriority dispatcherPriority_0, Delegate delegate_0)
		{
			return Delegate238.delegate238_0(object_0, dispatcherPriority_0, delegate_0);
		}

		// Token: 0x040002C5 RID: 709
		protected internal static readonly Delegate238 delegate238_0;
	}
}
