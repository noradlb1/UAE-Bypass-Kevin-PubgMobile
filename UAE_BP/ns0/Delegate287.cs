using System;
using System.Reflection;

namespace ns0
{
	// Token: 0x0200016C RID: 364
	internal sealed class Delegate287 : MulticastDelegate
	{
		// Token: 0x0600065E RID: 1630
		public extern Delegate287(object object_0, IntPtr intptr_0);

		// Token: 0x0600065F RID: 1631 RVA: 0x00004F78 File Offset: 0x00003178
		static Delegate287()
		{
			Class24.smethod_0(33554826, 167772416, 16777215);
		}

		// Token: 0x06000660 RID: 1632
		public extern Assembly Invoke(byte[] byte_0);

		// Token: 0x06000661 RID: 1633 RVA: 0x00004F8E File Offset: 0x0000318E
		public static Assembly smethod_0(byte[] byte_0)
		{
			return Delegate287.delegate287_0(byte_0);
		}

		// Token: 0x040002F6 RID: 758
		internal static readonly Delegate287 delegate287_0;
	}
}
