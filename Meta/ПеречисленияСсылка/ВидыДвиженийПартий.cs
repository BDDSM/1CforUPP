
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������
	{
		������������ = - 1,
		����������� = 0,
		���������� = 1,
	}
	public static partial class ������������������_��������//:������������������
	{
		public static readonly Guid ����������� = new Guid("6cd12b81-6fbe-fde7-4f39-cb7409d98381");
		public static readonly Guid ���������� = new Guid("2859939c-a21c-1209-4f85-3f740ebb2474");
		public static ������������������ ��������(this ������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������ ��������(this ������������������ ��������, Guid ������)
		{
			if(������ == �����������)
			{
				return ������������������.�����������;
			}
			else if(������ == ����������)
			{
				return ������������������.����������;
			}
			return ������������������.������������;
		}
		public static byte[] ����(this ������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������ ��������)
		{
			switch (��������)
			{
				case ������������������.�����������: return �����������;
				case ������������������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
