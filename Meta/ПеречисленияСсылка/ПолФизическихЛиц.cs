
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
	///<summary>
	///(���)
	///</summary>
		������� = 0,
	///<summary>
	///(���)
	///</summary>
		������� = 1,
	}
	public static partial class ����������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("1f4b7fa6-2afa-25ce-4077-8e147f241253");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("f8114d92-bd68-e095-4c8f-aeea40a3ad5b");
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
				case ����������������.�������: return �������;
			}
			return Guid.Empty;
		}
	}
}
