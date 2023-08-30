using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000148 RID: 328
	internal sealed class Delegate251 : MulticastDelegate
	{
		// Token: 0x060005CE RID: 1486
		public extern Delegate251(object object_0, IntPtr intptr_0);

		// Token: 0x060005CF RID: 1487 RVA: 0x00004A8C File Offset: 0x00002C8C
		static Delegate251()
		{
			Class24.smethod_0(33554788, 167772388, 452984837);
		}

		// Token: 0x060005D0 RID: 1488
		public extern AsyncTaskMethodBuilder<long> Invoke();

		// Token: 0x060005D1 RID: 1489 RVA: 0x00004AA2 File Offset: 0x00002CA2
		public static AsyncTaskMethodBuilder<long> smethod_0()
		{
			return Delegate251.delegate251_0();
		}

		// Token: 0x040002D2 RID: 722
		internal static readonly Delegate251 delegate251_0;
	}
}
