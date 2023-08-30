using System;

namespace ns0
{
	// Token: 0x0200004F RID: 79
	internal sealed class Delegate11 : MulticastDelegate
	{
		// Token: 0x06000205 RID: 517
		public extern Delegate11(object object_0, IntPtr intptr_0);

		// Token: 0x06000206 RID: 518 RVA: 0x00002968 File Offset: 0x00000B68
		static Delegate11()
		{
			Class24.smethod_0(33554512, 167772177, 16777215);
		}

		// Token: 0x06000207 RID: 519
		public extern uint Invoke(byte[] byte_0, int int_0);

		// Token: 0x06000208 RID: 520 RVA: 0x0000297E File Offset: 0x00000B7E
		public static uint smethod_0(byte[] byte_0, int int_0)
		{
			return Delegate11.delegate11_0(byte_0, int_0);
		}

		// Token: 0x040001D9 RID: 473
		internal static readonly Delegate11 delegate11_0;
	}
}
