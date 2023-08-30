using System;

namespace ns0
{
	// Token: 0x02000158 RID: 344
	internal sealed class Delegate267 : MulticastDelegate
	{
		// Token: 0x0600060E RID: 1550
		public extern Delegate267(object object_0, IntPtr intptr_0);

		// Token: 0x0600060F RID: 1551 RVA: 0x00004CBC File Offset: 0x00002EBC
		static Delegate267()
		{
			Class24.smethod_0(33554804, 100663639, 16777215);
		}

		// Token: 0x06000610 RID: 1552
		public extern void Invoke(object object_0, string value);

		// Token: 0x06000611 RID: 1553 RVA: 0x00004CD2 File Offset: 0x00002ED2
		public static void smethod_0(object object_0, string string_0)
		{
			Delegate267.delegate267_0(object_0, string_0);
		}

		// Token: 0x040002E2 RID: 738
		protected internal static readonly Delegate267 delegate267_0;
	}
}
