
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������Online
	{
		������������ = - 1,
	}
	public static partial class �����������Online_��������//:������������������
	{
		public static �����������Online ��������(this �����������Online ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �����������Online ��������(this �����������Online ��������, Guid ������)
		{
			return �����������Online.������������;
		}
		public static byte[] ����(this �����������Online ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �����������Online ��������)
		{
			switch (��������)
			{
			}
			return Guid.Empty;
		}
	}
}
