
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������������������
	{
		������������ = - 1,
		��������� = 0,
		������� = 1,
		������������� = 2,//�� �����������
	}
	public static partial class �������������������_��������//:������������������
	{
		public static readonly Guid ��������� = new Guid("bf65e096-dcbf-f58a-41c5-fdfc392e3a4f");
		public static readonly Guid ������� = new Guid("5f6f4e82-c001-cfe6-4896-a2799f210ed8");
		public static readonly Guid ������������� = new Guid("5d0db7a6-7624-3bec-4e5b-312d7309d3f3");//�� �����������
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == ���������)
			{
				return �������������������.���������;
			}
			else if(������ == �������)
			{
				return �������������������.�������;
			}
			else if(������ == �������������)
			{
				return �������������������.�������������;
			}
			return �������������������.������������;
		}
		public static byte[] ����(this ������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������� ��������)
		{
			switch (��������)
			{
				case �������������������.���������: return ���������;
				case �������������������.�������: return �������;
				case �������������������.�������������: return �������������;
			}
			return Guid.Empty;
		}
	}
}
