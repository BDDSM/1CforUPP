
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
	public partial class ����������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("0c148f3d-26d7-4fdb-b823-6a8a1caf7ee7");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191637.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*3*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*50*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public bool ������������� {get;set;}//����� ��������
		[DataMember]
		[ProtoMember(8)]
		public bool ������������� {get;set;}//����� ��������
		[DataMember]
		[ProtoMember(9)]
		public object ������������������ {get;set;}//���� ������ ��������
		[DataMember]
		[ProtoMember(10)]
		public object ������������������ {get;set;}//���� ������ ��������
		[DataMember]
		[ProtoMember(11)]
		public bool ������������������������ {get;set;}//��������� ������ ���������
		[DataMember]
		[ProtoMember(12)]
		public bool ��������������� {get;set;}//��������� �� ����
		[DataMember]
		[ProtoMember(13)]
		public string/*(0)*/ ��������������� {get;set;}//������� ��������
		[DataMember]
		[ProtoMember(14)]
		public string/*(255)*/ HTTP��������������� {get;set;}//HTTP ����� ������� ����� ��� ������
		[DataMember]
		[ProtoMember(15)]
		public string/*(255)*/ HTTP�������������������� {get;set;}//HTTP ����� ��� ������������
		[DataMember]
		[ProtoMember(16)]
		public string/*(255)*/ HTTP����������� {get;set;}//HTTP ����� ������
		[DataMember]
		[ProtoMember(17)]
		public bool HTTP������������������������ {get;set;}//������������ ������-������
		[DataMember]
		[ProtoMember(18)]
		public string/*(255)*/ HTTP����������������� {get;set;}//��� ��� ����� �������
		[DataMember]
		[ProtoMember(19)]
		public decimal/*(5)*/ HTTP��������������� {get;set;}//���� ������-�������
		[DataMember]
		[ProtoMember(20)]
		public string/*(255)*/ HTTP�������������������������� {get;set;}//��� ������������ ������
		[DataMember]
		[ProtoMember(21)]
		public string/*(255)*/ HTTP����������������� {get;set;}//������ ������������ ������-�������
		[DataMember]
		[ProtoMember(22)]
		public V82.�����������������.����������� �������������������������� {get;set;}//������ ��� ����� ������������
		[DataMember]
		[ProtoMember(23)]
		public V82.�����������������.������������ �������������������������� {get;set;}//������ ��� ����� ������������
		[DataMember]
		[ProtoMember(24)]
		public V82.�����������������.����������� ����������� {get;set;}
		[DataMember]
		[ProtoMember(25)]
		public V82.�����������������.������������ ������������� {get;set;}
		[DataMember]
		[ProtoMember(26)]
		public V82.�����������������.������������� ������������� {get;set;}
		[DataMember]
		[ProtoMember(27)]
		public bool ������������������������������� {get;set;}//���������� ��������� ������� �����
		[DataMember]
		[ProtoMember(28)]
		public bool ������������������ {get;set;}//��������� ���������
		[DataMember]
		[ProtoMember(29)]
		public bool ���������������������������� {get;set;}//��������� ��������� ����������
		[DataMember]
		[ProtoMember(30)]
		public string/*(12)*/ ������������������������������� {get;set;}//������ ������������� ������������
		[DataMember]
		[ProtoMember(31)]
		public V82.�����������������.���������������������������� ��������������������������������� {get;set;}//������� ��������� ����� ������������
		[DataMember]
		[ProtoMember(32)]
		public ����������������� ������������������������������� {get;set;}
		[DataMember]
		[ProtoMember(33)]
		public bool ����������������� {get;set;}//��������� ��������
		[DataMember]
		[ProtoMember(34)]
		public string/*(0)*/ ����������� {get;set;}
		[DataMember]
		[ProtoMember(35)]
		public string/*(40)*/ ������������������� {get;set;}//������������ �������
		[DataMember]
		[ProtoMember(36)]
		public bool ������������������������������� {get;set;}//������������ ������������ �������

		public V82.�����������������.����������������������  ��������������()
		{
			var ������ = new V82.�����������������.����������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.������������� = �������������;
			������.������������� = �������������;
			������.������������������ = ������������������;
			������.������������������ = ������������������;
			������.������������������������ = ������������������������;
			������.��������������� = ���������������;
			������.��������������� = ���������������;
			������.HTTP��������������� = HTTP���������������;
			������.HTTP�������������������� = HTTP��������������������;
			������.HTTP����������� = HTTP�����������;
			������.HTTP������������������������ = HTTP������������������������;
			������.HTTP����������������� = HTTP�����������������;
			������.HTTP��������������� = HTTP���������������;
			������.HTTP�������������������������� = HTTP��������������������������;
			������.HTTP����������������� = HTTP�����������������;
			������.�������������������������� = ��������������������������;
			������.�������������������������� = ��������������������������;
			������.����������� = �����������;
			������.������������� = �������������;
			������.������������� = �������������;
			������.������������������������������� = �������������������������������;
			������.������������������ = ������������������;
			������.���������������������������� = ����������������������������;
			������.������������������������������� = �������������������������������;
			������.��������������������������������� = ���������������������������������;
			������.������������������������������� = �������������������������������;
			������.����������������� = �����������������;
			������.����������� = �����������;
			������.������������������� = �������������������;
			������.������������������������������� = �������������������������������;
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
