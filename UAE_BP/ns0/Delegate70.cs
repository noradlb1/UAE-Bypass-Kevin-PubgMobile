using System;
using System.Reflection;

namespace ns0
{
	// Token: 0x0200008C RID: 140
	internal sealed class Delegate70 : MulticastDelegate
	{
		// Token: 0x060002F3 RID: 755
		public extern Delegate70(object object_0, IntPtr intptr_0);

		// Token: 0x060002F4 RID: 756 RVA: 0x00003195 File Offset: 0x00001395
		static Delegate70()
		{
			Class24.smethod_0(33554576, 167772226, 16777215);
		}

		// Token: 0x060002F5 RID: 757
		public extern Assembly Invoke();

		// Token: 0x060002F6 RID: 758 RVA: 0x000031AB File Offset: 0x000013AB
		public static Assembly smethod_0()
		{
			return Delegate70.delegate70_0();
		}

		// Token: 0x04000216 RID: 534
		internal static readonly Delegate70 delegate70_0;
	}
}
