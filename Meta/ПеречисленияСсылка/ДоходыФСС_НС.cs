
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ���������_��
	{
		������������ = - 1,
		���������� = 0,
		������������ = 1,//�� ����������
	}
	public static partial class ���������_��_��������//:������������������
	{
		public static readonly Guid ���������� = new Guid("612c6f80-aa42-0aff-49bb-0576a760fa20");
		public static readonly Guid ������������ = new Guid("000899ae-9d42-f7e4-43cd-3fd00960827d");//�� ����������
		public static ���������_�� ��������(this ���������_�� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������_�� ��������(this ���������_�� ��������, Guid ������)
		{
			if(������ == ����������)
			{
				return ���������_��.����������;
			}
			else if(������ == ������������)
			{
				return ���������_��.������������;
			}
			return ���������_��.������������;
		}
		public static byte[] ����(this ���������_�� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������_�� ��������)
		{
			switch (��������)
			{
				case ���������_��.����������: return ����������;
				case ���������_��.������������: return ������������;
			}
			return Guid.Empty;
		}
	}
}
