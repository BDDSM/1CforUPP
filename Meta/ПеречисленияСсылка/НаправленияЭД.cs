
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������������
	{
		������������ = - 1,
		�������� = 0,
		������������ = 1,//����� �������������
		��������� = 2,
	}
	public static partial class �������������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("35655ba6-a7f3-a268-4894-5fb1abef7262");
		public static readonly Guid ������������ = new Guid("9084308c-be3f-b01b-4826-bf9003ddc270");//����� �������������
		public static readonly Guid ��������� = new Guid("c073c6bb-6c7b-c36e-42bf-9020b68175ec");
		public static ������������� ��������(this ������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������� ��������(this ������������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return �������������.��������;
			}
			else if(������ == ������������)
			{
				return �������������.������������;
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
				case �������������.��������: return ��������;
				case �������������.������������: return ������������;
				case �������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
