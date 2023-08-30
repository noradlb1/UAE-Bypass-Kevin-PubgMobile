using System;
using System.Windows.Input;

namespace ns0
{
	// Token: 0x020001BF RID: 447
	internal sealed class Delegate363 : MulticastDelegate
	{
		// Token: 0x06000795 RID: 1941
		public extern Delegate363(object object_0, IntPtr intptr_0);

		// Token: 0x06000796 RID: 1942 RVA: 0x000059F8 File Offset: 0x00003BF8
		static Delegate363()
		{
			Class24.smethod_0(33554930, 167772482, 16777215);
		}

		// Token: 0x06000797 RID: 1943
		public extern void Invoke(object object_0, MouseButtonEventHandler mouseButtonEventHandler_0);

		// Token: 0x06000798 RID: 1944 RVA: 0x00005A0E File Offset: 0x00003C0E
		public static void smethod_0(object object_0, MouseButtonEventHandler mouseButtonEventHandler_0)
		{
			Delegate363.delegate363_0(object_0, mouseButtonEventHandler_0);
		}

		// Token: 0x04000349 RID: 841
		protected internal static readonly Delegate363 delegate363_0;
	}
}
