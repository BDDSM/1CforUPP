
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
	public partial class ������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("b895f316-ff2a-4e61-9aa3-b079ed364916");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221190855.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*11*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*150*/ ������������ {get;set;}
		///<summary>
		///����� - ������������, ��������� ������
		///</summary>
		[DataMember]
		[ProtoMember(7)]
		public V82.�����������������.������������ ����� {get;set;}
		///<summary>
		///���� ����������� ����� - ����������� � �������� (��������� �� �������� ������� ������� � �������� ����)
		///</summary>
		[DataMember]
		[ProtoMember(8)]
		public DateTime ���������������������������� {get;set;}//���� ����������� �������������
		///<summary>
		///���� �������� ������
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public DateTime ������������ {get;set;}//���� ��������
		///<summary>
		///���� ������ ����������
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public bool ���������� {get;set;}
		///<summary>
		///������ ������, ��������������� ���������� �����, ��� ������ � ������
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(10)*/ �������������� {get;set;}//������ ��������
		///<summary>
		///����������� � ������
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public string/*(0)*/ ����������� {get;set;}
		///<summary>
		///����� ������ ������
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public decimal/*(5)*/ ����������� {get;set;}//����� ������
		///<summary>
		///���� ������ �������� ���
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public bool ����������� {get;set;}//�������� ���
		///<summary>
		///������ ������������ (������ �� 256 ��������)
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public string/*(256)*/ ������������������ {get;set;}//������ ������������
		///<summary>
		///�������������� ���� � ����� �� ����� (� ������ ���� ���������������� - �� �����)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public string/*(0)*/ ���������� {get;set;}//���� � �����
		///<summary>
		///������ ����� ������
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public decimal/*(10)*/ ������ {get;set;}
		///<summary>
		///���������� ����� ������
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public string/*(10)*/ ���������� {get;set;}
		///<summary>
		///������������ ������ ��� ������ ������ - �������� ��������� ��������� ������
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public V82.�����������������.������������ ������������������ {get;set;}//������������ ������
		///<summary>
		///������ ���������� ������ - ��� �������� ������� ���������� ������
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public V82.������������/*������*/.����������������������������� ���������������������� {get;set;}//������ ���������� ������
		///<summary>
		///�����, ����������� �� ����� - ��� ��������������� ������
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public ����������������� �������������� {get;set;}//�����
		///<summary>
		///��� �������� ����� - � ���� ��� ����������������� ��� � �������� �� �����
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public V82.������������/*������*/.������������������ ���������������� {get;set;}//��� �������� �����
		///<summary>
		///������ �� ��� (� ������ ���� ���������������� - �� �����)
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public V82.�����������������.������������������ ��� {get;set;}
		///<summary>
		///���� ������
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public ����������������� ������������� {get;set;}//����

		public V82.�����������������.������������  ��������������()
		{
			var ������ = new V82.�����������������.������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.����� = �����;
			������.���������������������������� = ����������������������������;
			������.������������ = ������������;
			������.���������� = ����������;
			������.�������������� = ��������������;
			������.����������� = �����������;
			������.����������� = �����������;
			������.����������� = �����������;
			������.������������������ = ������������������;
			������.���������� = ����������;
			������.������ = ������;
			������.���������� = ����������;
			������.������������������ = ������������������;
			������.���������������������� = ����������������������;
			������.�������������� = ��������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������� = �������������;
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
