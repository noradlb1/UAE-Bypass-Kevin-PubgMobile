using System;

namespace ns0
{
	// Token: 0x02000197 RID: 407
	internal sealed class Delegate325 : MulticastDelegate
	{
		// Token: 0x060006FB RID: 1787
		public extern Delegate325(object object_0, IntPtr intptr_0);

		// Token: 0x060006FC RID: 1788 RVA: 0x000054BA File Offset: 0x000036BA
		static Delegate325()
		{
			Class24.smethod_0(33554885, 167772448, 16777215);
		}

		// Token: 0x060006FD RID: 1789
		public extern void Invoke(string string_0, byte[] byte_0);

		// Token: 0x060006FE RID: 1790 RVA: 0x000054D0 File Offset: 0x000036D0
		public static void smethod_0(string string_0, byte[] byte_0)
		{
			Delegate325.delegate325_0(string_0, byte_0);
		}

		// Token: 0x04000321 RID: 801
		internal static readonly Delegate325 delegate325_0;
	}
}
