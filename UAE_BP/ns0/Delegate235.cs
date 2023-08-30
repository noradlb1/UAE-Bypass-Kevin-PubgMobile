using System;
using System.Text;

namespace ns0
{
	// Token: 0x02000138 RID: 312
	internal sealed class Delegate235 : MulticastDelegate
	{
		// Token: 0x0600058E RID: 1422
		public extern Delegate235(object object_0, IntPtr intptr_0);

		// Token: 0x0600058F RID: 1423 RVA: 0x0000484C File Offset: 0x00002A4C
		static Delegate235()
		{
			Class24.smethod_0(33554772, 167772375, 16777215);
		}

		// Token: 0x06000590 RID: 1424
		public extern StringBuilder Invoke(object object_0, string string_0, object object_1);

		// Token: 0x06000591 RID: 1425 RVA: 0x00004862 File Offset: 0x00002A62
		public static StringBuilder smethod_0(object object_0, string string_0, object object_1)
		{
			return Delegate235.delegate235_0(object_0, string_0, object_1);
		}

		// Token: 0x040002C2 RID: 706
		protected internal static readonly Delegate235 delegate235_0;
	}
}
