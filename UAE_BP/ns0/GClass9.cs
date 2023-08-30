using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x02000015 RID: 21
	public sealed class GClass9
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00009E3C File Offset: 0x0000803C
		public string method_0(string string_0)
		{
			string result = "0";
			checked
			{
				try
				{
					IntPtr intPtr = IntPtr.Zero;
					uint num = 0U;
					IntPtr intPtr2 = GClass9.CreateToolhelp32Snapshot(2U, 0U);
					if ((int)intPtr2 > 0)
					{
						GClass9.GStruct0 gstruct = default(GClass9.GStruct0);
						gstruct.uint_0 = (uint)Marshal.SizeOf<GClass9.GStruct0>(gstruct);
						for (int num2 = GClass9.Process32First(intPtr2, ref gstruct); num2 == 1; num2 = GClass9.Process32Next(intPtr2, ref gstruct))
						{
							IntPtr intPtr3 = Marshal.AllocHGlobal((int)gstruct.uint_0);
							Marshal.StructureToPtr<GClass9.GStruct0>(gstruct, intPtr3, true);
							object obj = Marshal.PtrToStructure(intPtr3, typeof(GClass9.GStruct0));
							GClass9.GStruct0 gstruct2 = (obj != null) ? ((GClass9.GStruct0)obj) : default(GClass9.GStruct0);
							Marshal.FreeHGlobal(intPtr3);
							if (gstruct2.string_0.Contains(string_0) && gstruct2.uint_4 > num)
							{
								num = gstruct2.uint_4;
								intPtr = (IntPtr)((long)(unchecked((ulong)gstruct2.uint_2)));
							}
						}
						result = Convert.ToString(intPtr);
					}
				}
				catch
				{
				}
				return result;
			}
		}

		// Token: 0x060000AE RID: 174
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(uint uint_14, bool bool_1, uint uint_15);

		// Token: 0x060000AF RID: 175
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateToolhelp32Snapshot(uint uint_14, uint uint_15);

		// Token: 0x060000B0 RID: 176
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int Process32First(IntPtr intptr_1, ref GClass9.GStruct0 gstruct0_0);

		// Token: 0x060000B1 RID: 177
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int Process32Next(IntPtr intptr_1, ref GClass9.GStruct0 gstruct0_0);

		// Token: 0x060000B2 RID: 178
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		public static extern IntPtr OpenProcess_1(uint uint_14, bool bool_1, int int_5);

		// Token: 0x060000B3 RID: 179
		[DllImport("kernel32.dll")]
		public static extern UIntPtr VirtualQueryEx(IntPtr intptr_1, UIntPtr uintptr_0, out GClass9.GStruct2 gstruct2_0, UIntPtr uintptr_1);

		// Token: 0x060000B4 RID: 180
		[DllImport("kernel32.dll", EntryPoint = "VirtualQueryEx")]
		public static extern UIntPtr VirtualQueryEx_1(IntPtr intptr_1, UIntPtr uintptr_0, out GClass9.GStruct3 gstruct3_0, UIntPtr uintptr_1);

		// Token: 0x060000B5 RID: 181
		[DllImport("kernel32.dll")]
		private static extern uint GetLastError();

		// Token: 0x060000B6 RID: 182 RVA: 0x00009F58 File Offset: 0x00008158
		public UIntPtr method_1(IntPtr intptr_1, UIntPtr uintptr_0, out GClass9.GStruct4 gstruct4_0)
		{
			UIntPtr result;
			if (!this.Boolean_0 && IntPtr.Size != 8)
			{
				GClass9.GStruct2 gstruct = default(GClass9.GStruct2);
				UIntPtr uintPtr = GClass9.VirtualQueryEx(intptr_1, uintptr_0, out gstruct, new UIntPtr((uint)Marshal.SizeOf<GClass9.GStruct2>(gstruct)));
				gstruct4_0.uintptr_0 = gstruct.uintptr_0;
				gstruct4_0.uintptr_1 = gstruct.uintptr_1;
				gstruct4_0.uint_0 = gstruct.uint_0;
				gstruct4_0.long_0 = (long)((ulong)gstruct.uint_1);
				gstruct4_0.uint_1 = gstruct.uint_2;
				gstruct4_0.uint_2 = gstruct.uint_3;
				gstruct4_0.uint_3 = gstruct.uint_4;
				result = uintPtr;
			}
			else
			{
				GClass9.GStruct3 gstruct2 = default(GClass9.GStruct3);
				UIntPtr uintPtr2 = GClass9.VirtualQueryEx_1(intptr_1, uintptr_0, out gstruct2, new UIntPtr((uint)Marshal.SizeOf<GClass9.GStruct3>(gstruct2)));
				gstruct4_0.uintptr_0 = gstruct2.uintptr_0;
				gstruct4_0.uintptr_1 = gstruct2.uintptr_1;
				gstruct4_0.uint_0 = gstruct2.uint_0;
				gstruct4_0.long_0 = (long)gstruct2.ulong_0;
				gstruct4_0.uint_1 = gstruct2.uint_2;
				gstruct4_0.uint_2 = gstruct2.uint_3;
				gstruct4_0.uint_3 = gstruct2.uint_4;
				result = uintPtr2;
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183
		[DllImport("kernel32.dll")]
		private static extern void GetSystemInfo(out GClass9.GStruct1 gstruct1_0);

		// Token: 0x060000B8 RID: 184
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(GClass9.GEnum1 genum1_0, bool bool_1, uint uint_14);

		// Token: 0x060000B9 RID: 185
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr intptr_1);

		// Token: 0x060000BA RID: 186
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr intptr_1);

		// Token: 0x060000BB RID: 187
		[DllImport("dbghelp.dll")]
		private static extern bool MiniDumpWriteDump(IntPtr intptr_1, int int_5, IntPtr intptr_2, GClass9.Enum0 enum0_0, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5);

		// Token: 0x060000BC RID: 188
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowLong(IntPtr intptr_1, int int_5);

		// Token: 0x060000BD RID: 189
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr intptr_1, uint uint_14, IntPtr intptr_2, IntPtr intptr_3);

		// Token: 0x060000BE RID: 190
		[DllImport("kernel32.dll")]
		public static extern bool WriteProcessMemory(IntPtr intptr_1, UIntPtr uintptr_0, string string_0, UIntPtr uintptr_1, out IntPtr intptr_2);

		// Token: 0x060000BF RID: 191
		[DllImport("kernel32.dll")]
		private static extern int GetProcessId(IntPtr intptr_1);

		// Token: 0x060000C0 RID: 192
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		private static extern uint GetPrivateProfileString(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0, uint uint_14, string string_3);

		// Token: 0x060000C1 RID: 193
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool VirtualFreeEx(IntPtr intptr_1, UIntPtr uintptr_0, UIntPtr uintptr_1, uint uint_14);

		// Token: 0x060000C2 RID: 194
		[DllImport("kernel32.dll")]
		private static extern bool ReadProcessMemory(IntPtr intptr_1, UIntPtr uintptr_0, [Out] byte[] byte_0, UIntPtr uintptr_1, IntPtr intptr_2);

		// Token: 0x060000C3 RID: 195
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		private static extern bool ReadProcessMemory_1(IntPtr intptr_1, UIntPtr uintptr_0, [Out] byte[] byte_0, UIntPtr uintptr_1, out ulong ulong_0);

		// Token: 0x060000C4 RID: 196
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		private static extern bool ReadProcessMemory_2(IntPtr intptr_1, UIntPtr uintptr_0, [Out] IntPtr intptr_2, UIntPtr uintptr_1, out ulong ulong_0);

		// Token: 0x060000C5 RID: 197
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern UIntPtr VirtualAllocEx(IntPtr intptr_1, UIntPtr uintptr_0, uint uint_14, uint uint_15, uint uint_16);

		// Token: 0x060000C6 RID: 198
		[DllImport("kernel32.dll")]
		private static extern bool VirtualProtectEx(IntPtr intptr_1, UIntPtr uintptr_0, IntPtr intptr_2, GClass9.GEnum0 genum0_0, out GClass9.GEnum0 genum0_1);

		// Token: 0x060000C7 RID: 199
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern UIntPtr GetProcAddress(IntPtr intptr_1, string string_0);

		// Token: 0x060000C8 RID: 200
		[DllImport("kernel32.dll")]
		private static extern bool CloseHandle(IntPtr intptr_1);

		// Token: 0x060000C9 RID: 201
		[DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
		public static extern int CloseHandle_1(IntPtr intptr_1);

		// Token: 0x060000CA RID: 202
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string string_0);

		// Token: 0x060000CB RID: 203
		[DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
		internal static extern int WaitForSingleObject(IntPtr intptr_1, int int_5);

		// Token: 0x060000CC RID: 204
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
		private static extern bool WriteProcessMemory_1(IntPtr intptr_1, UIntPtr uintptr_0, byte[] byte_0, UIntPtr uintptr_1, IntPtr intptr_2);

		// Token: 0x060000CD RID: 205
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
		private static extern bool WriteProcessMemory_2(IntPtr intptr_1, UIntPtr uintptr_0, byte[] byte_0, UIntPtr uintptr_1, out IntPtr intptr_2);

		// Token: 0x060000CE RID: 206
		[DllImport("kernel32")]
		public static extern IntPtr CreateRemoteThread(IntPtr intptr_1, IntPtr intptr_2, uint uint_14, UIntPtr uintptr_0, UIntPtr uintptr_1, uint uint_15, out IntPtr intptr_3);

		// Token: 0x060000CF RID: 207
		[DllImport("kernel32")]
		public static extern bool IsWow64Process(IntPtr intptr_1, out bool bool_1);

		// Token: 0x060000D0 RID: 208
		[DllImport("user32.dll")]
		private static extern bool SetForegroundWindow(IntPtr intptr_1);

		// Token: 0x060000D1 RID: 209 RVA: 0x0000A074 File Offset: 0x00008274
		private bool method_2(string string_0)
		{
			foreach (char c in string_0)
			{
				if (c < '0' || c > '9')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000A0B0 File Offset: 0x000082B0
		public void method_3(string string_0)
		{
			Debug.WriteLine("Un-Freezing Address " + string_0);
			try
			{
			}
			catch
			{
				Debug.WriteLine("ERROR: Address " + string_0 + " was not frozen.");
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000A0F8 File Offset: 0x000082F8
		public bool method_4(int int_5)
		{
			if (!this.method_6())
			{
				Debug.WriteLine("WARNING: You are NOT running this program as admin!");
			}
			bool result;
			if (int_5 <= 0)
			{
				Debug.WriteLine("ERROR: OpenProcess given proc ID 0.");
				result = false;
			}
			else if (this.process_0 != null && this.process_0.Id == int_5)
			{
				result = true;
			}
			else
			{
				try
				{
					this.process_0 = Process.GetProcessById(int_5);
					if (this.process_0 != null && !this.process_0.Responding)
					{
						Debug.WriteLine("ERROR: OpenProcess: Process is not responding or null.");
						result = false;
					}
					else
					{
						this.intptr_0 = GClass9.OpenProcess_1(2035711U, true, int_5);
						Process.EnterDebugMode();
						if (this.intptr_0 == IntPtr.Zero)
						{
							Debug.WriteLine("ERROR: OpenProcess has failed opening a handle to the target process (GetLastWin32ErrorCode: " + Marshal.GetLastWin32Error().ToString() + ")");
							Process.LeaveDebugMode();
							this.process_0 = Class32.process_0;
							result = false;
						}
						else
						{
							this.processModule_0 = this.process_0.MainModule;
							this.method_7();
							bool flag;
							this.Boolean_0 = (Environment.Is64BitOperatingSystem && GClass9.IsWow64Process(this.intptr_0, out flag) && !flag);
							string str = "Program is operating at Administrative level. Process #";
							Process process = this.process_0;
							Debug.WriteLine(str + ((process != null) ? process.ToString() : null) + " is open and modules are stored.");
							result = true;
						}
					}
				}
				catch
				{
					Debug.WriteLine("ERROR: OpenProcess has crashed. Are you trying to hack a x64 game? https://github.com/erfg12/memory.dll/wiki/64bit-Games");
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002480 File Offset: 0x00000680
		public bool method_5(string string_0)
		{
			return this.method_4(this.method_9(string_0));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000A284 File Offset: 0x00008484
		public bool method_6()
		{
			bool result;
			using (WindowsIdentity current = WindowsIdentity.GetCurrent())
			{
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
				result = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
			}
			return result;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000248F File Offset: 0x0000068F
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002497 File Offset: 0x00000697
		public bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
			private set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000A2C8 File Offset: 0x000084C8
		public void method_7()
		{
			if (this.process_0 != Class32.process_0)
			{
				this.dictionary_0.Clear();
				foreach (object obj in this.process_0.Modules)
				{
					ProcessModule processModule = (ProcessModule)obj;
					if (!string.IsNullOrEmpty(processModule.ModuleName) && !this.dictionary_0.ContainsKey(processModule.ModuleName))
					{
						this.dictionary_0.Add(processModule.ModuleName, processModule.BaseAddress);
					}
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000024A0 File Offset: 0x000006A0
		public void method_8()
		{
			GClass9.SetForegroundWindow(this.process_0.MainWindowHandle);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000A37C File Offset: 0x0000857C
		public int method_9(string string_0)
		{
			Process[] processes = Process.GetProcesses();
			if (string_0.ToLower().Contains(".exe"))
			{
				string_0 = string_0.Replace(".exe", "");
			}
			if (string_0.ToLower().Contains(".bin"))
			{
				string_0 = string_0.Replace(".bin", "");
			}
			foreach (Process process in processes)
			{
				if (process.ProcessName.Equals(string_0, StringComparison.CurrentCultureIgnoreCase))
				{
					return process.Id;
				}
			}
			return 0;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000A40C File Offset: 0x0000860C
		public string method_10(string string_0, string string_1)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			if (string_1 != "")
			{
				GClass9.GetPrivateProfileString("codes", string_0, "", stringBuilder, (uint)stringBuilder.Capacity, string_1);
			}
			else
			{
				stringBuilder.Append(string_0);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000A45C File Offset: 0x0000865C
		private int method_11(string string_0, string string_1)
		{
			int result;
			try
			{
				int num = Convert.ToInt32(this.method_10(string_0, string_1), 16);
				if (num >= 0)
				{
					result = num;
				}
				else
				{
					result = 0;
				}
			}
			catch
			{
				Debug.WriteLine("ERROR: LoadIntCode function crashed!");
				result = 0;
			}
			return result;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000A4B0 File Offset: 0x000086B0
		public void method_12(string string_0, string string_1)
		{
			using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(string_1))
			{
				if (!namedPipeClientStream.IsConnected)
				{
					namedPipeClientStream.Connect();
				}
				using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
				{
					if (!streamWriter.AutoFlush)
					{
						streamWriter.AutoFlush = true;
					}
					streamWriter.WriteLine(string_0);
				}
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000A52C File Offset: 0x0000872C
		public string method_13(string string_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in string_0)
			{
				if (c < ' ' || c > '~')
				{
					break;
				}
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000A584 File Offset: 0x00008784
		public string method_14(string string_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in string_0)
			{
				if (c >= ' ' && c <= '~')
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000A5D4 File Offset: 0x000087D4
		public bool method_15(string string_0, GClass9.GEnum0 genum0_0, out GClass9.GEnum0 genum0_1, string string_1 = "")
		{
			UIntPtr uintPtr = this.method_39(string_0, string_1, 8);
			bool result;
			if (!(uintPtr == UIntPtr.Zero) && !(this.intptr_0 == IntPtr.Zero))
			{
				result = GClass9.VirtualProtectEx(this.intptr_0, uintPtr, (IntPtr)(this.Boolean_0 ? 8 : 4), genum0_0, out genum0_1);
			}
			else
			{
				genum0_1 = (GClass9.GEnum0)0U;
				result = false;
			}
			return result;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000A634 File Offset: 0x00008834
		public byte[] method_16(string string_0, long long_0, string string_1 = "")
		{
			byte[] array = new byte[long_0];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			byte[] result;
			if (!GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)((ulong)long_0), IntPtr.Zero))
			{
				result = Class43.byte_0;
			}
			else
			{
				result = array;
			}
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000A680 File Offset: 0x00008880
		public float method_17(string string_0, string string_1 = "", bool bool_1 = true)
		{
			byte[] array = new byte[4];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			float result;
			try
			{
				if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)4UL, IntPtr.Zero))
				{
					float num = BitConverter.ToSingle(array, 0);
					float num2 = num;
					if (bool_1)
					{
						num2 = (float)Math.Round((double)num, 2);
					}
					result = num2;
				}
				else
				{
					result = 0f;
				}
			}
			catch
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000A708 File Offset: 0x00008908
		public string method_18(string string_0, string string_1 = "", int int_5 = 32, bool bool_1 = true)
		{
			byte[] array = new byte[int_5];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			string result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero))
			{
				result = (bool_1 ? Encoding.UTF8.GetString(array).Split(new char[1])[0] : Encoding.UTF8.GetString(array));
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000A778 File Offset: 0x00008978
		public double method_19(string string_0, string string_1 = "", bool bool_1 = true)
		{
			byte[] array = new byte[8];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			double result;
			try
			{
				if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)8UL, IntPtr.Zero))
				{
					double num = BitConverter.ToDouble(array, 0);
					double num2 = num;
					if (bool_1)
					{
						num2 = Math.Round(num, 2);
					}
					result = num2;
				}
				else
				{
					result = 0.0;
				}
			}
			catch
			{
				result = 0.0;
			}
			return result;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000A804 File Offset: 0x00008A04
		public int method_20(UIntPtr uintptr_0)
		{
			byte[] array = new byte[4];
			int result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_0, array, (UIntPtr)4UL, IntPtr.Zero))
			{
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000A84C File Offset: 0x00008A4C
		public int method_21(string string_0, string string_1 = "")
		{
			byte[] array = new byte[4];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			int result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)4UL, IntPtr.Zero))
			{
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000A89C File Offset: 0x00008A9C
		public long method_22(string string_0, string string_1 = "")
		{
			byte[] array = new byte[16];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			long result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)16UL, IntPtr.Zero))
			{
				result = BitConverter.ToInt64(array, 0);
			}
			else
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		public ulong method_23(string string_0, string string_1 = "")
		{
			byte[] array = new byte[4];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			ulong result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)4UL, IntPtr.Zero))
			{
				result = BitConverter.ToUInt64(array, 0);
			}
			else
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000A94C File Offset: 0x00008B4C
		public int method_24(string string_0, int int_5, string string_1 = "")
		{
			byte[] array = new byte[4];
			UIntPtr pointer = this.method_39(string_0, string_1, 8);
			UIntPtr uintptr_ = UIntPtr.Add(pointer, int_5);
			int result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)2UL, IntPtr.Zero))
			{
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		public int method_25(string string_0, int int_5, string string_1 = "")
		{
			byte[] array = new byte[4];
			UIntPtr pointer = this.method_39(string_0, string_1, 8);
			UIntPtr uintptr_ = UIntPtr.Add(pointer, int_5);
			int result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)4UL, IntPtr.Zero))
			{
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000AA04 File Offset: 0x00008C04
		public ulong method_26(string string_0, int int_5, string string_1 = "")
		{
			byte[] array = new byte[8];
			UIntPtr pointer = this.method_39(string_0, string_1, 8);
			UIntPtr uintptr_ = UIntPtr.Add(pointer, int_5);
			ulong result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)8UL, IntPtr.Zero))
			{
				result = BitConverter.ToUInt64(array, 0);
			}
			else
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000AA68 File Offset: 0x00008C68
		public int method_27(string string_0, string string_1 = "")
		{
			byte[] array = new byte[4];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			int result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)2UL, IntPtr.Zero))
			{
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		public int method_28(string string_0, string string_1 = "")
		{
			byte[] array = new byte[1];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			int result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)1UL, IntPtr.Zero))
			{
				result = (int)array[0];
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000AB04 File Offset: 0x00008D04
		public bool[] method_29(string string_0, string string_1 = "")
		{
			byte[] array = new byte[1];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			bool[] array2 = new bool[8];
			bool[] result;
			if (!GClass9.ReadProcessMemory(this.intptr_0, uintptr_, array, (UIntPtr)1UL, IntPtr.Zero))
			{
				result = array2;
			}
			else
			{
				if (!BitConverter.IsLittleEndian)
				{
					throw new Exception("Should be little endian");
				}
				for (int i = 0; i < 8; i++)
				{
					array2[i] = Convert.ToBoolean((int)array[0] & 1 << i);
				}
				result = array2;
			}
			return result;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000AB94 File Offset: 0x00008D94
		public int method_30(UIntPtr uintptr_0, string string_0, string string_1 = "")
		{
			byte[] array = new byte[4];
			int result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_0 + this.method_11(string_0, string_1), array, (UIntPtr)1UL, IntPtr.Zero))
			{
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		public float method_31(UIntPtr uintptr_0, string string_0, string string_1 = "")
		{
			byte[] array = new byte[4];
			float result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_0 + this.method_11(string_0, string_1), array, (UIntPtr)4UL, IntPtr.Zero))
			{
				float num = BitConverter.ToSingle(array, 0);
				result = (float)Math.Round((double)num, 2);
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000AC48 File Offset: 0x00008E48
		public int method_32(UIntPtr uintptr_0, string string_0, string string_1 = "")
		{
			byte[] array = new byte[4];
			int result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_0 + this.method_11(string_0, string_1), array, (UIntPtr)4UL, IntPtr.Zero))
			{
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000AC9C File Offset: 0x00008E9C
		public string method_33(UIntPtr uintptr_0, string string_0, string string_1 = "")
		{
			byte[] array = new byte[32];
			string result;
			if (GClass9.ReadProcessMemory(this.intptr_0, uintptr_0 + this.method_11(string_0, string_1), array, (UIntPtr)32UL, IntPtr.Zero))
			{
				result = this.method_13(Encoding.ASCII.GetString(array));
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000AD00 File Offset: 0x00008F00
		public bool method_34(string string_0, string string_1, string string_2, string string_3 = "", Encoding encoding_0 = null)
		{
			byte[] array = new byte[4];
			int num = 4;
			UIntPtr uintptr_ = this.method_39(string_0, string_3, 8);
			if (string_1.ToLower() == "float")
			{
				array = BitConverter.GetBytes(Convert.ToSingle(string_2));
				num = 4;
			}
			else if (string_1.ToLower() == "int")
			{
				array = BitConverter.GetBytes(Convert.ToInt32(string_2));
				num = 4;
			}
			else if (string_1.ToLower() == "byte")
			{
				array = new byte[]
				{
					Convert.ToByte(string_2, 16)
				};
				num = 1;
			}
			else if (string_1.ToLower() == "2bytes")
			{
				array = new byte[]
				{
					(byte)(Convert.ToInt32(string_2) % 256),
					(byte)(Convert.ToInt32(string_2) / 256)
				};
				num = 2;
			}
			else if (string_1.ToLower() == "bytes")
			{
				if (!string_2.Contains(",") && !string_2.Contains(" "))
				{
					array = new byte[]
					{
						Convert.ToByte(string_2, 16)
					};
					num = 1;
				}
				else
				{
					string[] array2;
					if (string_2.Contains(","))
					{
						array2 = string_2.Split(new char[]
						{
							','
						});
					}
					else
					{
						array2 = string_2.Split(new char[]
						{
							' '
						});
					}
					int num2 = array2.Count<string>();
					array = new byte[num2];
					for (int i = 0; i < num2; i++)
					{
						array[i] = Convert.ToByte(array2[i], 16);
					}
					num = array2.Count<string>();
				}
			}
			else if (string_1.ToLower() == "double")
			{
				array = BitConverter.GetBytes(Convert.ToDouble(string_2));
				num = 8;
			}
			else if (string_1.ToLower() == "long")
			{
				array = BitConverter.GetBytes(Convert.ToInt64(string_2));
				num = 8;
			}
			else if (string_1.ToLower() == "string")
			{
				if (encoding_0 == Class42.encoding_0)
				{
					array = Encoding.UTF8.GetBytes(string_2);
				}
				else
				{
					array = encoding_0.GetBytes(string_2);
				}
				num = array.Length;
			}
			return GClass9.WriteProcessMemory_1(this.intptr_0, uintptr_, array, (UIntPtr)((ulong)((long)num)), IntPtr.Zero);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000AF24 File Offset: 0x00009124
		public bool method_35(string string_0, string string_1, string string_2, int int_5, string string_3 = "")
		{
			byte[] array = new byte[4];
			int num = 4;
			UIntPtr pointer = this.method_39(string_0, string_3, 8);
			if (string_1 == "float")
			{
				array = new byte[string_2.Length];
				array = BitConverter.GetBytes(Convert.ToSingle(string_2));
				num = string_2.Length;
			}
			else if (string_1 == "int")
			{
				array = BitConverter.GetBytes(Convert.ToInt32(string_2));
				num = 4;
			}
			else if (string_1 == "double")
			{
				array = BitConverter.GetBytes(Convert.ToDouble(string_2));
				num = 8;
			}
			else if (string_1 == "long")
			{
				array = BitConverter.GetBytes(Convert.ToInt64(string_2));
				num = 8;
			}
			else if (string_1 == "byte")
			{
				array = new byte[]
				{
					Convert.ToByte(string_2, 16)
				};
				num = 1;
			}
			else if (string_1 == "string")
			{
				array = new byte[string_2.Length];
				array = Encoding.UTF8.GetBytes(string_2);
				num = string_2.Length;
			}
			UIntPtr uintptr_ = UIntPtr.Add(pointer, int_5);
			Debug.Write(string.Concat(new string[]
			{
				"DEBUG: Writing bytes [TYPE:",
				string_1,
				" ADDR:[O]",
				pointer.ToString(),
				" [N]",
				uintptr_.ToString(),
				" MQTY:",
				int_5.ToString(),
				"] ",
				string.Join<byte>(",", array),
				Environment.NewLine
			}));
			Thread.Sleep(1000);
			return GClass9.WriteProcessMemory_1(this.intptr_0, uintptr_, array, (UIntPtr)((ulong)((long)num)), IntPtr.Zero);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000B0C4 File Offset: 0x000092C4
		public void method_36(string string_0, byte[] byte_0, string string_1 = "")
		{
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			GClass9.WriteProcessMemory_1(this.intptr_0, uintptr_, byte_0, (UIntPtr)((ulong)((long)byte_0.Length)), IntPtr.Zero);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000B0F8 File Offset: 0x000092F8
		public void method_37(string string_0, bool[] bool_1, string string_1 = "")
		{
			if (bool_1.Length != 8)
			{
				throw new ArgumentException("Not enough bits for a whole byte", "bits");
			}
			byte[] array = new byte[1];
			UIntPtr uintptr_ = this.method_39(string_0, string_1, 8);
			for (int i = 0; i < 8; i++)
			{
				if (bool_1[i])
				{
					byte[] array2 = array;
					byte[] array3 = array2;
					int num = 0;
					array3[num] |= (byte)(1 << i);
				}
			}
			GClass9.WriteProcessMemory_1(this.intptr_0, uintptr_, array, (UIntPtr)1UL, IntPtr.Zero);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000B17C File Offset: 0x0000937C
		public void method_38(UIntPtr uintptr_0, byte[] byte_0)
		{
			IntPtr intPtr;
			GClass9.WriteProcessMemory_2(this.intptr_0, uintptr_0, byte_0, (UIntPtr)((ulong)((long)byte_0.Length)), out intPtr);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000B1A4 File Offset: 0x000093A4
		public UIntPtr method_39(string string_0, string string_1 = "", int int_5 = 8)
		{
			UIntPtr result;
			if (this.Boolean_0)
			{
				if (int_5 == 8)
				{
					int_5 = 16;
				}
				result = this.method_40(string_0, string_1, int_5);
			}
			else
			{
				string text;
				if (string_1 != "")
				{
					text = this.method_10(string_0, string_1);
				}
				else
				{
					text = string_0;
				}
				if (text == "")
				{
					result = UIntPtr.Zero;
				}
				else
				{
					if (text.Contains(" "))
					{
						text.Replace(" ", string.Empty);
					}
					if (!text.Contains("+") && !text.Contains(","))
					{
						result = new UIntPtr(Convert.ToUInt32(text, 16));
					}
					else
					{
						string text2 = text;
						if (text.Contains("+"))
						{
							text2 = text.Substring(text.IndexOf('+') + 1);
						}
						byte[] array = new byte[int_5];
						if (text2.Contains(','))
						{
							List<int> list = new List<int>();
							string[] array2 = text2.Split(new char[]
							{
								','
							});
							foreach (string text3 in array2)
							{
								string text4 = text3;
								if (text3.Contains("0x"))
								{
									text4 = text3.Replace("0x", "");
								}
								int num;
								if (!text3.Contains("-"))
								{
									num = int.Parse(text4, NumberStyles.AllowHexSpecifier);
								}
								else
								{
									text4 = text4.Replace("-", "");
									num = int.Parse(text4, NumberStyles.AllowHexSpecifier);
									num *= -1;
								}
								list.Add(num);
							}
							int[] array4 = list.ToArray();
							if (!text.Contains("base") && !text.Contains("main"))
							{
								if (!text.Contains("base") && !text.Contains("main") && text.Contains("+"))
								{
									string[] array5 = text.Split(new char[]
									{
										'+'
									});
									IntPtr value = IntPtr.Zero;
									if (!array5[0].ToLower().Contains(".dll") && !array5[0].ToLower().Contains(".exe") && !array5[0].ToLower().Contains(".bin"))
									{
										string text5 = array5[0];
										if (text5.Contains("0x"))
										{
											text5 = text5.Replace("0x", "");
										}
										value = (IntPtr)int.Parse(text5, NumberStyles.HexNumber);
									}
									else
									{
										try
										{
											value = this.dictionary_0[array5[0]];
										}
										catch
										{
											Debug.WriteLine("Module " + array5[0] + " was not found in module list!");
											Debug.WriteLine("Modules: " + string.Join<KeyValuePair<string, IntPtr>>(",", this.dictionary_0));
										}
									}
									GClass9.ReadProcessMemory(this.intptr_0, (UIntPtr)((ulong)((long)((int)value + array4[0]))), array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero);
								}
								else
								{
									GClass9.ReadProcessMemory(this.intptr_0, (UIntPtr)((ulong)((long)array4[0])), array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero);
								}
							}
							else
							{
								GClass9.ReadProcessMemory(this.intptr_0, (UIntPtr)((ulong)((long)((int)this.processModule_0.BaseAddress + array4[0]))), array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero);
							}
							uint num2 = BitConverter.ToUInt32(array, 0);
							UIntPtr uintPtr = (UIntPtr)0UL;
							for (int j = 1; j < array4.Length; j++)
							{
								uintPtr = new UIntPtr(Convert.ToUInt32((long)((ulong)num2 + (ulong)((long)array4[j]))));
								GClass9.ReadProcessMemory(this.intptr_0, uintPtr, array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero);
								num2 = BitConverter.ToUInt32(array, 0);
							}
							result = uintPtr;
						}
						else
						{
							int num3 = Convert.ToInt32(text2, 16);
							IntPtr value2 = IntPtr.Zero;
							if (!text.ToLower().Contains("base") && !text.ToLower().Contains("main"))
							{
								if (!text.ToLower().Contains("base") && !text.ToLower().Contains("main") && text.Contains("+"))
								{
									string[] array6 = text.Split(new char[]
									{
										'+'
									});
									if (!array6[0].ToLower().Contains(".dll") && !array6[0].ToLower().Contains(".exe") && !array6[0].ToLower().Contains(".bin"))
									{
										string text6 = array6[0];
										if (text6.Contains("0x"))
										{
											text6 = text6.Replace("0x", "");
										}
										value2 = (IntPtr)int.Parse(text6, NumberStyles.HexNumber);
										goto IL_546;
									}
									try
									{
										value2 = this.dictionary_0[array6[0]];
										goto IL_546;
									}
									catch
									{
										Debug.WriteLine("Module " + array6[0] + " was not found in module list!");
										Debug.WriteLine("Modules: " + string.Join<KeyValuePair<string, IntPtr>>(",", this.dictionary_0));
										goto IL_546;
									}
								}
								value2 = this.dictionary_0[text.Split(new char[]
								{
									'+'
								})[0]];
							}
							else
							{
								value2 = this.processModule_0.BaseAddress;
							}
							IL_546:
							result = (UIntPtr)((ulong)((long)((int)value2 + num3)));
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000B72C File Offset: 0x0000992C
		public UIntPtr method_40(string string_0, string string_1 = "", int int_5 = 16)
		{
			string text;
			if (string_1 != "")
			{
				text = this.method_10(string_0, string_1);
			}
			else
			{
				text = string_0;
			}
			UIntPtr result;
			if (text == "")
			{
				result = UIntPtr.Zero;
			}
			else
			{
				if (text.Contains(" "))
				{
					text.Replace(" ", string.Empty);
				}
				string text2 = text;
				if (text.Contains("+"))
				{
					text2 = text.Substring(text.IndexOf('+') + 1);
				}
				byte[] array = new byte[int_5];
				if (!text.Contains("+") && !text.Contains(","))
				{
					result = new UIntPtr(Convert.ToUInt64(text, 16));
				}
				else if (text2.Contains(','))
				{
					List<long> list = new List<long>();
					string[] array2 = text2.Split(new char[]
					{
						','
					});
					foreach (string text3 in array2)
					{
						string text4 = text3;
						if (text3.Contains("0x"))
						{
							text4 = text3.Replace("0x", "");
						}
						long num;
						if (!text3.Contains("-"))
						{
							num = long.Parse(text4, NumberStyles.AllowHexSpecifier);
						}
						else
						{
							text4 = text4.Replace("-", "");
							num = long.Parse(text4, NumberStyles.AllowHexSpecifier);
							num *= -1L;
						}
						list.Add(num);
					}
					long[] array4 = list.ToArray();
					if (!text.Contains("base") && !text.Contains("main"))
					{
						if (!text.Contains("base") && !text.Contains("main") && text.Contains("+"))
						{
							string[] array5 = text.Split(new char[]
							{
								'+'
							});
							IntPtr value = IntPtr.Zero;
							if (!array5[0].ToLower().Contains(".dll") && !array5[0].ToLower().Contains(".exe") && !array5[0].ToLower().Contains(".bin"))
							{
								value = (IntPtr)long.Parse(array5[0], NumberStyles.HexNumber);
							}
							else
							{
								try
								{
									value = this.dictionary_0[array5[0]];
								}
								catch
								{
									Debug.WriteLine("Module " + array5[0] + " was not found in module list!");
									Debug.WriteLine("Modules: " + string.Join<KeyValuePair<string, IntPtr>>(",", this.dictionary_0));
								}
							}
							GClass9.ReadProcessMemory(this.intptr_0, (UIntPtr)((ulong)((long)value + array4[0])), array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero);
						}
						else
						{
							GClass9.ReadProcessMemory(this.intptr_0, (UIntPtr)((ulong)array4[0]), array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero);
						}
					}
					else
					{
						GClass9.ReadProcessMemory(this.intptr_0, (UIntPtr)((ulong)((long)this.processModule_0.BaseAddress + array4[0])), array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero);
					}
					long num2 = BitConverter.ToInt64(array, 0);
					UIntPtr uintPtr = (UIntPtr)0UL;
					for (int j = 1; j < array4.Length; j++)
					{
						uintPtr = new UIntPtr(Convert.ToUInt64(num2 + array4[j]));
						GClass9.ReadProcessMemory(this.intptr_0, uintPtr, array, (UIntPtr)((ulong)((long)int_5)), IntPtr.Zero);
						num2 = BitConverter.ToInt64(array, 0);
					}
					result = uintPtr;
				}
				else
				{
					long num3 = Convert.ToInt64(text2, 16);
					IntPtr value2 = IntPtr.Zero;
					if (!text.Contains("base") && !text.Contains("main"))
					{
						if (!text.Contains("base") && !text.Contains("main") && text.Contains("+"))
						{
							string[] array6 = text.Split(new char[]
							{
								'+'
							});
							if (!array6[0].ToLower().Contains(".dll") && !array6[0].ToLower().Contains(".exe") && !array6[0].ToLower().Contains(".bin"))
							{
								string text5 = array6[0];
								if (text5.Contains("0x"))
								{
									text5 = text5.Replace("0x", "");
								}
								value2 = (IntPtr)long.Parse(text5, NumberStyles.HexNumber);
								goto IL_4EF;
							}
							try
							{
								value2 = this.dictionary_0[array6[0]];
								goto IL_4EF;
							}
							catch
							{
								Debug.WriteLine("Module " + array6[0] + " was not found in module list!");
								Debug.WriteLine("Modules: " + string.Join<KeyValuePair<string, IntPtr>>(",", this.dictionary_0));
								goto IL_4EF;
							}
						}
						value2 = this.dictionary_0[text.Split(new char[]
						{
							'+'
						})[0]];
					}
					else
					{
						value2 = this.processModule_0.BaseAddress;
					}
					IL_4EF:
					result = (UIntPtr)((ulong)((long)value2 + num3));
				}
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000024B3 File Offset: 0x000006B3
		public void method_41()
		{
			GClass9.CloseHandle_1(this.intptr_0);
			this.process_0 = Class32.process_0;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000BC5C File Offset: 0x00009E5C
		public void method_42(string string_0)
		{
			foreach (object obj in this.process_0.Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				if (processModule.ModuleName.StartsWith("inject", StringComparison.InvariantCultureIgnoreCase))
				{
					return;
				}
			}
			if (this.process_0.Responding)
			{
				int num = string_0.Length + 1;
				UIntPtr uintPtr = GClass9.VirtualAllocEx(this.intptr_0, (UIntPtr)null, (uint)num, 12288U, 4U);
				IntPtr intPtr;
				GClass9.WriteProcessMemory(this.intptr_0, uintPtr, string_0, (UIntPtr)((ulong)((long)num)), out intPtr);
				UIntPtr procAddress = GClass9.GetProcAddress(GClass9.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
				IntPtr intptr_ = GClass9.CreateRemoteThread(this.intptr_0, (IntPtr)null, 0U, procAddress, uintPtr, 0U, out intPtr);
				int num2 = GClass9.WaitForSingleObject(intptr_, 10000);
				if ((long)num2 != 128L && (long)num2 != 258L)
				{
					GClass9.VirtualFreeEx(this.intptr_0, uintPtr, (UIntPtr)0UL, 32768U);
					GClass9.CloseHandle_1(intptr_);
				}
				else
				{
					GClass9.CloseHandle_1(intptr_);
				}
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		public void method_43(byte[] byte_0)
		{
			foreach (object obj in this.process_0.Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				if (processModule.ModuleName.StartsWith("inject", StringComparison.InvariantCultureIgnoreCase))
				{
					return;
				}
			}
			if (this.process_0.Responding)
			{
				string text = "proceffect.dll";
				int num = text.Length + 1;
				UIntPtr uintPtr = GClass9.VirtualAllocEx(this.intptr_0, (UIntPtr)null, (uint)num, 12288U, 4U);
				IntPtr intPtr;
				GClass9.WriteProcessMemory_2(this.intptr_0, uintPtr, byte_0, (UIntPtr)((ulong)((long)num)), out intPtr);
				UIntPtr procAddress = GClass9.GetProcAddress(GClass9.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
				IntPtr intptr_ = GClass9.CreateRemoteThread(this.intptr_0, (IntPtr)null, 0U, procAddress, uintPtr, 0U, out intPtr);
				int num2 = GClass9.WaitForSingleObject(intptr_, 10000);
				if ((long)num2 != 128L && (long)num2 != 258L)
				{
					GClass9.VirtualFreeEx(this.intptr_0, uintPtr, (UIntPtr)0UL, 32768U);
					GClass9.CloseHandle_1(intptr_);
				}
				else
				{
					GClass9.CloseHandle_1(intptr_);
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000BF1C File Offset: 0x0000A11C
		public UIntPtr method_44(string string_0, byte[] byte_0, int int_5, int int_6 = 4096, string string_1 = "")
		{
			UIntPtr result;
			if (int_5 < 5)
			{
				result = UIntPtr.Zero;
			}
			else
			{
				UIntPtr uintPtr = this.method_39(string_0, string_1, 8);
				UIntPtr uintPtr2 = uintPtr;
				UIntPtr uintPtr3 = UIntPtr.Zero;
				UIntPtr uintPtr4 = uintPtr2;
				int num = 0;
				while (num < 10 && uintPtr3 == UIntPtr.Zero)
				{
					uintPtr3 = GClass9.VirtualAllocEx(this.intptr_0, this.method_45(uintPtr4, (uint)int_6), (uint)int_6, 12288U, 64U);
					if (uintPtr3 == UIntPtr.Zero)
					{
						uintPtr4 = UIntPtr.Add(uintPtr4, 65536);
					}
					num++;
				}
				if (uintPtr3 == UIntPtr.Zero)
				{
					uintPtr3 = GClass9.VirtualAllocEx(this.intptr_0, UIntPtr.Zero, (uint)int_6, 12288U, 64U);
				}
				int num2 = (int_5 > 5) ? (int_5 - 5) : 0;
				int value = (int)((ulong)uintPtr3 - (ulong)uintPtr2 - 5UL);
				byte[] array = new byte[5 + num2];
				array[0] = 233;
				BitConverter.GetBytes(value).CopyTo(array, 1);
				for (int i = 5; i < array.Length; i++)
				{
					array[i] = 144;
				}
				this.method_38(uintPtr2, array);
				byte[] array2 = new byte[5 + byte_0.Length];
				value = (int)((ulong)uintPtr2 + (ulong)((long)array.Length) - ((ulong)uintPtr3 + (ulong)((long)byte_0.Length)) - 5UL);
				byte_0.CopyTo(array2, 0);
				array2[byte_0.Length] = 233;
				BitConverter.GetBytes(value).CopyTo(array2, byte_0.Length + 1);
				this.method_38(uintPtr3, array2);
				result = uintPtr3;
			}
			return result;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		private UIntPtr method_45(UIntPtr uintptr_0, uint uint_14)
		{
			UIntPtr uintPtr = UIntPtr.Subtract(uintptr_0, 1879048192);
			UIntPtr value = UIntPtr.Add(uintptr_0, 1879048192);
			UIntPtr uintPtr2 = UIntPtr.Zero;
			UIntPtr uintPtr3 = UIntPtr.Zero;
			GClass9.GStruct1 gstruct;
			GClass9.GetSystemInfo(out gstruct);
			if (this.Boolean_0)
			{
				if ((ulong)uintPtr > (ulong)gstruct.uintptr_1 || (ulong)uintPtr < (ulong)gstruct.uintptr_0)
				{
					uintPtr = gstruct.uintptr_0;
				}
				if ((ulong)value < (ulong)gstruct.uintptr_0 || (ulong)value > (ulong)gstruct.uintptr_1)
				{
					value = gstruct.uintptr_1;
				}
			}
			else
			{
				uintPtr = gstruct.uintptr_0;
				value = gstruct.uintptr_1;
			}
			UIntPtr uintPtr4 = uintPtr;
			GClass9.GStruct4 gstruct2;
			while (this.method_1(this.intptr_0, uintPtr4, out gstruct2).ToUInt64() > 0UL)
			{
				UIntPtr result;
				if ((ulong)gstruct2.uintptr_0 <= (ulong)value)
				{
					if (gstruct2.uint_1 == 65536U && gstruct2.long_0 > (long)((ulong)uint_14))
					{
						if ((ulong)gstruct2.uintptr_0 % (ulong)gstruct.uint_3 > 0UL)
						{
							uintPtr3 = gstruct2.uintptr_0;
							int num = (int)((ulong)gstruct.uint_3 - (ulong)uintPtr3 % (ulong)gstruct.uint_3);
							if (gstruct2.long_0 - (long)num >= (long)((ulong)uint_14))
							{
								uintPtr3 = UIntPtr.Add(uintPtr3, num);
								if ((ulong)uintPtr3 < (ulong)uintptr_0)
								{
									uintPtr3 = UIntPtr.Add(uintPtr3, (int)(gstruct2.long_0 - (long)num - (long)((ulong)uint_14)));
									if ((ulong)uintPtr3 > (ulong)uintptr_0)
									{
										uintPtr3 = uintptr_0;
									}
									uintPtr3 = UIntPtr.Subtract(uintPtr3, (int)((ulong)uintPtr3 % (ulong)gstruct.uint_3));
								}
								if (Math.Abs((long)((ulong)uintPtr3 - (ulong)uintptr_0)) < Math.Abs((long)((ulong)uintPtr2 - (ulong)uintptr_0)))
								{
									uintPtr2 = uintPtr3;
								}
							}
						}
						else
						{
							uintPtr3 = gstruct2.uintptr_0;
							if ((ulong)uintPtr3 < (ulong)uintptr_0)
							{
								uintPtr3 = UIntPtr.Add(uintPtr3, (int)(gstruct2.long_0 - (long)((ulong)uint_14)));
								if ((ulong)uintPtr3 > (ulong)uintptr_0)
								{
									uintPtr3 = uintptr_0;
								}
								uintPtr3 = UIntPtr.Subtract(uintPtr3, (int)((ulong)uintPtr3 % (ulong)gstruct.uint_3));
							}
							if (Math.Abs((long)((ulong)uintPtr3 - (ulong)uintptr_0)) < Math.Abs((long)((ulong)uintPtr2 - (ulong)uintptr_0)))
							{
								uintPtr2 = uintPtr3;
							}
						}
					}
					if (gstruct2.long_0 % (long)((ulong)gstruct.uint_3) > 0L)
					{
						gstruct2.long_0 += (long)((ulong)gstruct.uint_3 - (ulong)(gstruct2.long_0 % (long)((ulong)gstruct.uint_3)));
					}
					UIntPtr value2 = uintPtr4;
					uintPtr4 = UIntPtr.Add(gstruct2.uintptr_0, (int)gstruct2.long_0);
					if ((ulong)uintPtr4 <= (ulong)value)
					{
						if ((ulong)value2 <= (ulong)uintPtr4)
						{
							continue;
						}
						result = uintPtr2;
					}
					else
					{
						result = uintPtr2;
					}
				}
				else
				{
					result = UIntPtr.Zero;
				}
				return result;
			}
			return uintPtr2;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		public static void smethod_0(int int_5)
		{
			Process processById = Process.GetProcessById(int_5);
			if (!(processById.ProcessName == string.Empty))
			{
				foreach (object obj in processById.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = GClass9.OpenThread(GClass9.GEnum1.flag_1, false, (uint)processThread.Id);
					if (!(intPtr == IntPtr.Zero))
					{
						GClass9.SuspendThread(intPtr);
						GClass9.CloseHandle_1(intPtr);
					}
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000C478 File Offset: 0x0000A678
		public static void smethod_1(int int_5)
		{
			Process processById = Process.GetProcessById(int_5);
			if (!(processById.ProcessName == string.Empty))
			{
				foreach (object obj in processById.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = GClass9.OpenThread(GClass9.GEnum1.flag_1, false, (uint)processThread.Id);
					if (!(intPtr == IntPtr.Zero))
					{
						int num;
						do
						{
							num = GClass9.ResumeThread(intPtr);
						}
						while (num > 0);
						GClass9.CloseHandle_1(intPtr);
					}
				}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000C524 File Offset: 0x0000A724
		[DebuggerStepThrough]
		private Task method_46(int int_5)
		{
			GClass9.Class5 @class = new GClass9.Class5();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.gclass9_0 = this;
			@class.int_1 = int_5;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass9.Class5>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000C574 File Offset: 0x0000A774
		private void method_47(string string_0, byte[] byte_0)
		{
			using (FileStream fileStream = new FileStream(string_0, FileMode.Append))
			{
				fileStream.Write(byte_0, 0, byte_0.Length);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000C5B0 File Offset: 0x0000A7B0
		public byte[] method_48(string string_0, bool bool_1 = false)
		{
			byte[] result = File.ReadAllBytes(string_0);
			if (!bool_1)
			{
				File.Delete(string_0);
			}
			return result;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
		public string method_49()
		{
			string result;
			if (this.Boolean_0)
			{
				result = "x16";
			}
			else
			{
				result = "x8";
			}
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		public static string smethod_2(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			int num = 1;
			foreach (byte b in byte_0)
			{
				if (num == 16)
				{
					stringBuilder.AppendFormat("{0:x2}{1}", b, Environment.NewLine);
					num = 0;
				}
				else
				{
					stringBuilder.AppendFormat("{0:x2} ", b);
				}
				num++;
			}
			return stringBuilder.ToString().ToUpper();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000C674 File Offset: 0x0000A874
		public static string smethod_3(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			foreach (byte b in byte_0)
			{
				stringBuilder.AppendFormat("{0:x2} ", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		public ulong method_50()
		{
			GClass9.GStruct1 gstruct;
			GClass9.GetSystemInfo(out gstruct);
			return (ulong)gstruct.uintptr_0;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		public bool method_51(string string_0 = "dump.dmp")
		{
			Debug.Write("[DEBUG] memory dump starting... (" + DateTime.Now.ToString("h:mm:ss tt") + ")" + Environment.NewLine);
			GClass9.GStruct1 gstruct = default(GClass9.GStruct1);
			GClass9.GetSystemInfo(out gstruct);
			UIntPtr uintptr_ = gstruct.uintptr_0;
			long num = (long)((ulong)uintptr_);
			long num2 = this.process_0.VirtualMemorySize64 + num;
			if (File.Exists(string_0))
			{
				File.Delete(string_0);
			}
			GClass9.GStruct4 gstruct2 = default(GClass9.GStruct4);
			while (num < num2)
			{
				this.method_1(this.intptr_0, uintptr_, out gstruct2);
				byte[] byte_ = new byte[gstruct2.long_0];
				UIntPtr uintptr_2 = (UIntPtr)((ulong)gstruct2.long_0);
				UIntPtr uintptr_3 = (UIntPtr)((ulong)gstruct2.uintptr_0);
				GClass9.ReadProcessMemory(this.intptr_0, uintptr_3, byte_, uintptr_2, IntPtr.Zero);
				this.method_47(string_0, byte_);
				num += gstruct2.long_0;
				uintptr_ = new UIntPtr((ulong)num);
			}
			Debug.Write(string.Concat(new string[]
			{
				"[DEBUG] memory dump completed. Saving dump file to ",
				string_0,
				". (",
				DateTime.Now.ToString("h:mm:ss tt"),
				")",
				Environment.NewLine
			}));
			return true;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000C830 File Offset: 0x0000AA30
		public Task<IEnumerable<long>> method_52(string string_0, bool bool_1 = false, bool bool_2 = false, string string_1 = "")
		{
			/*
An exception occurred when decompiling this method (06000109)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Collections.Generic.IEnumerable`1<System.Int64>> ns0.GClass9::method_52(System.String,System.Boolean,System.Boolean,System.String)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000C860 File Offset: 0x0000AA60
		public Task<IEnumerable<long>> method_53(string string_0, bool bool_1, bool bool_2, bool bool_3, string string_1 = "")
		{
			/*
An exception occurred when decompiling this method (0600010A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Collections.Generic.IEnumerable`1<System.Int64>> ns0.GClass9::method_53(System.String,System.Boolean,System.Boolean,System.Boolean,System.String)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000C890 File Offset: 0x0000AA90
		public Task<IEnumerable<long>> method_54(long long_0, long long_1, string string_0, bool bool_1, bool bool_2, string string_1 = "")
		{
			return this.method_55(long_0, long_1, string_0, true, bool_1, bool_2, string_1);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000C8B0 File Offset: 0x0000AAB0
		public Task<IEnumerable<long>> method_55(long long_0, long long_1, string string_0, bool bool_1, bool bool_2, bool bool_3, string string_1 = "")
		{
			GClass9.Class6 @class = new GClass9.Class6();
			@class.gclass9_0 = this;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.long_0 = long_0;
			@class.long_1 = long_1;
			@class.bool_0 = bool_1;
			@class.bool_1 = bool_2;
			@class.bool_2 = bool_3;
			return Task.Run<IEnumerable<long>>(new Func<IEnumerable<long>>(@class.method_0));
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000C914 File Offset: 0x0000AB14
		[DebuggerStepThrough]
		public Task<long> method_56(string string_0, long long_0, string string_1, string string_2 = "")
		{
			GClass9.Class8 @class = new GClass9.Class8();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<long>.Create();
			@class.gclass9_0 = this;
			@class.string_0 = string_0;
			@class.long_0 = long_0;
			@class.string_1 = string_1;
			@class.string_2 = string_2;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass9.Class8>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000C978 File Offset: 0x0000AB78
		private unsafe long[] method_57(Struct0 struct0_0, byte[] byte_0, byte[] byte_1)
		{
			if (byte_1.Length != byte_0.Length)
			{
				throw new ArgumentException("aobPattern.Length != mask.Length");
			}
			IntPtr intPtr = Marshal.AllocHGlobal((int)struct0_0.RegionSize);
			ulong num;
			GClass9.ReadProcessMemory_2(this.intptr_0, struct0_0.CurrentBaseAddress, intPtr, (UIntPtr)((ulong)struct0_0.RegionSize), out num);
			int num2 = 0 - byte_0.Length;
			List<long> list = new List<long>();
			do
			{
				num2 = this.method_59((byte*)intPtr.ToPointer(), (int)num, byte_0, byte_1, num2 + byte_0.Length);
				if (num2 >= 0)
				{
					list.Add((long)((ulong)struct0_0.CurrentBaseAddress + (ulong)((long)num2)));
				}
			}
			while (num2 != -1);
			Marshal.FreeHGlobal(intPtr);
			return list.ToArray();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000CA34 File Offset: 0x0000AC34
		private int method_58(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_5 = 0)
		{
			int result = -1;
			if (byte_0.Length != 0 && byte_1.Length != 0 && int_5 <= byte_0.Length - byte_1.Length && byte_1.Length <= byte_0.Length)
			{
				for (int i = int_5; i <= byte_0.Length - byte_1.Length; i++)
				{
					if ((byte_0[i] & byte_2[0]) == (byte_1[0] & byte_2[0]))
					{
						bool flag = true;
						int j = 1;
						while (j <= byte_1.Length - 1)
						{
							if ((byte_0[i + j] & byte_2[j]) == (byte_1[j] & byte_2[j]))
							{
								j++;
							}
							else
							{
								flag = false;
								IL_76:
								if (!flag)
								{
									goto IL_7F;
								}
								result = i;
								goto IL_96;
							}
						}
						goto IL_76;
						IL_96:
						return result;
					}
					IL_7F:;
				}
				goto IL_96;
			}
			return result;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		private unsafe int method_59(byte* pByte_0, int int_5, byte[] byte_0, byte[] byte_1, int int_6 = 0)
		{
			int result = -1;
			if (int_5 > 0 && byte_0.Length != 0 && int_6 <= int_5 - byte_0.Length && byte_0.Length <= int_5)
			{
				for (int i = int_6; i <= int_5 - byte_0.Length; i++)
				{
					if ((pByte_0[i] & byte_1[0]) == (byte_0[0] & byte_1[0]))
					{
						bool flag = true;
						int j = 1;
						while (j <= byte_0.Length - 1)
						{
							if ((pByte_0[i + j] & byte_1[j]) == (byte_0[j] & byte_1[j]))
							{
								j++;
							}
							else
							{
								flag = false;
								IL_7B:
								if (!flag)
								{
									goto IL_84;
								}
								result = i;
								goto IL_99;
							}
						}
						goto IL_7B;
						IL_99:
						return result;
					}
					IL_84:;
				}
				goto IL_99;
			}
			return result;
		}

		// Token: 0x04000089 RID: 137
		private static int int_0;

		// Token: 0x0400008A RID: 138
		private static int int_1;

		// Token: 0x0400008B RID: 139
		private static int int_2;

		// Token: 0x0400008C RID: 140
		private static int int_3;

		// Token: 0x0400008D RID: 141
		private static int int_4;

		// Token: 0x0400008E RID: 142
		private static uint uint_0;

		// Token: 0x0400008F RID: 143
		private static uint uint_1;

		// Token: 0x04000090 RID: 144
		private static uint uint_2;

		// Token: 0x04000091 RID: 145
		private static uint uint_3;

		// Token: 0x04000092 RID: 146
		private static uint uint_4;

		// Token: 0x04000093 RID: 147
		private static uint uint_5;

		// Token: 0x04000094 RID: 148
		private static uint uint_6;

		// Token: 0x04000095 RID: 149
		private static uint uint_7;

		// Token: 0x04000096 RID: 150
		private static uint uint_8;

		// Token: 0x04000097 RID: 151
		private static uint uint_9;

		// Token: 0x04000098 RID: 152
		private static uint uint_10;

		// Token: 0x04000099 RID: 153
		private static uint uint_11;

		// Token: 0x0400009A RID: 154
		private uint uint_12 = 131072U;

		// Token: 0x0400009B RID: 155
		private uint uint_13 = 16777216U;

		// Token: 0x0400009C RID: 156
		public IntPtr intptr_0;

		// Token: 0x0400009D RID: 157
		public Process process_0 = Class32.process_0;

		// Token: 0x0400009E RID: 158
		private bool bool_0;

		// Token: 0x0400009F RID: 159
		public Dictionary<string, IntPtr> dictionary_0 = new Dictionary<string, IntPtr>();

		// Token: 0x040000A0 RID: 160
		private ProcessModule processModule_0;

		// Token: 0x02000016 RID: 22
		public struct GStruct0
		{
			// Token: 0x040000A1 RID: 161
			public uint uint_0;

			// Token: 0x040000A2 RID: 162
			public uint uint_1;

			// Token: 0x040000A3 RID: 163
			public uint uint_2;

			// Token: 0x040000A4 RID: 164
			public IntPtr intptr_0;

			// Token: 0x040000A5 RID: 165
			public uint uint_3;

			// Token: 0x040000A6 RID: 166
			public uint uint_4;

			// Token: 0x040000A7 RID: 167
			public uint uint_5;

			// Token: 0x040000A8 RID: 168
			public int int_0;

			// Token: 0x040000A9 RID: 169
			public uint uint_6;

			// Token: 0x040000AA RID: 170
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string string_0;
		}

		// Token: 0x02000017 RID: 23
		internal enum Enum0
		{
			// Token: 0x040000AC RID: 172
			const_0,
			// Token: 0x040000AD RID: 173
			const_1,
			// Token: 0x040000AE RID: 174
			const_2,
			// Token: 0x040000AF RID: 175
			const_3 = 4,
			// Token: 0x040000B0 RID: 176
			const_4 = 8,
			// Token: 0x040000B1 RID: 177
			const_5 = 16,
			// Token: 0x040000B2 RID: 178
			const_6 = 32,
			// Token: 0x040000B3 RID: 179
			const_7 = 64,
			// Token: 0x040000B4 RID: 180
			const_8 = 128,
			// Token: 0x040000B5 RID: 181
			const_9 = 256,
			// Token: 0x040000B6 RID: 182
			const_10 = 512,
			// Token: 0x040000B7 RID: 183
			const_11 = 1024,
			// Token: 0x040000B8 RID: 184
			const_12 = 2048,
			// Token: 0x040000B9 RID: 185
			const_13 = 4096,
			// Token: 0x040000BA RID: 186
			const_14 = 8192
		}

		// Token: 0x02000018 RID: 24
		[Flags]
		public enum GEnum0 : uint
		{
			// Token: 0x040000BC RID: 188
			flag_0 = 16U,
			// Token: 0x040000BD RID: 189
			flag_1 = 32U,
			// Token: 0x040000BE RID: 190
			flag_2 = 64U,
			// Token: 0x040000BF RID: 191
			flag_3 = 128U,
			// Token: 0x040000C0 RID: 192
			flag_4 = 1U,
			// Token: 0x040000C1 RID: 193
			flag_5 = 2U,
			// Token: 0x040000C2 RID: 194
			flag_6 = 4U,
			// Token: 0x040000C3 RID: 195
			flag_7 = 8U,
			// Token: 0x040000C4 RID: 196
			flag_8 = 256U,
			// Token: 0x040000C5 RID: 197
			flag_9 = 512U,
			// Token: 0x040000C6 RID: 198
			flag_10 = 1024U
		}

		// Token: 0x02000019 RID: 25
		[Flags]
		public enum GEnum1
		{
			// Token: 0x040000C8 RID: 200
			flag_0 = 1,
			// Token: 0x040000C9 RID: 201
			flag_1 = 2,
			// Token: 0x040000CA RID: 202
			flag_2 = 8,
			// Token: 0x040000CB RID: 203
			flag_3 = 16,
			// Token: 0x040000CC RID: 204
			flag_4 = 32,
			// Token: 0x040000CD RID: 205
			flag_5 = 64,
			// Token: 0x040000CE RID: 206
			flag_6 = 256,
			// Token: 0x040000CF RID: 207
			flag_7 = 512
		}

		// Token: 0x0200001A RID: 26
		public struct GStruct1
		{
			// Token: 0x040000D0 RID: 208
			public ushort ushort_0;

			// Token: 0x040000D1 RID: 209
			private ushort ushort_1;

			// Token: 0x040000D2 RID: 210
			public uint uint_0;

			// Token: 0x040000D3 RID: 211
			public UIntPtr uintptr_0;

			// Token: 0x040000D4 RID: 212
			public UIntPtr uintptr_1;

			// Token: 0x040000D5 RID: 213
			public IntPtr intptr_0;

			// Token: 0x040000D6 RID: 214
			public uint uint_1;

			// Token: 0x040000D7 RID: 215
			public uint uint_2;

			// Token: 0x040000D8 RID: 216
			public uint uint_3;

			// Token: 0x040000D9 RID: 217
			public ushort ushort_2;

			// Token: 0x040000DA RID: 218
			public ushort ushort_3;
		}

		// Token: 0x0200001B RID: 27
		public struct GStruct2
		{
			// Token: 0x040000DB RID: 219
			public UIntPtr uintptr_0;

			// Token: 0x040000DC RID: 220
			public UIntPtr uintptr_1;

			// Token: 0x040000DD RID: 221
			public uint uint_0;

			// Token: 0x040000DE RID: 222
			public uint uint_1;

			// Token: 0x040000DF RID: 223
			public uint uint_2;

			// Token: 0x040000E0 RID: 224
			public uint uint_3;

			// Token: 0x040000E1 RID: 225
			public uint uint_4;
		}

		// Token: 0x0200001C RID: 28
		public struct GStruct3
		{
			// Token: 0x040000E2 RID: 226
			public UIntPtr uintptr_0;

			// Token: 0x040000E3 RID: 227
			public UIntPtr uintptr_1;

			// Token: 0x040000E4 RID: 228
			public uint uint_0;

			// Token: 0x040000E5 RID: 229
			public uint uint_1;

			// Token: 0x040000E6 RID: 230
			public ulong ulong_0;

			// Token: 0x040000E7 RID: 231
			public uint uint_2;

			// Token: 0x040000E8 RID: 232
			public uint uint_3;

			// Token: 0x040000E9 RID: 233
			public uint uint_4;

			// Token: 0x040000EA RID: 234
			public uint uint_5;
		}

		// Token: 0x0200001D RID: 29
		public struct GStruct4
		{
			// Token: 0x040000EB RID: 235
			public UIntPtr uintptr_0;

			// Token: 0x040000EC RID: 236
			public UIntPtr uintptr_1;

			// Token: 0x040000ED RID: 237
			public uint uint_0;

			// Token: 0x040000EE RID: 238
			public long long_0;

			// Token: 0x040000EF RID: 239
			public uint uint_1;

			// Token: 0x040000F0 RID: 240
			public uint uint_2;

			// Token: 0x040000F1 RID: 241
			public uint uint_3;
		}

		// Token: 0x0200001F RID: 31
		[CompilerGenerated]
		private sealed class Class6
		{
			// Token: 0x06000115 RID: 277 RVA: 0x0000CC54 File Offset: 0x0000AE54
			internal IEnumerable<long> method_0()
			{
				GClass9.Class7 @class = new GClass9.Class7();
				@class.class6_0 = this;
				List<Struct0> list = new List<Struct0>();
				string text = this.gclass9_0.method_10(this.string_0, this.string_1);
				string[] array = text.Split(new char[]
				{
					' '
				});
				@class.byte_0 = new byte[array.Length];
				@class.byte_1 = new byte[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					string text2 = array[i];
					if (!(text2 == "??") && (text2.Length != 1 || !(text2 == "?")))
					{
						if (char.IsLetterOrDigit(text2[0]) && text2[1] == '?')
						{
							@class.byte_1[i] = 240;
							array[i] = text2[0].ToString() + "0";
						}
						else if (char.IsLetterOrDigit(text2[1]) && text2[0] == '?')
						{
							@class.byte_1[i] = 15;
							array[i] = "0" + text2[1].ToString();
						}
						else
						{
							@class.byte_1[i] = byte.MaxValue;
						}
					}
					else
					{
						@class.byte_1[i] = 0;
						array[i] = "0x00";
					}
				}
				for (int j = 0; j < array.Length; j++)
				{
					@class.byte_0[j] = (Convert.ToByte(array[j], 16) & @class.byte_1[j]);
				}
				GClass9.GStruct1 gstruct = default(GClass9.GStruct1);
				GClass9.GetSystemInfo(out gstruct);
				UIntPtr uintptr_ = gstruct.uintptr_0;
				UIntPtr uintptr_2 = gstruct.uintptr_1;
				if (this.long_0 < (long)uintptr_.ToUInt64())
				{
					this.long_0 = (long)uintptr_.ToUInt64();
				}
				if (this.long_1 > (long)uintptr_2.ToUInt64())
				{
					this.long_1 = (long)uintptr_2.ToUInt64();
				}
				Debug.WriteLine(string.Concat(new string[]
				{
					"[DEBUG] memory scan starting... (start:0x",
					this.long_0.ToString(this.gclass9_0.method_49()),
					" end:0x",
					this.long_1.ToString(this.gclass9_0.method_49()),
					" time:",
					DateTime.Now.ToString("h:mm:ss tt"),
					")"
				}));
				UIntPtr uintPtr = new UIntPtr((ulong)this.long_0);
				GClass9.GStruct4 gstruct2 = default(GClass9.GStruct4);
				while (this.gclass9_0.method_1(this.gclass9_0.intptr_0, uintPtr, out gstruct2).ToUInt64() != 0UL && uintPtr.ToUInt64() < (ulong)this.long_1 && uintPtr.ToUInt64() + (ulong)gstruct2.long_0 > uintPtr.ToUInt64())
				{
					bool flag;
					if (flag = (gstruct2.uint_1 == 4096U & gstruct2.uintptr_0.ToUInt64() < uintptr_2.ToUInt64() & (gstruct2.uint_2 & 256U) == 0U & (gstruct2.uint_2 & 1U) == 0U & (gstruct2.uint_3 == this.gclass9_0.uint_12 || gstruct2.uint_3 == this.gclass9_0.uint_13)))
					{
						bool flag2 = (gstruct2.uint_2 & 2U) > 0U;
						bool flag3 = (gstruct2.uint_2 & 4U) > 0U || (gstruct2.uint_2 & 8U) > 0U || (gstruct2.uint_2 & 64U) > 0U || (gstruct2.uint_2 & 128U) > 0U;
						bool flag4 = (gstruct2.uint_2 & 16U) > 0U || (gstruct2.uint_2 & 32U) > 0U || (gstruct2.uint_2 & 64U) > 0U || (gstruct2.uint_2 & 128U) > 0U;
						flag2 &= this.bool_0;
						flag3 &= this.bool_1;
						flag4 &= this.bool_2;
						flag &= (flag2 || flag3 || flag4);
					}
					if (!flag)
					{
						uintPtr = new UIntPtr(gstruct2.uintptr_0.ToUInt64() + (ulong)gstruct2.long_0);
					}
					else
					{
						Struct0 item = new Struct0
						{
							CurrentBaseAddress = uintPtr,
							RegionSize = gstruct2.long_0,
							RegionBase = gstruct2.uintptr_0
						};
						uintPtr = new UIntPtr(gstruct2.uintptr_0.ToUInt64() + (ulong)gstruct2.long_0);
						if (list.Count > 0)
						{
							Struct0 @struct = list[list.Count - 1];
							if ((ulong)@struct.RegionBase + (ulong)@struct.RegionSize == (ulong)gstruct2.uintptr_0)
							{
								list[list.Count - 1] = new Struct0
								{
									CurrentBaseAddress = @struct.CurrentBaseAddress,
									RegionBase = @struct.RegionBase,
									RegionSize = @struct.RegionSize + gstruct2.long_0
								};
								continue;
							}
						}
						list.Add(item);
					}
				}
				@class.concurrentBag_0 = new ConcurrentBag<long>();
				Parallel.ForEach<Struct0>(list, new Action<Struct0, ParallelLoopState, long>(@class.method_0));
				Debug.WriteLine("[DEBUG] memory scan completed. (time:" + DateTime.Now.ToString("h:mm:ss tt") + ")");
				return @class.concurrentBag_0.ToList<long>().OrderBy(new Func<long, long>(GClass9.<>c.<>c_0.method_0)).AsEnumerable<long>();
			}

			// Token: 0x040000F7 RID: 247
			public GClass9 gclass9_0;

			// Token: 0x040000F8 RID: 248
			public string string_0;

			// Token: 0x040000F9 RID: 249
			public string string_1;

			// Token: 0x040000FA RID: 250
			public long long_0;

			// Token: 0x040000FB RID: 251
			public long long_1;

			// Token: 0x040000FC RID: 252
			public bool bool_0;

			// Token: 0x040000FD RID: 253
			public bool bool_1;

			// Token: 0x040000FE RID: 254
			public bool bool_2;
		}

		// Token: 0x02000020 RID: 32
		[CompilerGenerated]
		private sealed class Class7
		{
			// Token: 0x06000117 RID: 279 RVA: 0x0000D23C File Offset: 0x0000B43C
			internal void method_0(Struct0 struct0_0, ParallelLoopState parallelLoopState_0, long long_0)
			{
				long[] array = this.class6_0.gclass9_0.method_57(struct0_0, this.byte_0, this.byte_1);
				foreach (long item in array)
				{
					this.concurrentBag_0.Add(item);
				}
			}

			// Token: 0x040000FF RID: 255
			public byte[] byte_0;

			// Token: 0x04000100 RID: 256
			public byte[] byte_1;

			// Token: 0x04000101 RID: 257
			public ConcurrentBag<long> concurrentBag_0;

			// Token: 0x04000102 RID: 258
			public GClass9.Class6 class6_0;
		}
	}
}
