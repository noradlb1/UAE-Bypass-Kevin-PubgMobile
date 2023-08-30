using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000119 RID: 281
	internal sealed class Delegate205 : MulticastDelegate
	{
		// Token: 0x06000515 RID: 1301
		public extern Delegate205(object object_0, IntPtr intptr_0);

		// Token: 0x06000516 RID: 1302 RVA: 0x00004424 File Offset: 0x00002624
		static Delegate205()
		{
			Class24.smethod_0(33554738, 167772349, 16777215);
		}

		// Token: 0x06000517 RID: 1303
		public extern bool Invoke(ref TaskAwaiter taskAwaiter_0);

		// Token: 0x06000518 RID: 1304 RVA: 0x0000443A File Offset: 0x0000263A
		public static bool smethod_0(ref TaskAwaiter taskAwaiter_0)
		{
			return Delegate205.delegate205_0(ref taskAwaiter_0);
		}

		// Token: 0x040002A3 RID: 675
		internal static readonly Delegate205 delegate205_0;
	}
}
