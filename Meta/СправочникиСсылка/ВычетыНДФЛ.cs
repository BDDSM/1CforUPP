
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
	public partial class ����������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("66162784-3d30-4c15-8f2b-953a823b945c");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191417.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*7*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*150*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*(3)*/ ����������������2007 {get;set;}//��� ��� ���������� 2007 �.
		[DataMember]
		[ProtoMember(8)]
		public string/*(3)*/ ����������������2008 {get;set;}//��� ��� ���������� 2008 �.
		[DataMember]
		[ProtoMember(9)]
		public string/*(3)*/ ����������������2009 {get;set;}//��� ��� ���������� 2009 �.
		[DataMember]
		[ProtoMember(10)]
		public string/*(0)*/ ������������2007 {get;set;}//������������ 2007 �.
		[DataMember]
		[ProtoMember(11)]
		public string/*(0)*/ ������������2008 {get;set;}//������������ 2008 �.
		[DataMember]
		[ProtoMember(12)]
		public string/*(3)*/ ����������������2010 {get;set;}//��� ��� ���������� 2010 �.
		[DataMember]
		[ProtoMember(13)]
		public bool ����������������������������� {get;set;}//�� ��������������� ������������
		[DataMember]
		[ProtoMember(14)]
		public bool �����������������������2010 {get;set;}//�� ���������� � ����������-2010
		[DataMember]
		[ProtoMember(15)]
		public V82.������������/*������*/.������������������� ������������ {get;set;}//������ ������
		[DataMember]
		[ProtoMember(16)]
		public string/*(0)*/ ������������2010 {get;set;}//������������ 2010 �.
		[DataMember]
		[ProtoMember(17)]
		public string/*(3)*/ ����������������2011 {get;set;}//��� ��� ���������� 2011 �.

		public V82.�����������������.����������  ��������������()
		{
			var ������ = new V82.�����������������.����������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.����������������2007 = ����������������2007;
			������.����������������2008 = ����������������2008;
			������.����������������2009 = ����������������2009;
			������.������������2007 = ������������2007;
			������.������������2008 = ������������2008;
			������.����������������2010 = ����������������2010;
			������.����������������������������� = �����������������������������;
			������.�����������������������2010 = �����������������������2010;
			������.������������ = ������������;
			������.������������2010 = ������������2010;
			������.����������������2011 = ����������������2011;
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
