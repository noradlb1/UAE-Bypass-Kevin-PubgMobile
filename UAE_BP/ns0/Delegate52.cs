using System;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x0200007A RID: 122
	internal sealed class Delegate52 : MulticastDelegate
	{
		// Token: 0x060002AB RID: 683
		public extern Delegate52(object object_0, IntPtr intptr_0);

		// Token: 0x060002AC RID: 684 RVA: 0x00002F15 File Offset: 0x00001115
		static Delegate52()
		{
			Class24.smethod_0(33554556, 167772210, 16777215);
		}

		// Token: 0x060002AD RID: 685
		public extern Task Invoke(int int_0);

		// Token: 0x060002AE RID: 686 RVA: 0x00002F2B File Offset: 0x0000112B
		public static Task smethod_0(int int_0)
		{
			return Delegate52.delegate52_0(int_0);
		}

		// Token: 0x04000204 RID: 516
		internal static readonly Delegate52 delegate52_0;
	}
}
