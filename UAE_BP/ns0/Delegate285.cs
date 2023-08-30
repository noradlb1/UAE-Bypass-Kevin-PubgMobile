using System;

namespace ns0
{
	// Token: 0x0200016A RID: 362
	internal sealed class Delegate285 : MulticastDelegate
	{
		// Token: 0x06000656 RID: 1622
		public extern Delegate285(object object_0, IntPtr intptr_0);

		// Token: 0x06000657 RID: 1623 RVA: 0x00004F30 File Offset: 0x00003130
		static Delegate285()
		{
			Class24.smethod_0(33554824, 167772414, 16777215);
		}

		// Token: 0x06000658 RID: 1624
		public extern int Invoke(object object_0, string string_0);

		// Token: 0x06000659 RID: 1625 RVA: 0x00004F46 File Offset: 0x00003146
		public static int smethod_0(object object_0, string string_0)
		{
			return Delegate285.delegate285_0(object_0, string_0);
		}

		// Token: 0x040002F4 RID: 756
		protected internal static readonly Delegate285 delegate285_0;
	}
}
