
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ����������
	{
		������������ = - 1,
		�������� = 0,//�� �������� �������
		������ = 1,//�������� �������
		������������� = 2,//�������� ������� �������
	}
	public static partial class ����������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("d5a17db3-a8dc-ee16-4d91-9d80108f69bf");//�� �������� �������
		public static readonly Guid ������ = new Guid("32fe218b-1d90-b6d2-4cf7-de23d1fd1c36");//�������� �������
		public static readonly Guid ������������� = new Guid("a867f580-9418-4b00-4d06-d4adab765cc0");//�������� ������� �������
		public static ���������� ��������(this ���������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������� ��������(this ���������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return ����������.��������;
			}
			else if(������ == ������)
			{
				return ����������.������;
			}
			else if(������ == �������������)
			{
				return ����������.�������������;
			}
			return ����������.������������;
		}
		public static byte[] ����(this ���������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������� ��������)
		{
			switch (��������)
			{
				case ����������.��������: return ��������;
				case ����������.������: return ������;
				case ����������.�������������: return �������������;
			}
			return Guid.Empty;
		}
	}
}
