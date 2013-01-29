
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
	public partial class �������������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("374d1800-8261-4660-a34c-eda2ba21a1cf");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191137.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*6*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*150*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public bool ���������������������������������� {get;set;}//��������� �������� ��� ������� �������
		[DataMember]
		[ProtoMember(8)]
		public bool ������������������������������� {get;set;}//������������ ������������ �������
		[DataMember]
		[ProtoMember(9)]
		public bool ���������������������������������������� {get;set;}//����������� �������� �������� ����� ��������
		[DataMember]
		[ProtoMember(10)]
		public V82.�����������������.������������ ������������� {get;set;}//������������
		[DataMember]
		[ProtoMember(11)]
		public bool ��������������������� {get;set;}//������ ������ ���������
		[DataMember]
		[ProtoMember(12)]
		public bool ��������������������������������� {get;set;}//������ ���������� ������ � ����������
		[DataMember]
		[ProtoMember(13)]
		public string/*(255)*/ �������������������������� {get;set;}//������� �������� �����������
		[DataMember]
		[ProtoMember(14)]
		public string/*(255)*/ ������������������������������� {get;set;}//��������� ����� ��� ��������� �����
		[DataMember]
		[ProtoMember(15)]
		public decimal/*(10)*/ ���������������������������������������������� {get;set;}//���������� ��������� � ���������� �� �������� ������
		[DataMember]
		[ProtoMember(16)]
		public decimal/*(10)*/ ���������������������������������������������� {get;set;}//���������� ��������� � ���������� �� �������� ������
		[DataMember]
		[ProtoMember(17)]
		public V82.�����������������.����������������������������� �������������������������������������� {get;set;}//������� ������ �������� ��������� �� ������
		[DataMember]
		[ProtoMember(18)]
		public string/*(100)*/ ��������������������������������� {get;set;}//����� ��� �������� ��������� �� ������
		[DataMember]
		[ProtoMember(19)]
		public string/*(0)*/ ����������� {get;set;}
		[DataMember]
		[ProtoMember(20)]
		public string/*(40)*/ ������������������� {get;set;}//������������ �������

		public V82.�����������������.�������������������������  ��������������()
		{
			var ������ = new V82.�����������������.�������������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.���������������������������������� = ����������������������������������;
			������.������������������������������� = �������������������������������;
			������.���������������������������������������� = ����������������������������������������;
			������.������������� = �������������;
			������.��������������������� = ���������������������;
			������.��������������������������������� = ���������������������������������;
			������.�������������������������� = ��������������������������;
			������.������������������������������� = �������������������������������;
			������.���������������������������������������������� = ����������������������������������������������;
			������.���������������������������������������������� = ����������������������������������������������;
			������.�������������������������������������� = ��������������������������������������;
			������.��������������������������������� = ���������������������������������;
			������.����������� = �����������;
			������.������������������� = �������������������;
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
