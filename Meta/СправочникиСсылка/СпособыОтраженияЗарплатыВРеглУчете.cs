
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
	///(����)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ����������������������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("96d81af6-9a15-4c01-98e9-f1f64ad5031b");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191301.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*100*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public object ������ {get;set;}//���� ��
		[DataMember]
		[ProtoMember(9)]
		public object ����������1 {get;set;}//�������� �� ����� 1
		[DataMember]
		[ProtoMember(10)]
		public object ����������2 {get;set;}//�������� �� ����� 2
		[DataMember]
		[ProtoMember(11)]
		public object ����������3 {get;set;}//�������� �� ����� 3
		[DataMember]
		[ProtoMember(12)]
		public V82.�����������������.���������������������������������� ������������������������� {get;set;}//������ ������������� ������
		[DataMember]
		[ProtoMember(13)]
		public object ������ {get;set;}//���� ��
		[DataMember]
		[ProtoMember(14)]
		public object ����������1 {get;set;}//�������� �� ����� 1
		[DataMember]
		[ProtoMember(15)]
		public object ����������2 {get;set;}//�������� �� ����� 2
		[DataMember]
		[ProtoMember(16)]
		public object ����������3 {get;set;}//�������� �� ����� 3
		[DataMember]
		[ProtoMember(17)]
		public object �������� {get;set;}//���� ������ ���������� �����
		[DataMember]
		[ProtoMember(18)]
		public object ������������1 {get;set;}//�������� �� ���. ����� ����� 1
		[DataMember]
		[ProtoMember(19)]
		public object ������������2 {get;set;}//�������� �� ���. ����� ����� 2
		[DataMember]
		[ProtoMember(20)]
		public object ������������3 {get;set;}//�������� �� ���. ����� ����� 3
		[DataMember]
		[ProtoMember(21)]
		public object �������� {get;set;}//���� ������� ���������� �����
		[DataMember]
		[ProtoMember(22)]
		public object ������������1 {get;set;}//�������� �� ���. ����� ����� 1
		[DataMember]
		[ProtoMember(23)]
		public object ������������2 {get;set;}//�������� �� ���. ����� ����� 2
		[DataMember]
		[ProtoMember(24)]
		public object ������������3 {get;set;}//�������� �� ���. ����� ����� 3
		[DataMember]
		[ProtoMember(25)]
		public V82.������������/*������*/.������������� ������������� {get;set;}//��������� ����
		[DataMember]
		[ProtoMember(26)]
		public V82.�����������������.������������������������ ��������������� {get;set;}//������������� ��
		[DataMember]
		[ProtoMember(27)]
		public V82.�����������������.������������������������ ��������������� {get;set;}//������������� ��
		[DataMember]
		[ProtoMember(28)]
		public V82.������������/*������*/.�����������������������������255�� ��������������������������������255�� {get;set;}//��� ���������� ������ ����� �� ������255 ��

		public V82.�����������������.����������������������������������  ��������������()
		{
			var ������ = new V82.�����������������.����������������������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��������� = ���������;
			������.�������� = ��������;
			������.������������ = ������������;
			������.������ = ������;
			������.����������1 = ����������1;
			������.����������2 = ����������2;
			������.����������3 = ����������3;
			������.������������������������� = �������������������������;
			������.������ = ������;
			������.����������1 = ����������1;
			������.����������2 = ����������2;
			������.����������3 = ����������3;
			������.�������� = ��������;
			������.������������1 = ������������1;
			������.������������2 = ������������2;
			������.������������3 = ������������3;
			������.�������� = ��������;
			������.������������1 = ������������1;
			������.������������2 = ������������2;
			������.������������3 = ������������3;
			������.������������� = �������������;
			������.��������������� = ���������������;
			������.��������������� = ���������������;
			������.��������������������������������255�� = ��������������������������������255��;
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
