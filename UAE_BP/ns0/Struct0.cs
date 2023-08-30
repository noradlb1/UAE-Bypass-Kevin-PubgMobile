using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000023 RID: 35
	internal struct Struct0
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000024DB File Offset: 0x000006DB
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000024E3 File Offset: 0x000006E3
		public UIntPtr CurrentBaseAddress { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000024F4 File Offset: 0x000006F4
		public long RegionSize { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000024FD File Offset: 0x000006FD
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002505 File Offset: 0x00000705
		public UIntPtr RegionBase { get; set; }

		// Token: 0x04000110 RID: 272
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UIntPtr uintptr_0;

		// Token: 0x04000111 RID: 273
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private long long_0;

		// Token: 0x04000112 RID: 274
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UIntPtr uintptr_1;
	}
}
