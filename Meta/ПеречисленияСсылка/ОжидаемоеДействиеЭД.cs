
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������������������
	{
		������������ = - 1,
		����������� = 0,//�� ���������
		��������� = 1,
		��������� = 2,
		������������ = 3,
		��������� = 4,
	}
	public static partial class �������������������_��������//:������������������
	{
		public static readonly Guid ����������� = new Guid("db4d479e-9ac5-b762-4656-40c4005f54e9");//�� ���������
		public static readonly Guid ��������� = new Guid("018e4196-ea5b-dc6f-478c-9da8cfda35b5");
		public static readonly Guid ��������� = new Guid("9563ecbe-8227-9b17-4bba-b61b00c64f1e");
		public static readonly Guid ������������ = new Guid("21ed59bf-c7af-3498-4257-c718ee7733e1");
		public static readonly Guid ��������� = new Guid("503e0c84-1f9f-304f-4a03-a9146a683f04");
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == �����������)
			{
				return �������������������.�����������;
			}
			else if(������ == ���������)
			{
				return �������������������.���������;
			}
			else if(������ == ���������)
			{
				return �������������������.���������;
			}
			else if(������ == ������������)
			{
				return �������������������.������������;
			}
			else if(������ == ���������)
			{
				return �������������������.���������;
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
				case �������������������.�����������: return �����������;
				case �������������������.���������: return ���������;
				case �������������������.���������: return ���������;
				case �������������������.������������: return ������������;
				case �������������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
