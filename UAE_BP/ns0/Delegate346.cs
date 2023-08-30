using System;
using System.Net;

namespace ns0
{
	// Token: 0x020001AE RID: 430
	internal sealed class Delegate346 : MulticastDelegate
	{
		// Token: 0x06000751 RID: 1873
		public extern Delegate346(object object_0, IntPtr intptr_0);

		// Token: 0x06000752 RID: 1874 RVA: 0x0000579D File Offset: 0x0000399D
		static Delegate346()
		{
			Class24.smethod_0(33554909, 167772467, 16777215);
		}

		// Token: 0x06000753 RID: 1875
		public extern HttpListenerRequest Invoke(object object_0);

		// Token: 0x06000754 RID: 1876 RVA: 0x000057B3 File Offset: 0x000039B3
		public static HttpListenerRequest smethod_0(object object_0)
		{
			return Delegate346.delegate346_0(object_0);
		}

		// Token: 0x04000338 RID: 824
		protected internal static readonly Delegate346 delegate346_0;
	}
}
