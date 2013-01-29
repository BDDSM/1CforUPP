
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
	public partial class ��������������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("be04091e-2e71-4a2a-9dc2-912b8acc2caa");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191911.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*25*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public V82.�����������������.�������������� ������� {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public V82.�����������������.����������� ����������� {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.������������/*������*/.��������������������������� �������������� {get;set;}//��� �����������
		[DataMember]
		[ProtoMember(10)]
		public DateTime ���������������� {get;set;}//���� ������ ������
		[DataMember]
		[ProtoMember(11)]
		public DateTime ������������������� {get;set;}//���� ��������� ������
		[DataMember]
		[ProtoMember(12)]
		public V82.�����������������.�������������������������������� �������������������� {get;set;}//��������� �����������
		[DataMember]
		[ProtoMember(13)]
		public bool ����������������������� {get;set;}//����������� ������������
		[DataMember]
		[ProtoMember(14)]
		public string/*(50)*/ ����������� {get;set;}
		[DataMember]
		[ProtoMember(15)]
		public V82.������������/*������*/.���������������� ��� {get;set;}
		[DataMember]
		[ProtoMember(16)]
		public DateTime ������������ {get;set;}//���� ��������
		[DataMember]
		[ProtoMember(17)]
		public string/*(300)*/ ��������������������� {get;set;}//������������� ��������
		[DataMember]
		[ProtoMember(18)]
		public string/*(100)*/ ���������������� {get;set;}//����� �����������
		[DataMember]
		[ProtoMember(19)]
		public string/*(100)*/ ��������������� {get;set;}//������� ��������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public V82.�����������������.������������������������������� ����������� {get;set;}//��� ���������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public string/*(14)*/ ������������� {get;set;}//����� ���������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public string/*(14)*/ ������������� {get;set;}//����� ���������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public DateTime ������������������ {get;set;}//���� ������ ���������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public string/*(0)*/ ���������������� {get;set;}//��� ����� ��������
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(25)]
		public string/*(15)*/ ������������������������ {get;set;}//��� ������������� � ���������
		[DataMember]
		[ProtoMember(26)]
		public string/*(0)*/ ����������� {get;set;}

		public V82.�����������������.��������������������������  ��������������()
		{
			var ������ = new V82.�����������������.��������������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.������� = �������;
			������.����������� = �����������;
			������.�������������� = ��������������;
			������.���������������� = ����������������;
			������.������������������� = �������������������;
			������.�������������������� = ��������������������;
			������.����������������������� = �����������������������;
			������.����������� = �����������;
			������.��� = ���;
			������.������������ = ������������;
			������.��������������������� = ���������������������;
			������.���������������� = ����������������;
			������.��������������� = ���������������;
			������.����������� = �����������;
			������.������������� = �������������;
			������.������������� = �������������;
			������.������������������ = ������������������;
			������.���������������� = ����������������;
			������.������������������������ = ������������������������;
			������.����������� = �����������;
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
