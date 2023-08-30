using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200017F RID: 383
	internal sealed class Delegate304 : MulticastDelegate
	{
		// Token: 0x060006A4 RID: 1700
		public extern Delegate304(object object_0, IntPtr intptr_0);

		// Token: 0x060006A5 RID: 1701 RVA: 0x000051D5 File Offset: 0x000033D5
		static Delegate304()
		{
			Class24.smethod_0(33554851, 167772429, 16777215);
		}

		// Token: 0x060006A6 RID: 1702
		public extern AsyncTaskMethodBuilder Invoke();

		// Token: 0x060006A7 RID: 1703 RVA: 0x000051EB File Offset: 0x000033EB
		public static AsyncTaskMethodBuilder smethod_0()
		{
			return Delegate304.delegate304_0();
		}

		// Token: 0x04000309 RID: 777
		internal static readonly Delegate304 delegate304_0;
	}
}
