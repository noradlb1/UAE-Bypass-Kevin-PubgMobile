using System;

namespace ns0
{
	// Token: 0x0200004E RID: 78
	internal sealed class Delegate10 : MulticastDelegate
	{
		// Token: 0x06000201 RID: 513
		public extern Delegate10(object object_0, IntPtr intptr_0);

		// Token: 0x06000202 RID: 514 RVA: 0x00002945 File Offset: 0x00000B45
		static Delegate10()
		{
			Class24.smethod_0(33554511, 100663457, 16777215);
		}

		// Token: 0x06000203 RID: 515
		public extern UIntPtr Invoke(ref Struct0 struct0_0);

		// Token: 0x06000204 RID: 516 RVA: 0x0000295B File Offset: 0x00000B5B
		public static UIntPtr smethod_0(ref Struct0 struct0_0)
		{
			return Delegate10.delegate10_0(ref struct0_0);
		}

		// Token: 0x040001D8 RID: 472
		internal static readonly Delegate10 delegate10_0;
	}
}
