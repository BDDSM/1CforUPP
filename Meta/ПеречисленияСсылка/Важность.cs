
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ��������
	{
		������������ = - 1,
		������� = 0,
		������� = 1,
		������ = 2,
	}
	public static partial class ��������_��������//:������������������
	{
		public static readonly Guid ������� = new Guid("db3bdfb6-b294-eac7-4b5a-af5606d76e9a");
		public static readonly Guid ������� = new Guid("4f20cea6-3699-b341-4239-6fe544af5928");
		public static readonly Guid ������ = new Guid("43f46a84-6f41-254f-4471-ba9393e0e603");
		public static �������� ��������(this �������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �������� ��������(this �������� ��������, Guid ������)
		{
			if(������ == �������)
			{
				return ��������.�������;
			}
			else if(������ == �������)
			{
				return ��������.�������;
			}
			else if(������ == ������)
			{
				return ��������.������;
			}
			return ��������.������������;
		}
		public static byte[] ����(this �������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �������� ��������)
		{
			switch (��������)
			{
				case ��������.�������: return �������;
				case ��������.�������: return �������;
				case ��������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
