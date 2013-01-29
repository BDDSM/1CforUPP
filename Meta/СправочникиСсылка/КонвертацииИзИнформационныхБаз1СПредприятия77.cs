
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
	///����������� �� �������������� ��� 1�:�����������
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ������������������������������1������������77:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("79589a37-9879-48a2-a789-c94c3cd18325");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191824.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*(50)*/ ������������������������� {get;set;}//������������� ������������
		[DataMember]
		[ProtoMember(8)]
		public string/*(0)*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public string/*(8)*/ ����������� {get;set;}//����� ������
		[DataMember]
		[ProtoMember(10)]
		public string/*(10)*/ ������������������� {get;set;}//�������� ��������
		[DataMember]
		[ProtoMember(11)]
		public string/*(10)*/ �������������������� {get;set;}//��������� ��������
		[DataMember]
		[ProtoMember(12)]
		public string/*(10)*/ ������������������ {get;set;}//������� ��������
		[DataMember]
		[ProtoMember(13)]
		public ����������������� ����������������� {get;set;}//��������� ���������
		[DataMember]
		[ProtoMember(14)]
		public ����������������� �������������������������� {get;set;}//��������� �������� ���������
		[DataMember]
		[ProtoMember(15)]
		public ����������������� ������������������ {get;set;}//��������� ��������� ��������
		[DataMember]
		[ProtoMember(16)]
		public ����������������� ���������������� {get;set;}//��������� ������ ��������
		[DataMember]
		[ProtoMember(17)]
		public string/*(256)*/ ��������������������� {get;set;}//������������� ��������

		public V82.�����������������.������������������������������1������������77  ��������������()
		{
			var ������ = new V82.�����������������.������������������������������1������������77();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��� = ���;
			������.������������ = ������������;
			������.������������������������� = �������������������������;
			������.������������ = ������������;
			������.����������� = �����������;
			������.������������������� = �������������������;
			������.�������������������� = ��������������������;
			������.������������������ = ������������������;
			������.����������������� = �����������������;
			������.�������������������������� = ��������������������������;
			������.������������������ = ������������������;
			������.���������������� = ����������������;
			������.��������������������� = ���������������������;
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
