
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������
	{
		������������ = - 1,
	///<summary>
	///������ ������� � ��������
	///</summary>
		��� = 0,//������ ������� � ��������
		���� = 1,//������ �������� �������� �������
		������ = 2,//������ ��������� �������
	}
	public static partial class ������������_��������//:������������������
	{
		///<summary>
		///������ ������� � ��������
		///</summary>
		public static readonly Guid ��� = new Guid("ec4caf8c-4b04-6b48-4f0b-d0224b525b58");//������ ������� � ��������
		public static readonly Guid ���� = new Guid("99981abf-2780-33b5-4230-fbd7a0bf2e21");//������ �������� �������� �������
		public static readonly Guid ������ = new Guid("a9301398-3214-22fe-4719-c5fc601c1b8b");//������ ��������� �������
		public static ������������ ��������(this ������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������ ��������(this ������������ ��������, Guid ������)
		{
			if(������ == ���)
			{
				return ������������.���;
			}
			else if(������ == ����)
			{
				return ������������.����;
			}
			else if(������ == ������)
			{
				return ������������.������;
			}
			return ������������.������������;
		}
		public static byte[] ����(this ������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������ ��������)
		{
			switch (��������)
			{
				case ������������.���: return ���;
				case ������������.����: return ����;
				case ������������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
