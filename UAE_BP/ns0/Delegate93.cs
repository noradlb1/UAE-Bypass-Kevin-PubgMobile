using System;

namespace ns0
{
	// Token: 0x020000A4 RID: 164
	internal sealed class Delegate93 : MulticastDelegate
	{
		// Token: 0x06000350 RID: 848
		public extern Delegate93(object object_0, IntPtr intptr_0);

		// Token: 0x06000351 RID: 849 RVA: 0x000034BF File Offset: 0x000016BF
		static Delegate93()
		{
			Class24.smethod_0(33554604, 167772246, 16777215);
		}

		// Token: 0x06000352 RID: 850
		public extern long Invoke(string string_0, int int_0);

		// Token: 0x06000353 RID: 851 RVA: 0x000034D5 File Offset: 0x000016D5
		public static long smethod_0(string string_0, int int_0)
		{
			return Delegate93.delegate93_0(string_0, int_0);
		}

		// Token: 0x0400022E RID: 558
		internal static readonly Delegate93 delegate93_0;
	}
}
