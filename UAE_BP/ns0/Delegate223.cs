using System;
using System.Windows;

namespace ns0
{
	// Token: 0x0200012C RID: 300
	internal sealed class Delegate223 : MulticastDelegate
	{
		// Token: 0x0600055E RID: 1374
		public extern Delegate223(object object_0, IntPtr intptr_0);

		// Token: 0x0600055F RID: 1375 RVA: 0x000046A0 File Offset: 0x000028A0
		static Delegate223()
		{
			Class24.smethod_0(33554757, 167772365, 16777215);
		}

		// Token: 0x06000560 RID: 1376
		public extern void Invoke(object object_0, RoutedEventHandler routedEventHandler_0);

		// Token: 0x06000561 RID: 1377 RVA: 0x000046B6 File Offset: 0x000028B6
		public static void smethod_0(object object_0, RoutedEventHandler routedEventHandler_0)
		{
			Delegate223.delegate223_0(object_0, routedEventHandler_0);
		}

		// Token: 0x040002B6 RID: 694
		protected internal static readonly Delegate223 delegate223_0;
	}
}
