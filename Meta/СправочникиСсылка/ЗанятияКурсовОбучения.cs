
using System;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	[ProtoContract]
	[DataContract]
	public partial class ���������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("1ba3b507-c263-4a5f-b639-2e6b393108c8");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191031.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long ���������������������� = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid ������ {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long ������ {get;set;}
		/*static ��� ����� ������� � ������� ����������*/
		/*������ ������ ���������������� �� ������*/
		[DataMember]
		[ProtoMember(3)]
		public bool ��������������� {get;set;}
		[DataMember]
		[ProtoMember(4)]
		public bool ���������������� {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public string/*150*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*(0)*/ ��������������� {get;set;}//�������� �������
		///<summary>
		///������������ ������� � �����
		///</summary>
		[DataMember]
		[ProtoMember(7)]
		public decimal/*(6.2)*/ ������������������� {get;set;}//������������ �������
		[DataMember]
		[ProtoMember(8)]
		public V82.�����������������.������������� ���������� {get;set;}//��� �������

		public V82.�����������������.���������������������  ��������������()
		{
			var ������ = new V82.�����������������.���������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.������������ = ������������;
			������.��������������� = ���������������;
			������.������������������� = �������������������;
			������.���������� = ����������;
			return ������;
		}

		public void ������������ProtoBuf(Stream �����)
		{
			Serializer.Serialize(�����,this);
		}
		
		public string ������������Json()
		{
			return this.ToJson();
		}
		
		public string ������������Xml()
		{
			return this.ToXml();
		}
	}
}
