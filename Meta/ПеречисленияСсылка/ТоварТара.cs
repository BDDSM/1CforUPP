
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ���������
	{
		������������ = - 1,
	///<summary>
	///���������� � ���� ������ (��������� � ��������), ��������� � ���������
	///</summary>
		����� = 0,
	///<summary>
	///���������� ���� (����������� � ���������� � �����������)
	///</summary>
		���� = 1,
	}
	public static partial class ���������_��������//:������������������
	{
		///<summary>
		///���������� � ���� ������ (��������� � ��������), ��������� � ���������
		///</summary>
		public static readonly Guid ����� = new Guid("8bbfb193-33c4-314f-4ff6-645e18384a56");
		///<summary>
		///���������� ���� (����������� � ���������� � �����������)
		///</summary>
		public static readonly Guid ���� = new Guid("68b2e086-7609-144d-47ce-7fcf6ee57b0d");
		public static ��������� ��������(this ��������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������� ��������(this ��������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return ���������.�����;
			}
			else if(������ == ����)
			{
				return ���������.����;
			}
			return ���������.������������;
		}
		public static byte[] ����(this ��������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������� ��������)
		{
			switch (��������)
			{
				case ���������.�����: return �����;
				case ���������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
