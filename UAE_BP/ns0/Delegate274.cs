using System;
using System.Collections.Concurrent;

namespace ns0
{
	// Token: 0x0200015F RID: 351
	internal sealed class Delegate274 : MulticastDelegate
	{
		// Token: 0x0600062A RID: 1578
		public extern Delegate274(object object_0, IntPtr intptr_0);

		// Token: 0x0600062B RID: 1579 RVA: 0x00004DB1 File Offset: 0x00002FB1
		static Delegate274()
		{
			Class25.smethod_0(33554812, 167772406, 452984835);
		}

		// Token: 0x0600062C RID: 1580
		public extern ConcurrentBag<long> Invoke();

		// Token: 0x0600062D RID: 1581 RVA: 0x00004DC7 File Offset: 0x00002FC7
		public static ConcurrentBag<long> smethod_0()
		{
			return Delegate274.delegate274_0();
		}

		// Token: 0x040002E9 RID: 745
		internal static readonly Delegate274 delegate274_0;
	}
}
