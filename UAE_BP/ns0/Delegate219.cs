using System;
using System.Security.Principal;

namespace ns0
{
	// Token: 0x02000128 RID: 296
	internal sealed class Delegate219 : MulticastDelegate
	{
		// Token: 0x0600054E RID: 1358
		public extern Delegate219(object object_0, IntPtr intptr_0);

		// Token: 0x0600054F RID: 1359 RVA: 0x00004613 File Offset: 0x00002813
		static Delegate219()
		{
			Class25.smethod_0(33554753, 167772362, 16777215);
		}

		// Token: 0x06000550 RID: 1360
		public extern WindowsPrincipal Invoke(WindowsIdentity windowsIdentity_0);

		// Token: 0x06000551 RID: 1361 RVA: 0x00004629 File Offset: 0x00002829
		public static WindowsPrincipal smethod_0(WindowsIdentity windowsIdentity_0)
		{
			return Delegate219.delegate219_0(windowsIdentity_0);
		}

		// Token: 0x040002B2 RID: 690
		internal static readonly Delegate219 delegate219_0;
	}
}
