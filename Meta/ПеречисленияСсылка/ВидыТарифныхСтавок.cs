
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
	///<summary>
	///(���)
	///</summary>
		�������� = 0,
	///<summary>
	///(���)
	///</summary>
		������� = 1,
	///<summary>
	///(���)
	///</summary>
		������� = 2,
	}
	public static partial class ������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������� = new Guid("fdb60fb9-06ba-0446-4f5b-44bf044e60a3");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("fc4edd9d-6b0b-7620-4a73-240e0daf7c58");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������� = new Guid("42ed25b3-e2a4-f28d-470a-43f3d56f600a");
		public static ������������������ ��������(this ������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������ ��������(this ������������������ ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return ������������������.��������;
			}
			else if(������ == �������)
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
				case ������������������.��������: return ��������;
				case ������������������.�������: return �������;
				case ������������������.�������: return �������;
			}
			return Guid.Empty;
		}
	}
}
