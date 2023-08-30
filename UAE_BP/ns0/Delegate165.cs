using System;
using System.Reflection;

namespace ns0
{
	// Token: 0x020000EF RID: 239
	internal sealed class Delegate165 : MulticastDelegate
	{
		// Token: 0x06000473 RID: 1139
		public extern Delegate165(object object_0, IntPtr intptr_0);

		// Token: 0x06000474 RID: 1140 RVA: 0x00003E9D File Offset: 0x0000209D
		static Delegate165()
		{
			Class24.smethod_0(33554689, 167772314, 16777215);
		}

		// Token: 0x06000475 RID: 1141
		public extern Assembly Invoke(object object_0);

		// Token: 0x06000476 RID: 1142 RVA: 0x00003EB3 File Offset: 0x000020B3
		public static Assembly smethod_0(object object_0)
		{
			return Delegate165.delegate165_0(object_0);
		}

		// Token: 0x04000279 RID: 633
		protected internal static readonly Delegate165 delegate165_0;
	}
}
