
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �����������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		������ = 0,
	///<summary>
	///(���)
	///</summary>
		��������� = 1,
	}
	public static partial class �����������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������ = new Guid("50fc4faa-4b89-b252-4e6c-cb6111ff4bdc");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������� = new Guid("652fc099-1f7e-1da7-4448-e926c0c7475e");
		public static ����������� ��������(this ����������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������� ��������(this ����������� ��������, Guid ������)
		{
			if(������ == ������)
			{
				return �����������.������;
			}
			else if(������ == ���������)
			{
				return �����������.���������;
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
				case �����������.������: return ������;
				case �����������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
