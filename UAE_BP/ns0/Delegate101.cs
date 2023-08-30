using System;

namespace ns0
{
	// Token: 0x020000AC RID: 172
	internal sealed class Delegate101 : MulticastDelegate
	{
		// Token: 0x06000370 RID: 880
		public extern Delegate101(object object_0, IntPtr intptr_0);

		// Token: 0x06000371 RID: 881 RVA: 0x000035DC File Offset: 0x000017DC
		static Delegate101()
		{
			Class24.smethod_0(33554613, 167772253, 16777215);
		}

		// Token: 0x06000372 RID: 882
		public extern int Invoke(IntPtr intptr_0);

		// Token: 0x06000373 RID: 883 RVA: 0x000035F2 File Offset: 0x000017F2
		public static int smethod_0(IntPtr intptr_0)
		{
			return Delegate101.delegate101_0(intptr_0);
		}

		// Token: 0x04000236 RID: 566
		internal static readonly Delegate101 delegate101_0;
	}
}
