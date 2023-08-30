using System;

namespace ns0
{
	// Token: 0x02000089 RID: 137
	internal sealed class Delegate67 : MulticastDelegate
	{
		// Token: 0x060002E7 RID: 743
		public extern Delegate67(object object_0, IntPtr intptr_0);

		// Token: 0x060002E8 RID: 744 RVA: 0x0000312A File Offset: 0x0000132A
		static Delegate67()
		{
			Class24.smethod_0(33554572, 167772223, 16777215);
		}

		// Token: 0x060002E9 RID: 745
		public extern byte[] Invoke(string string_0);

		// Token: 0x060002EA RID: 746 RVA: 0x00003140 File Offset: 0x00001340
		public static byte[] smethod_0(string string_0)
		{
			return Delegate67.delegate67_0(string_0);
		}

		// Token: 0x04000213 RID: 531
		internal static readonly Delegate67 delegate67_0;
	}
}
