
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
	///������������ ����������������� �� �������������
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class �����������������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("1d7957f5-e538-463a-b3ef-913e8125349c");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191042.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public Guid �������� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*9*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*100*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*(50)*/ ���������� {get;set;}//����� ������������
		///<summary>
		///���� ������ ������������
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public DateTime ���������� {get;set;}//���� ������
		///<summary>
		///���� ��������� �������� ������������
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public DateTime ������������� {get;set;}//���� ���������
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(1)*/ ����������������� {get;set;}//������� ����������
		[DataMember]
		[ProtoMember(12)]
		public string/*(1000)*/ ������������_������� {get;set;}//������������ �����������
		[DataMember]
		[ProtoMember(13)]
		public string/*(10)*/ ������������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(14)]
		public string/*(9)*/ ������������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(15)]
		public string/*(13)*/ ������������_���� {get;set;}//����
		///<summary>
		///��� ������������ ����������
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public string/*(12)*/ �������������_��� {get;set;}//��� ������������ ����������
		[DataMember]
		[ProtoMember(17)]
		public string/*(12)*/ ������������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(18)]
		public string/*(15)*/ ������������_���� {get;set;}//����
		[DataMember]
		[ProtoMember(19)]
		public V82.�����������������.���������������������� ������������_����������� {get;set;}//�����������
		[DataMember]
		[ProtoMember(20)]
		public DateTime ������������_������������ {get;set;}//������������
		[DataMember]
		[ProtoMember(21)]
		public string/*(1000)*/ ���������������_������� {get;set;}//������������ �����������
		[DataMember]
		[ProtoMember(22)]
		public string/*(10)*/ ���������������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(23)]
		public string/*(9)*/ ���������������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(24)]
		public string/*(13)*/ ���������������_���� {get;set;}//����
		[DataMember]
		[ProtoMember(25)]
		public string/*(12)*/ ���������������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(26)]
		public string/*(15)*/ ���������������_���� {get;set;}//����
		[DataMember]
		[ProtoMember(27)]
		public V82.�����������������.���������������������� ���������������_����������� {get;set;}//�����������
		[DataMember]
		[ProtoMember(28)]
		public DateTime ���������������_������������ {get;set;}//������������
		[DataMember]
		[ProtoMember(29)]
		public string/*(1000)*/ ����������_������� {get;set;}//������������ �����������
		[DataMember]
		[ProtoMember(30)]
		public string/*(10)*/ ����������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(31)]
		public string/*(9)*/ ����������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(32)]
		public string/*(13)*/ ����������_���� {get;set;}//����
		[DataMember]
		[ProtoMember(33)]
		public string/*(12)*/ ����������_��� {get;set;}//���
		[DataMember]
		[ProtoMember(34)]
		public bool �������������������� {get;set;}//���������� �������� ��
		[DataMember]
		[ProtoMember(35)]
		public bool ����������������������� {get;set;}//������������� �������� ��
		[DataMember]
		[ProtoMember(36)]
		public bool ������������������ {get;set;}//�������� �������� ��
		[DataMember]
		[ProtoMember(37)]
		public bool ������������������� {get;set;}//�������� �����������
		///<summary>
		///������� ��������������� ���� � ���������� - ��
		///</summary>
		[DataMember]
		[ProtoMember(38)]
		public bool ����������������� {get;set;}//���������� ����� ��
		[DataMember]
		[ProtoMember(39)]
		public bool �������������������������������� {get;set;}//������������� �������� �����������

		public V82.�����������������.�����������������������������  ��������������()
		{
			var ������ = new V82.�����������������.�����������������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.���������� = ����������;
			������.���������� = ����������;
			������.������������� = �������������;
			������.����������������� = �����������������;
			������.������������_������� = ������������_�������;
			������.������������_��� = ������������_���;
			������.������������_��� = ������������_���;
			������.������������_���� = ������������_����;
			������.�������������_��� = �������������_���;
			������.������������_��� = ������������_���;
			������.������������_���� = ������������_����;
			������.������������_����������� = ������������_�����������;
			������.������������_������������ = ������������_������������;
			������.���������������_������� = ���������������_�������;
			������.���������������_��� = ���������������_���;
			������.���������������_��� = ���������������_���;
			������.���������������_���� = ���������������_����;
			������.���������������_��� = ���������������_���;
			������.���������������_���� = ���������������_����;
			������.���������������_����������� = ���������������_�����������;
			������.���������������_������������ = ���������������_������������;
			������.����������_������� = ����������_�������;
			������.����������_��� = ����������_���;
			������.����������_��� = ����������_���;
			������.����������_���� = ����������_����;
			������.����������_��� = ����������_���;
			������.�������������������� = ��������������������;
			������.����������������������� = �����������������������;
			������.������������������ = ������������������;
			������.������������������� = �������������������;
			������.����������������� = �����������������;
			������.�������������������������������� = ��������������������������������;
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
