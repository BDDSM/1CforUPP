
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ����������������
	{
		������������ = - 1,
		������ = 0,
		�������� = 1,
	}
	public static partial class ����������������_��������//:������������������
	{
		public static readonly Guid ������ = new Guid("44cb1f9a-92b1-4d91-4d41-49378956a992");
		public static readonly Guid �������� = new Guid("8f7be684-3a93-37cb-497b-bbbe5b53842d");
		public static ���������������� ��������(this ���������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������� ��������(this ���������������� ��������, Guid ������)
		{
			if(������ == ������)
			{
				return ����������������.������;
			}
			else if(������ == ��������)
			{
				return ����������������.��������;
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
				case ����������������.������: return ������;
				case ����������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
