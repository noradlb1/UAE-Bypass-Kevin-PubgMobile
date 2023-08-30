using System;

namespace ns0
{
	// Token: 0x02000053 RID: 83
	internal sealed class Delegate15 : MulticastDelegate
	{
		// Token: 0x06000215 RID: 533
		public extern Delegate15(object object_0, IntPtr intptr_0);

		// Token: 0x06000216 RID: 534 RVA: 0x000029F6 File Offset: 0x00000BF6
		static Delegate15()
		{
			Class24.smethod_0(33554516, 167772181, 16777215);
		}

		// Token: 0x06000217 RID: 535
		public extern ulong Invoke(UIntPtr uintptr_0);

		// Token: 0x06000218 RID: 536 RVA: 0x00002A0C File Offset: 0x00000C0C
		public static ulong smethod_0(UIntPtr uintptr_0)
		{
			return Delegate15.delegate15_0(uintptr_0);
		}

		// Token: 0x040001DD RID: 477
		internal static readonly Delegate15 delegate15_0;
	}
}
