
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ����������������
	{
		������������ = - 1,
		������� = 0,
		������������ = 1,
		������� = 2,
	}
	public static partial class ����������������_��������//:������������������
	{
		public static readonly Guid ������� = new Guid("c32120b9-1847-24e3-4dae-c4ef3bf8ab60");
		public static readonly Guid ������������ = new Guid("b8ffd2ba-88ff-bedc-4ac0-cf9735909411");
		public static readonly Guid ������� = new Guid("a9d27db6-b621-c54b-4bdd-7cb093a0963d");
		public static ���������������� ��������(this ���������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������� ��������(this ���������������� ��������, Guid ������)
		{
			if(������ == �������)
			{
				return ����������������.�������;
			}
			else if(������ == ������������)
			{
				return ����������������.������������;
			}
			else if(������ == �������)
			{
				return ����������������.�������;
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
				case ����������������.�������: return �������;
				case ����������������.������������: return ������������;
				case ����������������.�������: return �������;
			}
			return Guid.Empty;
		}
	}
}
