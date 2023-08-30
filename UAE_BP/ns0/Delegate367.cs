using System;

namespace ns0
{
	// Token: 0x020001C3 RID: 451
	internal sealed class Delegate367 : MulticastDelegate
	{
		// Token: 0x060007A5 RID: 1957
		public extern Delegate367(object object_0, IntPtr intptr_0);

		// Token: 0x060007A6 RID: 1958 RVA: 0x00005A86 File Offset: 0x00003C86
		static Delegate367()
		{
			Class24.smethod_0(33554934, 167772486, 16777215);
		}

		// Token: 0x060007A7 RID: 1959
		public unsafe extern void* Invoke(ref IntPtr intptr_0);

		// Token: 0x060007A8 RID: 1960 RVA: 0x00005A9C File Offset: 0x00003C9C
		public unsafe static void* smethod_0(ref IntPtr intptr_0)
		{
			return Delegate367.delegate367_0(ref intptr_0);
		}

		// Token: 0x0400034D RID: 845
		internal static readonly Delegate367 delegate367_0;
	}
}
