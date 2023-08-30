using System;
using System.Reflection;

namespace ns0
{
	// Token: 0x020000BF RID: 191
	internal sealed class Delegate118 : MulticastDelegate
	{
		// Token: 0x060003B6 RID: 950
		public extern Delegate118(object object_0, IntPtr intptr_0);

		// Token: 0x060003B7 RID: 951 RVA: 0x00003831 File Offset: 0x00001A31
		static Delegate118()
		{
			Class24.smethod_0(33554635, 167772270, 16777215);
		}

		// Token: 0x060003B8 RID: 952
		public extern AssemblyName Invoke(object object_0);

		// Token: 0x060003B9 RID: 953 RVA: 0x00003847 File Offset: 0x00001A47
		public static AssemblyName smethod_0(object object_0)
		{
			return Delegate118.delegate118_0(object_0);
		}

		// Token: 0x04000249 RID: 585
		protected internal static readonly Delegate118 delegate118_0;
	}
}
