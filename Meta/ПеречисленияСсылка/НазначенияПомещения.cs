
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������������������
	{
		������������ = - 1,
		����� = 0,
		������� = 1,
	}
	public static partial class �������������������_��������//:������������������
	{
		public static readonly Guid ����� = new Guid("647e5b9c-2fbf-d0ea-4204-4de3a7c618d5");
		public static readonly Guid ������� = new Guid("745b96af-1957-cce4-41f2-d4c9fc84c01b");
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return �������������������.�����;
			}
			else if(������ == �������)
			{
				return �������������������.�������;
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
				case �������������������.�����: return �����;
				case �������������������.�������: return �������;
			}
			return Guid.Empty;
		}
	}
}
