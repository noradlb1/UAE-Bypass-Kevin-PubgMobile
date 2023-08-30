using System;

namespace ns0
{
	// Token: 0x02000144 RID: 324
	internal sealed class Delegate247 : MulticastDelegate
	{
		// Token: 0x060005BE RID: 1470
		public extern Delegate247(object object_0, IntPtr intptr_0);

		// Token: 0x060005BF RID: 1471 RVA: 0x000049FB File Offset: 0x00002BFB
		static Delegate247()
		{
			Class24.smethod_0(33554784, 167772384, 16777215);
		}

		// Token: 0x060005C0 RID: 1472
		public extern byte[] Invoke(object object_0, byte[] byte_0);

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004A11 File Offset: 0x00002C11
		public static byte[] smethod_0(object object_0, byte[] byte_0)
		{
			return Delegate247.delegate247_0(object_0, byte_0);
		}

		// Token: 0x040002CE RID: 718
		internal static readonly Delegate247 delegate247_0;
	}
}
