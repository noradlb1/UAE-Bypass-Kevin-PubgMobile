using System;

namespace ns0
{
	// Token: 0x020000CD RID: 205
	internal sealed class Delegate132 : MulticastDelegate
	{
		// Token: 0x060003EE RID: 1006
		public extern Delegate132(object object_0, IntPtr intptr_0);

		// Token: 0x060003EF RID: 1007 RVA: 0x00003A1B File Offset: 0x00001C1B
		static Delegate132()
		{
			Class24.smethod_0(33554650, 167772282, 16777215);
		}

		// Token: 0x060003F0 RID: 1008
		public extern byte[] Invoke(double double_0);

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003A31 File Offset: 0x00001C31
		public static byte[] smethod_0(double double_0)
		{
			return Delegate132.delegate132_0(double_0);
		}

		// Token: 0x04000257 RID: 599
		internal static readonly Delegate132 delegate132_0;
	}
}
