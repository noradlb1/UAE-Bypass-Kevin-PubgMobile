using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x02000093 RID: 147
	internal sealed class Delegate77 : MulticastDelegate
	{
		// Token: 0x0600030F RID: 783
		public extern Delegate77(object object_0, IntPtr intptr_0);

		// Token: 0x06000310 RID: 784 RVA: 0x0000328D File Offset: 0x0000148D
		static Delegate77()
		{
			Class24.smethod_0(33554584, 167772231, 452984838);
		}

		// Token: 0x06000311 RID: 785
		public extern List<string>.Enumerator Invoke(object object_0);

		// Token: 0x06000312 RID: 786 RVA: 0x000032A3 File Offset: 0x000014A3
		public static List<string>.Enumerator smethod_0(object object_0)
		{
			return Delegate77.delegate77_0(object_0);
		}

		// Token: 0x0400021D RID: 541
		protected internal static readonly Delegate77 delegate77_0;
	}
}
