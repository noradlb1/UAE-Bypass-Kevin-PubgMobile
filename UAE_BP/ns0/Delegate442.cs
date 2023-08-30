using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x02000210 RID: 528
	internal sealed class Delegate442 : MulticastDelegate
	{
		// Token: 0x060008D3 RID: 2259
		public extern Delegate442(object object_0, IntPtr intptr_0);

		// Token: 0x060008D4 RID: 2260 RVA: 0x000064DE File Offset: 0x000046DE
		static Delegate442()
		{
			Class25.smethod_0(33555022, 167772543, 16777215);
		}

		// Token: 0x060008D5 RID: 2261
		public extern ProcessStartInfo Invoke(string string_0, string string_1);

		// Token: 0x060008D6 RID: 2262 RVA: 0x000064F4 File Offset: 0x000046F4
		public static ProcessStartInfo smethod_0(string string_0, string string_1)
		{
			return Delegate442.delegate442_0(string_0, string_1);
		}

		// Token: 0x0400039A RID: 922
		internal static readonly Delegate442 delegate442_0;
	}
}
