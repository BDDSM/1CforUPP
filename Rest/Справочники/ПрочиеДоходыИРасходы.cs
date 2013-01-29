
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProchieDokhodyIRaskhody")]
	[Route("/Catalogs/ProchieDokhodyIRaskhody/{Code}")]
	public class ProchieDokhodyIRaskhodyRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<ProchieDokhodyIRaskhodyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProchieDokhodyIRaskhodyResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProchieDokhodyIRaskhodys")]
	[Route("/Catalogs/ProchieDokhodyIRaskhodys/{Codes}")]
	public class ProchieDokhodyIRaskhodysRequest/*��������������������������*/: IReturn<List<ProchieDokhodyIRaskhodyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProchieDokhodyIRaskhodysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProchieDokhodyIRaskhodysResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class ProchieDokhodyIRaskhodyService /*��������������������������*/ : Service
	{
		public object Any(ProchieDokhodyIRaskhodyRequest request)
		{
			return new ProchieDokhodyIRaskhodyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProchieDokhodyIRaskhodyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new ProchieDokhodyIRaskhodyResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(ProchieDokhodyIRaskhodysRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
