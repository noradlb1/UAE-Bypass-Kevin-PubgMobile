using System;

namespace ns0
{
	// Token: 0x0200017B RID: 379
	internal sealed class Delegate301 : MulticastDelegate
	{
		// Token: 0x06000697 RID: 1687
		public extern Delegate301(object object_0, IntPtr intptr_0);

		// Token: 0x06000698 RID: 1688 RVA: 0x0000516B File Offset: 0x0000336B
		static Delegate301()
		{
			Class24.smethod_0(33554847, 167772426, 16777215);
		}

		// Token: 0x06000699 RID: 1689
		public extern string Invoke(byte[] byte_0);

		// Token: 0x0600069A RID: 1690 RVA: 0x00005181 File Offset: 0x00003381
		public static string smethod_0(byte[] byte_0)
		{
			return Delegate301.delegate301_0(byte_0);
		}

		// Token: 0x04000305 RID: 773
		internal static readonly Delegate301 delegate301_0;
	}
}
