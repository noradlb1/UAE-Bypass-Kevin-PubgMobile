using System;

namespace ns0
{
	// Token: 0x0200009D RID: 157
	internal sealed class Delegate86 : MulticastDelegate
	{
		// Token: 0x06000334 RID: 820
		public extern Delegate86(object object_0, IntPtr intptr_0);

		// Token: 0x06000335 RID: 821 RVA: 0x000033CB File Offset: 0x000015CB
		static Delegate86()
		{
			Class24.smethod_0(33554596, 167772240, 16777215);
		}

		// Token: 0x06000336 RID: 822
		public extern long Invoke(IntPtr intptr_0);

		// Token: 0x06000337 RID: 823 RVA: 0x000033E1 File Offset: 0x000015E1
		public static long smethod_0(IntPtr intptr_0)
		{
			return Delegate86.delegate86_0(intptr_0);
		}

		// Token: 0x04000227 RID: 551
		internal static readonly Delegate86 delegate86_0;
	}
}
