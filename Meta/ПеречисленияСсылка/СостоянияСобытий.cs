
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
		������������� = 0,
	///<summary>
	///(���)
	///</summary>
		��������� = 1,
	///<summary>
	///(���)
	///</summary>
		�������� = 2,
	}
	public static partial class ����������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������������� = new Guid("94545f81-65f9-b0d2-4ef8-a9c5e3a62af1");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������� = new Guid("729362bf-190b-deab-4e50-65f217d898c6");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������� = new Guid("53e372a0-248a-c0c7-4cca-766807faeb27");
		public static ���������������� ��������(this ���������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������� ��������(this ���������������� ��������, Guid ������)
		{
			if(������ == �������������)
			{
				return ����������������.�������������;
			}
			else if(������ == ���������)
			{
				return ����������������.���������;
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
				case ����������������.�������������: return �������������;
				case ����������������.���������: return ���������;
				case ����������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
