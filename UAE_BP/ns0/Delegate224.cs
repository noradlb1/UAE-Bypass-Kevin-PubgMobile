using System;

namespace ns0
{
	// Token: 0x0200012D RID: 301
	internal sealed class Delegate224 : MulticastDelegate
	{
		// Token: 0x06000562 RID: 1378
		public extern Delegate224(object object_0, IntPtr intptr_0);

		// Token: 0x06000563 RID: 1379 RVA: 0x000046C4 File Offset: 0x000028C4
		static Delegate224()
		{
			Class24.smethod_0(33554759, 167772366, 16777215);
		}

		// Token: 0x06000564 RID: 1380
		public extern string Invoke(Environment.SpecialFolder specialFolder_0);

		// Token: 0x06000565 RID: 1381 RVA: 0x000046DA File Offset: 0x000028DA
		public static string smethod_0(Environment.SpecialFolder specialFolder_0)
		{
			return Delegate224.delegate224_0(specialFolder_0);
		}

		// Token: 0x040002B7 RID: 695
		internal static readonly Delegate224 delegate224_0;
	}
}
