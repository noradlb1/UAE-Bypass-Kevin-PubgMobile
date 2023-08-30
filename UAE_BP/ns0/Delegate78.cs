using System;

namespace ns0
{
	// Token: 0x02000094 RID: 148
	internal sealed class Delegate78 : MulticastDelegate
	{
		// Token: 0x06000313 RID: 787
		public extern Delegate78(object object_0, IntPtr intptr_0);

		// Token: 0x06000314 RID: 788 RVA: 0x000032B0 File Offset: 0x000014B0
		static Delegate78()
		{
			Class24.smethod_0(33554586, 167772232, 16777215);
		}

		// Token: 0x06000315 RID: 789
		public extern byte[] Invoke(object object_0, string string_0);

		// Token: 0x06000316 RID: 790 RVA: 0x000032C6 File Offset: 0x000014C6
		public static byte[] smethod_0(object object_0, string string_0)
		{
			return Delegate78.delegate78_0(object_0, string_0);
		}

		// Token: 0x0400021E RID: 542
		protected internal static readonly Delegate78 delegate78_0;
	}
}
