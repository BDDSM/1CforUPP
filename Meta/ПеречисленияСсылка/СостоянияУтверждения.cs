
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ��������������������
	{
		������������ = - 1,
		��������� = 0,
		����������� = 1,//�� ���������
		�������� = 2,
	}
	public static partial class ��������������������_��������//:������������������
	{
		public static readonly Guid ��������� = new Guid("8037a3bb-0b1b-7f88-4fd7-e0a0e9afd3ce");
		public static readonly Guid ����������� = new Guid("e9c3d59e-bdb4-dbd3-4a04-baccad43d4f2");//�� ���������
		public static readonly Guid �������� = new Guid("24b0c09b-4dc4-451c-45fa-033d2f4026ab");
		public static �������������������� ��������(this �������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������������� ��������(this �������������������� ��������, Guid ������)
		{
			if(������ == ���������)
			{
				return ��������������������.���������;
			}
			else if(������ == �����������)
			{
				return ��������������������.�����������;
			}
			else if(������ == ��������)
			{
				return ��������������������.��������;
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
				case ��������������������.���������: return ���������;
				case ��������������������.�����������: return �����������;
				case ��������������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
