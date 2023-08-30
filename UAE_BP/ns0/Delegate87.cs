using System;
using System.IO;

namespace ns0
{
	// Token: 0x0200009E RID: 158
	internal sealed class Delegate87 : MulticastDelegate
	{
		// Token: 0x06000338 RID: 824
		public extern Delegate87(object object_0, IntPtr intptr_0);

		// Token: 0x06000339 RID: 825 RVA: 0x000033EE File Offset: 0x000015EE
		static Delegate87()
		{
			Class25.smethod_0(33554597, 167772241, 16777215);
		}

		// Token: 0x0600033A RID: 826
		public extern MemoryStream Invoke(byte[] byte_0);

		// Token: 0x0600033B RID: 827 RVA: 0x00003404 File Offset: 0x00001604
		public static MemoryStream smethod_0(byte[] byte_0)
		{
			return Delegate87.delegate87_0(byte_0);
		}

		// Token: 0x04000228 RID: 552
		internal static readonly Delegate87 delegate87_0;
	}
}
