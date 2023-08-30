using System;
using System.Windows;

namespace ns0
{
	// Token: 0x020000B7 RID: 183
	internal sealed class Delegate110 : MulticastDelegate
	{
		// Token: 0x06000396 RID: 918
		public extern Delegate110(object object_0, IntPtr intptr_0);

		// Token: 0x06000397 RID: 919 RVA: 0x00003719 File Offset: 0x00001919
		static Delegate110()
		{
			Class24.smethod_0(33554625, 167772262, 16777215);
		}

		// Token: 0x06000398 RID: 920
		public extern WindowState Invoke(object object_0);

		// Token: 0x06000399 RID: 921 RVA: 0x0000372F File Offset: 0x0000192F
		public static WindowState smethod_0(object object_0)
		{
			return Delegate110.delegate110_0(object_0);
		}

		// Token: 0x04000241 RID: 577
		internal static readonly Delegate110 delegate110_0;
	}
}
