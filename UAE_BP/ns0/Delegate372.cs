using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x020001C8 RID: 456
	internal sealed class Delegate372 : MulticastDelegate
	{
		// Token: 0x060007B9 RID: 1977
		public extern Delegate372(object object_0, IntPtr intptr_0);

		// Token: 0x060007BA RID: 1978 RVA: 0x00005B37 File Offset: 0x00003D37
		static Delegate372()
		{
			Class24.smethod_0(33554940, 167772490, 16777215);
		}

		// Token: 0x060007BB RID: 1979
		public extern Process[] Invoke(string string_0);

		// Token: 0x060007BC RID: 1980 RVA: 0x00005B4D File Offset: 0x00003D4D
		public static Process[] smethod_0(string string_0)
		{
			return Delegate372.delegate372_0(string_0);
		}

		// Token: 0x04000352 RID: 850
		internal static readonly Delegate372 delegate372_0;
	}
}
