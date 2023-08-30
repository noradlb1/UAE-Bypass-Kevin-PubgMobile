using System;
using System.Windows;

namespace ns0
{
	// Token: 0x0200013F RID: 319
	internal sealed class Delegate242 : MulticastDelegate
	{
		// Token: 0x060005AA RID: 1450
		public extern Delegate242(object object_0, IntPtr intptr_0);

		// Token: 0x060005AB RID: 1451 RVA: 0x00004948 File Offset: 0x00002B48
		static Delegate242()
		{
			Class24.smethod_0(33554779, 167772381, 16777215);
		}

		// Token: 0x060005AC RID: 1452
		public extern void Invoke(object object_0, RoutedEventHandler routedEventHandler_0);

		// Token: 0x060005AD RID: 1453 RVA: 0x0000495E File Offset: 0x00002B5E
		public static void smethod_0(object object_0, RoutedEventHandler routedEventHandler_0)
		{
			Delegate242.delegate242_0(object_0, routedEventHandler_0);
		}

		// Token: 0x040002C9 RID: 713
		protected internal static readonly Delegate242 delegate242_0;
	}
}
