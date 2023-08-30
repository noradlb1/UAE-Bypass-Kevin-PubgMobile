using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ns0
{
	// Token: 0x0200000D RID: 13
	public sealed class GClass7
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00008348 File Offset: 0x00006548
		public GClass7(object object_1)
		{
			this.object_0 = object_1;
			Type type = this.object_0.GetType();
			this.dataContractJsonSerializer_0 = new DataContractJsonSerializer(type);
			if (!GClass7.smethod_0(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.object_0));
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000235B File Offset: 0x0000055B
		public static bool smethod_0(Type type_0)
		{
			return type_0.IsSerializable || type_0.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000839C File Offset: 0x0000659C
		public object method_0(string string_0)
		{
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.dataContractJsonSerializer_0.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002379 File Offset: 0x00000579
		public T method_1<T>(string string_0)
		{
			return (T)((object)this.method_0(string_0));
		}

		// Token: 0x04000035 RID: 53
		private DataContractJsonSerializer dataContractJsonSerializer_0;

		// Token: 0x04000036 RID: 54
		private object object_0;
	}
}
