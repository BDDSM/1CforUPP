
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ������������
	{
		������������ = - 1,
		��������� = 0,
		HTML = 1,
		��������� = 2,
	}
	public static partial class ������������_��������//:������������������
	{
		public static readonly Guid ��������� = new Guid("01fbabbe-0000-1b32-43ba-4fc8a037bbcb");
		public static readonly Guid HTML = new Guid("be8273aa-ba7e-0267-4f87-97d1aba94c0b");
		public static readonly Guid ��������� = new Guid("8e8d4688-7d79-daf0-45ff-6bbd74944e52");
		public static ������������ ��������(this ������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������ ��������(this ������������ ��������, Guid ������)
		{
			if(������ == ���������)
			{
				return ������������.���������;
			}
			else if(������ == HTML)
			{
				return ������������.HTML;
			}
			else if(������ == ���������)
			{
				return ������������.���������;
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
				case ������������.���������: return ���������;
				case ������������.HTML: return HTML;
				case ������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
