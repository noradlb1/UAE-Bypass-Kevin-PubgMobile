using System;

namespace ns0
{
	// Token: 0x02000050 RID: 80
	internal sealed class Delegate12 : MulticastDelegate
	{
		// Token: 0x06000209 RID: 521
		public extern Delegate12(object object_0, IntPtr intptr_0);

		// Token: 0x0600020A RID: 522 RVA: 0x0000298C File Offset: 0x00000B8C
		static Delegate12()
		{
			Class24.smethod_0(33554513, 167772178, 16777215);
		}

		// Token: 0x0600020B RID: 523
		public extern bool Invoke(string string_0);

		// Token: 0x0600020C RID: 524 RVA: 0x000029A2 File Offset: 0x00000BA2
		public static bool smethod_0(string string_0)
		{
			return Delegate12.delegate12_0(string_0);
		}

		// Token: 0x040001DA RID: 474
		internal static readonly Delegate12 delegate12_0;
	}
}
