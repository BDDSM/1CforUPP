
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ��������������
	{
		������������ = - 1,
		������� = 0,
		������� = 1,
	}
	public static partial class ��������������_��������//:������������������
	{
		public static readonly Guid ������� = new Guid("173358b8-80a0-a1a6-423f-dc0b23e68883");
		public static readonly Guid ������� = new Guid("37d3b886-4eff-bff4-430f-e6030b4ef259");
		public static �������������� ��������(this �������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������� ��������(this �������������� ��������, Guid ������)
		{
			if(������ == �������)
			{
				return ��������������.�������;
			}
			else if(������ == �������)
			{
				return ��������������.�������;
			}
			return ��������������.������������;
		}
		public static byte[] ����(this �������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �������������� ��������)
		{
			switch (��������)
			{
				case ��������������.�������: return �������;
				case ��������������.�������: return �������;
			}
			return Guid.Empty;
		}
	}
}
