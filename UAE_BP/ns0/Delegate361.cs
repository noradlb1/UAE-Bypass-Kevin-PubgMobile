using System;

namespace ns0
{
	// Token: 0x020001BD RID: 445
	internal sealed class Delegate361 : MulticastDelegate
	{
		// Token: 0x0600078D RID: 1933
		public extern Delegate361(object object_0, IntPtr intptr_0);

		// Token: 0x0600078E RID: 1934 RVA: 0x000059B1 File Offset: 0x00003BB1
		static Delegate361()
		{
			Class25.smethod_0(33554928, 167772480, 16777215);
		}

		// Token: 0x0600078F RID: 1935
		public extern ArgumentException Invoke(string string_0);

		// Token: 0x06000790 RID: 1936 RVA: 0x000059C7 File Offset: 0x00003BC7
		public static ArgumentException smethod_0(string string_0)
		{
			return Delegate361.delegate361_0(string_0);
		}

		// Token: 0x04000347 RID: 839
		internal static readonly Delegate361 delegate361_0;
	}
}
