using System;

namespace ns0
{
	// Token: 0x02000127 RID: 295
	internal sealed class Delegate218 : MulticastDelegate
	{
		// Token: 0x0600054A RID: 1354
		public extern Delegate218(object object_0, IntPtr intptr_0);

		// Token: 0x0600054B RID: 1355 RVA: 0x000045EF File Offset: 0x000027EF
		static Delegate218()
		{
			Class24.smethod_0(33554752, 167772361, 16777215);
		}

		// Token: 0x0600054C RID: 1356
		public extern ulong Invoke(string string_0, int int_0);

		// Token: 0x0600054D RID: 1357 RVA: 0x00004605 File Offset: 0x00002805
		public static ulong smethod_0(string string_0, int int_0)
		{
			return Delegate218.delegate218_0(string_0, int_0);
		}

		// Token: 0x040002B1 RID: 689
		internal static readonly Delegate218 delegate218_0;
	}
}
