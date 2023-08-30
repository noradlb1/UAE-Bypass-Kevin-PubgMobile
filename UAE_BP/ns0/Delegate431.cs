using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000205 RID: 517
	internal sealed class Delegate431 : MulticastDelegate
	{
		// Token: 0x060008A7 RID: 2215
		public extern Delegate431(object object_0, IntPtr intptr_0);

		// Token: 0x060008A8 RID: 2216 RVA: 0x0000635A File Offset: 0x0000455A
		static Delegate431()
		{
			Class24.smethod_0(33555010, 167772536, 452984842);
		}

		// Token: 0x060008A9 RID: 2217
		public extern void Invoke(ref AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0, Exception exception_0);

		// Token: 0x060008AA RID: 2218 RVA: 0x00006370 File Offset: 0x00004570
		public static void smethod_0(ref AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0, Exception exception_0)
		{
			Delegate431.delegate431_0(ref asyncTaskMethodBuilder_0, exception_0);
		}

		// Token: 0x0400038F RID: 911
		internal static readonly Delegate431 delegate431_0;
	}
}
