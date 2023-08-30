using System;

namespace ns0
{
	// Token: 0x02000061 RID: 97
	internal sealed class Delegate29 : MulticastDelegate
	{
		// Token: 0x0600024D RID: 589
		public extern Delegate29(object object_0, IntPtr intptr_0);

		// Token: 0x0600024E RID: 590 RVA: 0x00002BE5 File Offset: 0x00000DE5
		static Delegate29()
		{
			Class24.smethod_0(33554530, 100663649, 16777215);
		}

		// Token: 0x0600024F RID: 591
		public extern void Invoke(object object_0, string value);

		// Token: 0x06000250 RID: 592 RVA: 0x00002BFB File Offset: 0x00000DFB
		public static void smethod_0(object object_0, string string_0)
		{
			Delegate29.delegate29_0(object_0, string_0);
		}

		// Token: 0x040001EB RID: 491
		protected internal static readonly Delegate29 delegate29_0;
	}
}
