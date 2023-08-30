using System;

namespace ns0
{
	// Token: 0x020001E9 RID: 489
	internal sealed class Delegate405 : MulticastDelegate
	{
		// Token: 0x0600083D RID: 2109
		public extern Delegate405(object object_0, IntPtr intptr_0);

		// Token: 0x0600083E RID: 2110 RVA: 0x00005FC0 File Offset: 0x000041C0
		static Delegate405()
		{
			Class24.smethod_0(33554980, 100663462, 16777215);
		}

		// Token: 0x0600083F RID: 2111
		public extern void Invoke(ref Struct0 struct0_0, UIntPtr value);

		// Token: 0x06000840 RID: 2112 RVA: 0x00005FD6 File Offset: 0x000041D6
		public static void smethod_0(ref Struct0 struct0_0, UIntPtr uintptr_0)
		{
			Delegate405.delegate405_0(ref struct0_0, uintptr_0);
		}

		// Token: 0x04000373 RID: 883
		internal static readonly Delegate405 delegate405_0;
	}
}
