
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������
	{
		������������ = - 1,
		��������� = 0,//� ��������
		��������� = 1,
		��������� = 2,
		�������� = 3,//�� ������
		���� = 4,
	}
	public static partial class ���������������_��������//:������������������
	{
		public static readonly Guid ��������� = new Guid("0c96eeb0-db97-8a50-442b-68b718207208");//� ��������
		public static readonly Guid ��������� = new Guid("53148fac-5c88-3d51-4c69-8185f10e893a");
		public static readonly Guid ��������� = new Guid("8df59491-2186-616d-4b98-3b1d75247242");
		public static readonly Guid �������� = new Guid("8e679097-26f4-d57d-4ee6-1ea052173c3b");//�� ������
		public static readonly Guid ���� = new Guid("66dafc9d-055c-7d9f-4cb0-181fe2d76814");
		public static ��������������� ��������(this ��������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������� ��������(this ��������������� ��������, Guid ������)
		{
			if(������ == ���������)
			{
				return ���������������.���������;
			}
			else if(������ == ���������)
			{
				return ���������������.���������;
			}
			else if(������ == ���������)
			{
				return ���������������.���������;
			}
			else if(������ == ��������)
			{
				return ���������������.��������;
			}
			else if(������ == ����)
			{
				return ���������������.����;
			}
			return ���������������.������������;
		}
		public static byte[] ����(this ��������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������� ��������)
		{
			switch (��������)
			{
				case ���������������.���������: return ���������;
				case ���������������.���������: return ���������;
				case ���������������.���������: return ���������;
				case ���������������.��������: return ��������;
				case ���������������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
