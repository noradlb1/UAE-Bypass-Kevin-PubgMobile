using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000C7 RID: 199
	internal sealed class Delegate126 : MulticastDelegate
	{
		// Token: 0x060003D6 RID: 982
		public extern Delegate126(object object_0, IntPtr intptr_0);

		// Token: 0x060003D7 RID: 983 RVA: 0x00003949 File Offset: 0x00001B49
		static Delegate126()
		{
			Class24.smethod_0(33554643, 167772277, 16777215);
		}

		// Token: 0x060003D8 RID: 984
		public extern void Invoke(ref TaskAwaiter taskAwaiter_0);

		// Token: 0x060003D9 RID: 985 RVA: 0x0000395F File Offset: 0x00001B5F
		public static void smethod_0(ref TaskAwaiter taskAwaiter_0)
		{
			Delegate126.delegate126_0(ref taskAwaiter_0);
		}

		// Token: 0x04000251 RID: 593
		internal static readonly Delegate126 delegate126_0;
	}
}
