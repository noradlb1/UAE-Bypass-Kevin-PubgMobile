using System;
using System.IO;

namespace ns0
{
	// Token: 0x020001DF RID: 479
	internal sealed class Delegate395 : MulticastDelegate
	{
		// Token: 0x06000815 RID: 2069
		public extern Delegate395(object object_0, IntPtr intptr_0);

		// Token: 0x06000816 RID: 2070 RVA: 0x00005E62 File Offset: 0x00004062
		static Delegate395()
		{
			Class25.smethod_0(33554969, 167772507, 16777215);
		}

		// Token: 0x06000817 RID: 2071
		public extern MemoryStream Invoke(int int_0);

		// Token: 0x06000818 RID: 2072 RVA: 0x00005E78 File Offset: 0x00004078
		public static MemoryStream smethod_0(int int_0)
		{
			return Delegate395.delegate395_0(int_0);
		}

		// Token: 0x04000369 RID: 873
		internal static readonly Delegate395 delegate395_0;
	}
}
