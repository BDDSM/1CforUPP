
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ����������������������
	{
		������������ = - 1,
	///<summary>
	///���
	///</summary>
		����� = 0,
	///<summary>
	///���
	///</summary>
		���������� = 1,
	}
	public static partial class ����������������������_��������//:������������������
	{
		///<summary>
		///���
		///</summary>
		public static readonly Guid ����� = new Guid("56692aa9-c347-ba0c-4da8-06626e1c630f");
		///<summary>
		///���
		///</summary>
		public static readonly Guid ���������� = new Guid("17a5ca86-900c-4a5a-4886-d0cf75aa500e");
		public static ���������������������� ��������(this ���������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������������� ��������(this ���������������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return ����������������������.�����;
			}
			else if(������ == ����������)
			{
				return ����������������������.����������;
			}
			return ����������������������.������������;
		}
		public static byte[] ����(this ���������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������������� ��������)
		{
			switch (��������)
			{
				case ����������������������.�����: return �����;
				case ����������������������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
