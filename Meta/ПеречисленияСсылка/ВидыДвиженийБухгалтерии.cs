
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �����������������������
	{
		������������ = - 1,
		����� = 0,
		������ = 1,
	}
	public static partial class �����������������������_��������//:������������������
	{
		public static readonly Guid ����� = new Guid("3fd27ab6-071e-4af5-4000-3bb44f9fbfea");
		public static readonly Guid ������ = new Guid("1b847c97-2a16-d8a2-4ab5-09cafdcefb80");
		public static ����������������������� ��������(this ����������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������������� ��������(this ����������������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return �����������������������.�����;
			}
			else if(������ == ������)
			{
				return �����������������������.������;
			}
			return �����������������������.������������;
		}
		public static byte[] ����(this ����������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������������� ��������)
		{
			switch (��������)
			{
				case �����������������������.�����: return �����;
				case �����������������������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
