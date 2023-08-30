using System;

namespace ns0
{
	// Token: 0x0200009B RID: 155
	internal sealed class Delegate84 : MulticastDelegate
	{
		// Token: 0x0600032C RID: 812
		public extern Delegate84(object object_0, IntPtr intptr_0);

		// Token: 0x0600032D RID: 813 RVA: 0x00003384 File Offset: 0x00001584
		static Delegate84()
		{
			Class24.smethod_0(33554594, 167772238, 16777215);
		}

		// Token: 0x0600032E RID: 814
		public extern Version Invoke(object object_0);

		// Token: 0x0600032F RID: 815 RVA: 0x0000339A File Offset: 0x0000159A
		public static Version smethod_0(object object_0)
		{
			return Delegate84.delegate84_0(object_0);
		}

		// Token: 0x04000225 RID: 549
		protected internal static readonly Delegate84 delegate84_0;
	}
}
