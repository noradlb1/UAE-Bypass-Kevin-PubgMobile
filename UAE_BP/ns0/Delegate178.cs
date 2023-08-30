using System;

namespace ns0
{
	// Token: 0x020000FD RID: 253
	internal sealed class Delegate178 : MulticastDelegate
	{
		// Token: 0x060004A8 RID: 1192
		public extern Delegate178(object object_0, IntPtr intptr_0);

		// Token: 0x060004A9 RID: 1193 RVA: 0x00004067 File Offset: 0x00002267
		static Delegate178()
		{
			Class24.smethod_0(33554705, 167772326, 16777215);
		}

		// Token: 0x060004AA RID: 1194
		public extern Delegate Invoke(Type type_0, object object_0, string string_0);

		// Token: 0x060004AB RID: 1195 RVA: 0x0000407D File Offset: 0x0000227D
		public static Delegate smethod_0(Type type_0, object object_0, string string_0)
		{
			return Delegate178.delegate178_0(type_0, object_0, string_0);
		}

		// Token: 0x04000287 RID: 647
		internal static readonly Delegate178 delegate178_0;
	}
}
