using System;
using System.Security.Principal;

namespace ns0
{
	// Token: 0x02000088 RID: 136
	internal sealed class Delegate66 : MulticastDelegate
	{
		// Token: 0x060002E3 RID: 739
		public extern Delegate66(object object_0, IntPtr intptr_0);

		// Token: 0x060002E4 RID: 740 RVA: 0x00003108 File Offset: 0x00001308
		static Delegate66()
		{
			Class24.smethod_0(33554571, 167772222, 16777215);
		}

		// Token: 0x060002E5 RID: 741
		public extern WindowsIdentity Invoke();

		// Token: 0x060002E6 RID: 742 RVA: 0x0000311E File Offset: 0x0000131E
		public static WindowsIdentity smethod_0()
		{
			return Delegate66.delegate66_0();
		}

		// Token: 0x04000212 RID: 530
		internal static readonly Delegate66 delegate66_0;
	}
}
