using System;
using System.Security.Principal;

namespace ns0
{
	// Token: 0x02000164 RID: 356
	internal sealed class Delegate279 : MulticastDelegate
	{
		// Token: 0x0600063E RID: 1598
		public extern Delegate279(object object_0, IntPtr intptr_0);

		// Token: 0x0600063F RID: 1599 RVA: 0x00004E5F File Offset: 0x0000305F
		static Delegate279()
		{
			Class24.smethod_0(33554818, 167772409, 16777215);
		}

		// Token: 0x06000640 RID: 1600
		public extern SecurityIdentifier Invoke(object object_0);

		// Token: 0x06000641 RID: 1601 RVA: 0x00004E75 File Offset: 0x00003075
		public static SecurityIdentifier smethod_0(object object_0)
		{
			return Delegate279.delegate279_0(object_0);
		}

		// Token: 0x040002EE RID: 750
		protected internal static readonly Delegate279 delegate279_0;
	}
}
