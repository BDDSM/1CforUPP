
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������
	{
		������������ = - 1,
		���2 = 0,//���-2
		���3 = 1,//���-3
	}
	public static partial class �������_��������//:������������������
	{
		public static readonly Guid ���2 = new Guid("30756aad-fd27-0203-40ad-c7ec15adacfe");//���-2
		public static readonly Guid ���3 = new Guid("f003fd8e-28c6-2cb4-4626-32ac2ac44ea9");//���-3
		public static ������� ��������(this ������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������� ��������(this ������� ��������, Guid ������)
		{
			if(������ == ���2)
			{
				return �������.���2;
			}
			else if(������ == ���3)
			{
				return �������.���3;
			}
			return �������.������������;
		}
		public static byte[] ����(this ������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������� ��������)
		{
			switch (��������)
			{
				case �������.���2: return ���2;
				case �������.���3: return ���3;
			}
			return Guid.Empty;
		}
	}
}
