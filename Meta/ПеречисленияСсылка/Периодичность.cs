
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �������������
	{
		������������ = - 1,
		���� = 0,
		������ = 1,
		����� = 2,
		������� = 3,
		��� = 4,
		������ = 5,
		��������� = 6,
	}
	public static partial class �������������_��������//:������������������
	{
		public static readonly Guid ���� = new Guid("a9f87ca7-532a-cca0-460b-2a2a45bfa26a");
		public static readonly Guid ������ = new Guid("921397b1-7f1b-c393-4163-9eb3448e2ef1");
		public static readonly Guid ����� = new Guid("c0d4a4ae-4319-3159-4add-5854c56db50d");
		public static readonly Guid ������� = new Guid("85463fa5-7746-9855-4e8d-e262f2f7135d");
		public static readonly Guid ��� = new Guid("bd62e0a7-e0c8-1c2f-4c7e-9b44e4ee6590");
		public static readonly Guid ������ = new Guid("550f428c-7295-7220-4e75-a2f48c4e1b6b");
		public static readonly Guid ��������� = new Guid("55fede8e-fc2f-d18a-4f02-a3674f31faac");
		public static ������������� ��������(this ������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������� ��������(this ������������� ��������, Guid ������)
		{
			if(������ == ����)
			{
				return �������������.����;
			}
			else if(������ == ������)
			{
				return �������������.������;
			}
			else if(������ == �����)
			{
				return �������������.�����;
			}
			else if(������ == �������)
			{
				return �������������.�������;
			}
			else if(������ == ���)
			{
				return �������������.���;
			}
			else if(������ == ������)
			{
				return �������������.������;
			}
			else if(������ == ���������)
			{
				return �������������.���������;
			}
			return �������������.������������;
		}
		public static byte[] ����(this ������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������� ��������)
		{
			switch (��������)
			{
				case �������������.����: return ����;
				case �������������.������: return ������;
				case �������������.�����: return �����;
				case �������������.�������: return �������;
				case �������������.���: return ���;
				case �������������.������: return ������;
				case �������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
