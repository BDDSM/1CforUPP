
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������������
	{
		������������ = - 1,
	///<summary>
	///��������������� ��������� CSP
	///</summary>
		CryptoPro = 0,//Crypto pro
	///<summary>
	///��������������� VipNet CSP
	///</summary>
		VipNet = 1,//Vip net
	}
	public static partial class ���������������������_��������//:������������������
	{
		///<summary>
		///��������������� ��������� CSP
		///</summary>
		public static readonly Guid CryptoPro = new Guid("210431a0-5258-66a9-49a3-51ec5b750bc5");//Crypto pro
		///<summary>
		///��������������� VipNet CSP
		///</summary>
		public static readonly Guid VipNet = new Guid("7de12fb8-4f94-9d58-474f-7092a1a1603b");//Vip net
		public static ��������������������� ��������(this ��������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������� ��������(this ��������������������� ��������, Guid ������)
		{
			if(������ == CryptoPro)
			{
				return ���������������������.CryptoPro;
			}
			else if(������ == VipNet)
			{
				return ���������������������.VipNet;
			}
			return ���������������������.������������;
		}
		public static byte[] ����(this ��������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������.CryptoPro: return CryptoPro;
				case ���������������������.VipNet: return VipNet;
			}
			return Guid.Empty;
		}
	}
}
