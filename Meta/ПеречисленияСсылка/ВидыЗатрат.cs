
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ����������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		������������ = 0,
	///<summary>
	///(���)
	///</summary>
		����������� = 1,//������ �����
	///<summary>
	///(���)
	///</summary>
		����������� = 2,
	///<summary>
	///(���)
	///</summary>
		������ = 3,
	}
	public static partial class ����������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������������ = new Guid("ea7f079e-aa53-e8c5-4164-49ccd644a70d");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����������� = new Guid("df3bd69c-c81b-7062-4286-99eb33d1484e");//������ �����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����������� = new Guid("4df93cbb-5458-7900-4601-67175b5cc841");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������ = new Guid("d0c72386-2857-3a96-49bc-d6ddeada8cc2");
		public static ���������� ��������(this ���������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������� ��������(this ���������� ��������, Guid ������)
		{
			if(������ == ������������)
			{
				return ����������.������������;
			}
			else if(������ == �����������)
			{
				return ����������.�����������;
			}
			else if(������ == �����������)
			{
				return ����������.�����������;
			}
			else if(������ == ������)
			{
				return ����������.������;
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
				case ����������.������������: return ������������;
				case ����������.�����������: return �����������;
				case ����������.�����������: return �����������;
				case ����������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
