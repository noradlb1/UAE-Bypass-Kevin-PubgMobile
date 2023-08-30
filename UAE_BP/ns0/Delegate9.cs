using System;

namespace ns0
{
	// Token: 0x0200004D RID: 77
	internal sealed class Delegate9 : MulticastDelegate
	{
		// Token: 0x060001FD RID: 509
		public extern Delegate9(object object_0, IntPtr intptr_0);

		// Token: 0x060001FE RID: 510 RVA: 0x00002923 File Offset: 0x00000B23
		static Delegate9()
		{
			Class24.smethod_0(33554509, 100663551, 16777215);
		}

		// Token: 0x060001FF RID: 511
		public extern byte[] Invoke();

		// Token: 0x06000200 RID: 512 RVA: 0x00002939 File Offset: 0x00000B39
		public static byte[] smethod_0()
		{
			return Delegate9.delegate9_0();
		}

		// Token: 0x040001D7 RID: 471
		internal static readonly Delegate9 delegate9_0;
	}
}
