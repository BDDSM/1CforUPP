
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �����������
	{
		������������ = - 1,
	///<summary>
	///(���) ������� �����
	///</summary>
		������� = 0,
	///<summary>
	///(���) ���������
	///</summary>
		��������� = 1,
	///<summary>
	///(���) �������������������� �������� �����
	///</summary>
		��� = 2,
	}
	public static partial class �����������_��������//:������������������
	{
		///<summary>
		///(���) ������� �����
		///</summary>
		public static readonly Guid ������� = new Guid("a10187a1-e53c-dd39-422a-34f470b37882");
		///<summary>
		///(���) ���������
		///</summary>
		public static readonly Guid ��������� = new Guid("4750868c-fbe2-2021-4730-8b017fdc7b68");
		///<summary>
		///(���) �������������������� �������� �����
		///</summary>
		public static readonly Guid ��� = new Guid("61c79bb6-0f71-1761-4bb3-a2c06fee5b3d");
		public static ����������� ��������(this ����������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������� ��������(this ����������� ��������, Guid ������)
		{
			if(������ == �������)
			{
				return �����������.�������;
			}
			else if(������ == ���������)
			{
				return �����������.���������;
			}
			else if(������ == ���)
			{
				return �����������.���;
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
				case �����������.�������: return �������;
				case �����������.���������: return ���������;
				case �����������.���: return ���;
			}
			return Guid.Empty;
		}
	}
}
