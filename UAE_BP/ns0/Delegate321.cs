using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000193 RID: 403
	internal sealed class Delegate321 : MulticastDelegate
	{
		// Token: 0x060006EB RID: 1771
		public extern Delegate321(object object_0, IntPtr intptr_0);

		// Token: 0x060006EC RID: 1772 RVA: 0x0000542C File Offset: 0x0000362C
		static Delegate321()
		{
			Class24.smethod_0(33554880, 167772444, 452984839);
		}

		// Token: 0x060006ED RID: 1773
		public extern IEnumerable<long> Invoke(ref TaskAwaiter<IEnumerable<long>> taskAwaiter_0);

		// Token: 0x060006EE RID: 1774 RVA: 0x00005442 File Offset: 0x00003642
		public static IEnumerable<long> smethod_0(ref TaskAwaiter<IEnumerable<long>> taskAwaiter_0)
		{
			return Delegate321.delegate321_0(ref taskAwaiter_0);
		}

		// Token: 0x0400031D RID: 797
		internal static readonly Delegate321 delegate321_0;
	}
}
