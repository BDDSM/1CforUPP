
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		���������� = 0,
	///<summary>
	///(���)
	///</summary>
		����������� = 1,
	///<summary>
	///(���)
	///</summary>
		������� = 2,
		�������������� = 3,//����������� ���
	}
	public static partial class �������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���������� = new Guid("671c8caf-a687-8d2e-4ec2-c4fc4dba4830");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����������� = new Guid("4ea369bf-f0c8-6fd2-408a-ad0bc661367d");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("d0ee6e91-4282-5687-4cb6-8b88eaa213a4");
		public static readonly Guid �������������� = new Guid("c1e92e8d-7b5f-8bdd-40ec-aa80c643ce52");//����������� ���
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == ����������)
			{
				return �������������������.����������;
			}
			else if(������ == �����������)
			{
				return �������������������.�����������;
			}
			else if(������ == �������)
			{
				return �������������������.�������;
			}
			else if(������ == ��������������)
			{
				return �������������������.��������������;
			}
			return �������������������.������������;
		}
		public static byte[] ����(this ������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������� ��������)
		{
			switch (��������)
			{
				case �������������������.����������: return ����������;
				case �������������������.�����������: return �����������;
				case �������������������.�������: return �������;
				case �������������������.��������������: return ��������������;
			}
			return Guid.Empty;
		}
	}
}
