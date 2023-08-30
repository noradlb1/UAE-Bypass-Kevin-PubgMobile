using System;

namespace ns0
{
	// Token: 0x02000068 RID: 104
	internal sealed class Delegate36 : MulticastDelegate
	{
		// Token: 0x06000269 RID: 617
		public extern Delegate36(object object_0, IntPtr intptr_0);

		// Token: 0x0600026A RID: 618 RVA: 0x00002CDC File Offset: 0x00000EDC
		static Delegate36()
		{
			Class24.smethod_0(33554537, 167772196, 16777215);
		}

		// Token: 0x0600026B RID: 619
		public extern bool Invoke(object object_0, string string_0, StringComparison stringComparison_0);

		// Token: 0x0600026C RID: 620 RVA: 0x00002CF2 File Offset: 0x00000EF2
		public static bool smethod_0(object object_0, string string_0, StringComparison stringComparison_0)
		{
			return Delegate36.delegate36_0(object_0, string_0, stringComparison_0);
		}

		// Token: 0x040001F2 RID: 498
		protected internal static readonly Delegate36 delegate36_0;
	}
}
