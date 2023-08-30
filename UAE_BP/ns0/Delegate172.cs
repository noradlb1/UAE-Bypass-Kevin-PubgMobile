using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x020000F7 RID: 247
	internal sealed class Delegate172 : MulticastDelegate
	{
		// Token: 0x06000490 RID: 1168
		public extern Delegate172(object object_0, IntPtr intptr_0);

		// Token: 0x06000491 RID: 1169 RVA: 0x00003F95 File Offset: 0x00002195
		static Delegate172()
		{
			Class24.smethod_0(33554697, 167772321, 452984842);
		}

		// Token: 0x06000492 RID: 1170
		public extern Task<bool> Invoke(ref AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0);

		// Token: 0x06000493 RID: 1171 RVA: 0x00003FAB File Offset: 0x000021AB
		public static Task<bool> smethod_0(ref AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0)
		{
			return Delegate172.delegate172_0(ref asyncTaskMethodBuilder_0);
		}

		// Token: 0x04000281 RID: 641
		internal static readonly Delegate172 delegate172_0;
	}
}
