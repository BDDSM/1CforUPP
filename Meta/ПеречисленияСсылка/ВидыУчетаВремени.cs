
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
	///<summary>
	///(���)
	///</summary>
		������ = 0,//�� ����
	///<summary>
	///(���)
	///</summary>
		������� = 1,//�� �����
	///<summary>
	///(���)
	///</summary>
		��������������� = 2,//�� �������� �����
	///<summary>
	///(���)
	///</summary>
		������������� = 3,//�� ������ �����
	}
	public static partial class ����������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������ = new Guid("433d7cab-2dff-6af3-4a1c-20ec3dd28f7c");//�� ����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("e73ba092-f886-b837-4e0e-4debc6de75c8");//�� �����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������������� = new Guid("2de4089e-5b9e-9d13-4233-eebd2f39ba76");//�� �������� �����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������������� = new Guid("6b6ca0a4-f46e-69f4-4714-51923cead926");//�� ������ �����
		public static ���������������� ��������(this ���������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������� ��������(this ���������������� ��������, Guid ������)
		{
			if(������ == ������)
			{
				return ����������������.������;
			}
			else if(������ == �������)
			{
				return ����������������.�������;
			}
			else if(������ == ���������������)
			{
				return ����������������.���������������;
			}
			else if(������ == �������������)
			{
				return ����������������.�������������;
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
				case ����������������.������: return ������;
				case ����������������.�������: return �������;
				case ����������������.���������������: return ���������������;
				case ����������������.�������������: return �������������;
			}
			return Guid.Empty;
		}
	}
}
