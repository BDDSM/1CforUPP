
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���.)
		///</summary>
	public enum ���������������������
	{
		������������ = - 1,
		����� = 0,
		����� = 1,
	}
	public static partial class ���������������������_��������//:������������������
	{
		public static readonly Guid ����� = new Guid("c729ac80-2e21-605e-4e96-7e734984bbba");
		public static readonly Guid ����� = new Guid("896552b5-b9a7-b876-4aca-8d718320845c");
		public static ��������������������� ��������(this ��������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������� ��������(this ��������������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return ���������������������.�����;
			}
			else if(������ == �����)
			{
				return ���������������������.�����;
			}
			return ���������������������.������������;
		}
		public static byte[] ����(this ��������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������.�����: return �����;
				case ���������������������.�����: return �����;
			}
			return Guid.Empty;
		}
	}
}
