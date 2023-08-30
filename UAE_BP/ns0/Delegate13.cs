using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000051 RID: 81
	internal sealed class Delegate13 : MulticastDelegate
	{
		// Token: 0x0600020D RID: 525
		public extern Delegate13(object object_0, IntPtr intptr_0);

		// Token: 0x0600020E RID: 526 RVA: 0x000029AF File Offset: 0x00000BAF
		static Delegate13()
		{
			Class24.smethod_0(33554514, 167772179, 16777215);
		}

		// Token: 0x0600020F RID: 527
		public extern void Invoke(ref AsyncTaskMethodBuilder asyncTaskMethodBuilder_0, Exception exception_0);

		// Token: 0x06000210 RID: 528 RVA: 0x000029C5 File Offset: 0x00000BC5
		public static void smethod_0(ref AsyncTaskMethodBuilder asyncTaskMethodBuilder_0, Exception exception_0)
		{
			Delegate13.delegate13_0(ref asyncTaskMethodBuilder_0, exception_0);
		}

		// Token: 0x040001DB RID: 475
		internal static readonly Delegate13 delegate13_0;
	}
}
