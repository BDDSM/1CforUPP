
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������
	{
		������������ = - 1,
		�������� = 0,//��.
		���� = 1,//��.
	}
	public static partial class �����������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("71f5a694-9547-2d15-46fd-d4e175d6a533");//��.
		public static readonly Guid ���� = new Guid("4a0c6e92-9423-8c6d-439c-1ef8f4dcca98");//��.
		public static ����������� ��������(this ����������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������� ��������(this ����������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return �����������.��������;
			}
			else if(������ == ����)
			{
				return �����������.����;
			}
			return �����������.������������;
		}
		public static byte[] ����(this ����������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������� ��������)
		{
			switch (��������)
			{
				case �����������.��������: return ��������;
				case �����������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
