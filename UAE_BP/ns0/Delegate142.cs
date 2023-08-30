using System;
using System.Threading;

namespace ns0
{
	// Token: 0x020000D7 RID: 215
	internal sealed class Delegate142 : MulticastDelegate
	{
		// Token: 0x06000416 RID: 1046
		public extern Delegate142(object object_0, IntPtr intptr_0);

		// Token: 0x06000417 RID: 1047 RVA: 0x00003B7D File Offset: 0x00001D7D
		static Delegate142()
		{
			Class25.smethod_0(33554662, 167772292, 16777215);
		}

		// Token: 0x06000418 RID: 1048
		public extern Mutex Invoke(bool bool_0, string string_0);

		// Token: 0x06000419 RID: 1049 RVA: 0x00003B93 File Offset: 0x00001D93
		public static Mutex smethod_0(bool bool_0, string string_0)
		{
			return Delegate142.delegate142_0(bool_0, string_0);
		}

		// Token: 0x04000261 RID: 609
		internal static readonly Delegate142 delegate142_0;
	}
}
