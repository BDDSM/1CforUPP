
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
	///<summary>
	///(���)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ���������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("d8e39b2c-77c1-4485-aa1b-81256eb94277");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191350.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*10*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*100*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.�����������������.�������������� ������� {get;set;}
		[DataMember]
		[ProtoMember(10)]
		public bool ������������ {get;set;}//�� ��������� � ������
		[DataMember]
		[ProtoMember(11)]
		public V82.�����������������.����������� ����������� {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public V82.�����������������.����������� ������������������������� {get;set;}//�������� �������: ������������ �������������
		[DataMember]
		[ProtoMember(13)]
		public V82.������������/*������*/.����������������������� ����������� {get;set;}//��� ��������
		[DataMember]
		[ProtoMember(14)]
		public V82.������������/*������*/.������������������������� ������������ {get;set;}//��� ���������
		[DataMember]
		[ProtoMember(15)]
		public string/*(11)*/ ������������� {get;set;}//�������� �������: ����� ��������
		[DataMember]
		[ProtoMember(16)]
		public DateTime ������������ {get;set;}//�������� �������: ���� ��������
		[DataMember]
		[ProtoMember(17)]
		public V82.�����������������.������������� ������������ {get;set;}//�������� �������: ������ ������
		[DataMember]
		[ProtoMember(18)]
		public V82.�����������������.������������������������ ������������������������ {get;set;}//�������� �������: ������������� �����������
		[DataMember]
		[ProtoMember(19)]
		public V82.�����������������.�������������������� ��������� {get;set;}//�������� �������: ���������
		[DataMember]
		[ProtoMember(20)]
		public decimal/*(4.2)*/ ���������������� {get;set;}//�������� �������: ���������� ������
		[DataMember]
		[ProtoMember(21)]
		public DateTime ���������� {get;set;}//�������� �������: ���� ������
		[DataMember]
		[ProtoMember(22)]
		public DateTime ������������� {get;set;}//�������� �������: ���� ���������
		[DataMember]
		[ProtoMember(23)]
		public decimal/*(4.1)*/ ����������������� {get;set;}//�������� �������: ������������� ����
		[DataMember]
		[ProtoMember(24)]
		public object ���������� {get;set;}//�������� �������: ��� �������
		[DataMember]
		[ProtoMember(25)]
		public decimal/*(15.3)*/ �������������� {get;set;}//�������� �������: �������� ������
		[DataMember]
		[ProtoMember(26)]
		public V82.�����������������.������ �������������������� {get;set;}//�������� �������: ������ �������� ������
		[DataMember]
		[ProtoMember(27)]
		public string/*(15)*/ �������������������� {get;set;}//�������� ������������
		[DataMember]
		[ProtoMember(28)]
		public V82.�����������������.��������������� �������������� {get;set;}//�������� �������: �������� ������
		[DataMember]
		[ProtoMember(29)]
		public V82.�����������������.����������� �������������������������������� {get;set;}//������� ������������ �������������
		[DataMember]
		[ProtoMember(30)]
		public V82.�����������������.������������������������ ������������������������������� {get;set;}//������� ������������� �����������
		[DataMember]
		[ProtoMember(31)]
		public V82.�����������������.�������������������� ��������������������������� {get;set;}//������� ��������� �����������
		[DataMember]
		[ProtoMember(32)]
		public DateTime ������������������ {get;set;}//���� ������ �� ������
		[DataMember]
		[ProtoMember(33)]
		public DateTime �������������� {get;set;}//���� ����������
		[DataMember]
		[ProtoMember(34)]
		public V82.�����������������.������������� ���������������������������� {get;set;}//������������� ��������
		[DataMember]
		[ProtoMember(35)]
		public V82.�����������������.�������������������� ������������������������ {get;set;}//��������� ��������
		[DataMember]
		[ProtoMember(36)]
		public DateTime ��������������������������� {get;set;}//������ � ��������
		[DataMember]
		[ProtoMember(37)]
		public DateTime ������������������������ {get;set;}//������ �� ��������
		[DataMember]
		[ProtoMember(38)]
		public bool �������������������������������������� {get;set;}//�������� ��������� ���������� � ����������

		public V82.�����������������.���������������������  ��������������()
		{
			var ������ = new V82.�����������������.���������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��������� = ���������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.������� = �������;
			������.������������ = ������������;
			������.����������� = �����������;
			������.������������������������� = �������������������������;
			������.����������� = �����������;
			������.������������ = ������������;
			������.������������� = �������������;
			������.������������ = ������������;
			������.������������ = ������������;
			������.������������������������ = ������������������������;
			������.��������� = ���������;
			������.���������������� = ����������������;
			������.���������� = ����������;
			������.������������� = �������������;
			������.����������������� = �����������������;
			������.���������� = ����������;
			������.�������������� = ��������������;
			������.�������������������� = ��������������������;
			������.�������������������� = ��������������������;
			������.�������������� = ��������������;
			������.�������������������������������� = ��������������������������������;
			������.������������������������������� = �������������������������������;
			������.��������������������������� = ���������������������������;
			������.������������������ = ������������������;
			������.�������������� = ��������������;
			������.���������������������������� = ����������������������������;
			������.������������������������ = ������������������������;
			������.��������������������������� = ���������������������������;
			������.������������������������ = ������������������������;
			������.�������������������������������������� = ��������������������������������������;
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
