
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������
	{
		������������ = - 1,
		������������ = 0,
		������ = 1,
		��� = 2,
		���������� = 3,//���. �������
		�� = 4,
		��� = 5,
		�������� = 6,
		������ = 7,//������ (������)
	///<summary>
	///��� �� ������������� ���������
	///</summary>
		��� = 8,//��� �� ������������� ���������
	}
	public static partial class ���������������_��������//:������������������
	{
		public static readonly Guid ������������ = new Guid("86c94ab3-8f2e-3420-495f-59ff7162cf3e");
		public static readonly Guid ������ = new Guid("50a44794-e8c4-b270-426f-857784855056");
		public static readonly Guid ��� = new Guid("f379708e-10fe-7c58-4f30-3a1a49bc1dc8");
		public static readonly Guid ���������� = new Guid("2943ffab-6023-262a-4888-af92bd039973");//���. �������
		public static readonly Guid �� = new Guid("44c992b3-1a6a-e335-4049-f355f4ea3485");
		public static readonly Guid ��� = new Guid("31c107b9-3042-96d2-40c7-9d5c14eca1e3");
		public static readonly Guid �������� = new Guid("4e19bf84-1ade-a5f2-4b66-9b74322c70b2");
		public static readonly Guid ������ = new Guid("5775849d-f812-fb1a-4b01-65b0adf993b0");//������ (������)
		///<summary>
		///��� �� ������������� ���������
		///</summary>
		public static readonly Guid ��� = new Guid("078034af-53f3-36ef-4cff-9a6024e0ed2d");//��� �� ������������� ���������
		public static ��������������� ��������(this ��������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������� ��������(this ��������������� ��������, Guid ������)
		{
			if(������ == ������������)
			{
				return ���������������.������������;
			}
			else if(������ == ������)
			{
				return ���������������.������;
			}
			else if(������ == ���)
			{
				return ���������������.���;
			}
			else if(������ == ����������)
			{
				return ���������������.����������;
			}
			else if(������ == ��)
			{
				return ���������������.��;
			}
			else if(������ == ���)
			{
				return ���������������.���;
			}
			else if(������ == ��������)
			{
				return ���������������.��������;
			}
			else if(������ == ������)
			{
				return ���������������.������;
			}
			else if(������ == ���)
			{
				return ���������������.���;
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
				case ���������������.������������: return ������������;
				case ���������������.������: return ������;
				case ���������������.���: return ���;
				case ���������������.����������: return ����������;
				case ���������������.��: return ��;
				case ���������������.���: return ���;
				case ���������������.��������: return ��������;
				case ���������������.������: return ������;
				case ���������������.���: return ���;
			}
			return Guid.Empty;
		}
	}
}
