using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200019E RID: 414
	internal sealed class Delegate332 : MulticastDelegate
	{
		// Token: 0x06000717 RID: 1815
		public extern Delegate332(object object_0, IntPtr intptr_0);

		// Token: 0x06000718 RID: 1816 RVA: 0x000055B4 File Offset: 0x000037B4
		static Delegate332()
		{
			Class24.smethod_0(33554893, 167772455, 452984837);
		}

		// Token: 0x06000719 RID: 1817
		public extern void Invoke(ref AsyncTaskMethodBuilder<long> asyncTaskMethodBuilder_0, Exception exception_0);

		// Token: 0x0600071A RID: 1818 RVA: 0x000055CA File Offset: 0x000037CA
		public static void smethod_0(ref AsyncTaskMethodBuilder<long> asyncTaskMethodBuilder_0, Exception exception_0)
		{
			Delegate332.delegate332_0(ref asyncTaskMethodBuilder_0, exception_0);
		}

		// Token: 0x04000328 RID: 808
		internal static readonly Delegate332 delegate332_0;
	}
}
