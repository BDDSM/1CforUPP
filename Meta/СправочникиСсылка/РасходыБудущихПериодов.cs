
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
	public partial class ����������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("9abae386-a9bc-4f8c-82fd-1a97a39f239f");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191944.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*11*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*100*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.������������/*������*/.������� ������ {get;set;}//��� ���
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public DateTime ������������������ {get;set;}//���� ������ ��������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public DateTime ��������������������� {get;set;}//���� ��������� ��������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.�����������������.�������������������� �������������������� {get;set;}//�������������� ������
		[DataMember]
		[ProtoMember(13)]
		public V82.�����������������.�������������������� ������������������� {get;set;}//������ �������������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public V82.�����������������.������������� ������������� {get;set;}
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public V82.�����������������.������������������������ ������������������������ {get;set;}//������������� �����������
		[DataMember]
		[ProtoMember(16)]
		public V82.�����������������.������������ ��������� {get;set;}
		[DataMember]
		[ProtoMember(17)]
		public V82.�����������������.����������������� �������������� {get;set;}//����� ���������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public V82.�����������������.������������ ������������ {get;set;}//������ ������
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public object ������ {get;set;}//���� ��
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public object ����������1 {get;set;}//�������� �� 1
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public object ����������2 {get;set;}//�������� �� 2
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public object ����������3 {get;set;}//�������� �� 3
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public object ������ {get;set;}//���� ��
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public object ����������1 {get;set;}//�������� �� 1
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(25)]
		public object ����������2 {get;set;}//�������� �� 2
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(26)]
		public object ����������3 {get;set;}//�������� �� 3
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(27)]
		public decimal/*(15.2)*/ ����� {get;set;}
		[DataMember]
		[ProtoMember(28)]
		public V82.�����������������.�������������������������� ����������������������� {get;set;}//�������������� ���������
		[DataMember]
		[ProtoMember(29)]
		public V82.������������/*������*/.������������������������ ����������������������� {get;set;}//������ ��������� ��������
		[DataMember]
		[ProtoMember(30)]
		public V82.�����������������.���������������������������������� ��������������������������������� {get;set;}//������ ������������� ������ �� ������
		[DataMember]
		[ProtoMember(31)]
		public V82.������������/*������*/.�������������������� ������������������� {get;set;}//������ �������������
		[DataMember]
		[ProtoMember(32)]
		public V82.������������/*������*/.����������������� ��������� {get;set;}//��� ������

		public V82.�����������������.����������������������  ��������������()
		{
			var ������ = new V82.�����������������.����������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��������� = ���������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.������ = ������;
			������.������������������ = ������������������;
			������.��������������������� = ���������������������;
			������.�������������������� = ��������������������;
			������.������������������� = �������������������;
			������.������������� = �������������;
			������.������������������������ = ������������������������;
			������.��������� = ���������;
			������.�������������� = ��������������;
			������.������������ = ������������;
			������.������ = ������;
			������.����������1 = ����������1;
			������.����������2 = ����������2;
			������.����������3 = ����������3;
			������.������ = ������;
			������.����������1 = ����������1;
			������.����������2 = ����������2;
			������.����������3 = ����������3;
			������.����� = �����;
			������.����������������������� = �����������������������;
			������.����������������������� = �����������������������;
			������.��������������������������������� = ���������������������������������;
			������.������������������� = �������������������;
			������.��������� = ���������;
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
