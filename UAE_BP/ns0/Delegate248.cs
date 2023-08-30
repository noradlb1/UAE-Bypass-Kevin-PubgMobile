using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000145 RID: 325
	internal sealed class Delegate248 : MulticastDelegate
	{
		// Token: 0x060005C2 RID: 1474
		public extern Delegate248(object object_0, IntPtr intptr_0);

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004A1F File Offset: 0x00002C1F
		static Delegate248()
		{
			Class24.smethod_0(33554785, 167772385, 16777215);
		}

		// Token: 0x060005C4 RID: 1476
		public extern TaskAwaiter Invoke(object object_0);

		// Token: 0x060005C5 RID: 1477 RVA: 0x00004A35 File Offset: 0x00002C35
		public static TaskAwaiter smethod_0(object object_0)
		{
			return Delegate248.delegate248_0(object_0);
		}

		// Token: 0x040002CF RID: 719
		protected internal static readonly Delegate248 delegate248_0;
	}
}
