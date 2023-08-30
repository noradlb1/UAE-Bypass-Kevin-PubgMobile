using System;
using System.Windows.Input;

namespace ns0
{
	// Token: 0x020001A6 RID: 422
	internal sealed class Delegate339 : MulticastDelegate
	{
		// Token: 0x06000734 RID: 1844
		public extern Delegate339(object object_0, IntPtr intptr_0);

		// Token: 0x06000735 RID: 1845 RVA: 0x000056A9 File Offset: 0x000038A9
		static Delegate339()
		{
			Class24.smethod_0(33554901, 167772460, 16777215);
		}

		// Token: 0x06000736 RID: 1846
		public extern MouseButton Invoke(object object_0);

		// Token: 0x06000737 RID: 1847 RVA: 0x000056BF File Offset: 0x000038BF
		public static MouseButton smethod_0(object object_0)
		{
			return Delegate339.delegate339_0(object_0);
		}

		// Token: 0x04000330 RID: 816
		protected internal static readonly Delegate339 delegate339_0;
	}
}
