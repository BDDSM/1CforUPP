
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///��������� ��
		///</summary>
	public enum �����������
	{
		������������ = - 1,
	///<summary>
	///������� � �����
	///</summary>
		������������� = 0,//������� � �����
	///<summary>
	///������� � ������������
	///</summary>
		�������������������� = 1,//������� � ������������
	///<summary>
	///����� � �����
	///</summary>
		����������� = 2,//����� � �����
	}
	public static partial class �����������_��������//:������������������
	{
		///<summary>
		///������� � �����
		///</summary>
		public static readonly Guid ������������� = new Guid("0da2e599-9dfe-06a9-4031-74c602c21c5a");//������� � �����
		///<summary>
		///������� � ������������
		///</summary>
		public static readonly Guid �������������������� = new Guid("467f0595-a71d-7eb5-43bd-39526568c56a");//������� � ������������
		///<summary>
		///����� � �����
		///</summary>
		public static readonly Guid ����������� = new Guid("13f42abe-aeff-24c7-4ed5-b4b1e4d0ced6");//����� � �����
		public static ����������� ��������(this ����������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������� ��������(this ����������� ��������, Guid ������)
		{
			if(������ == �������������)
			{
				return �����������.�������������;
			}
			else if(������ == ��������������������)
			{
				return �����������.��������������������;
			}
			else if(������ == �����������)
			{
				return �����������.�����������;
			}
			return �����������.������������;
		}
		public static byte[] ����(this ����������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������� ��������)
		{
			switch (��������)
			{
				case �����������.�������������: return �������������;
				case �����������.��������������������: return ��������������������;
				case �����������.�����������: return �����������;
			}
			return Guid.Empty;
		}
	}
}
