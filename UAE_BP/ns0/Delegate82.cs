using System;

namespace ns0
{
	// Token: 0x02000099 RID: 153
	internal sealed class Delegate82 : MulticastDelegate
	{
		// Token: 0x06000324 RID: 804
		public extern Delegate82(object object_0, IntPtr intptr_0);

		// Token: 0x06000325 RID: 805 RVA: 0x0000333D File Offset: 0x0000153D
		static Delegate82()
		{
			Class24.smethod_0(33554592, 167772236, 16777215);
		}

		// Token: 0x06000326 RID: 806
		public extern object Invoke(IntPtr intptr_0, Type type_0);

		// Token: 0x06000327 RID: 807 RVA: 0x00003353 File Offset: 0x00001553
		public static object smethod_0(IntPtr intptr_0, Type type_0)
		{
			return Delegate82.delegate82_0(intptr_0, type_0);
		}

		// Token: 0x04000223 RID: 547
		internal static readonly Delegate82 delegate82_0;
	}
}
