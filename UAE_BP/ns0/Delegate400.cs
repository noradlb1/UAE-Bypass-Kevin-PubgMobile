using System;
using System.Text;

namespace ns0
{
	// Token: 0x020001E4 RID: 484
	internal sealed class Delegate400 : MulticastDelegate
	{
		// Token: 0x06000829 RID: 2089
		public extern Delegate400(object object_0, IntPtr intptr_0);

		// Token: 0x0600082A RID: 2090 RVA: 0x00005F10 File Offset: 0x00004110
		static Delegate400()
		{
			Class24.smethod_0(33554974, 167772510, 16777215);
		}

		// Token: 0x0600082B RID: 2091
		public extern StringBuilder Invoke(object object_0, string string_0, object object_1, object object_2);

		// Token: 0x0600082C RID: 2092 RVA: 0x00005F26 File Offset: 0x00004126
		public static StringBuilder smethod_0(object object_0, string string_0, object object_1, object object_2)
		{
			return Delegate400.delegate400_0(object_0, string_0, object_1, object_2);
		}

		// Token: 0x0400036E RID: 878
		protected internal static readonly Delegate400 delegate400_0;
	}
}
