
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �������������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		��������� = 0,
	///<summary>
	///(���)
	///</summary>
		�������� = 1,
	}
	public static partial class �������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������� = new Guid("9afe68ae-949b-3a12-48d9-fb915d435973");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������� = new Guid("e12ba4a8-d4ae-c2c2-4e02-09fce63c0913");
		public static ������������������������� ��������(this ������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������� ��������(this ������������������������� ��������, Guid ������)
		{
			if(������ == ���������)
			{
				return �������������������������.���������;
			}
			else if(������ == ��������)
			{
				return �������������������������.��������;
			}
			return �������������������������.������������;
		}
		public static byte[] ����(this ������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������� ��������)
		{
			switch (��������)
			{
				case �������������������������.���������: return ���������;
				case �������������������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
