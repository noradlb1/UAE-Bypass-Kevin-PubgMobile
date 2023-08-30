using System;
using System.Windows.Threading;

namespace ns0
{
	// Token: 0x02000075 RID: 117
	internal sealed class Delegate49 : MulticastDelegate
	{
		// Token: 0x0600029D RID: 669
		public extern Delegate49(object object_0, IntPtr intptr_0);

		// Token: 0x0600029E RID: 670 RVA: 0x00002EAA File Offset: 0x000010AA
		static Delegate49()
		{
			Class24.smethod_0(33554551, 167772207, 16777215);
		}

		// Token: 0x0600029F RID: 671
		public extern Dispatcher Invoke(object object_0);

		// Token: 0x060002A0 RID: 672 RVA: 0x00002EC0 File Offset: 0x000010C0
		public static Dispatcher smethod_0(object object_0)
		{
			return Delegate49.delegate49_0(object_0);
		}

		// Token: 0x040001FF RID: 511
		internal static readonly Delegate49 delegate49_0;
	}
}
