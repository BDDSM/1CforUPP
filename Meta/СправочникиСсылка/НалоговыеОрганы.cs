
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
	public partial class ���������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("31248f0c-d7f3-45dc-be41-d892b0833ef9");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221190933.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*4*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*120*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.�����������������.�������������������� ��� {get;set;}//��� ���������� ������
		[DataMember]
		[ProtoMember(10)]
		public string/*(250)*/ ������������������ {get;set;}//������ ������������
		[DataMember]
		[ProtoMember(11)]
		public bool ���������������������� {get;set;}//���� ������������������
		[DataMember]
		[ProtoMember(12)]
		public bool ������������������������ {get;set;}//����� ��������� ����������
		[DataMember]
		[ProtoMember(13)]
		public string/*(10)*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(14)]
		public string/*(9)*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(15)]
		public string/*(128)*/ ����� {get;set;}
		[DataMember]
		[ProtoMember(16)]
		public string/*(64)*/ ������� {get;set;}
		[DataMember]
		[ProtoMember(17)]
		public string/*(64)*/ ��������������������� {get;set;}//����� ����������� �����
		[DataMember]
		[ProtoMember(18)]
		public string/*(64)*/ ���������� {get;set;}//����� �����
		[DataMember]
		[ProtoMember(19)]
		public string/*(250)*/ ����������� {get;set;}
		[DataMember]
		[ProtoMember(20)]
		public string/*(40)*/ ����������������� {get;set;}//������� ����������
		[DataMember]
		[ProtoMember(21)]
		public string/*(254)*/ ����������������������������������������������������������������� {get;set;}//����� ����������� ����� ��� ����� ���������������� � �������������������

		public V82.�����������������.���������������  ��������������()
		{
			var ������ = new V82.�����������������.���������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��������� = ���������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.��� = ���;
			������.������������������ = ������������������;
			������.���������������������� = ����������������������;
			������.������������������������ = ������������������������;
			������.��� = ���;
			������.��� = ���;
			������.����� = �����;
			������.������� = �������;
			������.��������������������� = ���������������������;
			������.���������� = ����������;
			������.����������� = �����������;
			������.����������������� = �����������������;
			������.����������������������������������������������������������������� = �����������������������������������������������������������������;
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
