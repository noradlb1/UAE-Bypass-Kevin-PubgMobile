using System;

namespace ns0
{
	// Token: 0x02000207 RID: 519
	internal sealed class Delegate433 : MulticastDelegate
	{
		// Token: 0x060008AF RID: 2223
		public extern Delegate433(object object_0, IntPtr intptr_0);

		// Token: 0x060008B0 RID: 2224 RVA: 0x000063A2 File Offset: 0x000045A2
		static Delegate433()
		{
			Class24.smethod_0(33555013, 167772538, 16777215);
		}

		// Token: 0x060008B1 RID: 2225
		public extern bool Invoke(object object_0, string string_0, StringComparison stringComparison_0);

		// Token: 0x060008B2 RID: 2226 RVA: 0x000063B8 File Offset: 0x000045B8
		public static bool smethod_0(object object_0, string string_0, StringComparison stringComparison_0)
		{
			return Delegate433.delegate433_0(object_0, string_0, stringComparison_0);
		}

		// Token: 0x04000391 RID: 913
		protected internal static readonly Delegate433 delegate433_0;
	}
}
