using System;

namespace ns0
{
	// Token: 0x02000069 RID: 105
	internal sealed class Delegate37 : MulticastDelegate
	{
		// Token: 0x0600026D RID: 621
		public extern Delegate37(object object_0, IntPtr intptr_0);

		// Token: 0x0600026E RID: 622 RVA: 0x00002D01 File Offset: 0x00000F01
		static Delegate37()
		{
			Class25.smethod_0(33554538, 167772197, 16777215);
		}

		// Token: 0x0600026F RID: 623
		public extern Exception Invoke(string string_0);

		// Token: 0x06000270 RID: 624 RVA: 0x00002D17 File Offset: 0x00000F17
		public static Exception smethod_0(string string_0)
		{
			return Delegate37.delegate37_0(string_0);
		}

		// Token: 0x040001F3 RID: 499
		internal static readonly Delegate37 delegate37_0;
	}
}
