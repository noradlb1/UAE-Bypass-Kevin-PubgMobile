using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x020000E0 RID: 224
	internal sealed class Delegate150 : MulticastDelegate
	{
		// Token: 0x06000437 RID: 1079
		public extern Delegate150(object object_0, IntPtr intptr_0);

		// Token: 0x06000438 RID: 1080 RVA: 0x00003C97 File Offset: 0x00001E97
		static Delegate150()
		{
			Class24.smethod_0(33554673, 167772300, 16777215);
		}

		// Token: 0x06000439 RID: 1081
		public extern Process Invoke(string string_0, string string_1);

		// Token: 0x0600043A RID: 1082 RVA: 0x00003CAD File Offset: 0x00001EAD
		public static Process smethod_0(string string_0, string string_1)
		{
			return Delegate150.delegate150_0(string_0, string_1);
		}

		// Token: 0x0400026A RID: 618
		internal static readonly Delegate150 delegate150_0;
	}
}
