
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������������������
	{
		������������ = - 1,
		������ = 0,
		���� = 1,
		������������ = 2,
	}
	public static partial class �������������������_��������//:������������������
	{
		public static readonly Guid ������ = new Guid("7304ffa7-59c4-3105-4296-922983a08316");
		public static readonly Guid ���� = new Guid("97cf0080-ed1d-15bb-44ba-62b9fe2d95bc");
		public static readonly Guid ������������ = new Guid("ecb98b82-bf4a-7a47-493b-8466f6ea32e0");
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == ������)
			{
				return �������������������.������;
			}
			else if(������ == ����)
			{
				return �������������������.����;
			}
			else if(������ == ������������)
			{
				return �������������������.������������;
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
				case �������������������.������: return ������;
				case �������������������.����: return ����;
				case �������������������.������������: return ������������;
			}
			return Guid.Empty;
		}
	}
}
