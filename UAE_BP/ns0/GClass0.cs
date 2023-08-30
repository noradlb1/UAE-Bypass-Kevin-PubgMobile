using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace ns0
{
	// Token: 0x02000002 RID: 2
	public sealed class GClass0
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00006504 File Offset: 0x00004704
		public GClass0(string string_6, string string_7, string string_8, string string_9)
		{
			if (string.IsNullOrWhiteSpace(string_6) || string.IsNullOrWhiteSpace(string_7) || string.IsNullOrWhiteSpace(string_8) || string.IsNullOrWhiteSpace(string_9))
			{
				GClass0.smethod_1("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.string_0 = string_6;
			this.string_1 = string_7;
			this.string_2 = string_8;
			this.string_3 = string_9;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00006598 File Offset: 0x00004798
		public bool method_0(bool bool_1 = false)
		{
			this.string_5 = GClass6.smethod_0(GClass6.smethod_4());
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = GClass6.smethod_6(this.string_3, this.string_2, value);
			nameValueCollection["hash"] = GClass0.smethod_0(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = GClass6.smethod_6(this.string_5, this.string_2, value);
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string a = GClass0.smethod_2(nameValueCollection_);
			bool result;
			if (a == "KeyAuth_Invalid")
			{
				GClass0.smethod_1("Application not found");
				Environment.Exit(0);
				result = false;
			}
			else
			{
				a = GClass6.smethod_7(a, this.string_2, value);
				GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(a);
				this.method_20(response_structure);
				if (response_structure.success)
				{
					this.method_18(response_structure.appinfo);
					this.string_4 = response_structure.sessionid;
					this.bool_0 = true;
					result = this.bool_0;
				}
				else if (response_structure.message == "invalidver")
				{
					this.gclass2_0.downloadLink = response_structure.download;
					try
					{
						Process.Start(response_structure.download);
					}
					catch
					{
					}
					Process.GetCurrentProcess().Kill();
					result = false;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00006764 File Offset: 0x00004964
		public void method_1(string string_6, string string_7, string string_8)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string value2 = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = GClass6.smethod_6(string_6, this.string_5, value2);
			nameValueCollection["pass"] = GClass6.smethod_6(string_7, this.string_5, value2);
			nameValueCollection["key"] = GClass6.smethod_6(string_8, this.string_5, value2);
			nameValueCollection["hwid"] = GClass6.smethod_6(value, this.string_5, value2);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value2;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value2);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			if (response_structure.success)
			{
				this.method_19(response_structure.info);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000068DC File Offset: 0x00004ADC
		public void method_2(string string_6, string string_7)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string value2 = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = GClass6.smethod_6(string_6, this.string_5, value2);
			nameValueCollection["pass"] = GClass6.smethod_6(string_7, this.string_5, value2);
			nameValueCollection["hwid"] = GClass6.smethod_6(value, this.string_5, value2);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value2;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value2);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			if (response_structure.success)
			{
				this.method_19(response_structure.info);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00006A3C File Offset: 0x00004C3C
		public void method_3()
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			HttpListener httpListener = new HttpListener();
			string text = "handshake";
			text = "http://localhost:1337/" + text + "/";
			httpListener.Prefixes.Add(text);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse response = context.Response;
			response.ContentType = "gay/nigger";
			response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			response.AddHeader("Access-Control-Allow-Origin", "*");
			response.AddHeader("Via", "hugzho's big brain");
			response.AddHeader("Warning", "you're a gay nigger and need to check into the nearest concentration camp ASAP");
			response.AddHeader("Location", "your kernel ;)");
			response.AddHeader("Retry-After", "never lmao");
			response.Headers.Add("Server", "\r\n\r\n");
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			string rawUrl = request.RawUrl;
			string text2 = rawUrl.Replace("/handshake?user=", "");
			text2 = text2.Replace("&token=", " ");
			string text3 = text2;
			string value2 = text3.Split(Array.Empty<char>())[0];
			string value3 = text3.Split(new char[]
			{
				' '
			})[1];
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = value2;
			nameValueCollection["token"] = value3;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = this.string_4;
			nameValueCollection["name"] = this.string_0;
			nameValueCollection["ownerid"] = this.string_1;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text4 = GClass0.smethod_3(nameValueCollection_);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text4);
			this.method_20(response_structure);
			bool flag = true;
			if (response_structure.success)
			{
				this.method_19(response_structure.info);
				response.StatusCode = 420;
				response.StatusDescription = "SHEESH";
			}
			else
			{
				Console.WriteLine(response_structure.message);
				response.StatusCode = 200;
				response.StatusDescription = response_structure.message;
				flag = false;
			}
			byte[] bytes = Encoding.UTF8.GetBytes("Whats up?");
			response.ContentLength64 = (long)bytes.Length;
			Stream outputStream = response.OutputStream;
			outputStream.Write(bytes, 0, bytes.Length);
			Thread.Sleep(1250);
			httpListener.Stop();
			if (!flag)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00006CF0 File Offset: 0x00004EF0
		public void method_4(string string_6)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			HttpListener httpListener = new HttpListener();
			string uriPrefix = "http://localhost:1337/" + string_6 + "/";
			httpListener.Prefixes.Add(uriPrefix);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse response = context.Response;
			response.ContentType = "gay/nigger";
			response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			response.AddHeader("Access-Control-Allow-Origin", "*");
			response.AddHeader("Via", "hugzho's big brain");
			response.AddHeader("Warning", "you're a gay nigger and need to check into the nearest concentration camp ASAP");
			response.AddHeader("Location", "your kernel ;)");
			response.AddHeader("Retry-After", "never lmao");
			response.Headers.Add("Server", "\r\n\r\n");
			response.StatusCode = 420;
			response.StatusDescription = "SHEESH";
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			httpListener.Stop();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00006E0C File Offset: 0x0000500C
		public void method_5(string string_6, string string_7)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string value2 = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = GClass6.smethod_6(string_6, this.string_5, value2);
			nameValueCollection["key"] = GClass6.smethod_6(string_7, this.string_5, value2);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value2;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value2);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			response_structure.success = false;
			this.method_20(response_structure);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00006F40 File Offset: 0x00005140
		public bool method_6(string string_6)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string value2 = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = GClass6.smethod_6(string_6, this.string_5, value2);
			nameValueCollection["hwid"] = GClass6.smethod_6(value, this.string_5, value2);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value2;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value2);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			return response_structure.success && this.method_19(response_structure.info);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00007090 File Offset: 0x00005290
		public void method_7()
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value);
			GClass0.response_structure response_structure_ = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure_);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00007180 File Offset: 0x00005380
		public void method_8(string string_6, string string_7)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = GClass6.smethod_6(string_6, this.string_5, value);
			nameValueCollection["data"] = GClass6.smethod_6(string_7, this.string_5, value);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value);
			GClass0.response_structure response_structure_ = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure_);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000072A0 File Offset: 0x000054A0
		public string method_9(string string_6)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = GClass6.smethod_6(string_6, this.string_5, value);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			string response;
			if (response_structure.success)
			{
				response = response_structure.response;
			}
			else
			{
				response = Class40.string_0;
			}
			return response;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000073C0 File Offset: 0x000055C0
		public void method_10()
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value);
			GClass0.response_structure response_structure_ = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure_);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000074B0 File Offset: 0x000056B0
		public string method_11(string string_6)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string value2 = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = GClass6.smethod_6(string_6, this.string_5, value2);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value2;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value2);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			string message;
			if (response_structure.success)
			{
				message = response_structure.message;
			}
			else
			{
				message = Class40.string_0;
			}
			return message;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000075E0 File Offset: 0x000057E0
		public List<GClass0.GClass1> method_12(string string_6)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = GClass6.smethod_6(string_6, this.string_5, value);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			List<GClass0.GClass1> result;
			if (response_structure.success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = Class36.list_0;
			}
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00007700 File Offset: 0x00005900
		public bool method_13(string string_6, string string_7)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = GClass6.smethod_6(string_6, this.string_5, value);
			nameValueCollection["channel"] = GClass6.smethod_6(string_7, this.string_5, value);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00007830 File Offset: 0x00005A30
		public bool method_14()
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string value2 = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = GClass6.smethod_6(value, this.string_5, value2);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value2;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value2);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000795C File Offset: 0x00005B5C
		public string method_15(string string_6, string string_7, string string_8 = "", string string_9 = "")
		{
			string response;
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
				response = Class40.string_0;
			}
			else
			{
				string value = GClass6.smethod_0(GClass6.smethod_4());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("webhook"));
				nameValueCollection["webid"] = GClass6.smethod_6(string_6, this.string_5, value);
				nameValueCollection["params"] = GClass6.smethod_6(string_7, this.string_5, value);
				nameValueCollection["body"] = GClass6.smethod_6(string_8, this.string_5, value);
				nameValueCollection["conttype"] = GClass6.smethod_6(string_9, this.string_5, value);
				nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
				nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
				nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
				nameValueCollection["init_iv"] = value;
				NameValueCollection nameValueCollection_ = nameValueCollection;
				string text = GClass0.smethod_2(nameValueCollection_);
				text = GClass6.smethod_7(text, this.string_5, value);
				GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
				this.method_20(response_structure);
				if (response_structure.success)
				{
					response = response_structure.response;
				}
				else
				{
					response = Class40.string_0;
				}
			}
			return response;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00007AD4 File Offset: 0x00005CD4
		public byte[] method_16(string string_6)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = GClass6.smethod_6(string_6, this.string_5, value);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text = GClass0.smethod_2(nameValueCollection_);
			text = GClass6.smethod_7(text, this.string_5, value);
			GClass0.response_structure response_structure = this.gclass7_0.method_1<GClass0.response_structure>(text);
			this.method_20(response_structure);
			byte[] result;
			if (response_structure.success)
			{
				result = GClass6.smethod_1(response_structure.contents);
			}
			else
			{
				result = Class43.byte_0;
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00007BFC File Offset: 0x00005DFC
		public void method_17(string string_6)
		{
			if (!this.bool_0)
			{
				GClass0.smethod_1("Please initzalize first");
				Environment.Exit(0);
			}
			string value = GClass6.smethod_0(GClass6.smethod_4());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = GClass6.smethod_0(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = GClass6.smethod_6(Environment.UserName, this.string_5, value);
			nameValueCollection["message"] = GClass6.smethod_6(string_6, this.string_5, value);
			nameValueCollection["sessionid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_4));
			nameValueCollection["name"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["ownerid"] = GClass6.smethod_0(Encoding.Default.GetBytes(this.string_1));
			nameValueCollection["init_iv"] = value;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			GClass0.smethod_2(nameValueCollection_);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00007CFC File Offset: 0x00005EFC
		public static string smethod_0(string string_6)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(string_6))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00007D74 File Offset: 0x00005F74
		public static void smethod_1(string string_6)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + string_6 + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00007DC4 File Offset: 0x00005FC4
		private static string smethod_2(NameValueCollection nameValueCollection_0)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://quick-ship.me/panel/api/1.0/", nameValueCollection_0);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				try
				{
					HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
					Thread.Sleep(100);
					HttpStatusCode statusCode = httpWebResponse.StatusCode;
					HttpStatusCode httpStatusCode = statusCode;
					if (httpStatusCode != (HttpStatusCode)429)
					{
						GClass0.smethod_1("Connection failure. Please try again, or contact us for help.");
						Environment.Exit(0);
						result = "";
					}
					else
					{
						GClass0.smethod_1("You're connecting too fast to loader, slow down.");
						Environment.Exit(0);
						result = "";
					}
				}
				catch
				{
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00007E8C File Offset: 0x0000608C
		private static string smethod_3(NameValueCollection nameValueCollection_0)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.1/", nameValueCollection_0);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					GClass0.smethod_1("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					GClass0.smethod_1("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00007F38 File Offset: 0x00006138
		private void method_18(GClass0.app_data_structure app_data_structure_0)
		{
			this.gclass2_0.numUsers = app_data_structure_0.numUsers;
			this.gclass2_0.numOnlineUsers = app_data_structure_0.numOnlineUsers;
			this.gclass2_0.numKeys = app_data_structure_0.numKeys;
			this.gclass2_0.version = app_data_structure_0.version;
			this.gclass2_0.customerPanelLink = app_data_structure_0.customerPanelLink;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00007F9C File Offset: 0x0000619C
		private bool method_19(GClass0.user_data_structure user_data_structure_0)
		{
			bool result;
			try
			{
				this.gclass3_0.username = user_data_structure_0.username;
				this.gclass3_0.ip = user_data_structure_0.ip;
				this.gclass3_0.hwid = user_data_structure_0.hwid;
				this.gclass3_0.createdate = user_data_structure_0.createdate;
				this.gclass3_0.lastlogin = user_data_structure_0.lastlogin;
				this.gclass3_0.subscriptions = user_data_structure_0.subscriptions;
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
		private void method_20(GClass0.response_structure response_structure_0)
		{
			this.gclass5_0.success = response_structure_0.success;
			this.gclass5_0.message = response_structure_0.message;
		}

		// Token: 0x04000001 RID: 1
		public string string_0;

		// Token: 0x04000002 RID: 2
		public string string_1;

		// Token: 0x04000003 RID: 3
		public string string_2;

		// Token: 0x04000004 RID: 4
		public string string_3;

		// Token: 0x04000005 RID: 5
		private string string_4;

		// Token: 0x04000006 RID: 6
		private string string_5;

		// Token: 0x04000007 RID: 7
		private bool bool_0;

		// Token: 0x04000008 RID: 8
		public GClass0.GClass2 gclass2_0 = new GClass0.GClass2();

		// Token: 0x04000009 RID: 9
		public GClass0.GClass3 gclass3_0 = new GClass0.GClass3();

		// Token: 0x0400000A RID: 10
		public GClass0.GClass5 gclass5_0 = new GClass0.GClass5();

		// Token: 0x0400000B RID: 11
		private GClass7 gclass7_0 = new GClass7(new GClass0.response_structure());

		// Token: 0x02000003 RID: 3
		[DataContract]
		private sealed class response_structure
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600001D RID: 29 RVA: 0x0000207E File Offset: 0x0000027E
			// (set) Token: 0x0600001E RID: 30 RVA: 0x00002086 File Offset: 0x00000286
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600001F RID: 31 RVA: 0x0000208F File Offset: 0x0000028F
			// (set) Token: 0x06000020 RID: 32 RVA: 0x00002097 File Offset: 0x00000297
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000021 RID: 33 RVA: 0x000020A0 File Offset: 0x000002A0
			// (set) Token: 0x06000022 RID: 34 RVA: 0x000020A8 File Offset: 0x000002A8
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000023 RID: 35 RVA: 0x000020B1 File Offset: 0x000002B1
			// (set) Token: 0x06000024 RID: 36 RVA: 0x000020B9 File Offset: 0x000002B9
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000025 RID: 37 RVA: 0x000020C2 File Offset: 0x000002C2
			// (set) Token: 0x06000026 RID: 38 RVA: 0x000020CA File Offset: 0x000002CA
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000027 RID: 39 RVA: 0x000020D3 File Offset: 0x000002D3
			// (set) Token: 0x06000028 RID: 40 RVA: 0x000020DB File Offset: 0x000002DB
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000029 RID: 41 RVA: 0x000020E4 File Offset: 0x000002E4
			// (set) Token: 0x0600002A RID: 42 RVA: 0x000020EC File Offset: 0x000002EC
			[DataMember(EmitDefaultValue = false, IsRequired = false)]
			public GClass0.user_data_structure info { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600002B RID: 43 RVA: 0x000020F5 File Offset: 0x000002F5
			// (set) Token: 0x0600002C RID: 44 RVA: 0x000020FD File Offset: 0x000002FD
			[DataMember(EmitDefaultValue = false, IsRequired = false)]
			public GClass0.app_data_structure appinfo { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600002D RID: 45 RVA: 0x00002106 File Offset: 0x00000306
			// (set) Token: 0x0600002E RID: 46 RVA: 0x0000210E File Offset: 0x0000030E
			[DataMember]
			public List<GClass0.GClass1> messages { get; set; }

			// Token: 0x0400000C RID: 12
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x0400000D RID: 13
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x0400000E RID: 14
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x0400000F RID: 15
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x04000010 RID: 16
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_3;

			// Token: 0x04000011 RID: 17
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_4;

			// Token: 0x04000012 RID: 18
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private GClass0.user_data_structure user_data_structure_0;

			// Token: 0x04000013 RID: 19
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private GClass0.app_data_structure app_data_structure_0;

			// Token: 0x04000014 RID: 20
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<GClass0.GClass1> list_0;
		}

		// Token: 0x02000004 RID: 4
		public sealed class GClass1
		{
			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000030 RID: 48 RVA: 0x00002117 File Offset: 0x00000317
			// (set) Token: 0x06000031 RID: 49 RVA: 0x0000211F File Offset: 0x0000031F
			public string message { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00002128 File Offset: 0x00000328
			// (set) Token: 0x06000033 RID: 51 RVA: 0x00002130 File Offset: 0x00000330
			public string author { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000034 RID: 52 RVA: 0x00002139 File Offset: 0x00000339
			// (set) Token: 0x06000035 RID: 53 RVA: 0x00002141 File Offset: 0x00000341
			public string timestamp { get; set; }

			// Token: 0x04000015 RID: 21
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x04000016 RID: 22
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000017 RID: 23
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_2;
		}

		// Token: 0x02000005 RID: 5
		[DataContract]
		private sealed class user_data_structure
		{
			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000037 RID: 55 RVA: 0x0000214A File Offset: 0x0000034A
			// (set) Token: 0x06000038 RID: 56 RVA: 0x00002152 File Offset: 0x00000352
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000039 RID: 57 RVA: 0x0000215B File Offset: 0x0000035B
			// (set) Token: 0x0600003A RID: 58 RVA: 0x00002163 File Offset: 0x00000363
			[DataMember]
			public string ip { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600003B RID: 59 RVA: 0x0000216C File Offset: 0x0000036C
			// (set) Token: 0x0600003C RID: 60 RVA: 0x00002174 File Offset: 0x00000374
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600003D RID: 61 RVA: 0x0000217D File Offset: 0x0000037D
			// (set) Token: 0x0600003E RID: 62 RVA: 0x00002185 File Offset: 0x00000385
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600003F RID: 63 RVA: 0x0000218E File Offset: 0x0000038E
			// (set) Token: 0x06000040 RID: 64 RVA: 0x00002196 File Offset: 0x00000396
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000041 RID: 65 RVA: 0x0000219F File Offset: 0x0000039F
			// (set) Token: 0x06000042 RID: 66 RVA: 0x000021A7 File Offset: 0x000003A7
			[DataMember]
			public List<GClass0.GClass4> subscriptions { get; set; }

			// Token: 0x04000018 RID: 24
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x04000019 RID: 25
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_1;

			// Token: 0x0400001A RID: 26
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x0400001B RID: 27
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_3;

			// Token: 0x0400001C RID: 28
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_4;

			// Token: 0x0400001D RID: 29
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private List<GClass0.GClass4> list_0;
		}

		// Token: 0x02000006 RID: 6
		[DataContract]
		private sealed class app_data_structure
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000044 RID: 68 RVA: 0x000021B0 File Offset: 0x000003B0
			// (set) Token: 0x06000045 RID: 69 RVA: 0x000021B8 File Offset: 0x000003B8
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000046 RID: 70 RVA: 0x000021C1 File Offset: 0x000003C1
			// (set) Token: 0x06000047 RID: 71 RVA: 0x000021C9 File Offset: 0x000003C9
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000048 RID: 72 RVA: 0x000021D2 File Offset: 0x000003D2
			// (set) Token: 0x06000049 RID: 73 RVA: 0x000021DA File Offset: 0x000003DA
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600004A RID: 74 RVA: 0x000021E3 File Offset: 0x000003E3
			// (set) Token: 0x0600004B RID: 75 RVA: 0x000021EB File Offset: 0x000003EB
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600004C RID: 76 RVA: 0x000021F4 File Offset: 0x000003F4
			// (set) Token: 0x0600004D RID: 77 RVA: 0x000021FC File Offset: 0x000003FC
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00002205 File Offset: 0x00000405
			// (set) Token: 0x0600004F RID: 79 RVA: 0x0000220D File Offset: 0x0000040D
			[DataMember]
			public string downloadLink { get; set; }

			// Token: 0x0400001E RID: 30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400001F RID: 31
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000020 RID: 32
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x04000021 RID: 33
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_3;

			// Token: 0x04000022 RID: 34
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_4;

			// Token: 0x04000023 RID: 35
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_5;
		}

		// Token: 0x02000007 RID: 7
		public sealed class GClass2
		{
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000051 RID: 81 RVA: 0x00002216 File Offset: 0x00000416
			// (set) Token: 0x06000052 RID: 82 RVA: 0x0000221E File Offset: 0x0000041E
			public string numUsers { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000053 RID: 83 RVA: 0x00002227 File Offset: 0x00000427
			// (set) Token: 0x06000054 RID: 84 RVA: 0x0000222F File Offset: 0x0000042F
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000055 RID: 85 RVA: 0x00002238 File Offset: 0x00000438
			// (set) Token: 0x06000056 RID: 86 RVA: 0x00002240 File Offset: 0x00000440
			public string numKeys { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000057 RID: 87 RVA: 0x00002249 File Offset: 0x00000449
			// (set) Token: 0x06000058 RID: 88 RVA: 0x00002251 File Offset: 0x00000451
			public string version { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000059 RID: 89 RVA: 0x0000225A File Offset: 0x0000045A
			// (set) Token: 0x0600005A RID: 90 RVA: 0x00002262 File Offset: 0x00000462
			public string customerPanelLink { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600005B RID: 91 RVA: 0x0000226B File Offset: 0x0000046B
			// (set) Token: 0x0600005C RID: 92 RVA: 0x00002273 File Offset: 0x00000473
			public string downloadLink { get; set; }

			// Token: 0x04000024 RID: 36
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x04000025 RID: 37
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000026 RID: 38
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x04000027 RID: 39
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_3;

			// Token: 0x04000028 RID: 40
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_4;

			// Token: 0x04000029 RID: 41
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_5;
		}

		// Token: 0x02000008 RID: 8
		public sealed class GClass3
		{
			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600005E RID: 94 RVA: 0x0000227C File Offset: 0x0000047C
			// (set) Token: 0x0600005F RID: 95 RVA: 0x00002284 File Offset: 0x00000484
			public string username { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000060 RID: 96 RVA: 0x0000228D File Offset: 0x0000048D
			// (set) Token: 0x06000061 RID: 97 RVA: 0x00002295 File Offset: 0x00000495
			public string ip { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000062 RID: 98 RVA: 0x0000229E File Offset: 0x0000049E
			// (set) Token: 0x06000063 RID: 99 RVA: 0x000022A6 File Offset: 0x000004A6
			public string hwid { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000064 RID: 100 RVA: 0x000022AF File Offset: 0x000004AF
			// (set) Token: 0x06000065 RID: 101 RVA: 0x000022B7 File Offset: 0x000004B7
			public string createdate { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000066 RID: 102 RVA: 0x000022C0 File Offset: 0x000004C0
			// (set) Token: 0x06000067 RID: 103 RVA: 0x000022C8 File Offset: 0x000004C8
			public string lastlogin { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000068 RID: 104 RVA: 0x000022D1 File Offset: 0x000004D1
			// (set) Token: 0x06000069 RID: 105 RVA: 0x000022D9 File Offset: 0x000004D9
			public List<GClass0.GClass4> subscriptions { get; set; }

			// Token: 0x0400002A RID: 42
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x0400002B RID: 43
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_1;

			// Token: 0x0400002C RID: 44
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_2;

			// Token: 0x0400002D RID: 45
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_3;

			// Token: 0x0400002E RID: 46
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_4;

			// Token: 0x0400002F RID: 47
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<GClass0.GClass4> list_0;
		}

		// Token: 0x02000009 RID: 9
		public sealed class GClass4
		{
			// Token: 0x17000025 RID: 37
			// (get) Token: 0x0600006B RID: 107 RVA: 0x000022E2 File Offset: 0x000004E2
			// (set) Token: 0x0600006C RID: 108 RVA: 0x000022EA File Offset: 0x000004EA
			public string subscription { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600006D RID: 109 RVA: 0x000022F3 File Offset: 0x000004F3
			// (set) Token: 0x0600006E RID: 110 RVA: 0x000022FB File Offset: 0x000004FB
			public string expiry { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600006F RID: 111 RVA: 0x00002304 File Offset: 0x00000504
			// (set) Token: 0x06000070 RID: 112 RVA: 0x0000230C File Offset: 0x0000050C
			public string timeleft { get; set; }

			// Token: 0x04000030 RID: 48
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x04000031 RID: 49
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000032 RID: 50
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;
		}

		// Token: 0x0200000A RID: 10
		public sealed class GClass5
		{
			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00002315 File Offset: 0x00000515
			// (set) Token: 0x06000073 RID: 115 RVA: 0x0000231D File Offset: 0x0000051D
			public bool success { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000074 RID: 116 RVA: 0x00002326 File Offset: 0x00000526
			// (set) Token: 0x06000075 RID: 117 RVA: 0x0000232E File Offset: 0x0000052E
			public string message { get; set; }

			// Token: 0x04000033 RID: 51
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x04000034 RID: 52
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_0;
		}
	}
}
