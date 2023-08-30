using System;

namespace ns0
{
	// Token: 0x020001BE RID: 446
	internal sealed class Delegate362 : MulticastDelegate
	{
		// Token: 0x06000791 RID: 1937
		public extern Delegate362(object object_0, IntPtr intptr_0);

		// Token: 0x06000792 RID: 1938 RVA: 0x000059D4 File Offset: 0x00003BD4
		static Delegate362()
		{
			Class24.smethod_0(33554929, 167772481, 16777215);
		}

		// Token: 0x06000793 RID: 1939
		public extern double Invoke(byte[] byte_0, int int_0);

		// Token: 0x06000794 RID: 1940 RVA: 0x000059EA File Offset: 0x00003BEA
		public static double smethod_0(byte[] byte_0, int int_0)
		{
			return Delegate362.delegate362_0(byte_0, int_0);
		}

		// Token: 0x04000348 RID: 840
		internal static readonly Delegate362 delegate362_0;
	}
}
