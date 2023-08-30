using System;
using System.Windows;

namespace ns0
{
	// Token: 0x0200011B RID: 283
	internal sealed class Delegate207 : MulticastDelegate
	{
		// Token: 0x0600051D RID: 1309
		public extern Delegate207(object object_0, IntPtr intptr_0);

		// Token: 0x0600051E RID: 1310 RVA: 0x00004469 File Offset: 0x00002669
		static Delegate207()
		{
			Class24.smethod_0(33554740, 167772351, 16777215);
		}

		// Token: 0x0600051F RID: 1311
		public extern void Invoke(object object_0, RoutedEventHandler routedEventHandler_0);

		// Token: 0x06000520 RID: 1312 RVA: 0x0000447F File Offset: 0x0000267F
		public static void smethod_0(object object_0, RoutedEventHandler routedEventHandler_0)
		{
			Delegate207.delegate207_0(object_0, routedEventHandler_0);
		}

		// Token: 0x040002A5 RID: 677
		protected internal static readonly Delegate207 delegate207_0;
	}
}
