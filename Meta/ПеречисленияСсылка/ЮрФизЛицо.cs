
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
	///(���)
	///</summary>
		������ = 0,
	///<summary>
	///(���)
	///</summary>
		������� = 1,
	}
	public static partial class ���������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������ = new Guid("6d7a91b3-8ec0-f6a0-4f59-c4deeef13a4c");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("b8b93ea1-82fc-86a2-4720-bafad2cff47a");
		public static ��������� ��������(this ��������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������� ��������(this ��������� ��������, Guid ������)
		{
			if(������ == ������)
			{
				return ���������.������;
			}
			else if(������ == �������)
			{
				return ���������.�������;
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
				case ���������.������: return ������;
				case ���������.�������: return �������;
			}
			return Guid.Empty;
		}
	}
}
