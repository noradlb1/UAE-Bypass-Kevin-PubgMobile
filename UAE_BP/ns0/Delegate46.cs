using System;

namespace ns0
{
	// Token: 0x02000072 RID: 114
	internal sealed class Delegate46 : MulticastDelegate
	{
		// Token: 0x06000291 RID: 657
		public extern Delegate46(object object_0, IntPtr intptr_0);

		// Token: 0x06000292 RID: 658 RVA: 0x00002E40 File Offset: 0x00001040
		static Delegate46()
		{
			Class24.smethod_0(33554548, 167772206, 16777215);
		}

		// Token: 0x06000293 RID: 659
		public extern bool Invoke(UIntPtr uintptr_0, UIntPtr uintptr_1);

		// Token: 0x06000294 RID: 660 RVA: 0x00002E56 File Offset: 0x00001056
		public static bool smethod_0(UIntPtr uintptr_0, UIntPtr uintptr_1)
		{
			return Delegate46.delegate46_0(uintptr_0, uintptr_1);
		}

		// Token: 0x040001FC RID: 508
		internal static readonly Delegate46 delegate46_0;
	}
}
