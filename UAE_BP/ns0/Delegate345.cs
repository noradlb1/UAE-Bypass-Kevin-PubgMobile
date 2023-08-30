using System;

namespace ns0
{
	// Token: 0x020001AC RID: 428
	internal sealed class Delegate345 : MulticastDelegate
	{
		// Token: 0x0600074C RID: 1868
		public extern Delegate345(object object_0, IntPtr intptr_0);

		// Token: 0x0600074D RID: 1869 RVA: 0x0000577A File Offset: 0x0000397A
		static Delegate345()
		{
			Class24.smethod_0(33554907, 167772466, 16777215);
		}

		// Token: 0x0600074E RID: 1870
		public extern IntPtr Invoke(long long_0);

		// Token: 0x0600074F RID: 1871 RVA: 0x00005790 File Offset: 0x00003990
		public static IntPtr smethod_0(long long_0)
		{
			return Delegate345.delegate345_0(long_0);
		}

		// Token: 0x04000336 RID: 822
		internal static readonly Delegate345 delegate345_0;
	}
}
