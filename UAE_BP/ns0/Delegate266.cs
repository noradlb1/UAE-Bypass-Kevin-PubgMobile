using System;

namespace ns0
{
	// Token: 0x02000157 RID: 343
	internal sealed class Delegate266 : MulticastDelegate
	{
		// Token: 0x0600060A RID: 1546
		public extern Delegate266(object object_0, IntPtr intptr_0);

		// Token: 0x0600060B RID: 1547 RVA: 0x00004C99 File Offset: 0x00002E99
		static Delegate266()
		{
			Class24.smethod_0(33554803, 167772400, 16777215);
		}

		// Token: 0x0600060C RID: 1548
		public extern long Invoke(string string_0);

		// Token: 0x0600060D RID: 1549 RVA: 0x00004CAF File Offset: 0x00002EAF
		public static long smethod_0(string string_0)
		{
			return Delegate266.delegate266_0(string_0);
		}

		// Token: 0x040002E1 RID: 737
		internal static readonly Delegate266 delegate266_0;
	}
}
