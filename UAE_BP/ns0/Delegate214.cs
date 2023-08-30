using System;
using System.IO;

namespace ns0
{
	// Token: 0x02000122 RID: 290
	internal sealed class Delegate214 : MulticastDelegate
	{
		// Token: 0x06000539 RID: 1337
		public extern Delegate214(object object_0, IntPtr intptr_0);

		// Token: 0x0600053A RID: 1338 RVA: 0x00004563 File Offset: 0x00002763
		static Delegate214()
		{
			Class25.smethod_0(33554747, 167772358, 16777215);
		}

		// Token: 0x0600053B RID: 1339
		public extern FileInfo Invoke(string string_0);

		// Token: 0x0600053C RID: 1340 RVA: 0x00004579 File Offset: 0x00002779
		public static FileInfo smethod_0(string string_0)
		{
			return Delegate214.delegate214_0(string_0);
		}

		// Token: 0x040002AC RID: 684
		internal static readonly Delegate214 delegate214_0;
	}
}
