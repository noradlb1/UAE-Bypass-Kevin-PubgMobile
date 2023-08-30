using System;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000201 RID: 513
	internal sealed class Delegate427 : MulticastDelegate
	{
		// Token: 0x06000897 RID: 2199
		public extern Delegate427(object object_0, IntPtr intptr_0);

		// Token: 0x06000898 RID: 2200 RVA: 0x000062CF File Offset: 0x000044CF
		static Delegate427()
		{
			Class25.smethod_0(33555006, 167772533, 16777215);
		}

		// Token: 0x06000899 RID: 2201
		public extern DESCryptoServiceProvider Invoke();

		// Token: 0x0600089A RID: 2202 RVA: 0x000062E5 File Offset: 0x000044E5
		public static DESCryptoServiceProvider smethod_0()
		{
			return Delegate427.delegate427_0();
		}

		// Token: 0x0400038B RID: 907
		internal static readonly Delegate427 delegate427_0;
	}
}
