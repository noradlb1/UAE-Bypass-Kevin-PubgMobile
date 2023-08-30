using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0
{
	// Token: 0x0200003D RID: 61
	internal sealed class Class22
	{
		// Token: 0x060001AE RID: 430
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void SetLastError(uint uint_2);

		// Token: 0x060001AF RID: 431
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern int CloseHandle(IntPtr intptr_0);

		// Token: 0x060001B0 RID: 432
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr OpenProcess(uint uint_2, int int_1, uint uint_3);

		// Token: 0x060001B1 RID: 433
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern uint GetCurrentProcessId();

		// Token: 0x060001B2 RID: 434
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr LoadLibrary(string string_0);

		// Token: 0x060001B3 RID: 435
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		internal static extern Class22.Delegate0 GetProcAddress(IntPtr intptr_0, string string_0);

		// Token: 0x060001B4 RID: 436
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern Class22.Delegate1 GetProcAddress_1(IntPtr intptr_0, string string_0);

		// Token: 0x060001B5 RID: 437
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern Class22.Delegate4 GetProcAddress_2(IntPtr intptr_0, string string_0);

		// Token: 0x060001B6 RID: 438
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern Class22.Delegate2 GetProcAddress_3(IntPtr intptr_0, string string_0);

		// Token: 0x060001B7 RID: 439
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern Class22.Delegate3 GetProcAddress_4(IntPtr intptr_0, string string_0);

		// Token: 0x060001B8 RID: 440
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern Class22.Delegate6 GetProcAddress_5(IntPtr intptr_0, string string_0);

		// Token: 0x060001B9 RID: 441 RVA: 0x0000F24C File Offset: 0x0000D44C
		private static int smethod_0(IntPtr intptr_0, IntPtr intptr_1)
		{
			string[] array = new string[]
			{
				"OLLYDBG"
			};
			string strA = Class22.smethod_1(intptr_0);
			foreach (string strB in array)
			{
				if (string.Compare(strA, strB, true) == 0)
				{
					Class22.bool_0 = true;
					return 0;
				}
			}
			return 1;
		}

		// Token: 0x060001BA RID: 442
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_1);

		// Token: 0x060001BB RID: 443 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
		internal static string smethod_1(IntPtr intptr_0)
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			Class22.GetClassName(intptr_0, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000F2D4 File Offset: 0x0000D4D4
		internal static void smethod_2()
		{
			if (Class22.smethod_3())
			{
				string arg = "Debugger";
				throw new Exception(string.Format("{0}{1} was found - this software cannot be executed under the {0}.", arg, ""));
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000F304 File Offset: 0x0000D504
		internal static bool smethod_3()
		{
			try
			{
				if (Debugger.IsAttached)
				{
					return true;
				}
				IntPtr intptr_ = Class22.LoadLibrary("kernel32.dll");
				Class22.Delegate2 procAddress_ = Class22.GetProcAddress_3(intptr_, "IsDebuggerPresent");
				if (procAddress_ != null && procAddress_() != 0)
				{
					return true;
				}
				uint currentProcessId = Class22.GetCurrentProcessId();
				IntPtr intPtr = Class22.OpenProcess(1024U, 0, currentProcessId);
				if (intPtr != IntPtr.Zero)
				{
					try
					{
						Class22.Delegate4 procAddress_2 = Class22.GetProcAddress_2(intptr_, "CheckRemoteDebuggerPresent");
						if (procAddress_2 != null)
						{
							int num = 0;
							if (procAddress_2(intPtr, ref num) != 0 && num != 0)
							{
								return true;
							}
						}
					}
					finally
					{
						Class22.CloseHandle(intPtr);
					}
				}
				bool flag = false;
				try
				{
					Class22.CloseHandle(new IntPtr(305419896));
				}
				catch
				{
					flag = true;
				}
				if (flag)
				{
					return true;
				}
				try
				{
					IntPtr intptr_2 = Class22.LoadLibrary("user32.dll");
					Class22.Delegate6 procAddress_3 = Class22.GetProcAddress_5(intptr_2, "EnumWindows");
					if (procAddress_3 != null)
					{
						Class22.bool_0 = false;
						procAddress_3(new Class22.Delegate5(Class22.smethod_0), IntPtr.Zero);
						if (Class22.bool_0)
						{
							return true;
						}
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0400017A RID: 378
		internal static uint uint_0;

		// Token: 0x0400017B RID: 379
		internal static uint uint_1;

		// Token: 0x0400017C RID: 380
		internal static int int_0;

		// Token: 0x0400017D RID: 381
		private static bool bool_0;

		// Token: 0x0200003E RID: 62
		[StructLayout(LayoutKind.Sequential)]
		internal sealed class Class23
		{
			// Token: 0x0400017E RID: 382
			internal IntPtr intptr_0;

			// Token: 0x0400017F RID: 383
			internal IntPtr intptr_1;

			// Token: 0x04000180 RID: 384
			internal IntPtr intptr_2;

			// Token: 0x04000181 RID: 385
			internal IntPtr intptr_3;

			// Token: 0x04000182 RID: 386
			internal IntPtr intptr_4;

			// Token: 0x04000183 RID: 387
			internal IntPtr intptr_5;
		}

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060001C0 RID: 448
		internal delegate int Delegate0(IntPtr ProcessHandle, int ProcessInformationClass, Class22.Class23 ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060001C4 RID: 452
		internal delegate int Delegate1(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060001C8 RID: 456
		internal delegate int Delegate2();

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060001CC RID: 460
		internal delegate void Delegate3([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060001D0 RID: 464
		internal delegate int Delegate4(IntPtr hProcess, ref int pbDebuggerPresent);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060001D4 RID: 468
		internal delegate int Delegate5(IntPtr wnd, IntPtr lParam);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060001D8 RID: 472
		internal delegate int Delegate6(Class22.Delegate5 lpEnumFunc, IntPtr lParam);
	}
}
