using System;
using System.IO;

namespace ns0
{
	// Token: 0x020001A7 RID: 423
	internal sealed class Delegate340 : MulticastDelegate
	{
		// Token: 0x06000738 RID: 1848
		public extern Delegate340(object object_0, IntPtr intptr_0);

		// Token: 0x06000739 RID: 1849 RVA: 0x000056CC File Offset: 0x000038CC
		static Delegate340()
		{
			Class25.smethod_0(33554902, 167772461, 16777215);
		}

		// Token: 0x0600073A RID: 1850
		public extern MemoryStream Invoke();

		// Token: 0x0600073B RID: 1851 RVA: 0x000056E2 File Offset: 0x000038E2
		public static MemoryStream smethod_0()
		{
			return Delegate340.delegate340_0();
		}

		// Token: 0x04000331 RID: 817
		internal static readonly Delegate340 delegate340_0;
	}
}
