
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ����������������
	{
		������������ = - 1,
		��������� = 0,
		������ = 1,
		���� = 2,
	}
	public static partial class ����������������_��������//:������������������
	{
		public static readonly Guid ��������� = new Guid("7c014684-175c-a47e-4fef-99c53a9ea153");
		public static readonly Guid ������ = new Guid("fc367b80-dd48-e49d-446c-88244ed263a3");
		public static readonly Guid ���� = new Guid("bc0bffb6-7030-bf58-4d45-fca5988a8782");
		public static ���������������� ��������(this ���������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������� ��������(this ���������������� ��������, Guid ������)
		{
			if(������ == ���������)
			{
				return ����������������.���������;
			}
			else if(������ == ������)
			{
				return ����������������.������;
			}
			else if(������ == ����)
			{
				return ����������������.����;
			}
			return ����������������.������������;
		}
		public static byte[] ����(this ���������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������� ��������)
		{
			switch (��������)
			{
				case ����������������.���������: return ���������;
				case ����������������.������: return ������;
				case ����������������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
