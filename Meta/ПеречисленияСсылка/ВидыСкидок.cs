
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ����������
	{
		������������ = - 1,
		������� = 0,
		��������� = 1,
	}
	public static partial class ����������_��������//:������������������
	{
		public static readonly Guid ������� = new Guid("3043d496-19fe-a9cf-4dc3-54a0e56dacec");
		public static readonly Guid ��������� = new Guid("f0071482-dfe5-1475-4225-0ceca1a984f8");
		public static ���������� ��������(this ���������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������� ��������(this ���������� ��������, Guid ������)
		{
			if(������ == �������)
			{
				return ����������.�������;
			}
			else if(������ == ���������)
			{
				return ����������.���������;
			}
			return ����������.������������;
		}
		public static byte[] ����(this ���������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������� ��������)
		{
			switch (��������)
			{
				case ����������.�������: return �������;
				case ����������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
