
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
	public partial class �����������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("96a1d76f-5dd2-49e0-9b68-523b824bab2e");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191458.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*10*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*150*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public V82.�����������������.����������������������������� ������������� {get;set;}//������� ������
		[DataMember]
		[ProtoMember(8)]
		public V82.������������/*������*/.���������������� ��� {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public string/*(100)*/ ������������� {get;set;}//������������� ����� ������
		[DataMember]
		[ProtoMember(10)]
		public object ������� {get;set;}
		[DataMember]
		[ProtoMember(11)]
		public V82.�����������������.����������� ����������� {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public object ������������������ {get;set;}//������� �����������
		[DataMember]
		[ProtoMember(13)]
		public DateTime ������������ {get;set;}//���� ��������
		[DataMember]
		[ProtoMember(14)]
		public DateTime ������������ {get;set;}//���� ��������
		[DataMember]
		[ProtoMember(15)]
		public DateTime ����������������������� {get;set;}//���� ���������� ���������
		[DataMember]
		[ProtoMember(16)]
		public object ��������� {get;set;}//��� ������
		[DataMember]
		[ProtoMember(17)]
		public DateTime ����������������� {get;set;}//���� ������ �������
		[DataMember]
		[ProtoMember(18)]
		public DateTime �������������������� {get;set;}//���� ��������� �������
		[DataMember]
		[ProtoMember(19)]
		public decimal/*(3)*/ ������������ {get;set;}//��� ���������
		[DataMember]
		[ProtoMember(20)]
		public V82.������������/*������*/.��������������� ��������� {get;set;}//��� ������
		[DataMember]
		[ProtoMember(21)]
		public V82.������������/*������*/.����������������������� ������������ {get;set;}//������ ������
		[DataMember]
		[ProtoMember(22)]
		public string/*(16)*/ ������ {get;set;}
		[DataMember]
		[ProtoMember(23)]
		public V82.������������/*������*/.���������������� ��� {get;set;}
		[DataMember]
		[ProtoMember(24)]
		public V82.������������/*������*/.��������������������������� ���������������������� {get;set;}//������ ����������������

		public V82.�����������������.�����������  ��������������()
		{
			var ������ = new V82.�����������������.�����������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.������������� = �������������;
			������.��� = ���;
			������.������������� = �������������;
			������.������� = �������;
			������.����������� = �����������;
			������.������������������ = ������������������;
			������.������������ = ������������;
			������.������������ = ������������;
			������.����������������������� = �����������������������;
			������.��������� = ���������;
			������.����������������� = �����������������;
			������.�������������������� = ��������������������;
			������.������������ = ������������;
			������.��������� = ���������;
			������.������������ = ������������;
			������.������ = ������;
			������.��� = ���;
			������.���������������������� = ����������������������;
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
