
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
	public partial class ���������������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("01cfb766-298c-418c-809b-5e4319699d61");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191533.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*9*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*50*/ ������������ {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(7)]
		public string/*(0)*/ ����������� {get;set;}//������ ��������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(8)]
		public decimal/*(6.3)*/ �����������1 {get;set;}//������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public decimal/*(6.3)*/ �����������2 {get;set;}//�������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public decimal/*(6.3)*/ �����������3 {get;set;}//����
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(6.3)*/ �����������4 {get;set;}//������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public decimal/*(6.3)*/ �����������5 {get;set;}//���
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public decimal/*(6.3)*/ �����������6 {get;set;}//����
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public decimal/*(6.3)*/ �����������7 {get;set;}//����
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public decimal/*(6.3)*/ �����������8 {get;set;}//������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public decimal/*(6.3)*/ �����������9 {get;set;}//��������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public decimal/*(6.3)*/ �����������10 {get;set;}//�������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public decimal/*(6.3)*/ �����������11 {get;set;}//������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public decimal/*(6.3)*/ �����������12 {get;set;}//�������

		public V82.�����������������.���������������������������  ��������������()
		{
			var ������ = new V82.�����������������.���������������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.����������� = �����������;
			������.�����������1 = �����������1;
			������.�����������2 = �����������2;
			������.�����������3 = �����������3;
			������.�����������4 = �����������4;
			������.�����������5 = �����������5;
			������.�����������6 = �����������6;
			������.�����������7 = �����������7;
			������.�����������8 = �����������8;
			������.�����������9 = �����������9;
			������.�����������10 = �����������10;
			������.�����������11 = �����������11;
			������.�����������12 = �����������12;
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
