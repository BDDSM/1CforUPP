
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum XYZ�������������
	{
		������������ = - 1,
		X����� = 0,//X - �����
		Y����� = 1,//Y - �����
		Z����� = 2,//Z - �����
	}
	public static partial class XYZ�������������_��������//:������������������
	{
		public static readonly Guid X����� = new Guid("3e9986a3-bd07-3a9a-4dd5-a784ff346941");//X - �����
		public static readonly Guid Y����� = new Guid("2384468c-8ece-dfef-4745-f113ee4cb7b2");//Y - �����
		public static readonly Guid Z����� = new Guid("338f50b1-f149-3385-4f6b-fa52f66801e9");//Z - �����
		public static XYZ������������� ��������(this XYZ������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static XYZ������������� ��������(this XYZ������������� ��������, Guid ������)
		{
			if(������ == X�����)
			{
				return XYZ�������������.X�����;
			}
			else if(������ == Y�����)
			{
				return XYZ�������������.Y�����;
			}
			else if(������ == Z�����)
			{
				return XYZ�������������.Z�����;
			}
			return XYZ�������������.������������;
		}
		public static byte[] ����(this XYZ������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this XYZ������������� ��������)
		{
			switch (��������)
			{
				case XYZ�������������.X�����: return X�����;
				case XYZ�������������.Y�����: return Y�����;
				case XYZ�������������.Z�����: return Z�����;
			}
			return Guid.Empty;
		}
	}
}
