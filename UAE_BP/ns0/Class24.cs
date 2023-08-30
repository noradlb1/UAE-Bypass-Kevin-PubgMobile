using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ns0
{
	// Token: 0x02000046 RID: 70
	internal sealed class Class24
	{
		// Token: 0x060001DB RID: 475 RVA: 0x0000280F File Offset: 0x00000A0F
		static Class24()
		{
			if (typeof(MulticastDelegate) != null)
			{
				Class24.moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00002833 File Offset: 0x00000A33
		private int Int32_0
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000F484 File Offset: 0x0000D684
		public static void smethod_0(int int_22, int int_23, int int_24)
		{
			Type typeFromHandle;
			MethodInfo methodInfo;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(Class24.moduleHandle_0.ResolveTypeHandle(int_22));
				object methodFromHandle;
				if (int_24 == 16777215)
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(Class24.moduleHandle_0.ResolveMethodHandle(int_23));
				}
				else
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(Class24.moduleHandle_0.ResolveMethodHandle(int_23), Class24.moduleHandle_0.ResolveTypeHandle(int_24));
				}
				methodInfo = (MethodInfo)methodFromHandle;
			}
			catch (Exception)
			{
				throw;
			}
			foreach (FieldInfo fieldInfo in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
			{
				try
				{
					Delegate value;
					if (methodInfo.IsStatic)
					{
						value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num = parameters.Length + 1;
						Type[] array = new Type[num];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array[0] = typeof(object);
						}
						for (int j = 1; j < num; j++)
						{
							array[j] = parameters[j - 1].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Ldarg_0);
						if (num > 1)
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
						}
						if (num > 2)
						{
							ilgenerator.Emit(OpCodes.Ldarg_2);
						}
						if (num > 3)
						{
							ilgenerator.Emit(OpCodes.Ldarg_3);
						}
						if (num > 4)
						{
							for (int k = 4; k < num; k++)
							{
								ilgenerator.Emit(OpCodes.Ldarg_S, k);
							}
						}
						ilgenerator.Emit(fieldInfo.IsFamilyOrAssembly ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						value = dynamicMethod.CreateDelegate(typeFromHandle);
					}
					fieldInfo.SetValue(null, value);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x04000184 RID: 388
		private static readonly int int_0;

		// Token: 0x04000185 RID: 389
		private static readonly int int_1;

		// Token: 0x04000186 RID: 390
		private static readonly int int_2;

		// Token: 0x04000187 RID: 391
		private static readonly int int_3;

		// Token: 0x04000188 RID: 392
		private static readonly int int_4;

		// Token: 0x04000189 RID: 393
		private static readonly int int_5;

		// Token: 0x0400018A RID: 394
		private static readonly int int_6;

		// Token: 0x0400018B RID: 395
		private static readonly int int_7;

		// Token: 0x0400018C RID: 396
		private static readonly int int_8;

		// Token: 0x0400018D RID: 397
		private static readonly int int_9;

		// Token: 0x0400018E RID: 398
		private static readonly int int_10;

		// Token: 0x0400018F RID: 399
		private static readonly int int_11;

		// Token: 0x04000190 RID: 400
		private static readonly int int_12;

		// Token: 0x04000191 RID: 401
		private static readonly int int_13;

		// Token: 0x04000192 RID: 402
		private static readonly int int_14;

		// Token: 0x04000193 RID: 403
		private static readonly int int_15;

		// Token: 0x04000194 RID: 404
		private static readonly int int_16;

		// Token: 0x04000195 RID: 405
		private static readonly int int_17;

		// Token: 0x04000196 RID: 406
		private static readonly int int_18;

		// Token: 0x04000197 RID: 407
		private static readonly int int_19;

		// Token: 0x04000198 RID: 408
		private static readonly int int_20;

		// Token: 0x04000199 RID: 409
		private static readonly int int_21;

		// Token: 0x0400019A RID: 410
		private static readonly ModuleHandle moduleHandle_0;
	}
}
