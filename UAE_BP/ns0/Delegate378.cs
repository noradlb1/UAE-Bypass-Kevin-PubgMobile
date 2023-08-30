using System;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x020001CE RID: 462
	internal sealed class Delegate378 : MulticastDelegate
	{
		// Token: 0x060007D1 RID: 2001
		public extern Delegate378(object object_0, IntPtr intptr_0);

		// Token: 0x060007D2 RID: 2002 RVA: 0x00005C08 File Offset: 0x00003E08
		static Delegate378()
		{
			Class24.smethod_0(33554948, 167772494, 16777215);
		}

		// Token: 0x060007D3 RID: 2003
		public extern void Invoke(object object_0, CipherMode cipherMode_0);

		// Token: 0x060007D4 RID: 2004 RVA: 0x00005C1E File Offset: 0x00003E1E
		public static void smethod_0(object object_0, CipherMode cipherMode_0)
		{
			Delegate378.delegate378_0(object_0, cipherMode_0);
		}

		// Token: 0x04000358 RID: 856
		protected internal static readonly Delegate378 delegate378_0;
	}
}
