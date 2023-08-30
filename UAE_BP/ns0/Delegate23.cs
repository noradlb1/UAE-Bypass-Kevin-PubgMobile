using System;

namespace ns0
{
	// Token: 0x0200005B RID: 91
	internal sealed class Delegate23 : MulticastDelegate
	{
		// Token: 0x06000235 RID: 565
		public extern Delegate23(object object_0, IntPtr intptr_0);

		// Token: 0x06000236 RID: 566 RVA: 0x00002B10 File Offset: 0x00000D10
		static Delegate23()
		{
			Class24.smethod_0(33554524, 167772186, 16777215);
		}

		// Token: 0x06000237 RID: 567
		public extern string Invoke(string string_0, string string_1, string string_2, string string_3);

		// Token: 0x06000238 RID: 568 RVA: 0x00002B26 File Offset: 0x00000D26
		public static string smethod_0(string string_0, string string_1, string string_2, string string_3)
		{
			return Delegate23.delegate23_0(string_0, string_1, string_2, string_3);
		}

		// Token: 0x040001E5 RID: 485
		internal static readonly Delegate23 delegate23_0;
	}
}
