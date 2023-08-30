using System;
using System.IO;
using System.IO.Compression;

namespace ns0
{
	// Token: 0x02000083 RID: 131
	internal sealed class Delegate61 : MulticastDelegate
	{
		// Token: 0x060002CF RID: 719
		public extern Delegate61(object object_0, IntPtr intptr_0);

		// Token: 0x060002D0 RID: 720 RVA: 0x00003057 File Offset: 0x00001257
		static Delegate61()
		{
			Class25.smethod_0(33554566, 167772217, 16777215);
		}

		// Token: 0x060002D1 RID: 721
		public extern DeflateStream Invoke(Stream stream_0, CompressionMode compressionMode_0);

		// Token: 0x060002D2 RID: 722 RVA: 0x0000306D File Offset: 0x0000126D
		public static DeflateStream smethod_0(Stream stream_0, CompressionMode compressionMode_0)
		{
			return Delegate61.delegate61_0(stream_0, compressionMode_0);
		}

		// Token: 0x0400020D RID: 525
		internal static readonly Delegate61 delegate61_0;
	}
}
