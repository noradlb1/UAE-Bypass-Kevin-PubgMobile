using System;

namespace ns0
{
	// Token: 0x0200011C RID: 284
	internal sealed class Delegate208 : MulticastDelegate
	{
		// Token: 0x06000521 RID: 1313
		public extern Delegate208(object object_0, IntPtr intptr_0);

		// Token: 0x06000522 RID: 1314 RVA: 0x0000448D File Offset: 0x0000268D
		static Delegate208()
		{
			Class24.smethod_0(33554741, 167772352, 16777215);
		}

		// Token: 0x06000523 RID: 1315
		public extern ulong Invoke(ref UIntPtr uintptr_0);

		// Token: 0x06000524 RID: 1316 RVA: 0x000044A3 File Offset: 0x000026A3
		public static ulong smethod_0(ref UIntPtr uintptr_0)
		{
			return Delegate208.delegate208_0(ref uintptr_0);
		}

		// Token: 0x040002A6 RID: 678
		internal static readonly Delegate208 delegate208_0;
	}
}
