using System;

namespace ns0
{
	// Token: 0x02000058 RID: 88
	internal sealed class Delegate20 : MulticastDelegate
	{
		// Token: 0x06000229 RID: 553
		public extern Delegate20(object object_0, IntPtr intptr_0);

		// Token: 0x0600022A RID: 554 RVA: 0x00002AA5 File Offset: 0x00000CA5
		static Delegate20()
		{
			Class24.smethod_0(33554521, 167772183, 16777215);
		}

		// Token: 0x0600022B RID: 555
		public extern void Invoke(object object_0, long long_0);

		// Token: 0x0600022C RID: 556 RVA: 0x00002ABB File Offset: 0x00000CBB
		public static void smethod_0(object object_0, long long_0)
		{
			Delegate20.delegate20_0(object_0, long_0);
		}

		// Token: 0x040001E2 RID: 482
		protected internal static readonly Delegate20 delegate20_0;
	}
}
