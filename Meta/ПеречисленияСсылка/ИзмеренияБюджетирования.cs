
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �����������������������
	{
		������������ = - 1,
		�������� = 0,
		��� = 1,
		������ = 2,
		������ = 3,
		���������� = 4,
		������������ = 5,
	}
	public static partial class �����������������������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("afde32b6-3cf3-d19c-4216-7e3a60644654");
		public static readonly Guid ��� = new Guid("5243a1aa-6a73-cc65-4bdf-36ba8df52e02");
		public static readonly Guid ������ = new Guid("dbd16b95-2d09-338d-4297-e2681ece4bad");
		public static readonly Guid ������ = new Guid("bcd27982-e41f-9891-4f57-423a3dffe1da");
		public static readonly Guid ���������� = new Guid("d4a46eb3-638a-edc1-47d7-b1a5905482c6");
		public static readonly Guid ������������ = new Guid("94da538b-bf25-a62d-47c7-bcbed8d57a44");
		public static ����������������������� ��������(this ����������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������������� ��������(this ����������������������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return �����������������������.��������;
			}
			else if(������ == ���)
			{
				return �����������������������.���;
			}
			else if(������ == ������)
			{
				return �����������������������.������;
			}
			else if(������ == ������)
			{
				return �����������������������.������;
			}
			else if(������ == ����������)
			{
				return �����������������������.����������;
			}
			else if(������ == ������������)
			{
				return �����������������������.������������;
			}
			return �����������������������.������������;
		}
		public static byte[] ����(this ����������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������������� ��������)
		{
			switch (��������)
			{
				case �����������������������.��������: return ��������;
				case �����������������������.���: return ���;
				case �����������������������.������: return ������;
				case �����������������������.������: return ������;
				case �����������������������.����������: return ����������;
				case �����������������������.������������: return ������������;
			}
			return Guid.Empty;
		}
	}
}
