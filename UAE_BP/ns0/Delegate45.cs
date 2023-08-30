using System;

namespace ns0
{
	// Token: 0x02000071 RID: 113
	internal sealed class Delegate45 : MulticastDelegate
	{
		// Token: 0x0600028D RID: 653
		public extern Delegate45(object object_0, IntPtr intptr_0);

		// Token: 0x0600028E RID: 654 RVA: 0x00002E1C File Offset: 0x0000101C
		static Delegate45()
		{
			Class24.smethod_0(33554547, 167772205, 16777215);
		}

		// Token: 0x0600028F RID: 655
		public extern long Invoke(byte[] byte_0, int int_0);

		// Token: 0x06000290 RID: 656 RVA: 0x00002E32 File Offset: 0x00001032
		public static long smethod_0(byte[] byte_0, int int_0)
		{
			return Delegate45.delegate45_0(byte_0, int_0);
		}

		// Token: 0x040001FB RID: 507
		internal static readonly Delegate45 delegate45_0;
	}
}
