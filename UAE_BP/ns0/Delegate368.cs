using System;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x020001C4 RID: 452
	internal sealed class Delegate368 : MulticastDelegate
	{
		// Token: 0x060007A9 RID: 1961
		public extern Delegate368(object object_0, IntPtr intptr_0);

		// Token: 0x060007AA RID: 1962 RVA: 0x00005AA9 File Offset: 0x00003CA9
		static Delegate368()
		{
			Class24.smethod_0(33554935, 167772487, 16777215);
		}

		// Token: 0x060007AB RID: 1963
		public extern MD5 Invoke();

		// Token: 0x060007AC RID: 1964 RVA: 0x00005ABF File Offset: 0x00003CBF
		public static MD5 smethod_0()
		{
			return Delegate368.delegate368_0();
		}

		// Token: 0x0400034E RID: 846
		internal static readonly Delegate368 delegate368_0;
	}
}
