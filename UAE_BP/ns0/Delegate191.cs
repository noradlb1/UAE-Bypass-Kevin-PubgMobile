using System;

namespace ns0
{
	// Token: 0x0200010A RID: 266
	internal sealed class Delegate191 : MulticastDelegate
	{
		// Token: 0x060004DC RID: 1244
		public extern Delegate191(object object_0, IntPtr intptr_0);

		// Token: 0x060004DD RID: 1245 RVA: 0x00004237 File Offset: 0x00002437
		static Delegate191()
		{
			Class24.smethod_0(33554718, 100663712, 16777215);
		}

		// Token: 0x060004DE RID: 1246
		public extern int Invoke(object object_0, Class22.Delegate5 lpEnumFunc, IntPtr lParam);

		// Token: 0x060004DF RID: 1247 RVA: 0x0000424D File Offset: 0x0000244D
		public static int smethod_0(object object_0, Class22.Delegate5 delegate5_0, IntPtr intptr_0)
		{
			return Delegate191.delegate191_0(object_0, delegate5_0, intptr_0);
		}

		// Token: 0x04000294 RID: 660
		protected internal static readonly Delegate191 delegate191_0;
	}
}
