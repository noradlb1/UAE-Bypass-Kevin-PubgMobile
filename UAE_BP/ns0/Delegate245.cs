using System;

namespace ns0
{
	// Token: 0x02000142 RID: 322
	internal sealed class Delegate245 : MulticastDelegate
	{
		// Token: 0x060005B6 RID: 1462
		public extern Delegate245(object object_0, IntPtr intptr_0);

		// Token: 0x060005B7 RID: 1463 RVA: 0x000049B3 File Offset: 0x00002BB3
		static Delegate245()
		{
			Class24.smethod_0(33554782, 167772383, 16777215);
		}

		// Token: 0x060005B8 RID: 1464
		public extern object Invoke(string string_0, string string_1, object object_0);

		// Token: 0x060005B9 RID: 1465 RVA: 0x000049C9 File Offset: 0x00002BC9
		public static object smethod_0(string string_0, string string_1, object object_0)
		{
			return Delegate245.delegate245_0(string_0, string_1, object_0);
		}

		// Token: 0x040002CC RID: 716
		internal static readonly Delegate245 delegate245_0;
	}
}
