
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������
	{
		������������ = - 1,
		��� = 0,
		�������� = 1,
	}
	public static partial class ���������_��������//:������������������
	{
		public static readonly Guid ��� = new Guid("86bce5ae-4291-f897-402a-e21c9836bf4d");
		public static readonly Guid �������� = new Guid("da2216a4-bb59-6fb6-43a8-76af73a5cfd7");
		public static ��������� ��������(this ��������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������� ��������(this ��������� ��������, Guid ������)
		{
			if(������ == ���)
			{
				return ���������.���;
			}
			else if(������ == ��������)
			{
				return ���������.��������;
			}
			return ���������.������������;
		}
		public static byte[] ����(this ��������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������� ��������)
		{
			switch (��������)
			{
				case ���������.���: return ���;
				case ���������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
