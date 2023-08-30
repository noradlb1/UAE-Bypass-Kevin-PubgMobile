using System;

namespace ns0
{
	// Token: 0x020000C9 RID: 201
	internal sealed class Delegate128 : MulticastDelegate
	{
		// Token: 0x060003DE RID: 990
		public extern Delegate128(object object_0, IntPtr intptr_0);

		// Token: 0x060003DF RID: 991 RVA: 0x0000398F File Offset: 0x00001B8F
		static Delegate128()
		{
			Class24.smethod_0(33554645, 100663643, 16777215);
		}

		// Token: 0x060003E0 RID: 992
		public extern void Invoke(object object_0, string value);

		// Token: 0x060003E1 RID: 993 RVA: 0x000039A5 File Offset: 0x00001BA5
		public static void smethod_0(object object_0, string string_0)
		{
			Delegate128.delegate128_0(object_0, string_0);
		}

		// Token: 0x04000253 RID: 595
		protected internal static readonly Delegate128 delegate128_0;
	}
}
