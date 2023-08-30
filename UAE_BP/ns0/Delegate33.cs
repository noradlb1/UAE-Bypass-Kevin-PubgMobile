using System;

namespace ns0
{
	// Token: 0x02000065 RID: 101
	internal sealed class Delegate33 : MulticastDelegate
	{
		// Token: 0x0600025D RID: 605
		public extern Delegate33(object object_0, IntPtr intptr_0);

		// Token: 0x0600025E RID: 606 RVA: 0x00002C73 File Offset: 0x00000E73
		static Delegate33()
		{
			Class24.smethod_0(33554534, 167772194, 16777215);
		}

		// Token: 0x0600025F RID: 607
		public unsafe extern UIntPtr Invoke(void* pVoid_0);

		// Token: 0x06000260 RID: 608 RVA: 0x00002C89 File Offset: 0x00000E89
		public unsafe static UIntPtr smethod_0(void* pVoid_0)
		{
			return Delegate33.delegate33_0(pVoid_0);
		}

		// Token: 0x040001EF RID: 495
		internal static readonly Delegate33 delegate33_0;
	}
}
