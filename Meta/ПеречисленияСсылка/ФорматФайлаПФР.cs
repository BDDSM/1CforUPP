
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ��������������
	{
		������������ = - 1,
	///<summary>
	///������ 04.00
	///</summary>
		������04 = 0,//������ 04.00 (�����)
	///<summary>
	///������ 07.00
	///</summary>
		������07 = 1,//������ 07.00 (XML)
	}
	public static partial class ��������������_��������//:������������������
	{
		///<summary>
		///������ 04.00
		///</summary>
		public static readonly Guid ������04 = new Guid("ed241d99-8675-a38d-4e12-db77c079a0cb");//������ 04.00 (�����)
		///<summary>
		///������ 07.00
		///</summary>
		public static readonly Guid ������07 = new Guid("fec90482-58b1-df64-4a0c-ae4acc766935");//������ 07.00 (XML)
		public static �������������� ��������(this �������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������������� ��������(this �������������� ��������, Guid ������)
		{
			if(������ == ������04)
			{
				return ��������������.������04;
			}
			else if(������ == ������07)
			{
				return ��������������.������07;
			}
			return ��������������.������������;
		}
		public static byte[] ����(this �������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �������������� ��������)
		{
			switch (��������)
			{
				case ��������������.������04: return ������04;
				case ��������������.������07: return ������07;
			}
			return Guid.Empty;
		}
	}
}
