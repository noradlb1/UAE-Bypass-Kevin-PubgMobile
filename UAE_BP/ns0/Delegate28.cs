using System;

namespace ns0
{
	// Token: 0x02000060 RID: 96
	internal sealed class Delegate28 : MulticastDelegate
	{
		// Token: 0x06000249 RID: 585
		public extern Delegate28(object object_0, IntPtr intptr_0);

		// Token: 0x0600024A RID: 586 RVA: 0x00002BC2 File Offset: 0x00000DC2
		static Delegate28()
		{
			Class24.smethod_0(33554529, 167772190, 16777215);
		}

		// Token: 0x0600024B RID: 587
		public extern IntPtr Invoke(object object_0);

		// Token: 0x0600024C RID: 588 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public static IntPtr smethod_0(object object_0)
		{
			return Delegate28.delegate28_0(object_0);
		}

		// Token: 0x040001EA RID: 490
		protected internal static readonly Delegate28 delegate28_0;
	}
}
