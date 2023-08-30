using System;

namespace ns0
{
	// Token: 0x02000184 RID: 388
	internal sealed class Delegate309 : MulticastDelegate
	{
		// Token: 0x060006B8 RID: 1720
		public extern Delegate309(object object_0, IntPtr intptr_0);

		// Token: 0x060006B9 RID: 1721 RVA: 0x00005283 File Offset: 0x00003483
		static Delegate309()
		{
			Class24.smethod_0(33554857, 167772433, 16777215);
		}

		// Token: 0x060006BA RID: 1722
		public extern bool Invoke(object object_0, string string_0);

		// Token: 0x060006BB RID: 1723 RVA: 0x00005299 File Offset: 0x00003499
		public static bool smethod_0(object object_0, string string_0)
		{
			return Delegate309.delegate309_0(object_0, string_0);
		}

		// Token: 0x0400030E RID: 782
		protected internal static readonly Delegate309 delegate309_0;
	}
}
