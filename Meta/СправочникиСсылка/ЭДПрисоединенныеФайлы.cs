
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
		public static readonly Guid ���������� = new Guid("e0923338-40d1-44a1-bd03-6b1662cb1b25");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191849.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		///<summary>
		///����� - ������������, ���������� ����
		///</summary>
		[DataMember]
		[ProtoMember(6)]
		public V82.�����������������.������������ ����� {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public V82.������������/*������*/.������ ����� {get;set;}//��� ��
		[DataMember]
		[ProtoMember(8)]
		public object ������������� {get;set;}//�������� �����
		[DataMember]
		[ProtoMember(9)]
		public DateTime ������������������������ {get;set;}//���� ��������� �����������
		[DataMember]
		[ProtoMember(10)]
		public DateTime ���������������������� {get;set;}//���� ��������� ������� ��
		[DataMember]
		[ProtoMember(11)]
		public DateTime ���������������������������� {get;set;}//���� ����������� �������������
		///<summary>
		///���� ���������� ����� � ����
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public DateTime ������������ {get;set;}//���� ��������
		[DataMember]
		[ProtoMember(13)]
		public DateTime ������������������������������ {get;set;}//���� ������������ �� ������������
		[DataMember]
		[ProtoMember(14)]
		public bool �������� {get;set;}
		[DataMember]
		[ProtoMember(15)]
		public bool ���������� {get;set;}
		///<summary>
		///������������, ���������� ����
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public V82.�����������������.������������ ������� {get;set;}
		///<summary>
		///������ ������, ��������������� ���������� �����, ��� ������ � ������
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public decimal/*(10)*/ �������������� {get;set;}//������ ��������
		[DataMember]
		[ProtoMember(18)]
		public V82.�����������������.����������� ���������� {get;set;}
		[DataMember]
		[ProtoMember(19)]
		public V82.������������/*������*/.������������� ������������� {get;set;}//����������� ��
		[DataMember]
		[ProtoMember(20)]
		public decimal/*(3)*/ ������������� {get;set;}//����� ������ ��
		[DataMember]
		[ProtoMember(21)]
		public string/*(30)*/ ������������������������� {get;set;}//����� ��������� �����������
		[DataMember]
		[ProtoMember(22)]
		public string/*(150)*/ ������� {get;set;}//����� ��
		///<summary>
		///�������� �����
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public string/*(0)*/ �������� {get;set;}
		[DataMember]
		[ProtoMember(24)]
		public V82.�����������������.����������� ����������� {get;set;}
		[DataMember]
		[ProtoMember(25)]
		public V82.�����������������.������������ ������������� {get;set;}
		[DataMember]
		[ProtoMember(26)]
		public string/*(50)*/ ������������� {get;set;}//����������� ��
		[DataMember]
		[ProtoMember(27)]
		public bool ����������� {get;set;}//�������� ���
		[DataMember]
		[ProtoMember(28)]
		public string/*(50)*/ ������������ {get;set;}//���������� ��
		[DataMember]
		[ProtoMember(29)]
		public string/*(0)*/ ����������������� {get;set;}//������� ����������
		///<summary>
		///�������������� ���� � ����� �� ����� (� ������, ���� "��� �������� �����" - �� �����)
		///</summary>
		[DataMember]
		[ProtoMember(30)]
		public string/*(0)*/ ���������� {get;set;}//���� � �����
		///<summary>
		///������ �����
		///</summary>
		[DataMember]
		[ProtoMember(31)]
		public decimal/*(10)*/ ������ {get;set;}
		///<summary>
		///���������� ����� ������
		///</summary>
		[DataMember]
		[ProtoMember(32)]
		public string/*(10)*/ ���������� {get;set;}
		///<summary>
		///������������, �������� ���� ��� ��������������
		///</summary>
		[DataMember]
		[ProtoMember(33)]
		public V82.�����������������.������������ ����������� {get;set;}
		[DataMember]
		[ProtoMember(34)]
		public V82.�����������������.��������������������������� ������������ {get;set;}//���������� ��
		///<summary>
		///������ ���������� ������ - ��� �������� ������� ���������� ������
		///</summary>
		[DataMember]
		[ProtoMember(35)]
		public V82.������������/*������*/.����������������������������� ���������������������� {get;set;}//������ ���������� ������
		[DataMember]
		[ProtoMember(36)]
		public V82.������������/*������*/.��������� �������� {get;set;}//������ ��
		///<summary>
		///�����, ����������� �� ����� - ��� ��������������� ������
		///</summary>
		[DataMember]
		[ProtoMember(37)]
		public ����������������� �������������� {get;set;}//�����
		///<summary>
		///��� �������� ����� - � ���� ��� ����������������� ��� � �������� �� �����
		///</summary>
		[DataMember]
		[ProtoMember(38)]
		public V82.������������/*������*/.������������������ ���������������� {get;set;}//��� �������� �����
		[DataMember]
		[ProtoMember(39)]
		public V82.������������/*������*/.��������������������� ������������������� {get;set;}//��� �������� ������ ��
		///<summary>
		///������ �� ��� (� ������, ���� "��� �������� �����" - �� �����)
		///</summary>
		[DataMember]
		[ProtoMember(40)]
		public V82.�����������������.������������������ ��� {get;set;}
		[DataMember]
		[ProtoMember(41)]
		public string/*(36)*/ ������������ {get;set;}//���������� ��
		///<summary>
		///��������� ���� ��� ������ ������� � ���
		///</summary>
		[DataMember]
		[ProtoMember(42)]
		public ����������������� ������������� {get;set;}//���� ���������
		[DataMember]
		[ProtoMember(43)]
		public V82.�����������������.��������������������� ��������������������������� {get;set;}//����������� �������� ��������

		public V82.�����������������.���������������������  ��������������()
		{
			var ������ = new V82.�����������������.���������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.������������ = ������������;
			������.����� = �����;
			������.����� = �����;
			������.������������� = �������������;
			������.������������������������ = ������������������������;
			������.���������������������� = ����������������������;
			������.���������������������������� = ����������������������������;
			������.������������ = ������������;
			������.������������������������������ = ������������������������������;
			������.�������� = ��������;
			������.���������� = ����������;
			������.������� = �������;
			������.�������������� = ��������������;
			������.���������� = ����������;
			������.������������� = �������������;
			������.������������� = �������������;
			������.������������������������� = �������������������������;
			������.������� = �������;
			������.�������� = ��������;
			������.����������� = �����������;
			������.������������� = �������������;
			������.������������� = �������������;
			������.����������� = �����������;
			������.������������ = ������������;
			������.����������������� = �����������������;
			������.���������� = ����������;
			������.������ = ������;
			������.���������� = ����������;
			������.����������� = �����������;
			������.������������ = ������������;
			������.���������������������� = ����������������������;
			������.�������� = ��������;
			������.�������������� = ��������������;
			������.���������������� = ����������������;
			������.������������������� = �������������������;
			������.��� = ���;
			������.������������ = ������������;
			������.������������� = �������������;
			������.��������������������������� = ���������������������������;
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
