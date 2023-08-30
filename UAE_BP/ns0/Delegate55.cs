using System;
using System.IO;

namespace ns0
{
	// Token: 0x0200007D RID: 125
	internal sealed class Delegate55 : MulticastDelegate
	{
		// Token: 0x060002B7 RID: 695
		public extern Delegate55(object object_0, IntPtr intptr_0);

		// Token: 0x060002B8 RID: 696 RVA: 0x00002F7F File Offset: 0x0000117F
		static Delegate55()
		{
			Class25.smethod_0(33554559, 167772213, 16777215);
		}

		// Token: 0x060002B9 RID: 697
		public extern StreamWriter Invoke(Stream stream_0);

		// Token: 0x060002BA RID: 698 RVA: 0x00002F95 File Offset: 0x00001195
		public static StreamWriter smethod_0(Stream stream_0)
		{
			return Delegate55.delegate55_0(stream_0);
		}

		// Token: 0x04000207 RID: 519
		internal static readonly Delegate55 delegate55_0;
	}
}
