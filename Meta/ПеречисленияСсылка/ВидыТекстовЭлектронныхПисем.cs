
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������������������
	{
		������������ = - 1,
		HTML = 0,
		����� = 1,//������� �����
		������ = 2,
		HTML����������� = 3,//HTML � ����������
	}
	public static partial class ���������������������������_��������//:������������������
	{
		public static readonly Guid HTML = new Guid("908e1c80-5002-09d3-4530-c2a1286e20e8");
		public static readonly Guid ����� = new Guid("257a76a1-e6f5-4561-46d6-af808186d7b5");//������� �����
		public static readonly Guid ������ = new Guid("e3d508bd-386a-0f58-48db-628a9f02ff83");
		public static readonly Guid HTML����������� = new Guid("bfedb6aa-8341-cdf3-4e1f-11b95b11992f");//HTML � ����������
		public static ��������������������������� ��������(this ��������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������� ��������(this ��������������������������� ��������, Guid ������)
		{
			if(������ == HTML)
			{
				return ���������������������������.HTML;
			}
			else if(������ == �����)
			{
				return ���������������������������.�����;
			}
			else if(������ == ������)
			{
				return ���������������������������.������;
			}
			else if(������ == HTML�����������)
			{
				return ���������������������������.HTML�����������;
			}
			return ���������������������������.������������;
		}
		public static byte[] ����(this ��������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������������.HTML: return HTML;
				case ���������������������������.�����: return �����;
				case ���������������������������.������: return ������;
				case ���������������������������.HTML�����������: return HTML�����������;
			}
			return Guid.Empty;
		}
	}
}
