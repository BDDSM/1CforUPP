
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
		������������� = 0,
		���� = 1,
	}
	public static partial class ������������_��������//:������������������
	{
		public static readonly Guid ������������� = new Guid("808b62a8-24fa-7f3b-4d6b-67dfa2abade5");
		public static readonly Guid ���� = new Guid("0058c985-5744-6b9d-4b66-dbe731abca43");
		public static ������������ ��������(this ������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������ ��������(this ������������ ��������, Guid ������)
		{
			if(������ == �������������)
			{
				return ������������.�������������;
			}
			else if(������ == ����)
			{
				return ������������.����;
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
				case ������������.�������������: return �������������;
				case ������������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
