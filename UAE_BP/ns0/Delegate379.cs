using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x020001CF RID: 463
	internal sealed class Delegate379 : MulticastDelegate
	{
		// Token: 0x060007D5 RID: 2005
		public extern Delegate379(object object_0, IntPtr intptr_0);

		// Token: 0x060007D6 RID: 2006 RVA: 0x00005C2C File Offset: 0x00003E2C
		static Delegate379()
		{
			Class24.smethod_0(33554949, 167772495, 452984840);
		}

		// Token: 0x060007D7 RID: 2007
		public extern bool Invoke(ref List<string>.Enumerator enumerator_0);

		// Token: 0x060007D8 RID: 2008 RVA: 0x00005C42 File Offset: 0x00003E42
		public static bool smethod_0(ref List<string>.Enumerator enumerator_0)
		{
			return Delegate379.delegate379_0(ref enumerator_0);
		}

		// Token: 0x04000359 RID: 857
		internal static readonly Delegate379 delegate379_0;
	}
}
