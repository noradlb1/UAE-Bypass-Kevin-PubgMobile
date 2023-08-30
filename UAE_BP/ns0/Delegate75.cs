using System;

namespace ns0
{
	// Token: 0x02000091 RID: 145
	internal sealed class Delegate75 : MulticastDelegate
	{
		// Token: 0x06000307 RID: 775
		public extern Delegate75(object object_0, IntPtr intptr_0);

		// Token: 0x06000308 RID: 776 RVA: 0x00003245 File Offset: 0x00001445
		static Delegate75()
		{
			Class24.smethod_0(33554582, 167772229, 16777215);
		}

		// Token: 0x06000309 RID: 777
		public extern int Invoke(byte[] byte_0, int int_0);

		// Token: 0x0600030A RID: 778 RVA: 0x0000325B File Offset: 0x0000145B
		public static int smethod_0(byte[] byte_0, int int_0)
		{
			return Delegate75.delegate75_0(byte_0, int_0);
		}

		// Token: 0x0400021B RID: 539
		internal static readonly Delegate75 delegate75_0;
	}
}
