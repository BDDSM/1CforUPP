
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		����� = 0,
	///<summary>
	///(���)
	///</summary>
		������� = 1,
	///<summary>
	///(���)
	///</summary>
		��������������������� = 2,//E-Mail
	///<summary>
	///(���)
	///</summary>
		����������� = 3,//���-��������
	///<summary>
	///(���)
	///</summary>
		������ = 4,
	}
	public static partial class ������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����� = new Guid("ccb3499c-a099-1f38-473f-31dd972971a9");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("27fda094-adbd-805c-41f1-22244cd904b6");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������������������� = new Guid("92fc80af-3430-edc1-41a8-3a7b79c1c3e0");//E-Mail
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����������� = new Guid("37c4648e-b19a-0773-4a06-8e4a6135332b");//���-��������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������ = new Guid("bd34d7bd-a45b-1394-455f-314a125ade40");
		public static ������������������������ ��������(this ������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������ ��������(this ������������������������ ��������, Guid ������)
		{
			if(������ == �����)
			{
				return ������������������������.�����;
			}
			else if(������ == �������)
			{
				return ������������������������.�������;
			}
			else if(������ == ���������������������)
			{
				return ������������������������.���������������������;
			}
			else if(������ == �����������)
			{
				return ������������������������.�����������;
			}
			else if(������ == ������)
			{
				return ������������������������.������;
			}
			return ������������������������.������������;
		}
		public static byte[] ����(this ������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������.�����: return �����;
				case ������������������������.�������: return �������;
				case ������������������������.���������������������: return ���������������������;
				case ������������������������.�����������: return �����������;
				case ������������������������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
