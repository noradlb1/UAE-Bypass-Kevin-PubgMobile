using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace ns0
{
	// Token: 0x02000049 RID: 73
	internal sealed class Class27
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x0000FA14 File Offset: 0x0000DC14
		static Class27()
		{
			if (Class27.byte_0 == null)
			{
				string text = "VUFFX0JQKg==";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				Class27.byte_0 = Class21.smethod_3(97L, manifestResourceStream);
				Class27.dictionary_0 = new Dictionary<int, int>();
				using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(Class27.byte_0, false)))
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						int key = binaryReader.ReadInt32();
						int value = binaryReader.ReadInt32();
						Class27.dictionary_0[key] = value;
					}
				}
			}
			if (typeof(MulticastDelegate) != null)
			{
				Class27.moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		internal static void smethod_0(int int_1, int int_2, int int_3)
		{
			Type typeFromHandle;
			MethodBase methodBase;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(Class27.moduleHandle_0.ResolveTypeHandle(int_1));
				object methodFromHandle = MethodBase.GetMethodFromHandle(Class27.moduleHandle_0.ResolveMethodHandle(int_2), Class27.moduleHandle_0.ResolveTypeHandle(int_3));
				methodBase = (MethodBase)methodFromHandle;
			}
			catch (Exception)
			{
				throw;
			}
			foreach (FieldInfo fieldInfo in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
			{
				try
				{
					DynamicMethod dynamicMethod = Class45.dynamicMethod_0;
					MethodBody methodBody = methodBase.GetMethodBody();
					Type[] parameterTypes = Class27.smethod_5(methodBase);
					dynamicMethod = new DynamicMethod(methodBase.DeclaringType.FullName + "." + methodBase.Name + "_Encrypted$", (methodBase is ConstructorInfo) ? null : ((MethodInfo)methodBase).ReturnType, parameterTypes, methodBase.DeclaringType, true);
					int num;
					Class27.dictionary_0.TryGetValue(int_1, out num);
					DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
					Class27.smethod_2(methodBody, dynamicILInfo);
					Class27.smethod_1(ref num, methodBase, dynamicILInfo);
					Class27.smethod_3(ref num, dynamicILInfo);
					Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
					fieldInfo.SetValue(null, value);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000FC48 File Offset: 0x0000DE48
		private static void smethod_1(ref int int_1, MethodBase methodBase_0, DynamicILInfo dynamicILInfo_0)
		{
			int maxStackSize = BitConverter.ToInt32(Class27.byte_0, int_1);
			int_1 += 4;
			int num = BitConverter.ToInt32(Class27.byte_0, int_1);
			int_1 += 4;
			byte[] array = new byte[num];
			Buffer.BlockCopy(Class27.byte_0, int_1, array, 0, num);
			Class27.Class28 @class = new Class27.Class28(methodBase_0, array, dynamicILInfo_0);
			@class.method_0();
			dynamicILInfo_0.SetCode(array, maxStackSize);
			int_1 += num;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
		private static void smethod_2(MethodBody methodBody_0, DynamicILInfo dynamicILInfo_0)
		{
			SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
			foreach (LocalVariableInfo localVariableInfo in methodBody_0.LocalVariables)
			{
				localVarSigHelper.AddArgument(localVariableInfo.LocalType, localVariableInfo.IsPinned);
			}
			dynamicILInfo_0.SetLocalSignature(localVarSigHelper.GetSignature());
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		private static void smethod_3(ref int int_1, DynamicILInfo dynamicILInfo_0)
		{
			int num = BitConverter.ToInt32(Class27.byte_0, int_1);
			int_1 += 4;
			if (num == 0)
			{
				return;
			}
			byte[] array = new byte[num];
			Buffer.BlockCopy(Class27.byte_0, int_1, array, 0, num);
			int num2 = 4;
			int num3 = (num - 4) / 24;
			for (int i = 0; i < num3; i++)
			{
				ExceptionHandlingClauseOptions exceptionHandlingClauseOptions = (ExceptionHandlingClauseOptions)BitConverter.ToInt32(array, num2);
				num2 += 20;
				switch (exceptionHandlingClauseOptions)
				{
				case ExceptionHandlingClauseOptions.Clause:
				{
					RuntimeTypeHandle type = Class27.moduleHandle_0.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
					int tokenFor = dynamicILInfo_0.GetTokenFor(type);
					Class27.smethod_4(tokenFor, num2, array);
					break;
				}
				case ExceptionHandlingClauseOptions.Fault:
					throw new NotSupportedException("dynamic method does not support fault clause");
				}
				num2 += 4;
			}
			dynamicILInfo_0.SetExceptions(array);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000287E File Offset: 0x00000A7E
		public static void smethod_4(int int_1, int int_2, byte[] byte_1)
		{
			byte_1[int_2++] = (byte)int_1;
			byte_1[int_2++] = (byte)(int_1 >> 8);
			byte_1[int_2++] = (byte)(int_1 >> 16);
			byte_1[int_2++] = (byte)(int_1 >> 24);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
		private static Type[] smethod_5(MethodBase methodBase_0)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			int num = parameters.Length;
			if (!methodBase_0.IsStatic)
			{
				num++;
			}
			Type[] array = new Type[num];
			int num2 = 0;
			if (!methodBase_0.IsStatic)
			{
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array[0] = methodBase_0.DeclaringType.MakeByRefType();
				}
				else
				{
					array[0] = methodBase_0.DeclaringType;
				}
				num2++;
			}
			int i = 0;
			while (i < parameters.Length)
			{
				array[num2] = parameters[i].ParameterType;
				i++;
				num2++;
			}
			return array;
		}

		// Token: 0x040001C9 RID: 457
		internal static readonly byte[] byte_0;

		// Token: 0x040001CA RID: 458
		internal static readonly Dictionary<int, int> dictionary_0;

		// Token: 0x040001CB RID: 459
		private static readonly ModuleHandle moduleHandle_0;

		// Token: 0x040001CC RID: 460
		internal readonly int int_0;

		// Token: 0x0200004A RID: 74
		public sealed class Class28
		{
			// Token: 0x060001ED RID: 493 RVA: 0x0000FE68 File Offset: 0x0000E068
			static Class28()
			{
				foreach (FieldInfo fieldInfo in typeof(OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public))
				{
					OpCode opCode = (OpCode)fieldInfo.GetValue(Class29.object_0);
					ushort num = (ushort)opCode.Value;
					if (num < 256)
					{
						Class27.Class28.opCode_0[(int)num] = opCode;
					}
					else if ((num & 65280) == 65024)
					{
						Class27.Class28.opCode_1[(int)(num & 255)] = opCode;
					}
				}
			}

			// Token: 0x060001EE RID: 494 RVA: 0x0000FF18 File Offset: 0x0000E118
			public Class28(MethodBase methodBase_0, byte[] byte_1, DynamicILInfo dynamicILInfo_1)
			{
				this.dynamicILInfo_0 = dynamicILInfo_1;
				this.byte_0 = byte_1;
				this.int_0 = 0;
				this.module_0 = methodBase_0.Module;
				this.type_0 = ((methodBase_0 is ConstructorInfo) ? Class44.type_0 : methodBase_0.GetGenericArguments());
				this.type_1 = ((methodBase_0.DeclaringType == null) ? Class44.type_0 : methodBase_0.DeclaringType.GetGenericArguments());
			}

			// Token: 0x060001EF RID: 495 RVA: 0x000028B0 File Offset: 0x00000AB0
			internal void method_0()
			{
				while (this.int_0 < this.byte_0.Length)
				{
					this.method_1();
				}
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x0000FF88 File Offset: 0x0000E188
			private object method_1()
			{
				int num = this.int_0;
				OpCode opCode = OpCodes.Nop;
				byte b = this.method_3();
				if (b != 254)
				{
					opCode = Class27.Class28.opCode_0[(int)b];
				}
				else
				{
					b = this.method_3();
					opCode = Class27.Class28.opCode_1[(int)b];
				}
				switch (opCode.OperandType)
				{
				case OperandType.InlineBrTarget:
					this.method_2(4);
					return null;
				case OperandType.InlineField:
				{
					int num2 = this.method_4();
					FieldInfo fieldInfo = this.module_0.ResolveField(num2, this.type_1, this.type_0);
					this.method_5(this.dynamicILInfo_0.GetTokenFor(fieldInfo.FieldHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineI:
					this.method_2(4);
					return null;
				case OperandType.InlineI8:
					this.method_2(8);
					return null;
				case OperandType.InlineMethod:
				{
					int num2 = this.method_4();
					MethodBase methodBase = this.module_0.ResolveMethod(num2, this.type_1, this.type_0);
					this.method_5(this.dynamicILInfo_0.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType.TypeHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineNone:
					return null;
				case OperandType.InlineR:
					this.method_2(8);
					return null;
				case OperandType.InlineSig:
				{
					int num2 = this.method_4();
					this.method_5(this.dynamicILInfo_0.GetTokenFor(this.module_0.ResolveSignature(num2)), num + opCode.Size);
					return null;
				}
				case OperandType.InlineString:
				{
					int num2 = this.method_4();
					this.method_5(this.dynamicILInfo_0.GetTokenFor(this.module_0.ResolveString(num2)), num + opCode.Size);
					return null;
				}
				case OperandType.InlineSwitch:
				{
					int num3 = this.method_4();
					this.method_2(num3 * 4);
					return null;
				}
				case OperandType.InlineTok:
				{
					int num2 = this.method_4();
					MemberInfo memberInfo = this.module_0.ResolveMember(num2, this.type_1, this.type_0);
					if (memberInfo.MemberType != MemberTypes.TypeInfo)
					{
						if (memberInfo.MemberType != MemberTypes.NestedType)
						{
							if (memberInfo.MemberType != MemberTypes.Method)
							{
								if (memberInfo.MemberType != MemberTypes.Constructor)
								{
									if (memberInfo.MemberType == MemberTypes.Field)
									{
										FieldInfo fieldInfo2 = memberInfo as FieldInfo;
										num2 = this.dynamicILInfo_0.GetTokenFor(fieldInfo2.FieldHandle);
										goto IL_2BE;
									}
									goto IL_2BE;
								}
							}
							MethodBase methodBase2 = memberInfo as MethodBase;
							num2 = this.dynamicILInfo_0.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType.TypeHandle);
							goto IL_2BE;
						}
					}
					Type type = memberInfo as Type;
					num2 = this.dynamicILInfo_0.GetTokenFor(type.TypeHandle);
					IL_2BE:
					this.method_5(num2, num + opCode.Size);
					return null;
				}
				case OperandType.InlineType:
				{
					int num2 = this.method_4();
					Type type2 = this.module_0.ResolveType(num2, this.type_1, this.type_0);
					this.method_5(this.dynamicILInfo_0.GetTokenFor(type2.TypeHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineVar:
					this.method_2(2);
					return null;
				case OperandType.ShortInlineBrTarget:
					this.method_2(1);
					return null;
				case OperandType.ShortInlineI:
					this.method_2(1);
					return null;
				case OperandType.ShortInlineR:
					this.method_2(4);
					return null;
				case OperandType.ShortInlineVar:
					this.method_2(1);
					return null;
				}
				throw new BadImageFormatException("unexpected OperandType " + opCode.OperandType);
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x000028CC File Offset: 0x00000ACC
			private void method_2(int int_1)
			{
				this.int_0 += int_1;
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x000102DC File Offset: 0x0000E4DC
			private byte method_3()
			{
				return this.byte_0[this.int_0++];
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00010304 File Offset: 0x0000E504
			private int method_4()
			{
				int startIndex = this.int_0;
				this.int_0 += 4;
				return BitConverter.ToInt32(this.byte_0, startIndex);
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00010334 File Offset: 0x0000E534
			private void method_5(int int_1, int int_2)
			{
				this.byte_0[int_2++] = (byte)int_1;
				this.byte_0[int_2++] = (byte)(int_1 >> 8);
				this.byte_0[int_2++] = (byte)(int_1 >> 16);
				this.byte_0[int_2++] = (byte)(int_1 >> 24);
			}

			// Token: 0x040001CD RID: 461
			private static OpCode[] opCode_0 = new OpCode[256];

			// Token: 0x040001CE RID: 462
			private static OpCode[] opCode_1 = new OpCode[256];

			// Token: 0x040001CF RID: 463
			private int int_0;

			// Token: 0x040001D0 RID: 464
			private byte[] byte_0;

			// Token: 0x040001D1 RID: 465
			private DynamicILInfo dynamicILInfo_0;

			// Token: 0x040001D2 RID: 466
			private Module module_0;

			// Token: 0x040001D3 RID: 467
			private Type[] type_0;

			// Token: 0x040001D4 RID: 468
			private Type[] type_1;
		}
	}
}
