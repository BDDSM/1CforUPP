
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������������
	{
		������������ = - 1,
		SMTP = 0,
		POP3 = 1,
		HTTP = 2,
	}
	public static partial class ���������������������_��������//:������������������
	{
		public static readonly Guid SMTP = new Guid("98b8e788-fdee-6e55-4a5f-cd25d05dfce3");
		public static readonly Guid POP3 = new Guid("c51a95ae-da53-45b2-4585-6fd6048456b8");
		public static readonly Guid HTTP = new Guid("fb392ab2-14d6-5b25-4e6f-2460cf63c87f");
		public static ��������������������� ��������(this ��������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������� ��������(this ��������������������� ��������, Guid ������)
		{
			if(������ == SMTP)
			{
				return ���������������������.SMTP;
			}
			else if(������ == POP3)
			{
				return ���������������������.POP3;
			}
			else if(������ == HTTP)
			{
				return ���������������������.HTTP;
			}
			return ���������������������.������������;
		}
		public static byte[] ����(this ��������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������.SMTP: return SMTP;
				case ���������������������.POP3: return POP3;
				case ���������������������.HTTP: return HTTP;
			}
			return Guid.Empty;
		}
	}
}
