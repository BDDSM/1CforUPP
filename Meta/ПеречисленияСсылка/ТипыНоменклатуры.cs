
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ����������������
	{
		������������ = - 1,
		����� = 0,
		������ = 1,
		����� = 2,//�����-�����
		�������� = 3,//�����-��������
	}
	public static partial class ����������������_��������//:������������������
	{
		public static readonly Guid ����� = new Guid("5061ae9f-04d2-6e4e-4e79-2b61e30f755b");
		public static readonly Guid ������ = new Guid("7fa6f5b4-8f04-db61-46d9-86307cf04a0c");
		public static readonly Guid ����� = new Guid("792bcbba-0fb1-7b02-4d62-3097cba7b276");//�����-�����
		public static readonly Guid �������� = new Guid("a5e61c97-36d5-c4ea-4ba7-0ee7fbd5b16b");//�����-��������
		public static ���������������� ��������(this ���������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������� ��������(this ���������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return ����������������.�����;
			}
			else if(������ == ������)
			{
				return ����������������.������;
			}
			else if(������ == �����)
			{
				return ����������������.�����;
			}
			else if(������ == ��������)
			{
				return ����������������.��������;
			}
			return ����������������.������������;
		}
		public static byte[] ����(this ���������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������� ��������)
		{
			switch (��������)
			{
				case ����������������.�����: return �����;
				case ����������������.������: return ������;
				case ����������������.�����: return �����;
				case ����������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
