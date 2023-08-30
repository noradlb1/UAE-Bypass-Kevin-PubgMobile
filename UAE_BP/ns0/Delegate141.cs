using System;
using System.Reflection;
using System.Resources;

namespace ns0
{
	// Token: 0x020000D6 RID: 214
	internal sealed class Delegate141 : MulticastDelegate
	{
		// Token: 0x06000412 RID: 1042
		public extern Delegate141(object object_0, IntPtr intptr_0);

		// Token: 0x06000413 RID: 1043 RVA: 0x00003B59 File Offset: 0x00001D59
		static Delegate141()
		{
			Class25.smethod_0(33554661, 167772291, 16777215);
		}

		// Token: 0x06000414 RID: 1044
		public extern ResourceManager Invoke(string string_0, Assembly assembly_0);

		// Token: 0x06000415 RID: 1045 RVA: 0x00003B6F File Offset: 0x00001D6F
		public static ResourceManager smethod_0(string string_0, Assembly assembly_0)
		{
			return Delegate141.delegate141_0(string_0, assembly_0);
		}

		// Token: 0x04000260 RID: 608
		internal static readonly Delegate141 delegate141_0;
	}
}
