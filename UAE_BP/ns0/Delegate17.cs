using System;

namespace ns0
{
	// Token: 0x02000055 RID: 85
	internal sealed class Delegate17 : MulticastDelegate
	{
		// Token: 0x0600021D RID: 541
		public extern Delegate17(object object_0, IntPtr intptr_0);

		// Token: 0x0600021E RID: 542 RVA: 0x00002A3C File Offset: 0x00000C3C
		static Delegate17()
		{
			Class24.smethod_0(33554518, 100663458, 16777215);
		}

		// Token: 0x0600021F RID: 543
		public extern void Invoke(ref Struct0 struct0_0, UIntPtr value);

		// Token: 0x06000220 RID: 544 RVA: 0x00002A52 File Offset: 0x00000C52
		public static void smethod_0(ref Struct0 struct0_0, UIntPtr uintptr_0)
		{
			Delegate17.delegate17_0(ref struct0_0, uintptr_0);
		}

		// Token: 0x040001DF RID: 479
		internal static readonly Delegate17 delegate17_0;
	}
}
