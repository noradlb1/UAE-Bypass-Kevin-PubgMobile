using System;

namespace ns0
{
	// Token: 0x020001A0 RID: 416
	internal sealed class Delegate334 : MulticastDelegate
	{
		// Token: 0x0600071F RID: 1823
		public extern Delegate334(object object_0, IntPtr intptr_0);

		// Token: 0x06000720 RID: 1824 RVA: 0x000055FA File Offset: 0x000037FA
		static Delegate334()
		{
			Class24.smethod_0(33554895, 167772457, 16777215);
		}

		// Token: 0x06000721 RID: 1825
		public extern bool Invoke(string string_0);

		// Token: 0x06000722 RID: 1826 RVA: 0x00005610 File Offset: 0x00003810
		public static bool smethod_0(string string_0)
		{
			return Delegate334.delegate334_0(string_0);
		}

		// Token: 0x0400032A RID: 810
		internal static readonly Delegate334 delegate334_0;
	}
}
