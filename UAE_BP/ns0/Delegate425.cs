using System;

namespace ns0
{
	// Token: 0x020001FE RID: 510
	internal sealed class Delegate425 : MulticastDelegate
	{
		// Token: 0x0600088E RID: 2190
		public extern Delegate425(object object_0, IntPtr intptr_0);

		// Token: 0x0600088F RID: 2191 RVA: 0x00006286 File Offset: 0x00004486
		static Delegate425()
		{
			Class24.smethod_0(33555003, 167772531, 16777215);
		}

		// Token: 0x06000890 RID: 2192
		public extern void Invoke(string string_0, string string_1, object object_0);

		// Token: 0x06000891 RID: 2193 RVA: 0x0000629C File Offset: 0x0000449C
		public static void smethod_0(string string_0, string string_1, object object_0)
		{
			Delegate425.delegate425_0(string_0, string_1, object_0);
		}

		// Token: 0x04000388 RID: 904
		internal static readonly Delegate425 delegate425_0;
	}
}
