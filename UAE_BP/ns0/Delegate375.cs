using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x020001CB RID: 459
	internal sealed class Delegate375 : MulticastDelegate
	{
		// Token: 0x060007C5 RID: 1989
		public extern Delegate375(object object_0, IntPtr intptr_0);

		// Token: 0x060007C6 RID: 1990 RVA: 0x00005B9F File Offset: 0x00003D9F
		static Delegate375()
		{
			Class25.smethod_0(33554945, 167772491, 16777215);
		}

		// Token: 0x060007C7 RID: 1991
		public extern Process Invoke();

		// Token: 0x060007C8 RID: 1992 RVA: 0x00005BB5 File Offset: 0x00003DB5
		public static Process smethod_0()
		{
			return Delegate375.delegate375_0();
		}

		// Token: 0x04000355 RID: 853
		internal static readonly Delegate375 delegate375_0;
	}
}
