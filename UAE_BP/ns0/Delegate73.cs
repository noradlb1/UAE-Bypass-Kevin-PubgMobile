using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200008F RID: 143
	internal sealed class Delegate73 : MulticastDelegate
	{
		// Token: 0x060002FF RID: 767
		public extern Delegate73(object object_0, IntPtr intptr_0);

		// Token: 0x06000300 RID: 768 RVA: 0x000031FE File Offset: 0x000013FE
		static Delegate73()
		{
			Class24.smethod_0(33554579, 167772228, 16777215);
		}

		// Token: 0x06000301 RID: 769
		public extern void Invoke(ref AsyncVoidMethodBuilder asyncVoidMethodBuilder_0, Exception exception_0);

		// Token: 0x06000302 RID: 770 RVA: 0x00003214 File Offset: 0x00001414
		public static void smethod_0(ref AsyncVoidMethodBuilder asyncVoidMethodBuilder_0, Exception exception_0)
		{
			Delegate73.delegate73_0(ref asyncVoidMethodBuilder_0, exception_0);
		}

		// Token: 0x04000219 RID: 537
		internal static readonly Delegate73 delegate73_0;
	}
}
