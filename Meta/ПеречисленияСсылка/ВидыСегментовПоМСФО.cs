
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
		������������ = 0,
		���������� = 1,
	}
	public static partial class �������������������_��������//:������������������
	{
		public static readonly Guid ������������ = new Guid("e4c89fac-9077-7941-4244-d452afb47dc8");
		public static readonly Guid ���������� = new Guid("840a1491-3f92-406d-4e29-5e16e3af26ab");
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == ������������)
			{
				return �������������������.������������;
			}
			else if(������ == ����������)
			{
				return �������������������.����������;
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
				case �������������������.������������: return ������������;
				case �������������������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
