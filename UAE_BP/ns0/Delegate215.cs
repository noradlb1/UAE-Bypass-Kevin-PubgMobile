using System;
using System.IO.Pipes;

namespace ns0
{
	// Token: 0x02000123 RID: 291
	internal sealed class Delegate215 : MulticastDelegate
	{
		// Token: 0x0600053D RID: 1341
		public extern Delegate215(object object_0, IntPtr intptr_0);

		// Token: 0x0600053E RID: 1342 RVA: 0x00004586 File Offset: 0x00002786
		static Delegate215()
		{
			Class25.smethod_0(33554748, 167772359, 16777215);
		}

		// Token: 0x0600053F RID: 1343
		public extern NamedPipeClientStream Invoke(string string_0);

		// Token: 0x06000540 RID: 1344 RVA: 0x0000459C File Offset: 0x0000279C
		public static NamedPipeClientStream smethod_0(string string_0)
		{
			return Delegate215.delegate215_0(string_0);
		}

		// Token: 0x040002AD RID: 685
		internal static readonly Delegate215 delegate215_0;
	}
}
