using System;

namespace ns0
{
	// Token: 0x02000146 RID: 326
	internal sealed class Delegate249 : MulticastDelegate
	{
		// Token: 0x060005C6 RID: 1478
		public extern Delegate249(object object_0, IntPtr intptr_0);

		// Token: 0x060005C7 RID: 1479 RVA: 0x00004A42 File Offset: 0x00002C42
		static Delegate249()
		{
			Class24.smethod_0(33554786, 167772386, 16777215);
		}

		// Token: 0x060005C8 RID: 1480
		public extern string Invoke(object object_0, byte[] byte_0, int int_0, int int_1);

		// Token: 0x060005C9 RID: 1481 RVA: 0x00004A58 File Offset: 0x00002C58
		public static string smethod_0(object object_0, byte[] byte_0, int int_0, int int_1)
		{
			return Delegate249.delegate249_0(object_0, byte_0, int_0, int_1);
		}

		// Token: 0x040002D0 RID: 720
		protected internal static readonly Delegate249 delegate249_0;
	}
}
