
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
	public partial class �����������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("499ec507-a418-47ff-8f7e-37d01c34e0f5");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221190709.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public bool ��������� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public Guid �������� {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*25*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*50*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public bool ������������������ {get;set;}//�������������� ����
		[DataMember]
		[ProtoMember(10)]
		public bool ���������������������� {get;set;}//������������������ ����
		[DataMember]
		[ProtoMember(11)]
		public object ������������������� {get;set;}//�������� �� ���������
		[DataMember]
		[ProtoMember(12)]
		public bool �������������� {get;set;}//������ ��������
		[DataMember]
		[ProtoMember(13)]
		public bool ������������������ {get;set;}//������ �������� ����.

		public V82.�����������������.�����������������������  ��������������()
		{
			var ������ = new V82.�����������������.�����������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��������� = ���������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.������������������ = ������������������;
			������.���������������������� = ����������������������;
			������.������������������� = �������������������;
			������.�������������� = ��������������;
			������.������������������ = ������������������;
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
