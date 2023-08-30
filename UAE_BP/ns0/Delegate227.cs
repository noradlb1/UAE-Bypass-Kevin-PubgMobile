using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000130 RID: 304
	internal sealed class Delegate227 : MulticastDelegate
	{
		// Token: 0x0600056E RID: 1390
		public extern Delegate227(object object_0, IntPtr intptr_0);

		// Token: 0x0600056F RID: 1391 RVA: 0x0000472C File Offset: 0x0000292C
		static Delegate227()
		{
			Class24.smethod_0(33554762, 167772369, 452984842);
		}

		// Token: 0x06000570 RID: 1392
		public extern void Invoke(ref AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0, bool bool_0);

		// Token: 0x06000571 RID: 1393 RVA: 0x00004742 File Offset: 0x00002942
		public static void smethod_0(ref AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0, bool bool_0)
		{
			Delegate227.delegate227_0(ref asyncTaskMethodBuilder_0, bool_0);
		}

		// Token: 0x040002BA RID: 698
		internal static readonly Delegate227 delegate227_0;
	}
}
