using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020001B3 RID: 435
	internal sealed class Delegate351 : MulticastDelegate
	{
		// Token: 0x06000765 RID: 1893
		public extern Delegate351(object object_0, IntPtr intptr_0);

		// Token: 0x06000766 RID: 1894 RVA: 0x0000584F File Offset: 0x00003A4F
		static Delegate351()
		{
			Class24.smethod_0(33554915, 167772472, 452984844);
		}

		// Token: 0x06000767 RID: 1895
		public extern bool Invoke(ref TaskAwaiter<bool> taskAwaiter_0);

		// Token: 0x06000768 RID: 1896 RVA: 0x00005865 File Offset: 0x00003A65
		public static bool smethod_0(ref TaskAwaiter<bool> taskAwaiter_0)
		{
			return Delegate351.delegate351_0(ref taskAwaiter_0);
		}

		// Token: 0x0400033D RID: 829
		internal static readonly Delegate351 delegate351_0;
	}
}
