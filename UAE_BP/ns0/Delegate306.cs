using System;

namespace ns0
{
	// Token: 0x02000181 RID: 385
	internal sealed class Delegate306 : MulticastDelegate
	{
		// Token: 0x060006AC RID: 1708
		public extern Delegate306(object object_0, IntPtr intptr_0);

		// Token: 0x060006AD RID: 1709 RVA: 0x0000521A File Offset: 0x0000341A
		static Delegate306()
		{
			Class24.smethod_0(33554853, 167772431, 16777215);
		}

		// Token: 0x060006AE RID: 1710
		public extern int Invoke(object object_0, string string_0, StringComparison stringComparison_0);

		// Token: 0x060006AF RID: 1711 RVA: 0x00005230 File Offset: 0x00003430
		public static int smethod_0(object object_0, string string_0, StringComparison stringComparison_0)
		{
			return Delegate306.delegate306_0(object_0, string_0, stringComparison_0);
		}

		// Token: 0x0400030B RID: 779
		protected internal static readonly Delegate306 delegate306_0;
	}
}
