
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///���� �������������: �����������, ������������
		///</summary>
	public enum �����������������
	{
		������������ = - 1,
	///<summary>
	///�����������
	///</summary>
		����������� = 0,
	///<summary>
	///������������
	///</summary>
		������������ = 1,
	}
	public static partial class �����������������_��������//:������������������
	{
		///<summary>
		///�����������
		///</summary>
		public static readonly Guid ����������� = new Guid("e9a92b8c-7e3c-ef7f-4216-a3e4eabde08b");
		///<summary>
		///������������
		///</summary>
		public static readonly Guid ������������ = new Guid("ebf89cb0-9714-a0ba-4414-d0d74b211015");
		public static ����������������� ��������(this ����������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������� ��������(this ����������������� ��������, Guid ������)
		{
			if(������ == �����������)
			{
				return �����������������.�����������;
			}
			else if(������ == ������������)
			{
				return �����������������.������������;
			}
			return �����������������.������������;
		}
		public static byte[] ����(this ����������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������� ��������)
		{
			switch (��������)
			{
				case �����������������.�����������: return �����������;
				case �����������������.������������: return ������������;
			}
			return Guid.Empty;
		}
	}
}
