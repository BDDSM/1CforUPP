
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������������
	{
		������������ = - 1,
		�������� = 0,
		��������� = 1,
	}
	public static partial class ������������������������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("6efaaaac-53c6-701b-4f08-3c023642a5f3");
		public static readonly Guid ��������� = new Guid("b08a0d97-d6b8-ed36-4ed8-c9beac5a6c99");
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
			else if(������ == ���������)
			{
				return ������������������������.���������;
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
				case ������������������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
