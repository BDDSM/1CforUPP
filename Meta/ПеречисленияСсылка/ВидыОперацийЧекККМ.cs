
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
		������� = 0,
		������� = 1,//��� �� �������
	}
	public static partial class ������������������_��������//:������������������
	{
		public static readonly Guid ������� = new Guid("2829bab9-3e91-87b9-4594-fd7c42f38028");
		public static readonly Guid ������� = new Guid("7f32fea8-8daf-5031-413e-f8c4485e36d8");//��� �� �������
		public static ������������������ ��������(this ������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������ ��������(this ������������������ ��������, Guid ������)
		{
			if(������ == �������)
			{
				return ������������������.�������;
			}
			else if(������ == �������)
			{
				return ������������������.�������;
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
				case ������������������.�������: return �������;
				case ������������������.�������: return �������;
			}
			return Guid.Empty;
		}
	}
}
