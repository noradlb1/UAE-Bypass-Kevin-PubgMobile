using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000C5 RID: 197
	internal sealed class Delegate124 : MulticastDelegate
	{
		// Token: 0x060003CE RID: 974
		public extern Delegate124(object object_0, IntPtr intptr_0);

		// Token: 0x060003CF RID: 975 RVA: 0x00003904 File Offset: 0x00001B04
		static Delegate124()
		{
			Class24.smethod_0(33554641, 167772275, 452984844);
		}

		// Token: 0x060003D0 RID: 976
		public extern bool Invoke(ref TaskAwaiter<bool> taskAwaiter_0);

		// Token: 0x060003D1 RID: 977 RVA: 0x0000391A File Offset: 0x00001B1A
		public static bool smethod_0(ref TaskAwaiter<bool> taskAwaiter_0)
		{
			return Delegate124.delegate124_0(ref taskAwaiter_0);
		}

		// Token: 0x0400024F RID: 591
		internal static readonly Delegate124 delegate124_0;
	}
}
