
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
		����������� = 0,
	///<summary>
	///(���)
	///</summary>
		������� = 1,
	///<summary>
	///(���)
	///</summary>
		����� = 2,
	///<summary>
	///(���)
	///</summary>
		������� = 3,
	///<summary>
	///(���)
	///</summary>
		������� = 4,
	///<summary>
	///(���)
	///</summary>
		������� = 5,
	///<summary>
	///(���)
	///</summary>
		����������� = 6,
	}
	public static partial class ���������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����������� = new Guid("1833afab-2eec-7b29-4d2b-db35599aab3e");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("03c551a6-60e8-bc41-4957-ef7a8b34b573");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����� = new Guid("d791f586-fa46-527c-4955-2ce3fa93ea82");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("57581d94-e0e0-e186-4fe4-99a1a14338bd");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("1a266c82-ffcd-466f-4427-14667d9da492");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("1ae9f19f-3bff-a875-42dc-bdc0abc607d9");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����������� = new Guid("57347f9e-02ef-5e81-4583-72b47a4039a9");
		public static ��������� ��������(this ��������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������� ��������(this ��������� ��������, Guid ������)
		{
			if(������ == �����������)
			{
				return ���������.�����������;
			}
			else if(������ == �������)
			{
				return ���������.�������;
			}
			else if(������ == �����)
			{
				return ���������.�����;
			}
			else if(������ == �������)
			{
				return ���������.�������;
			}
			else if(������ == �������)
			{
				return ���������.�������;
			}
			else if(������ == �������)
			{
				return ���������.�������;
			}
			else if(������ == �����������)
			{
				return ���������.�����������;
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
				case ���������.�����������: return �����������;
				case ���������.�������: return �������;
				case ���������.�����: return �����;
				case ���������.�������: return �������;
				case ���������.�������: return �������;
				case ���������.�������: return �������;
				case ���������.�����������: return �����������;
			}
			return Guid.Empty;
		}
	}
}
