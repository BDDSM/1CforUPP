
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ���������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		������� = 0,//�� �����
	///<summary>
	///(���)
	///</summary>
		�������������� = 1,//� �������������
	}
	public static partial class ���������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("98d34b9d-7b3d-b5ac-4327-b1a74ae21c5b");//�� �����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������������� = new Guid("3c377c81-6e3c-25d4-4a42-c45869d5e9a5");//� �������������
		public static ��������������������� ��������(this ��������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������� ��������(this ��������������������� ��������, Guid ������)
		{
			if(������ == �������)
			{
				return ���������������������.�������;
			}
			else if(������ == ��������������)
			{
				return ���������������������.��������������;
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
				case ���������������������.�������: return �������;
				case ���������������������.��������������: return ��������������;
			}
			return Guid.Empty;
		}
	}
}
