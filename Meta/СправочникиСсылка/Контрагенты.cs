
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
	public partial class �����������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("946bc5df-4474-4748-88c8-6475a2a3d688");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191631.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*9*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*100*/ ������������ {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public string/*(0)*/ ������������������ {get;set;}//������ ������������
		///<summary>
		///(���) ����� �������������� ����������
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(0)*/ ����������� {get;set;}
		///<summary>
		///(���) �������������� ��������
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public string/*(0)*/ ���������������������� {get;set;}//�������������� ��������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.�����������������.����������� ������������������ {get;set;}//�������� ����������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public V82.�����������������.������������������������������������������ ������������������������������ {get;set;}//�������� ���������� ��� ���������
		///<summary>
		///(����) 
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public string/*(10)*/ ��������� {get;set;}//��� �� ����
		///<summary>
		///(����) ����������������� ����� �����������������
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public string/*(12)*/ ��� {get;set;}
		///<summary>
		///(����) ����������������� ����� �����������������
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public string/*(9)*/ ��� {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public V82.������������/*������*/.��������� ��������� {get;set;}//��. / ���. ����
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public V82.�����������������.��������������� ���������������������� {get;set;}//�������� ���������� ����
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public V82.�����������������.�������������������� �������������������������� {get;set;}//�������� ������� �����������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public V82.�����������������.���������������������������� ����������������������� {get;set;}//�������� ��� ������������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public string/*(0)*/ ������������������������������ {get;set;}//��������, �������������� ��������
		///<summary>
		///(���) �������� ��������
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public V82.�����������������.������������ �������������������������� {get;set;}//�������� �������� ����������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public bool ���������� {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public bool ��������� {get;set;}
		///<summary>
		///(���) ���������� ������ �������
		///</summary>
		[DataMember]
		[ProtoMember(25)]
		public string/*(0)*/ ����������������������� {get;set;}//���������� ������ �������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(26)]
		public decimal/*(3)*/ ������������������������������� {get;set;}//���� ���������� ������ ����������� (� ����)
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(27)]
		public V82.�����������������.�������������������������� ���������������������� {get;set;}//�������� ���������� ����
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(28)]
		public bool �������������������� {get;set;}//�� �������� ����������
		[DataMember]
		[ProtoMember(29)]
		public V82.�����������������.������������������ ����� {get;set;}
		[DataMember]
		[ProtoMember(30)]
		public V82.�����������������.������� ������ {get;set;}
		[DataMember]
		[ProtoMember(31)]
		public V82.�����������������.������������������������� ������������������������ {get;set;}//������ ������� �����������

		public V82.�����������������.�����������  ��������������()
		{
			var ������ = new V82.�����������������.�����������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��������� = ���������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.������������������ = ������������������;
			������.����������� = �����������;
			������.���������������������� = ����������������������;
			������.������������������ = ������������������;
			������.������������������������������ = ������������������������������;
			������.��������� = ���������;
			������.��� = ���;
			������.��� = ���;
			������.��������� = ���������;
			������.���������������������� = ����������������������;
			������.�������������������������� = ��������������������������;
			������.����������������������� = �����������������������;
			������.������������������������������ = ������������������������������;
			������.�������������������������� = ��������������������������;
			������.���������� = ����������;
			������.��������� = ���������;
			������.����������������������� = �����������������������;
			������.������������������������������� = �������������������������������;
			������.���������������������� = ����������������������;
			������.�������������������� = ��������������������;
			������.����� = �����;
			������.������ = ������;
			������.������������������������ = ������������������������;
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
