using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x020000E2 RID: 226
	internal sealed class Delegate152 : MulticastDelegate
	{
		// Token: 0x0600043F RID: 1087
		public extern Delegate152(object object_0, IntPtr intptr_0);

		// Token: 0x06000440 RID: 1088 RVA: 0x00003CDE File Offset: 0x00001EDE
		static Delegate152()
		{
			Class24.smethod_0(33554675, 167772302, 16777215);
		}

		// Token: 0x06000441 RID: 1089
		public extern void Invoke(object object_0, ProcessWindowStyle processWindowStyle_0);

		// Token: 0x06000442 RID: 1090 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public static void smethod_0(object object_0, ProcessWindowStyle processWindowStyle_0)
		{
			Delegate152.delegate152_0(object_0, processWindowStyle_0);
		}

		// Token: 0x0400026C RID: 620
		protected internal static readonly Delegate152 delegate152_0;
	}
}
