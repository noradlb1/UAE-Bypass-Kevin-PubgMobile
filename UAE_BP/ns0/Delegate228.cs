using System;

namespace ns0
{
	// Token: 0x02000131 RID: 305
	internal sealed class Delegate228 : MulticastDelegate
	{
		// Token: 0x06000572 RID: 1394
		public extern Delegate228(object object_0, IntPtr intptr_0);

		// Token: 0x06000573 RID: 1395 RVA: 0x00004750 File Offset: 0x00002950
		static Delegate228()
		{
			Class24.smethod_0(33554764, 167772370, 16777215);
		}

		// Token: 0x06000574 RID: 1396
		public extern byte[] Invoke(object object_0, byte[] byte_0, int int_0, int int_1);

		// Token: 0x06000575 RID: 1397 RVA: 0x00004766 File Offset: 0x00002966
		public static byte[] smethod_0(object object_0, byte[] byte_0, int int_0, int int_1)
		{
			return Delegate228.delegate228_0(object_0, byte_0, int_0, int_1);
		}

		// Token: 0x040002BB RID: 699
		protected internal static readonly Delegate228 delegate228_0;
	}
}
