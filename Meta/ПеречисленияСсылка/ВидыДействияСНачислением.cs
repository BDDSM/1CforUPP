
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		������ = 0,
	///<summary>
	///(���)
	///</summary>
		�������� = 1,
	///<summary>
	///(���)
	///</summary>
		���������� = 2,//�� ��������
	///<summary>
	///(���)
	///</summary>
		���������� = 3,
	}
	public static partial class ������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������ = new Guid("7604bbaa-7683-f6fa-468b-4b7ca17977fc");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������� = new Guid("a1dd4884-e072-b1a8-48d8-d019b9c2a3c9");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���������� = new Guid("f58a8a84-520d-1490-4c31-10899ddf0807");//�� ��������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���������� = new Guid("92381a9c-c221-121b-486c-0090ec0d0d14");
		public static ������������������������ ��������(this ������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������ ��������(this ������������������������ ��������, Guid ������)
		{
			if(������ == ������)
			{
				return ������������������������.������;
			}
			else if(������ == ��������)
			{
				return ������������������������.��������;
			}
			else if(������ == ����������)
			{
				return ������������������������.����������;
			}
			else if(������ == ����������)
			{
				return ������������������������.����������;
			}
			return ������������������������.������������;
		}
		public static byte[] ����(this ������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������.������: return ������;
				case ������������������������.��������: return ��������;
				case ������������������������.����������: return ����������;
				case ������������������������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
