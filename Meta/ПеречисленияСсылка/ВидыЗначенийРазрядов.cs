
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ��������������������
	{
		������������ = - 1,
		��� = 0,
		������� = 1,
		�������� = 2,
	}
	public static partial class ��������������������_��������//:������������������
	{
		public static readonly Guid ��� = new Guid("135b0893-5dd0-ecf8-4ff8-5c6e7ef38d2a");
		public static readonly Guid ������� = new Guid("395a2cab-bd34-b799-449d-1c08738bd98a");
		public static readonly Guid �������� = new Guid("f74e48af-1981-5cb7-4f0d-267761af8c5b");
		public static �������������������� ��������(this �������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������������� ��������(this �������������������� ��������, Guid ������)
		{
			if(������ == ���)
			{
				return ��������������������.���;
			}
			else if(������ == �������)
			{
				return ��������������������.�������;
			}
			else if(������ == ��������)
			{
				return ��������������������.��������;
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
				case ��������������������.���: return ���;
				case ��������������������.�������: return �������;
				case ��������������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
