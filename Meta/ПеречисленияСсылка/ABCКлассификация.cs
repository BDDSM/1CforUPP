
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ABC�������������
	{
		������������ = - 1,
		A����� = 0,//A - �����
		B����� = 1,//B - �����
		C����� = 2,//C - �����
	}
	public static partial class ABC�������������_��������//:������������������
	{
		public static readonly Guid A����� = new Guid("3086dc81-621e-e183-4a8f-06560888700c");//A - �����
		public static readonly Guid B����� = new Guid("bec48db2-c370-bfe9-4d3e-cb639e4207b6");//B - �����
		public static readonly Guid C����� = new Guid("12686896-1993-98c3-4f55-d4cdbd0ffda8");//C - �����
		public static ABC������������� ��������(this ABC������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ABC������������� ��������(this ABC������������� ��������, Guid ������)
		{
			if(������ == A�����)
			{
				return ABC�������������.A�����;
			}
			else if(������ == B�����)
			{
				return ABC�������������.B�����;
			}
			else if(������ == C�����)
			{
				return ABC�������������.C�����;
			}
			return ABC�������������.������������;
		}
		public static byte[] ����(this ABC������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ABC������������� ��������)
		{
			switch (��������)
			{
				case ABC�������������.A�����: return A�����;
				case ABC�������������.B�����: return B�����;
				case ABC�������������.C�����: return C�����;
			}
			return Guid.Empty;
		}
	}
}
