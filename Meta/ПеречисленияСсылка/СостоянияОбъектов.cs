
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �����������������
	{
		������������ = - 1,
		����������� = 0,
		��������� = 1,
		������� = 2,
		���������� = 3,
		�������� = 4,
	}
	public static partial class �����������������_��������//:������������������
	{
		public static readonly Guid ����������� = new Guid("091d8eb0-b04c-3b92-4105-d8619d3093c1");
		public static readonly Guid ��������� = new Guid("3c6307a9-5050-d652-4a06-e8608f2e04c6");
		public static readonly Guid ������� = new Guid("c83fddb6-fe3e-2603-4059-4bafc0316856");
		public static readonly Guid ���������� = new Guid("c77dfea2-5b5f-66e5-45e0-a209fcbcd6a4");
		public static readonly Guid �������� = new Guid("32498d8b-635c-f186-4fa0-3d7cedf3b172");
		public static ����������������� ��������(this ����������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������� ��������(this ����������������� ��������, Guid ������)
		{
			if(������ == �����������)
			{
				return �����������������.�����������;
			}
			else if(������ == ���������)
			{
				return �����������������.���������;
			}
			else if(������ == �������)
			{
				return �����������������.�������;
			}
			else if(������ == ����������)
			{
				return �����������������.����������;
			}
			else if(������ == ��������)
			{
				return �����������������.��������;
			}
			return �����������������.������������;
		}
		public static byte[] ����(this ����������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������� ��������)
		{
			switch (��������)
			{
				case �����������������.�����������: return �����������;
				case �����������������.���������: return ���������;
				case �����������������.�������: return �������;
				case �����������������.����������: return ����������;
				case �����������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
