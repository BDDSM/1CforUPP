
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ����������������
	{
		������������ = - 1,
		�������� = 0,
		��� = 1,//��������� ������ (����� ���)
		���� = 2,
	}
	public static partial class ����������������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("b0a37fbb-20ad-75a4-4930-3d2f1fd9acca");
		public static readonly Guid ��� = new Guid("4b6249a8-5993-57a0-4fce-980cd5f1b12d");//��������� ������ (����� ���)
		public static readonly Guid ���� = new Guid("df6c8581-55f5-6914-43e1-e133a3e08a86");
		public static ���������������� ��������(this ���������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������� ��������(this ���������������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return ����������������.��������;
			}
			else if(������ == ���)
			{
				return ����������������.���;
			}
			else if(������ == ����)
			{
				return ����������������.����;
			}
			return ����������������.������������;
		}
		public static byte[] ����(this ���������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������� ��������)
		{
			switch (��������)
			{
				case ����������������.��������: return ��������;
				case ����������������.���: return ���;
				case ����������������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
