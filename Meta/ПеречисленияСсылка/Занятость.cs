
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
		�������� = 0,
		������ = 1,
		���������� = 2,
	}
	public static partial class ���������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("e74be688-d55c-b6f5-4268-9c735d5947aa");
		public static readonly Guid ������ = new Guid("d66196ba-1176-634e-4ab0-4bec2fa05dc3");
		public static readonly Guid ���������� = new Guid("7b11d9a0-3eef-0605-4c9f-a139fb8e7538");
		public static ��������� ��������(this ��������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������� ��������(this ��������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return ���������.��������;
			}
			else if(������ == ������)
			{
				return ���������.������;
			}
			else if(������ == ����������)
			{
				return ���������.����������;
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
				case ���������.��������: return ��������;
				case ���������.������: return ������;
				case ���������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
