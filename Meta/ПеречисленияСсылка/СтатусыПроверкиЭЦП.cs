
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ������������������
	{
		������������ = - 1,
		������� = 0,
		��������� = 1,//�� �������
	}
	public static partial class ������������������_��������//:������������������
	{
		public static readonly Guid ������� = new Guid("e7bae292-5503-36cd-4f87-53193bc9fd6a");
		public static readonly Guid ��������� = new Guid("e2e97580-381f-740b-4174-fa842e1a4dc8");//�� �������
		public static ������������������ ��������(this ������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������ ��������(this ������������������ ��������, Guid ������)
		{
			if(������ == �������)
			{
				return ������������������.�������;
			}
			else if(������ == ���������)
			{
				return ������������������.���������;
			}
			return ������������������.������������;
		}
		public static byte[] ����(this ������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������ ��������)
		{
			switch (��������)
			{
				case ������������������.�������: return �������;
				case ������������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
