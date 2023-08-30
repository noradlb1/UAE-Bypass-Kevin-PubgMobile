using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x0200019D RID: 413
	internal sealed class Delegate331 : MulticastDelegate
	{
		// Token: 0x06000713 RID: 1811
		public extern Delegate331(object object_0, IntPtr intptr_0);

		// Token: 0x06000714 RID: 1812 RVA: 0x00005591 File Offset: 0x00003791
		static Delegate331()
		{
			Class24.smethod_0(33554892, 167772454, 16777215);
		}

		// Token: 0x06000715 RID: 1813
		public extern Process Invoke(ProcessStartInfo processStartInfo_0);

		// Token: 0x06000716 RID: 1814 RVA: 0x000055A7 File Offset: 0x000037A7
		public static Process smethod_0(ProcessStartInfo processStartInfo_0)
		{
			return Delegate331.delegate331_0(processStartInfo_0);
		}

		// Token: 0x04000327 RID: 807
		internal static readonly Delegate331 delegate331_0;
	}
}
