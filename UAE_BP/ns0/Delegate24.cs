using System;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x0200005C RID: 92
	internal sealed class Delegate24 : MulticastDelegate
	{
		// Token: 0x06000239 RID: 569
		public extern Delegate24(object object_0, IntPtr intptr_0);

		// Token: 0x0600023A RID: 570 RVA: 0x00002B36 File Offset: 0x00000D36
		static Delegate24()
		{
			Class24.smethod_0(33554525, 167772187, 16777215);
		}

		// Token: 0x0600023B RID: 571
		public extern ICryptoTransform Invoke(object object_0);

		// Token: 0x0600023C RID: 572 RVA: 0x00002B4C File Offset: 0x00000D4C
		public static ICryptoTransform smethod_0(object object_0)
		{
			return Delegate24.delegate24_0(object_0);
		}

		// Token: 0x040001E6 RID: 486
		protected internal static readonly Delegate24 delegate24_0;
	}
}
