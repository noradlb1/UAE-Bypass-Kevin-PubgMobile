using System;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x020001F5 RID: 501
	internal sealed class Delegate417 : MulticastDelegate
	{
		// Token: 0x0600086D RID: 2157
		public extern Delegate417(object object_0, IntPtr intptr_0);

		// Token: 0x0600086E RID: 2158 RVA: 0x00006169 File Offset: 0x00004369
		static Delegate417()
		{
			Class25.smethod_0(33554992, 167772524, 16777215);
		}

		// Token: 0x0600086F RID: 2159
		public extern SHA256Managed Invoke();

		// Token: 0x06000870 RID: 2160 RVA: 0x0000617F File Offset: 0x0000437F
		public static SHA256Managed smethod_0()
		{
			return Delegate417.delegate417_0();
		}

		// Token: 0x0400037F RID: 895
		internal static readonly Delegate417 delegate417_0;
	}
}
