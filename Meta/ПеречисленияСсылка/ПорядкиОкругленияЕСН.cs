
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ��������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		����� = 0,//� ������������ ���������
	///<summary>
	///(���)
	///</summary>
		������� = 1,//� ������
	///<summary>
	///(���)
	///</summary>
		���������������� = 2,//� ������ � ��������
	}
	public static partial class ��������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����� = new Guid("1aff739b-a0f3-1350-4639-e0c4423da236");//� ������������ ���������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("a1e643ba-160d-44f5-4dd1-d0c9821934dc");//� ������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���������������� = new Guid("4d236180-5f30-babd-4832-c535eec4a2d2");//� ������ � ��������
		public static �������������������� ��������(this �������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������������� ��������(this �������������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return ��������������������.�����;
			}
			else if(������ == �������)
			{
				return ��������������������.�������;
			}
			else if(������ == ����������������)
			{
				return ��������������������.����������������;
			}
			return ��������������������.������������;
		}
		public static byte[] ����(this �������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �������������������� ��������)
		{
			switch (��������)
			{
				case ��������������������.�����: return �����;
				case ��������������������.�������: return �������;
				case ��������������������.����������������: return ����������������;
			}
			return Guid.Empty;
		}
	}
}
