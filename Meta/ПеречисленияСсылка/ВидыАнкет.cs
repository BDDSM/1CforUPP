
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������
	{
		������������ = - 1,
		����� = 0,
		������������ = 1,
	}
	public static partial class ���������_��������//:������������������
	{
		public static readonly Guid ����� = new Guid("d92bd89f-7deb-708f-4332-b2826b7ca2ca");
		public static readonly Guid ������������ = new Guid("d0fd90ac-6747-703b-439f-c5f50ba86304");
		public static ��������� ��������(this ��������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������� ��������(this ��������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return ���������.�����;
			}
			else if(������ == ������������)
			{
				return ���������.������������;
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
				case ���������.�����: return �����;
				case ���������.������������: return ������������;
			}
			return Guid.Empty;
		}
	}
}
