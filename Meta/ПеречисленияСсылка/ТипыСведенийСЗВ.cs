
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������
	{
		������������ = - 1,
		�������� = 0,
		���������� = 1,
		�������������� = 2,
		���������� = 3,
	}
	public static partial class ���������������_��������//:������������������
	{
		public static readonly Guid �������� = new Guid("0fda778f-51a7-eb31-4473-8ab43621c5e7");
		public static readonly Guid ���������� = new Guid("d8d003a0-8b7b-30e6-4b3b-05328424e951");
		public static readonly Guid �������������� = new Guid("2e3b18b1-8698-554c-41bf-88507ac52df7");
		public static readonly Guid ���������� = new Guid("b1d5af92-de66-276d-4719-394fbc1472ee");
		public static ��������������� ��������(this ��������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������� ��������(this ��������������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return ���������������.��������;
			}
			else if(������ == ����������)
			{
				return ���������������.����������;
			}
			else if(������ == ��������������)
			{
				return ���������������.��������������;
			}
			else if(������ == ����������)
			{
				return ���������������.����������;
			}
			return ���������������.������������;
		}
		public static byte[] ����(this ��������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������� ��������)
		{
			switch (��������)
			{
				case ���������������.��������: return ��������;
				case ���������������.����������: return ����������;
				case ���������������.��������������: return ��������������;
				case ���������������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
