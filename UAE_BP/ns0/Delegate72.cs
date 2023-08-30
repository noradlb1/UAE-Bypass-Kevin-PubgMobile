using System;

namespace ns0
{
	// Token: 0x0200008E RID: 142
	internal sealed class Delegate72 : MulticastDelegate
	{
		// Token: 0x060002FB RID: 763
		public extern Delegate72(object object_0, IntPtr intptr_0);

		// Token: 0x060002FC RID: 764 RVA: 0x000031DB File Offset: 0x000013DB
		static Delegate72()
		{
			Class24.smethod_0(33554578, 100663459, 16777215);
		}

		// Token: 0x060002FD RID: 765
		public extern long Invoke(ref Struct0 struct0_0);

		// Token: 0x060002FE RID: 766 RVA: 0x000031F1 File Offset: 0x000013F1
		public static long smethod_0(ref Struct0 struct0_0)
		{
			return Delegate72.delegate72_0(ref struct0_0);
		}

		// Token: 0x04000218 RID: 536
		internal static readonly Delegate72 delegate72_0;
	}
}
