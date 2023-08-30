using System;
using System.Globalization;

namespace ns0
{
	// Token: 0x020001F4 RID: 500
	internal sealed class Delegate416 : MulticastDelegate
	{
		// Token: 0x06000869 RID: 2153
		public extern Delegate416(object object_0, IntPtr intptr_0);

		// Token: 0x0600086A RID: 2154 RVA: 0x00006145 File Offset: 0x00004345
		static Delegate416()
		{
			Class24.smethod_0(33554991, 167772523, 16777215);
		}

		// Token: 0x0600086B RID: 2155
		public extern int Invoke(string string_0, NumberStyles numberStyles_0);

		// Token: 0x0600086C RID: 2156 RVA: 0x0000615B File Offset: 0x0000435B
		public static int smethod_0(string string_0, NumberStyles numberStyles_0)
		{
			return Delegate416.delegate416_0(string_0, numberStyles_0);
		}

		// Token: 0x0400037E RID: 894
		internal static readonly Delegate416 delegate416_0;
	}
}
