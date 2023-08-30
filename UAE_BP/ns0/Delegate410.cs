using System;

namespace ns0
{
	// Token: 0x020001EE RID: 494
	internal sealed class Delegate410 : MulticastDelegate
	{
		// Token: 0x06000851 RID: 2129
		public extern Delegate410(object object_0, IntPtr intptr_0);

		// Token: 0x06000852 RID: 2130 RVA: 0x00006070 File Offset: 0x00004270
		static Delegate410()
		{
			Class24.smethod_0(33554985, 167772518, 16777215);
		}

		// Token: 0x06000853 RID: 2131
		public extern string Invoke(ref int int_0);

		// Token: 0x06000854 RID: 2132 RVA: 0x00006086 File Offset: 0x00004286
		public static string smethod_0(ref int int_0)
		{
			return Delegate410.delegate410_0(ref int_0);
		}

		// Token: 0x04000378 RID: 888
		internal static readonly Delegate410 delegate410_0;
	}
}
