
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ��������������������
	{
		������������ = - 1,
		���������������� = 0,
		��������� = 1,
		��� = 2,//�� ������ ��
	}
	public static partial class ��������������������_��������//:������������������
	{
		public static readonly Guid ���������������� = new Guid("b775e8bc-317f-c8e0-4139-22ad4ba5fd6f");
		public static readonly Guid ��������� = new Guid("a5f5088a-1546-def0-4bc4-709134f86ba4");
		public static readonly Guid ��� = new Guid("d7a83aa4-3ae2-6749-4c28-7ae4d23ff084");//�� ������ ��
		public static �������������������� ��������(this �������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������������� ��������(this �������������������� ��������, Guid ������)
		{
			if(������ == ����������������)
			{
				return ��������������������.����������������;
			}
			else if(������ == ���������)
			{
				return ��������������������.���������;
			}
			else if(������ == ���)
			{
				return ��������������������.���;
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
				case ��������������������.����������������: return ����������������;
				case ��������������������.���������: return ���������;
				case ��������������������.���: return ���;
			}
			return Guid.Empty;
		}
	}
}
