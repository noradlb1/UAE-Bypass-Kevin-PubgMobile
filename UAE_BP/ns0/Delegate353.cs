using System;

namespace ns0
{
	// Token: 0x020001B5 RID: 437
	internal sealed class Delegate353 : MulticastDelegate
	{
		// Token: 0x0600076D RID: 1901
		public extern Delegate353(object object_0, IntPtr intptr_0);

		// Token: 0x0600076E RID: 1902 RVA: 0x00005894 File Offset: 0x00003A94
		static Delegate353()
		{
			Class24.smethod_0(33554917, 167772474, 16777215);
		}

		// Token: 0x0600076F RID: 1903
		public extern DateTime Invoke(ref DateTime dateTime_0, double double_0);

		// Token: 0x06000770 RID: 1904 RVA: 0x000058AA File Offset: 0x00003AAA
		public static DateTime smethod_0(ref DateTime dateTime_0, double double_0)
		{
			return Delegate353.delegate353_0(ref dateTime_0, double_0);
		}

		// Token: 0x0400033F RID: 831
		internal static readonly Delegate353 delegate353_0;
	}
}
