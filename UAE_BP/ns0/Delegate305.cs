using System;

namespace ns0
{
	// Token: 0x02000180 RID: 384
	internal sealed class Delegate305 : MulticastDelegate
	{
		// Token: 0x060006A8 RID: 1704
		public extern Delegate305(object object_0, IntPtr intptr_0);

		// Token: 0x060006A9 RID: 1705 RVA: 0x000051F7 File Offset: 0x000033F7
		static Delegate305()
		{
			Class24.smethod_0(33554852, 167772430, 16777215);
		}

		// Token: 0x060006AA RID: 1706
		public extern string Invoke(byte[] byte_0);

		// Token: 0x060006AB RID: 1707 RVA: 0x0000520D File Offset: 0x0000340D
		public static string smethod_0(byte[] byte_0)
		{
			return Delegate305.delegate305_0(byte_0);
		}

		// Token: 0x0400030A RID: 778
		internal static readonly Delegate305 delegate305_0;
	}
}
