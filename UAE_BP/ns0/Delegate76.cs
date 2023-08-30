using System;
using System.IO;

namespace ns0
{
	// Token: 0x02000092 RID: 146
	internal sealed class Delegate76 : MulticastDelegate
	{
		// Token: 0x0600030B RID: 779
		public extern Delegate76(object object_0, IntPtr intptr_0);

		// Token: 0x0600030C RID: 780 RVA: 0x00003269 File Offset: 0x00001469
		static Delegate76()
		{
			Class25.smethod_0(33554583, 167772230, 16777215);
		}

		// Token: 0x0600030D RID: 781
		public extern FileStream Invoke(string string_0, FileMode fileMode_0);

		// Token: 0x0600030E RID: 782 RVA: 0x0000327F File Offset: 0x0000147F
		public static FileStream smethod_0(string string_0, FileMode fileMode_0)
		{
			return Delegate76.delegate76_0(string_0, fileMode_0);
		}

		// Token: 0x0400021C RID: 540
		internal static readonly Delegate76 delegate76_0;
	}
}
