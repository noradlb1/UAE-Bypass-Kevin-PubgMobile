using System;

namespace ns0
{
	// Token: 0x020001C7 RID: 455
	internal sealed class Delegate371 : MulticastDelegate
	{
		// Token: 0x060007B5 RID: 1973
		public extern Delegate371(object object_0, IntPtr intptr_0);

		// Token: 0x060007B6 RID: 1974 RVA: 0x00005B12 File Offset: 0x00003D12
		static Delegate371()
		{
			Class24.smethod_0(33554938, 100663692, 16777215);
		}

		// Token: 0x060007B7 RID: 1975
		public extern int Invoke(object object_0, IntPtr hProcess, ref int pbDebuggerPresent);

		// Token: 0x060007B8 RID: 1976 RVA: 0x00005B28 File Offset: 0x00003D28
		public static int smethod_0(object object_0, IntPtr intptr_0, ref int int_0)
		{
			return Delegate371.delegate371_0(object_0, intptr_0, ref int_0);
		}

		// Token: 0x04000351 RID: 849
		protected internal static readonly Delegate371 delegate371_0;
	}
}
