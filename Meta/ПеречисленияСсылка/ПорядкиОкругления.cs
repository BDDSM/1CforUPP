
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
	///<summary>
	///(���)
	///</summary>
		���0_01 = 0,//0.01
	///<summary>
	///(���)
	///</summary>
		���0_05 = 1,//0.05
	///<summary>
	///(���)
	///</summary>
		���0_1 = 2,//0.1
	///<summary>
	///(���)
	///</summary>
		���0_5 = 3,//0.5
	///<summary>
	///(���)
	///</summary>
		���1 = 4,//1
	///<summary>
	///(���)
	///</summary>
		���5 = 5,//5
	///<summary>
	///(���)
	///</summary>
		���10 = 6,//10
	///<summary>
	///(���)
	///</summary>
		���50 = 7,//50
	///<summary>
	///(���)
	///</summary>
		���100 = 8,//100
	}
	public static partial class �����������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���0_01 = new Guid("dc8908bc-c3dc-7cd8-4e78-7e91eb0a7cac");//0.01
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���0_05 = new Guid("dce4558d-5335-1b5b-4435-181c81b2be88");//0.05
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���0_1 = new Guid("6f32da86-cd1b-02d4-439b-3bfef5a56fab");//0.1
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���0_5 = new Guid("625472ab-8326-f158-4d59-ba58146c5750");//0.5
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���1 = new Guid("3b1e4f9b-83e3-7fd2-4ec5-997f0b7cc695");//1
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���5 = new Guid("8d1a919d-10fd-8e82-4a68-fb603b107c6f");//5
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���10 = new Guid("48095b93-ffcd-4a43-4aaf-0e1037ab1335");//10
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���50 = new Guid("e13e028d-f79f-9757-48cc-a383e698c574");//50
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���100 = new Guid("25c07b8c-92cc-968f-453f-5d717c82fb0c");//100
		public static ����������������� ��������(this ����������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������� ��������(this ����������������� ��������, Guid ������)
		{
			if(������ == ���0_01)
			{
				return �����������������.���0_01;
			}
			else if(������ == ���0_05)
			{
				return �����������������.���0_05;
			}
			else if(������ == ���0_1)
			{
				return �����������������.���0_1;
			}
			else if(������ == ���0_5)
			{
				return �����������������.���0_5;
			}
			else if(������ == ���1)
			{
				return �����������������.���1;
			}
			else if(������ == ���5)
			{
				return �����������������.���5;
			}
			else if(������ == ���10)
			{
				return �����������������.���10;
			}
			else if(������ == ���50)
			{
				return �����������������.���50;
			}
			else if(������ == ���100)
			{
				return �����������������.���100;
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
				case �����������������.���0_01: return ���0_01;
				case �����������������.���0_05: return ���0_05;
				case �����������������.���0_1: return ���0_1;
				case �����������������.���0_5: return ���0_5;
				case �����������������.���1: return ���1;
				case �����������������.���5: return ���5;
				case �����������������.���10: return ���10;
				case �����������������.���50: return ���50;
				case �����������������.���100: return ���100;
			}
			return Guid.Empty;
		}
	}
}
