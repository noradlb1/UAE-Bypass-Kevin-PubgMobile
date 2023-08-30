using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x0200009F RID: 159
	internal sealed class Delegate88 : MulticastDelegate
	{
		// Token: 0x0600033C RID: 828
		public extern Delegate88(object object_0, IntPtr intptr_0);

		// Token: 0x0600033D RID: 829 RVA: 0x00003411 File Offset: 0x00001611
		static Delegate88()
		{
			Class24.smethod_0(33554599, 167772242, 16777215);
		}

		// Token: 0x0600033E RID: 830
		public extern Task Invoke(ref AsyncTaskMethodBuilder asyncTaskMethodBuilder_0);

		// Token: 0x0600033F RID: 831 RVA: 0x00003427 File Offset: 0x00001627
		public static Task smethod_0(ref AsyncTaskMethodBuilder asyncTaskMethodBuilder_0)
		{
			return Delegate88.delegate88_0(ref asyncTaskMethodBuilder_0);
		}

		// Token: 0x04000229 RID: 553
		internal static readonly Delegate88 delegate88_0;
	}
}
