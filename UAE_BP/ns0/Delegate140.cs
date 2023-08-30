using System;

namespace ns0
{
	// Token: 0x020000D5 RID: 213
	internal sealed class Delegate140 : MulticastDelegate
	{
		// Token: 0x0600040E RID: 1038
		public extern Delegate140(object object_0, IntPtr intptr_0);

		// Token: 0x0600040F RID: 1039 RVA: 0x00003B35 File Offset: 0x00001D35
		static Delegate140()
		{
			Class24.smethod_0(33554660, 167772290, 16777215);
		}

		// Token: 0x06000410 RID: 1040
		public extern UIntPtr Invoke(UIntPtr uintptr_0, int int_0);

		// Token: 0x06000411 RID: 1041 RVA: 0x00003B4B File Offset: 0x00001D4B
		public static UIntPtr smethod_0(UIntPtr uintptr_0, int int_0)
		{
			return Delegate140.delegate140_0(uintptr_0, int_0);
		}

		// Token: 0x0400025F RID: 607
		internal static readonly Delegate140 delegate140_0;
	}
}
