using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200017A RID: 378
	internal sealed class Delegate300 : MulticastDelegate
	{
		// Token: 0x06000693 RID: 1683
		public extern Delegate300(object object_0, IntPtr intptr_0);

		// Token: 0x06000694 RID: 1684 RVA: 0x00005148 File Offset: 0x00003348
		static Delegate300()
		{
			Class24.smethod_0(33554846, 167772425, 452984847);
		}

		// Token: 0x06000695 RID: 1685
		public extern TaskAwaiter<bool> Invoke(object object_0);

		// Token: 0x06000696 RID: 1686 RVA: 0x0000515E File Offset: 0x0000335E
		public static TaskAwaiter<bool> smethod_0(object object_0)
		{
			return Delegate300.delegate300_0(object_0);
		}

		// Token: 0x04000304 RID: 772
		protected internal static readonly Delegate300 delegate300_0;
	}
}
