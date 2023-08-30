using System;
using System.Net;

namespace ns0
{
	// Token: 0x020001B1 RID: 433
	internal sealed class Delegate349 : MulticastDelegate
	{
		// Token: 0x0600075D RID: 1885
		public extern Delegate349(object object_0, IntPtr intptr_0);

		// Token: 0x0600075E RID: 1886 RVA: 0x00005807 File Offset: 0x00003A07
		static Delegate349()
		{
			Class24.smethod_0(33554913, 167772470, 16777215);
		}

		// Token: 0x0600075F RID: 1887
		public extern void Invoke(object object_0, AuthenticationSchemes authenticationSchemes_0);

		// Token: 0x06000760 RID: 1888 RVA: 0x0000581D File Offset: 0x00003A1D
		public static void smethod_0(object object_0, AuthenticationSchemes authenticationSchemes_0)
		{
			Delegate349.delegate349_0(object_0, authenticationSchemes_0);
		}

		// Token: 0x0400033B RID: 827
		protected internal static readonly Delegate349 delegate349_0;
	}
}
