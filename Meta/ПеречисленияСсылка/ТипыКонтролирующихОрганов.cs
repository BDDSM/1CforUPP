
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������������������������
	{
		������������ = - 1,
		��� = 0,
		��� = 1,
		��� = 2,
		���� = 3,//�������
	}
	public static partial class �������������������������_��������//:������������������
	{
		public static readonly Guid ��� = new Guid("ee0888af-f5ae-9d5e-4861-897334a9057c");
		public static readonly Guid ��� = new Guid("3de14e9f-c189-409f-4375-f8f6742fde9a");
		public static readonly Guid ��� = new Guid("934cb6a9-e0e0-993d-4453-e75851b5abbe");
		public static readonly Guid ���� = new Guid("ec0f4598-054f-7d80-48be-359c3dfeb33c");//�������
		public static ������������������������� ��������(this ������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������� ��������(this ������������������������� ��������, Guid ������)
		{
			if(������ == ���)
			{
				return �������������������������.���;
			}
			else if(������ == ���)
			{
				return �������������������������.���;
			}
			else if(������ == ���)
			{
				return �������������������������.���;
			}
			else if(������ == ����)
			{
				return �������������������������.����;
			}
			return �������������������������.������������;
		}
		public static byte[] ����(this ������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������� ��������)
		{
			switch (��������)
			{
				case �������������������������.���: return ���;
				case �������������������������.���: return ���;
				case �������������������������.���: return ���;
				case �������������������������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
