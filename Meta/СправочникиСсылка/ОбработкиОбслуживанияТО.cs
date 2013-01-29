
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
	///������ ���������� �������� ��������� ������������ ��������� ������������.
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class �����������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("05c02b8c-8ef4-47d6-897c-c5d7c6aee567");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191737.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		///�������� �������� �������� ��������� ������������.
		///</summary>
		[DataMember]
		[ProtoMember(7)]
		public string/*(0)*/ �������� {get;set;}//�������� ��������� ������������
		///<summary>
		///��� ��������� ������������, ������������� ��������� ���������� ������������.
		///</summary>
		[DataMember]
		[ProtoMember(8)]
		public V82.������������/*������*/.������������������������� ��� {get;set;}//��� ��������� ������������
		///<summary>
		///��� ����� ��������� ������������.
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public string/*(256)*/ �������� {get;set;}//��� �����
		///<summary>
		///��������� ������������ ��������� ������������.
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public ����������������� ��������� {get;set;}//��������� ������������
		///<summary>
		///������ ��������� ������������.
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(10.2)*/ ������ {get;set;}
		///<summary>
		///���������� ������������� ��������� ������������.
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public string/*(36)*/ ������������� {get;set;}
		///<summary>
		///������ API ��������� ���������, ��������������� ���������� ������������.
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public decimal/*(10.2)*/ ������API {get;set;}//������ API

		public V82.�����������������.�����������������������  ��������������()
		{
			var ������ = new V82.�����������������.�����������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.�������� = ��������;
			������.��� = ���;
			������.�������� = ��������;
			������.��������� = ���������;
			������.������ = ������;
			������.������������� = �������������;
			������.������API = ������API;
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
