using System;
using System.IO;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000063 RID: 99
	internal sealed class Delegate31 : MulticastDelegate
	{
		// Token: 0x06000255 RID: 597
		public extern Delegate31(object object_0, IntPtr intptr_0);

		// Token: 0x06000256 RID: 598 RVA: 0x00002C2C File Offset: 0x00000E2C
		static Delegate31()
		{
			Class25.smethod_0(33554532, 167772192, 16777215);
		}

		// Token: 0x06000257 RID: 599
		public extern CryptoStream Invoke(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0);

		// Token: 0x06000258 RID: 600 RVA: 0x00002C42 File Offset: 0x00000E42
		public static CryptoStream smethod_0(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0)
		{
			return Delegate31.delegate31_0(stream_0, icryptoTransform_0, cryptoStreamMode_0);
		}

		// Token: 0x040001ED RID: 493
		internal static readonly Delegate31 delegate31_0;
	}
}
