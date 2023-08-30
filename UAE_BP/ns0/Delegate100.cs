using System;

namespace ns0
{
	// Token: 0x020000AB RID: 171
	internal sealed class Delegate100 : MulticastDelegate
	{
		// Token: 0x0600036C RID: 876
		public extern Delegate100(object object_0, IntPtr intptr_0);

		// Token: 0x0600036D RID: 877 RVA: 0x000035BA File Offset: 0x000017BA
		static Delegate100()
		{
			Class24.smethod_0(33554612, 167772252, 16777215);
		}

		// Token: 0x0600036E RID: 878
		public extern AppDomain Invoke();

		// Token: 0x0600036F RID: 879 RVA: 0x000035D0 File Offset: 0x000017D0
		public static AppDomain smethod_0()
		{
			return Delegate100.delegate100_0();
		}

		// Token: 0x04000235 RID: 565
		internal static readonly Delegate100 delegate100_0;
	}
}
