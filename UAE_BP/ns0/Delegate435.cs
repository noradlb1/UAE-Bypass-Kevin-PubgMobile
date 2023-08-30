using System;
using System.Reflection;

namespace ns0
{
	// Token: 0x02000209 RID: 521
	internal sealed class Delegate435 : MulticastDelegate
	{
		// Token: 0x060008B7 RID: 2231
		public extern Delegate435(object object_0, IntPtr intptr_0);

		// Token: 0x060008B8 RID: 2232 RVA: 0x000063EA File Offset: 0x000045EA
		static Delegate435()
		{
			Class25.smethod_0(33555015, 167772539, 16777215);
		}

		// Token: 0x060008B9 RID: 2233
		public extern AssemblyName Invoke(string string_0);

		// Token: 0x060008BA RID: 2234 RVA: 0x00006400 File Offset: 0x00004600
		public static AssemblyName smethod_0(string string_0)
		{
			return Delegate435.delegate435_0(string_0);
		}

		// Token: 0x04000393 RID: 915
		internal static readonly Delegate435 delegate435_0;
	}
}
