
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ����������������������
	{
		������������ = - 1,
		��������� = 0,
		��������� = 1,
	}
	public static partial class ����������������������_��������//:������������������
	{
		public static readonly Guid ��������� = new Guid("e2c6a7b1-47fa-904a-4fb7-1e6770176b0f");
		public static readonly Guid ��������� = new Guid("879cfd85-95c3-24c6-4a19-0500111e19ef");
		public static ���������������������� ��������(this ���������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������������� ��������(this ���������������������� ��������, Guid ������)
		{
			if(������ == ���������)
			{
				return ����������������������.���������;
			}
			else if(������ == ���������)
			{
				return ����������������������.���������;
			}
			return ����������������������.������������;
		}
		public static byte[] ����(this ���������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������������� ��������)
		{
			switch (��������)
			{
				case ����������������������.���������: return ���������;
				case ����������������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
