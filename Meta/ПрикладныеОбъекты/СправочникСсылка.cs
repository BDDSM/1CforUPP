using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using System.Runtime.Serialization;

namespace V82.�����������������
{
	[DataContract]
	[Serializable]
	public partial class ����������������
	{
	}
	public interface I������������ProtoBuf
	{
		void ������������ProtoBuf(Stream �����);
	}
	public interface I������������Json
	{
		string ������������Json();
	}
}

