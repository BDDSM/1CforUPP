
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum �������������
	{
		������������ = - 1,
		����������� = 0,
		������������� = 1,//�� �����������
		�������������� = 2,
	}
	public static partial class �������������_��������//:������������������
	{
		public static readonly Guid ����������� = new Guid("a089c6b9-1b50-e21b-430a-90de52e18cff");
		public static readonly Guid ������������� = new Guid("a64d7bb1-0815-9af8-49f4-0476633bc00c");//�� �����������
		public static readonly Guid �������������� = new Guid("f813a0b8-23a4-b82c-4bdb-90631dd8919c");
		public static ������������� ��������(this ������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������� ��������(this ������������� ��������, Guid ������)
		{
			if(������ == �����������)
			{
				return �������������.�����������;
			}
			else if(������ == �������������)
			{
				return �������������.�������������;
			}
			else if(������ == ��������������)
			{
				return �������������.��������������;
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
				case �������������.�����������: return �����������;
				case �������������.�������������: return �������������;
				case �������������.��������������: return ��������������;
			}
			return Guid.Empty;
		}
	}
}
