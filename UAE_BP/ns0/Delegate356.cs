using System;

namespace ns0
{
	// Token: 0x020001B8 RID: 440
	internal sealed class Delegate356 : MulticastDelegate
	{
		// Token: 0x06000779 RID: 1913
		public extern Delegate356(object object_0, IntPtr intptr_0);

		// Token: 0x0600077A RID: 1914 RVA: 0x00005900 File Offset: 0x00003B00
		static Delegate356()
		{
			Class24.smethod_0(33554922, 167772477, 16777215);
		}

		// Token: 0x0600077B RID: 1915
		public extern byte[] Invoke(string string_0);

		// Token: 0x0600077C RID: 1916 RVA: 0x00005916 File Offset: 0x00003B16
		public static byte[] smethod_0(string string_0)
		{
			return Delegate356.delegate356_0(string_0);
		}

		// Token: 0x04000342 RID: 834
		internal static readonly Delegate356 delegate356_0;
	}
}
