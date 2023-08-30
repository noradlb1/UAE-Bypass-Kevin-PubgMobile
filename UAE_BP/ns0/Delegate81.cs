using System;
using System.Windows;

namespace ns0
{
	// Token: 0x02000098 RID: 152
	internal sealed class Delegate81 : MulticastDelegate
	{
		// Token: 0x06000320 RID: 800
		public extern Delegate81(object object_0, IntPtr intptr_0);

		// Token: 0x06000321 RID: 801 RVA: 0x00003319 File Offset: 0x00001519
		static Delegate81()
		{
			Class24.smethod_0(33554591, 167772235, 16777215);
		}

		// Token: 0x06000322 RID: 802
		public extern void Invoke(object object_0, Visibility visibility_0);

		// Token: 0x06000323 RID: 803 RVA: 0x0000332F File Offset: 0x0000152F
		public static void smethod_0(object object_0, Visibility visibility_0)
		{
			Delegate81.delegate81_0(object_0, visibility_0);
		}

		// Token: 0x04000222 RID: 546
		protected internal static readonly Delegate81 delegate81_0;
	}
}
