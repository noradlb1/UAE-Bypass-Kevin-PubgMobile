using System;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x020000E1 RID: 225
	internal sealed class Delegate151 : MulticastDelegate
	{
		// Token: 0x0600043B RID: 1083
		public extern Delegate151(object object_0, IntPtr intptr_0);

		// Token: 0x0600043C RID: 1084 RVA: 0x00003CBB File Offset: 0x00001EBB
		static Delegate151()
		{
			Class24.smethod_0(33554674, 167772301, 16777215);
		}

		// Token: 0x0600043D RID: 1085
		public extern ICryptoTransform Invoke(object object_0);

		// Token: 0x0600043E RID: 1086 RVA: 0x00003CD1 File Offset: 0x00001ED1
		public static ICryptoTransform smethod_0(object object_0)
		{
			return Delegate151.delegate151_0(object_0);
		}

		// Token: 0x0400026B RID: 619
		protected internal static readonly Delegate151 delegate151_0;
	}
}
