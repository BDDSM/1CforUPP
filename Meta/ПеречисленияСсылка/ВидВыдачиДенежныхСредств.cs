
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ������������������������
	{
		������������ = - 1,
		�������� = 0,//����� ���
		��� = 1,
	}
	public static partial class ������������������������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("abfffe8a-80d3-92a1-4834-e8de1c4cb498");//����� ���
		public static readonly Guid ��� = new Guid("b57d6b97-19c1-bf77-40ed-e73c2c756df8");
		public static ������������������������ ��������(this ������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������ ��������(this ������������������������ ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return ������������������������.��������;
			}
			else if(������ == ���)
			{
				return ������������������������.���;
			}
			return ������������������������.������������;
		}
		public static byte[] ����(this ������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������.��������: return ��������;
				case ������������������������.���: return ���;
			}
			return Guid.Empty;
		}
	}
}
