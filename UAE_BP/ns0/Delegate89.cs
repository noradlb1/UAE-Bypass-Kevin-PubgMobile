using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000A0 RID: 160
	internal sealed class Delegate89 : MulticastDelegate
	{
		// Token: 0x06000340 RID: 832
		public extern Delegate89(object object_0, IntPtr intptr_0);

		// Token: 0x06000341 RID: 833 RVA: 0x00003434 File Offset: 0x00001634
		static Delegate89()
		{
			Class24.smethod_0(33554600, 167772243, 452984839);
		}

		// Token: 0x06000342 RID: 834
		public extern bool Invoke(ref TaskAwaiter<IEnumerable<long>> taskAwaiter_0);

		// Token: 0x06000343 RID: 835 RVA: 0x0000344A File Offset: 0x0000164A
		public static bool smethod_0(ref TaskAwaiter<IEnumerable<long>> taskAwaiter_0)
		{
			return Delegate89.delegate89_0(ref taskAwaiter_0);
		}

		// Token: 0x0400022A RID: 554
		internal static readonly Delegate89 delegate89_0;
	}
}
