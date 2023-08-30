using System;
using System.Windows;

namespace ns0
{
	// Token: 0x020000A1 RID: 161
	internal sealed class Delegate90 : MulticastDelegate
	{
		// Token: 0x06000344 RID: 836
		public extern Delegate90(object object_0, IntPtr intptr_0);

		// Token: 0x06000345 RID: 837 RVA: 0x00003457 File Offset: 0x00001657
		static Delegate90()
		{
			Class24.smethod_0(33554601, 167772244, 16777215);
		}

		// Token: 0x06000346 RID: 838
		public extern Application Invoke();

		// Token: 0x06000347 RID: 839 RVA: 0x0000346D File Offset: 0x0000166D
		public static Application smethod_0()
		{
			return Delegate90.delegate90_0();
		}

		// Token: 0x0400022B RID: 555
		internal static readonly Delegate90 delegate90_0;
	}
}
