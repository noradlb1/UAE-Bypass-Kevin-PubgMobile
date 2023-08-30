using System;

namespace ns0
{
	// Token: 0x020001D6 RID: 470
	internal sealed class Delegate386 : MulticastDelegate
	{
		// Token: 0x060007F1 RID: 2033
		public extern Delegate386(object object_0, IntPtr intptr_0);

		// Token: 0x060007F2 RID: 2034 RVA: 0x00005D24 File Offset: 0x00003F24
		static Delegate386()
		{
			Class24.smethod_0(33554959, 167772500, 16777215);
		}

		// Token: 0x060007F3 RID: 2035
		public unsafe extern IntPtr Invoke(void* pVoid_0);

		// Token: 0x060007F4 RID: 2036 RVA: 0x00005D3A File Offset: 0x00003F3A
		public unsafe static IntPtr smethod_0(void* pVoid_0)
		{
			return Delegate386.delegate386_0(pVoid_0);
		}

		// Token: 0x04000360 RID: 864
		internal static readonly Delegate386 delegate386_0;
	}
}
