
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum �������������
	{
		������������ = - 1,
		��������� = 0,//�� �������
	///<summary>
	///First input, first output (������ ������, ������ ���������)
	///</summary>
		���� = 1,
	///<summary>
	///Last input, first output (��������� ������, ������ ���������)
	///</summary>
		���� = 2,
	}
	public static partial class �������������_��������//:������������������
	{
		public static readonly Guid ��������� = new Guid("d9620884-3a94-13d3-47ee-822491b64739");//�� �������
		///<summary>
		///First input, first output (������ ������, ������ ���������)
		///</summary>
		public static readonly Guid ���� = new Guid("65c6a5af-8de2-6b2a-462e-70888faf6ff7");
		///<summary>
		///Last input, first output (��������� ������, ������ ���������)
		///</summary>
		public static readonly Guid ���� = new Guid("595d1695-3c6f-74e7-46f4-5909f411d078");
		public static ������������� ��������(this ������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������� ��������(this ������������� ��������, Guid ������)
		{
			if(������ == ���������)
			{
				return �������������.���������;
			}
			else if(������ == ����)
			{
				return �������������.����;
			}
			else if(������ == ����)
			{
				return �������������.����;
			}
			return �������������.������������;
		}
		public static byte[] ����(this ������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������� ��������)
		{
			switch (��������)
			{
				case �������������.���������: return ���������;
				case �������������.����: return ����;
				case �������������.����: return ����;
			}
			return Guid.Empty;
		}
	}
}
