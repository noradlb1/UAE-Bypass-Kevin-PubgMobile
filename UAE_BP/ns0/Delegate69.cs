using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200008B RID: 139
	internal sealed class Delegate69 : MulticastDelegate
	{
		// Token: 0x060002EF RID: 751
		public extern Delegate69(object object_0, IntPtr intptr_0);

		// Token: 0x060002F0 RID: 752 RVA: 0x00003171 File Offset: 0x00001371
		static Delegate69()
		{
			Class24.smethod_0(33554575, 167772225, 452984837);
		}

		// Token: 0x060002F1 RID: 753
		public extern void Invoke(ref AsyncTaskMethodBuilder<long> asyncTaskMethodBuilder_0, long long_0);

		// Token: 0x060002F2 RID: 754 RVA: 0x00003187 File Offset: 0x00001387
		public static void smethod_0(ref AsyncTaskMethodBuilder<long> asyncTaskMethodBuilder_0, long long_0)
		{
			Delegate69.delegate69_0(ref asyncTaskMethodBuilder_0, long_0);
		}

		// Token: 0x04000215 RID: 533
		internal static readonly Delegate69 delegate69_0;
	}
}
