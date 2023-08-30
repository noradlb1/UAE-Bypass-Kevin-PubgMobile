using System;
using System.Windows;

namespace ns0
{
	// Token: 0x020001F3 RID: 499
	internal sealed class Delegate415 : MulticastDelegate
	{
		// Token: 0x06000865 RID: 2149
		public extern Delegate415(object object_0, IntPtr intptr_0);

		// Token: 0x06000866 RID: 2150 RVA: 0x00006121 File Offset: 0x00004321
		static Delegate415()
		{
			Class24.smethod_0(33554990, 167772522, 16777215);
		}

		// Token: 0x06000867 RID: 2151
		public extern void Invoke(object object_0, RoutedEventHandler routedEventHandler_0);

		// Token: 0x06000868 RID: 2152 RVA: 0x00006137 File Offset: 0x00004337
		public static void smethod_0(object object_0, RoutedEventHandler routedEventHandler_0)
		{
			Delegate415.delegate415_0(object_0, routedEventHandler_0);
		}

		// Token: 0x0400037D RID: 893
		protected internal static readonly Delegate415 delegate415_0;
	}
}
