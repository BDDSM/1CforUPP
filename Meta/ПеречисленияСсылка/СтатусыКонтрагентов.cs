
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
		��������� = 1,
	///<summary>
	///(���)
	///</summary>
		������ = 2,
	}
	public static partial class �������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���������� = new Guid("823dcb9d-61c8-4178-44c5-e87ce099df13");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������� = new Guid("68355680-d1d2-00d1-4130-957e80f431b9");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������ = new Guid("f7f60eb1-9a03-b392-4ac8-0f24dd8f5e06");
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
			else if(������ == ���������)
			{
				return �������������������.���������;
			}
			else if(������ == ������)
			{
				return �������������������.������;
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
				case �������������������.���������: return ���������;
				case �������������������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
