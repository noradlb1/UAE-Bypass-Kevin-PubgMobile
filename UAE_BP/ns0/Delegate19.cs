using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x02000057 RID: 87
	internal sealed class Delegate19 : MulticastDelegate
	{
		// Token: 0x06000225 RID: 549
		public extern Delegate19(object object_0, IntPtr intptr_0);

		// Token: 0x06000226 RID: 550 RVA: 0x00002A82 File Offset: 0x00000C82
		static Delegate19()
		{
			Class24.smethod_0(33554520, 167772182, 16777215);
		}

		// Token: 0x06000227 RID: 551
		public extern Process Invoke(int int_0);

		// Token: 0x06000228 RID: 552 RVA: 0x00002A98 File Offset: 0x00000C98
		public static Process smethod_0(int int_0)
		{
			return Delegate19.delegate19_0(int_0);
		}

		// Token: 0x040001E1 RID: 481
		internal static readonly Delegate19 delegate19_0;
	}
}
