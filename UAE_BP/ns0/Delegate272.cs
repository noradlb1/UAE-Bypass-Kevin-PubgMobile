using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200015D RID: 349
	internal sealed class Delegate272 : MulticastDelegate
	{
		// Token: 0x06000622 RID: 1570
		public extern Delegate272(object object_0, IntPtr intptr_0);

		// Token: 0x06000623 RID: 1571 RVA: 0x00004D6C File Offset: 0x00002F6C
		static Delegate272()
		{
			Class24.smethod_0(33554810, 167772404, 452984846);
		}

		// Token: 0x06000624 RID: 1572
		public extern TaskAwaiter<IEnumerable<long>> Invoke(object object_0);

		// Token: 0x06000625 RID: 1573 RVA: 0x00004D82 File Offset: 0x00002F82
		public static TaskAwaiter<IEnumerable<long>> smethod_0(object object_0)
		{
			return Delegate272.delegate272_0(object_0);
		}

		// Token: 0x040002E7 RID: 743
		protected internal static readonly Delegate272 delegate272_0;
	}
}
