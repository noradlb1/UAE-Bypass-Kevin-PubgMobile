using System;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000087 RID: 135
	internal sealed class Delegate65 : MulticastDelegate
	{
		// Token: 0x060002DF RID: 735
		public extern Delegate65(object object_0, IntPtr intptr_0);

		// Token: 0x060002E0 RID: 736 RVA: 0x000030E6 File Offset: 0x000012E6
		static Delegate65()
		{
			Class24.smethod_0(33554570, 167772221, 16777215);
		}

		// Token: 0x060002E1 RID: 737
		public extern Aes Invoke();

		// Token: 0x060002E2 RID: 738 RVA: 0x000030FC File Offset: 0x000012FC
		public static Aes smethod_0()
		{
			return Delegate65.delegate65_0();
		}

		// Token: 0x04000211 RID: 529
		internal static readonly Delegate65 delegate65_0;
	}
}
