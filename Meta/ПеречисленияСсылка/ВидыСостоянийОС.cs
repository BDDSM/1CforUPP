
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ���������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		������������� = 0,//������� � �����
	///<summary>
	///(���)
	///</summary>
		�������������������� = 1,//������� � ������������
	///<summary>
	///(���)
	///</summary>
		��������������� = 2,
	///<summary>
	///(���)
	///</summary>
		����������� = 3,//����� � �����
	///<summary>
	///(���)
	///</summary>
		���� = 4,
	}
	public static partial class ���������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������������� = new Guid("0664b091-423b-50c0-48d8-20201e9a0d6a");//������� � �����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������������������� = new Guid("8e1e9caa-c0a5-9b61-45ca-01e9f2e141b7");//������� � ������������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������������� = new Guid("3f1958bb-18fb-48b8-4e30-0d14c28e4418");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����������� = new Guid("d368058a-8603-4615-45c2-a92177d49f31");//����� � �����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���� = new Guid("a198db80-a691-9430-4d61-73a7717a0fc4");
		public static ��������������� ��������(this ��������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������� ��������(this ��������������� ��������, Guid ������)
		{
			if(������ == �������������)
			{
				return ���������������.�������������;
			}
			else if(������ == ��������������������)
			{
				return ���������������.��������������������;
			}
			else if(������ == ���������������)
			{
				return ���������������.���������������;
			}
			else if(������ == �����������)
			{
				return ���������������.�����������;
			}
			else if(������ == ����)
			{
				return ���������������.����;
			}
			return ���������������.������������;
		}
		public static byte[] ����(this ��������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������� ��������)
		{
			switch (��������)
			{
				case ���������������.�������������: return �������������;
				case ���������������.��������������������: return ��������������������;
				case ���������������.���������������: return ���������������;
				case ���������������.�����������: return �����������;
				case ���������������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
