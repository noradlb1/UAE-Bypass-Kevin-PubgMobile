using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200018F RID: 399
	internal sealed class Delegate317 : MulticastDelegate
	{
		// Token: 0x060006DB RID: 1755
		public extern Delegate317(object object_0, IntPtr intptr_0);

		// Token: 0x060006DC RID: 1756 RVA: 0x000053A0 File Offset: 0x000035A0
		static Delegate317()
		{
			Class24.smethod_0(33554874, 167772441, 16777215);
		}

		// Token: 0x060006DD RID: 1757
		public extern void Invoke(ref AsyncVoidMethodBuilder asyncVoidMethodBuilder_0);

		// Token: 0x060006DE RID: 1758 RVA: 0x000053B6 File Offset: 0x000035B6
		public static void smethod_0(ref AsyncVoidMethodBuilder asyncVoidMethodBuilder_0)
		{
			Delegate317.delegate317_0(ref asyncVoidMethodBuilder_0);
		}

		// Token: 0x04000319 RID: 793
		internal static readonly Delegate317 delegate317_0;
	}
}
