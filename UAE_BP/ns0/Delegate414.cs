using System;

namespace ns0
{
	// Token: 0x020001F2 RID: 498
	internal sealed class Delegate414 : MulticastDelegate
	{
		// Token: 0x06000861 RID: 2145
		public extern Delegate414(object object_0, IntPtr intptr_0);

		// Token: 0x06000862 RID: 2146 RVA: 0x000060FD File Offset: 0x000042FD
		static Delegate414()
		{
			Class25.smethod_0(33554989, 167772521, 16777215);
		}

		// Token: 0x06000863 RID: 2147
		public extern ArgumentException Invoke(string string_0, string string_1);

		// Token: 0x06000864 RID: 2148 RVA: 0x00006113 File Offset: 0x00004313
		public static ArgumentException smethod_0(string string_0, string string_1)
		{
			return Delegate414.delegate414_0(string_0, string_1);
		}

		// Token: 0x0400037C RID: 892
		internal static readonly Delegate414 delegate414_0;
	}
}
