using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x0200000E RID: 14
	public sealed class GClass8
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000023AE File Offset: 0x000005AE
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000023B5 File Offset: 0x000005B5
		public static string key { get; set; }

		// Token: 0x06000087 RID: 135 RVA: 0x000083E8 File Offset: 0x000065E8
		[DebuggerStepThrough]
		[STAThread]
		public static Task smethod_0()
		{
			GClass8.Class0 @class = new GClass8.Class0();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass8.Class0>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00008428 File Offset: 0x00006628
		private static bool smethod_1()
		{
			bool result;
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Tencent\\MobileGamePC", "AdbDisable", 0);
				GClass8.string_2 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\UI", "InstallPath", "").ToString().Replace("UI\\", "ui\\");
				GClass8.string_3 = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\AOW_Rootfs_100", "InstallPath", "");
				GClass8.string_5 = Path.Combine(GClass8.string_2, GClass8.string_4);
				Process.Start(string.Format("\"{0}\"", GClass8.string_5), " -vm 100");
				result = true;
			}
			catch
			{
				GClass8.smethod_12(string.Format("Cant' Find {0} Emulator", GClass8.string_4));
				result = false;
			}
			return result;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000084F4 File Offset: 0x000066F4
		private static bool smethod_2()
		{
			bool result = false;
			string path = GClass8.string_3;
			foreach (string path2 in Directory.GetDirectories(path))
			{
				string[] files = Directory.GetFiles(path2);
				string[] array = files.OrderByDescending(new Func<string, int>(GClass8.<>c.<>c_0.method_0)).ToArray<string>();
				foreach (string text in array)
				{
					try
					{
						bool flag;
						if (GClass8.int_0 == 32)
						{
							flag = (new FileInfo(text).Length == 325632L);
						}
						else
						{
							flag = (new FileInfo(text).Length == 637424L);
						}
						if (flag)
						{
							GClass8.list_0.Add(text);
							GClass8.byte_0 = File.ReadAllBytes(text);
							result = true;
						}
						goto IL_D6;
					}
					catch
					{
						goto IL_D6;
					}
					break;
					IL_D6:;
				}
			}
			return result;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000085F4 File Offset: 0x000067F4
		[DebuggerStepThrough]
		private static Task smethod_3()
		{
			GClass8.Class2 @class = new GClass8.Class2();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass8.Class2>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00008634 File Offset: 0x00006834
		[DebuggerStepThrough]
		public static Task smethod_4(int int_1)
		{
			GClass8.Class3 @class = new GClass8.Class3();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.int_1 = int_1;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass8.Class3>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000867C File Offset: 0x0000687C
		private static string smethod_5(string string_18 = "cmd.exe", string string_19 = "", bool bool_0 = true)
		{
			string result;
			try
			{
				int milliseconds = 5000;
				Process process = new Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.RedirectStandardInput = true;
				processStartInfo.RedirectStandardOutput = true;
				processStartInfo.RedirectStandardError = true;
				processStartInfo.UseShellExecute = false;
				processStartInfo.CreateNoWindow = true;
				processStartInfo.FileName = string_18;
				if (string_18 == "cmd.exe")
				{
					processStartInfo.Arguments = "/c " + string_19;
				}
				else
				{
					processStartInfo.Arguments = string_19;
				}
				process.StartInfo = processStartInfo;
				process.Start();
				process.WaitForExit(milliseconds);
				if (bool_0)
				{
					result = process.StandardOutput.ReadLine();
				}
				else
				{
					result = process.StandardOutput.ReadToEnd();
				}
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008744 File Offset: 0x00006944
		private static string smethod_6(byte[] byte_2)
		{
			string text = Convert.ToBase64String(byte_2);
			return text.Replace("f", "#").Replace("n", "!").Replace("A", "?");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000878C File Offset: 0x0000698C
		private static byte[] smethod_7(string string_18)
		{
			string_18 = string_18.Replace("#", "f").Replace("!", "n").Replace("?", "A");
			return Convert.FromBase64String(string_18);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000087D4 File Offset: 0x000069D4
		[DebuggerStepThrough]
		private static Task<bool> smethod_8()
		{
			GClass8.Class4 @class = new GClass8.Class4();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<long>.Create();
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass8.Class4>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008814 File Offset: 0x00006A14
		private static string smethod_9()
		{
			Random random = new Random();
			return random.Next().ToString();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000883C File Offset: 0x00006A3C
		private static void smethod_10(string string_18, bool bool_0)
		{
			GClass11 gclass = Application.Current.MainWindow as GClass11;
			if (gclass != Class31.gclass11_0)
			{
				gclass.gcontrol4_0.method_0(string_18, bool_0);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00008870 File Offset: 0x00006A70
		private static void smethod_11(string string_18, int int_1)
		{
			GClass11 gclass = Application.Current.MainWindow as GClass11;
			if (gclass != Class31.gclass11_0)
			{
				gclass.gcontrol5_0.textBlock_0.Text = int_1.ToString();
				gclass.gcontrol5_0.textBlock_1.Text = string_18;
				gclass.gcontrol5_0.textBlock_2.Text = "";
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000088D4 File Offset: 0x00006AD4
		private static void smethod_12(string string_18)
		{
			GClass11 gclass = Application.Current.MainWindow as GClass11;
			if (gclass != Class31.gclass11_0)
			{
				gclass.gcontrol5_0.textBlock_2.Text = string_18;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000023BD File Offset: 0x000005BD
		public static void smethod_13()
		{
			Task.Run(new Func<Task>(GClass8.<>c.<>c_0.method_1));
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000023E4 File Offset: 0x000005E4
		public static void smethod_14()
		{
			Task.Run(new Action(GClass8.<>c.<>c_0.method_2));
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000240B File Offset: 0x0000060B
		public static void smethod_15()
		{
			Task.Run(new Action(GClass8.<>c.<>c_0.method_3));
		}

		// Token: 0x04000037 RID: 55
		public static string string_0 = "com.tencent.ig";

		// Token: 0x04000038 RID: 56
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static string string_1;

		// Token: 0x04000039 RID: 57
		private static string string_2;

		// Token: 0x0400003A RID: 58
		private static string string_3;

		// Token: 0x0400003B RID: 59
		private static string string_4;

		// Token: 0x0400003C RID: 60
		private static string string_5;

		// Token: 0x0400003D RID: 61
		private static string string_6;

		// Token: 0x0400003E RID: 62
		private static string string_7;

		// Token: 0x0400003F RID: 63
		private static string string_8;

		// Token: 0x04000040 RID: 64
		private static string string_9;

		// Token: 0x04000041 RID: 65
		private static string string_10;

		// Token: 0x04000042 RID: 66
		private static string string_11;

		// Token: 0x04000043 RID: 67
		private static string string_12;

		// Token: 0x04000044 RID: 68
		private static string string_13;

		// Token: 0x04000045 RID: 69
		private static string string_14;

		// Token: 0x04000046 RID: 70
		private static string string_15;

		// Token: 0x04000047 RID: 71
		private static string string_16;

		// Token: 0x04000048 RID: 72
		private static byte[] byte_0;

		// Token: 0x04000049 RID: 73
		private static byte[] byte_1;

		// Token: 0x0400004A RID: 74
		private static string string_17;

		// Token: 0x0400004B RID: 75
		private static List<string> list_0 = new List<string>();

		// Token: 0x0400004C RID: 76
		private static WebClient webClient_0 = new WebClient();

		// Token: 0x0400004D RID: 77
		public static int int_0 = 64;
	}
}
