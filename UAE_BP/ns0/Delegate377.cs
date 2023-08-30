using System;
using System.Text;

namespace ns0
{
	// Token: 0x020001CD RID: 461
	internal sealed class Delegate377 : MulticastDelegate
	{
		// Token: 0x060007CD RID: 1997
		public extern Delegate377(object object_0, IntPtr intptr_0);

		// Token: 0x060007CE RID: 1998 RVA: 0x00005BE4 File Offset: 0x00003DE4
		static Delegate377()
		{
			Class24.smethod_0(33554947, 167772493, 16777215);
		}

		// Token: 0x060007CF RID: 1999
		public extern StringBuilder Invoke(object object_0, string string_0);

		// Token: 0x060007D0 RID: 2000 RVA: 0x00005BFA File Offset: 0x00003DFA
		public static StringBuilder smethod_0(object object_0, string string_0)
		{
			return Delegate377.delegate377_0(object_0, string_0);
		}

		// Token: 0x04000357 RID: 855
		protected internal static readonly Delegate377 delegate377_0;
	}
}
