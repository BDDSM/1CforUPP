
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ����������
	{
		������������ = - 1,
		������13 = 0,//13%
		������30 = 1,//30%
		������09 = 2,//9%
		������35 = 3,//35%
		������15 = 4,//15%
	}
	public static partial class ����������_��������//:������������������
	{
		public static readonly Guid ������13 = new Guid("6e5577bb-0435-4843-49d1-ebbcfc3ba933");//13%
		public static readonly Guid ������30 = new Guid("b3d708ac-17e9-52d1-4942-a94c0037441b");//30%
		public static readonly Guid ������09 = new Guid("e2ff3da9-9c2a-48e2-4dc5-795f642697ea");//9%
		public static readonly Guid ������35 = new Guid("81aa5d81-ba8a-7037-410d-d4f78caef17d");//35%
		public static readonly Guid ������15 = new Guid("f74068a7-72a7-7c16-44f4-0eaf740a980b");//15%
		public static ���������� ��������(this ���������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������� ��������(this ���������� ��������, Guid ������)
		{
			if(������ == ������13)
			{
				return ����������.������13;
			}
			else if(������ == ������30)
			{
				return ����������.������30;
			}
			else if(������ == ������09)
			{
				return ����������.������09;
			}
			else if(������ == ������35)
			{
				return ����������.������35;
			}
			else if(������ == ������15)
			{
				return ����������.������15;
			}
			return ����������.������������;
		}
		public static byte[] ����(this ���������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������� ��������)
		{
			switch (��������)
			{
				case ����������.������13: return ������13;
				case ����������.������30: return ������30;
				case ����������.������09: return ������09;
				case ����������.������35: return ������35;
				case ����������.������15: return ������15;
			}
			return Guid.Empty;
		}
	}
}
