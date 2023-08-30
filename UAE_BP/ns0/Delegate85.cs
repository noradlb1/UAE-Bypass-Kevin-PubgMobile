using System;

namespace ns0
{
	// Token: 0x0200009C RID: 156
	internal sealed class Delegate85 : MulticastDelegate
	{
		// Token: 0x06000330 RID: 816
		public extern Delegate85(object object_0, IntPtr intptr_0);

		// Token: 0x06000331 RID: 817 RVA: 0x000033A7 File Offset: 0x000015A7
		static Delegate85()
		{
			Class24.smethod_0(33554595, 167772239, 16777215);
		}

		// Token: 0x06000332 RID: 818
		public extern UIntPtr Invoke(UIntPtr uintptr_0, int int_0);

		// Token: 0x06000333 RID: 819 RVA: 0x000033BD File Offset: 0x000015BD
		public static UIntPtr smethod_0(UIntPtr uintptr_0, int int_0)
		{
			return Delegate85.delegate85_0(uintptr_0, int_0);
		}

		// Token: 0x04000226 RID: 550
		internal static readonly Delegate85 delegate85_0;
	}
}
