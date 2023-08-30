using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x0200018B RID: 395
	internal sealed class Delegate314 : MulticastDelegate
	{
		// Token: 0x060006CE RID: 1742
		public extern Delegate314(object object_0, IntPtr intptr_0);

		// Token: 0x060006CF RID: 1743 RVA: 0x00005337 File Offset: 0x00003537
		static Delegate314()
		{
			Class25.smethod_0(33554868, 167772438, 16777215);
		}

		// Token: 0x060006D0 RID: 1744
		public extern ProcessStartInfo Invoke();

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000534D File Offset: 0x0000354D
		public static ProcessStartInfo smethod_0()
		{
			return Delegate314.delegate314_0();
		}

		// Token: 0x04000315 RID: 789
		internal static readonly Delegate314 delegate314_0;
	}
}
