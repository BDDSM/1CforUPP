
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ������������
	{
		������������ = - 1,
		���������� = 0,
		������������ = 1,
		��������� = 2,
		����������� = 3,
	}
	public static partial class ������������_��������//:������������������
	{
		public static readonly Guid ���������� = new Guid("a2bc35a9-f657-bb60-43b0-c53a7ff9c8ea");
		public static readonly Guid ������������ = new Guid("062bd8a2-8705-dc03-4991-b64d10fd8ab3");
		public static readonly Guid ��������� = new Guid("74907088-d4bc-69dc-4d62-2345201e4f9f");
		public static readonly Guid ����������� = new Guid("d8cad490-4cc5-af07-407d-bc30bd244fcb");
		public static ������������ ��������(this ������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������ ��������(this ������������ ��������, Guid ������)
		{
			if(������ == ����������)
			{
				return ������������.����������;
			}
			else if(������ == ������������)
			{
				return ������������.������������;
			}
			else if(������ == ���������)
			{
				return ������������.���������;
			}
			else if(������ == �����������)
			{
				return ������������.�����������;
			}
			return ������������.������������;
		}
		public static byte[] ����(this ������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������ ��������)
		{
			switch (��������)
			{
				case ������������.����������: return ����������;
				case ������������.������������: return ������������;
				case ������������.���������: return ���������;
				case ������������.�����������: return �����������;
			}
			return Guid.Empty;
		}
	}
}
