using System;
using System.IO;

namespace ns0
{
	// Token: 0x0200007B RID: 123
	internal sealed class Delegate53 : MulticastDelegate
	{
		// Token: 0x060002AF RID: 687
		public extern Delegate53(object object_0, IntPtr intptr_0);

		// Token: 0x060002B0 RID: 688 RVA: 0x00002F38 File Offset: 0x00001138
		static Delegate53()
		{
			Class24.smethod_0(33554557, 167772211, 16777215);
		}

		// Token: 0x060002B1 RID: 689
		public extern byte[] Invoke(object object_0, Stream stream_0);

		// Token: 0x060002B2 RID: 690 RVA: 0x00002F4E File Offset: 0x0000114E
		public static byte[] smethod_0(object object_0, Stream stream_0)
		{
			return Delegate53.delegate53_0(object_0, stream_0);
		}

		// Token: 0x04000205 RID: 517
		protected internal static readonly Delegate53 delegate53_0;
	}
}
