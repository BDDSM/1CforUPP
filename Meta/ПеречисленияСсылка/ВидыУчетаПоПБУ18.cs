
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ��������������18
	{
		������������ = - 1,
	///<summary>
	///��������� ����
	///</summary>
		�� = 0,
	///<summary>
	///���� ���������� ������
	///</summary>
		�� = 1,
	///<summary>
	///���� ��������� ������
	///</summary>
		�� = 2,
	}
	public static partial class ��������������18_��������//:������������������
	{
		///<summary>
		///��������� ����
		///</summary>
		public static readonly Guid �� = new Guid("fffbfc82-bae1-859d-4b5c-e60440f3e05d");
		///<summary>
		///���� ���������� ������
		///</summary>
		public static readonly Guid �� = new Guid("57fd0aab-655f-5beb-41f5-8ed70d499bd0");
		///<summary>
		///���� ��������� ������
		///</summary>
		public static readonly Guid �� = new Guid("87bb509e-d440-0c7d-486c-e5f26649350d");
		public static ��������������18 ��������(this ��������������18 ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������18 ��������(this ��������������18 ��������, Guid ������)
		{
			if(������ == ��)
			{
				return ��������������18.��;
			}
			else if(������ == ��)
			{
				return ��������������18.��;
			}
			else if(������ == ��)
			{
				return ��������������18.��;
			}
			return ��������������18.������������;
		}
		public static byte[] ����(this ��������������18 ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������18 ��������)
		{
			switch (��������)
			{
				case ��������������18.��: return ��;
				case ��������������18.��: return ��;
				case ��������������18.��: return ��;
			}
			return Guid.Empty;
		}
	}
}
