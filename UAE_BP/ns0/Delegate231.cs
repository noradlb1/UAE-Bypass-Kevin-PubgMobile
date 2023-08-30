using System;
using System.IO;

namespace ns0
{
	// Token: 0x02000134 RID: 308
	internal sealed class Delegate231 : MulticastDelegate
	{
		// Token: 0x0600057E RID: 1406
		public extern Delegate231(object object_0, IntPtr intptr_0);

		// Token: 0x0600057F RID: 1407 RVA: 0x000047BE File Offset: 0x000029BE
		static Delegate231()
		{
			Class24.smethod_0(33554768, 167772371, 16777215);
		}

		// Token: 0x06000580 RID: 1408
		public extern object Invoke(object object_0, Stream stream_0);

		// Token: 0x06000581 RID: 1409 RVA: 0x000047D4 File Offset: 0x000029D4
		public static object smethod_0(object object_0, Stream stream_0)
		{
			return Delegate231.delegate231_0(object_0, stream_0);
		}

		// Token: 0x040002BE RID: 702
		protected internal static readonly Delegate231 delegate231_0;
	}
}
