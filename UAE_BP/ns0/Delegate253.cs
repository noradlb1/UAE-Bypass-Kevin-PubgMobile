using System;
using System.IO;

namespace ns0
{
	// Token: 0x0200014A RID: 330
	internal sealed class Delegate253 : MulticastDelegate
	{
		// Token: 0x060005D6 RID: 1494
		public extern Delegate253(object object_0, IntPtr intptr_0);

		// Token: 0x060005D7 RID: 1495 RVA: 0x00004AD1 File Offset: 0x00002CD1
		static Delegate253()
		{
			Class24.smethod_0(33554790, 167772389, 16777215);
		}

		// Token: 0x060005D8 RID: 1496
		public extern StreamReader Invoke(object object_0);

		// Token: 0x060005D9 RID: 1497 RVA: 0x00004AE7 File Offset: 0x00002CE7
		public static StreamReader smethod_0(object object_0)
		{
			return Delegate253.delegate253_0(object_0);
		}

		// Token: 0x040002D4 RID: 724
		protected internal static readonly Delegate253 delegate253_0;
	}
}
