using System;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x0200010D RID: 269
	internal sealed class Delegate194 : MulticastDelegate
	{
		// Token: 0x060004E8 RID: 1256
		public extern Delegate194(object object_0, IntPtr intptr_0);

		// Token: 0x060004E9 RID: 1257 RVA: 0x000042A1 File Offset: 0x000024A1
		static Delegate194()
		{
			Class24.smethod_0(33554725, 167772340, 16777215);
		}

		// Token: 0x060004EA RID: 1258
		public extern Task Invoke(Action action_0);

		// Token: 0x060004EB RID: 1259 RVA: 0x000042B7 File Offset: 0x000024B7
		public static Task smethod_0(Action action_0)
		{
			return Delegate194.delegate194_0(action_0);
		}

		// Token: 0x04000297 RID: 663
		internal static readonly Delegate194 delegate194_0;
	}
}
