using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x020000A9 RID: 169
	internal sealed class Delegate98 : MulticastDelegate
	{
		// Token: 0x06000364 RID: 868
		public extern Delegate98(object object_0, IntPtr intptr_0);

		// Token: 0x06000365 RID: 869 RVA: 0x00003573 File Offset: 0x00001773
		static Delegate98()
		{
			Class24.smethod_0(33554610, 100663584, 16777215);
		}

		// Token: 0x06000366 RID: 870
		public extern List<GClass0.GClass1> Invoke(object object_0);

		// Token: 0x06000367 RID: 871 RVA: 0x00003589 File Offset: 0x00001789
		public static List<GClass0.GClass1> smethod_0(object object_0)
		{
			return Delegate98.delegate98_0(object_0);
		}

		// Token: 0x04000233 RID: 563
		protected internal static readonly Delegate98 delegate98_0;
	}
}
