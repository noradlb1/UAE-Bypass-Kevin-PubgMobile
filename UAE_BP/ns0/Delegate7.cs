using System;

namespace ns0
{
	// Token: 0x0200004B RID: 75
	internal sealed class Delegate7 : MulticastDelegate
	{
		// Token: 0x060001F5 RID: 501
		public extern Delegate7(object object_0, IntPtr intptr_0);

		// Token: 0x060001F6 RID: 502 RVA: 0x000028DC File Offset: 0x00000ADC
		static Delegate7()
		{
			Class24.smethod_0(33554507, 167772176, 16777215);
		}

		// Token: 0x060001F7 RID: 503
		public extern bool Invoke(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x060001F8 RID: 504 RVA: 0x000028F2 File Offset: 0x00000AF2
		public static bool smethod_0(IntPtr intptr_0, IntPtr intptr_1)
		{
			return Delegate7.delegate7_0(intptr_0, intptr_1);
		}

		// Token: 0x040001D5 RID: 469
		internal static readonly Delegate7 delegate7_0;
	}
}
