
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ����������������
	{
		������������ = - 1,
		�������� = 0,
		������������ = 1,//������ � �����
		������ = 2,
	}
	public static partial class ����������������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("fb2bcfab-323c-275e-473d-cdec801ac213");
		public static readonly Guid ������������ = new Guid("c23380ba-95ef-41c3-47a1-3abe766269dc");//������ � �����
		public static readonly Guid ������ = new Guid("504591ad-560c-a64c-4dc9-a7aa8b0453e4");
		public static ���������������� ��������(this ���������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������� ��������(this ���������������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return ����������������.��������;
			}
			else if(������ == ������������)
			{
				return ����������������.������������;
			}
			else if(������ == ������)
			{
				return ����������������.������;
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
				case ����������������.��������: return ��������;
				case ����������������.������������: return ������������;
				case ����������������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
