
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ��������������������
	{
		������������ = - 1,
		����� = 0,
		������ = 1,
	}
	public static partial class ��������������������_��������//:������������������
	{
		public static readonly Guid ����� = new Guid("9b3b97af-d434-8c05-4099-301d0d66db10");
		public static readonly Guid ������ = new Guid("3d7a1b8d-c045-035c-40b8-2ef2fec65e4b");
		public static �������������������� ��������(this �������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������������� ��������(this �������������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return ��������������������.�����;
			}
			else if(������ == ������)
			{
				return ��������������������.������;
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
				case ��������������������.�����: return �����;
				case ��������������������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
