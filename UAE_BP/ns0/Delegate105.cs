using System;

namespace ns0
{
	// Token: 0x020000B2 RID: 178
	internal sealed class Delegate105 : MulticastDelegate
	{
		// Token: 0x06000382 RID: 898
		public extern Delegate105(object object_0, IntPtr intptr_0);

		// Token: 0x06000383 RID: 899 RVA: 0x00003667 File Offset: 0x00001867
		static Delegate105()
		{
			Class24.smethod_0(33554619, 167772257, 452984836);
		}

		// Token: 0x06000384 RID: 900
		public extern IntPtr Invoke(object object_0, string string_0);

		// Token: 0x06000385 RID: 901 RVA: 0x0000367D File Offset: 0x0000187D
		public static IntPtr smethod_0(object object_0, string string_0)
		{
			return Delegate105.delegate105_0(object_0, string_0);
		}

		// Token: 0x0400023C RID: 572
		protected internal static readonly Delegate105 delegate105_0;
	}
}
