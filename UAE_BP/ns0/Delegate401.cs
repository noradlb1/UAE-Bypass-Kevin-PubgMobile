using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020001E5 RID: 485
	internal sealed class Delegate401 : MulticastDelegate
	{
		// Token: 0x0600082D RID: 2093
		public extern Delegate401(object object_0, IntPtr intptr_0);

		// Token: 0x0600082E RID: 2094 RVA: 0x00005F36 File Offset: 0x00004136
		static Delegate401()
		{
			Class24.smethod_0(33554976, 167772511, 16777215);
		}

		// Token: 0x0600082F RID: 2095
		public extern AsyncVoidMethodBuilder Invoke();

		// Token: 0x06000830 RID: 2096 RVA: 0x00005F4C File Offset: 0x0000414C
		public static AsyncVoidMethodBuilder smethod_0()
		{
			return Delegate401.delegate401_0();
		}

		// Token: 0x0400036F RID: 879
		internal static readonly Delegate401 delegate401_0;
	}
}
