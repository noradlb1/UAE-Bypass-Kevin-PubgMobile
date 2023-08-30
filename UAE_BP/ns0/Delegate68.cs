using System;
using System.Security.Principal;

namespace ns0
{
	// Token: 0x0200008A RID: 138
	internal sealed class Delegate68 : MulticastDelegate
	{
		// Token: 0x060002EB RID: 747
		public extern Delegate68(object object_0, IntPtr intptr_0);

		// Token: 0x060002EC RID: 748 RVA: 0x0000314D File Offset: 0x0000134D
		static Delegate68()
		{
			Class24.smethod_0(33554573, 167772224, 16777215);
		}

		// Token: 0x060002ED RID: 749
		public extern bool Invoke(object object_0, WindowsBuiltInRole windowsBuiltInRole_0);

		// Token: 0x060002EE RID: 750 RVA: 0x00003163 File Offset: 0x00001363
		public static bool smethod_0(object object_0, WindowsBuiltInRole windowsBuiltInRole_0)
		{
			return Delegate68.delegate68_0(object_0, windowsBuiltInRole_0);
		}

		// Token: 0x04000214 RID: 532
		protected internal static readonly Delegate68 delegate68_0;
	}
}
