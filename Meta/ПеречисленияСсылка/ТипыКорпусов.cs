
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ������������
	{
		������������ = - 1,
		������ = 0,
		�������� = 1,
	}
	public static partial class ������������_��������//:������������������
	{
		public static readonly Guid ������ = new Guid("98b05c82-3741-c438-4b45-a15d9df7bc46");
		public static readonly Guid �������� = new Guid("113a64bc-0892-fa74-46a6-dc04e1b454ec");
		public static ������������ ��������(this ������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������ ��������(this ������������ ��������, Guid ������)
		{
			if(������ == ������)
			{
				return ������������.������;
			}
			else if(������ == ��������)
			{
				return ������������.��������;
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
				case ������������.������: return ������;
				case ������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
