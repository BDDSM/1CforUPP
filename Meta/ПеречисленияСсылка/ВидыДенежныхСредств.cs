
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �������������������
	{
		������������ = - 1,
		�������� = 0,
		����������� = 1,
	}
	public static partial class �������������������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("74ff2eb2-0c25-6375-4852-f580c4a92552");
		public static readonly Guid ����������� = new Guid("8446c6b7-7b13-add0-40d7-4997770c5ff4");
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return �������������������.��������;
			}
			else if(������ == �����������)
			{
				return �������������������.�����������;
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
				case �������������������.��������: return ��������;
				case �������������������.�����������: return �����������;
			}
			return Guid.Empty;
		}
	}
}
