
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ���������
	{
		������������ = - 1,
	///<summary>
	///(���) ������ ��� 18%
	///</summary>
		���18 = 0,//18%
	///<summary>
	///(���) ��������� ������ ��� 18% / 118%
	///</summary>
		���18_118 = 1,//18% / 118%
	///<summary>
	///(���) ������ ��� 10%
	///</summary>
		���10 = 2,//10%
	///<summary>
	///(���) ��������� ������ ��� 10% / 110%
	///</summary>
		���10_110 = 3,//10% / 110%
	///<summary>
	///(���) ������ ��� 0%
	///</summary>
		���0 = 4,//0%
	///<summary>
	///(���)
	///</summary>
		������ = 5,//��� ���
	///<summary>
	///(���) ������ ��� 20%
	///</summary>
		���20 = 6,//20%
	///<summary>
	///(���) ��������� ������ ��� 20% / 120%
	///</summary>
		���20_120 = 7,//20% / 120%
	}
	public static partial class ���������_��������//:������������������
	{
		///<summary>
		///(���) ������ ��� 18%
		///</summary>
		public static readonly Guid ���18 = new Guid("50008596-83ba-8ec2-11d8-4680a2d43b82");//18%
		///<summary>
		///(���) ��������� ������ ��� 18% / 118%
		///</summary>
		public static readonly Guid ���18_118 = new Guid("50008596-83ba-8ec2-11d8-4680a2d43b83");//18% / 118%
		///<summary>
		///(���) ������ ��� 10%
		///</summary>
		public static readonly Guid ���10 = new Guid("b8b66d8f-a491-499d-4630-db1dd9b92c12");//10%
		///<summary>
		///(���) ��������� ������ ��� 10% / 110%
		///</summary>
		public static readonly Guid ���10_110 = new Guid("abf8cb89-0cde-a6ce-4965-6abdf86e7109");//10% / 110%
		///<summary>
		///(���) ������ ��� 0%
		///</summary>
		public static readonly Guid ���0 = new Guid("50008596-83ba-8ec2-11d8-6841836dca8b");//0%
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������ = new Guid("f06669a1-d53a-a613-4e42-52527a2c0e90");//��� ���
		///<summary>
		///(���) ������ ��� 20%
		///</summary>
		public static readonly Guid ���20 = new Guid("0fa5d8be-3267-eb88-400c-bbd4562b979b");//20%
		///<summary>
		///(���) ��������� ������ ��� 20% / 120%
		///</summary>
		public static readonly Guid ���20_120 = new Guid("bc8214b9-1663-9357-43b5-3e6d1f96d505");//20% / 120%
		public static ��������� ��������(this ��������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������� ��������(this ��������� ��������, Guid ������)
		{
			if(������ == ���18)
			{
				return ���������.���18;
			}
			else if(������ == ���18_118)
			{
				return ���������.���18_118;
			}
			else if(������ == ���10)
			{
				return ���������.���10;
			}
			else if(������ == ���10_110)
			{
				return ���������.���10_110;
			}
			else if(������ == ���0)
			{
				return ���������.���0;
			}
			else if(������ == ������)
			{
				return ���������.������;
			}
			else if(������ == ���20)
			{
				return ���������.���20;
			}
			else if(������ == ���20_120)
			{
				return ���������.���20_120;
			}
			return ���������.������������;
		}
		public static byte[] ����(this ��������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������� ��������)
		{
			switch (��������)
			{
				case ���������.���18: return ���18;
				case ���������.���18_118: return ���18_118;
				case ���������.���10: return ���10;
				case ���������.���10_110: return ���10_110;
				case ���������.���0: return ���0;
				case ���������.������: return ������;
				case ���������.���20: return ���20;
				case ���������.���20_120: return ���20_120;
			}
			return Guid.Empty;
		}
	}
}
