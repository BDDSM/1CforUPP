
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������������������
	{
		������������ = - 1,
		����� = 0,
		�������� = 1,
	}
	public static partial class �����������������������_��������//:������������������
	{
		public static readonly Guid ����� = new Guid("2bd6b3aa-ec80-4fb5-41db-c0b38a11f558");
		public static readonly Guid �������� = new Guid("6f541daf-93fd-081c-4dc0-25506cda7e53");
		public static ����������������������� ��������(this ����������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������������� ��������(this ����������������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return �����������������������.�����;
			}
			else if(������ == ��������)
			{
				return �����������������������.��������;
			}
			return �����������������������.������������;
		}
		public static byte[] ����(this ����������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������������� ��������)
		{
			switch (��������)
			{
				case �����������������������.�����: return �����;
				case �����������������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
