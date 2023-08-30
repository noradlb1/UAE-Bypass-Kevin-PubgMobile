using System;

namespace ns0
{
	// Token: 0x0200009A RID: 154
	internal sealed class Delegate83 : MulticastDelegate
	{
		// Token: 0x06000328 RID: 808
		public extern Delegate83(object object_0, IntPtr intptr_0);

		// Token: 0x06000329 RID: 809 RVA: 0x00003361 File Offset: 0x00001561
		static Delegate83()
		{
			Class24.smethod_0(33554593, 167772237, 16777215);
		}

		// Token: 0x0600032A RID: 810
		public extern byte[] Invoke(long long_0);

		// Token: 0x0600032B RID: 811 RVA: 0x00003377 File Offset: 0x00001577
		public static byte[] smethod_0(long long_0)
		{
			return Delegate83.delegate83_0(long_0);
		}

		// Token: 0x04000224 RID: 548
		internal static readonly Delegate83 delegate83_0;
	}
}
