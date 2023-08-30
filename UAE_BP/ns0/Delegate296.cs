using System;

namespace ns0
{
	// Token: 0x02000175 RID: 373
	internal sealed class Delegate296 : MulticastDelegate
	{
		// Token: 0x06000682 RID: 1666
		public extern Delegate296(object object_0, IntPtr intptr_0);

		// Token: 0x06000683 RID: 1667 RVA: 0x000050B4 File Offset: 0x000032B4
		static Delegate296()
		{
			Class24.smethod_0(33554837, 167772421, 16777215);
		}

		// Token: 0x06000684 RID: 1668
		public extern int Invoke(object object_0, byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2);

		// Token: 0x06000685 RID: 1669 RVA: 0x000050CA File Offset: 0x000032CA
		public static int smethod_0(object object_0, byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
		{
			return Delegate296.delegate296_0(object_0, byte_0, int_0, int_1, byte_1, int_2);
		}

		// Token: 0x040002FF RID: 767
		protected internal static readonly Delegate296 delegate296_0;
	}
}
