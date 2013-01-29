
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlyuchiAnalitikiUchetaPartijj")]
	[Route("/Catalogs/KlyuchiAnalitikiUchetaPartijj/{Code}")]
	public class KlyuchiAnalitikiUchetaPartijjRequest/*�������������������������������*/: V82.�����������������.�������������������������,IReturn<KlyuchiAnalitikiUchetaPartijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlyuchiAnalitikiUchetaPartijjResponse//������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlyuchiAnalitikiUchetaPartijjs")]
	[Route("/Catalogs/KlyuchiAnalitikiUchetaPartijjs/{Codes}")]
	public class KlyuchiAnalitikiUchetaPartijjsRequest/*�������������������������������*/: IReturn<List<KlyuchiAnalitikiUchetaPartijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlyuchiAnalitikiUchetaPartijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlyuchiAnalitikiUchetaPartijjsResponse//������������������������������
	{
		public string Result {get;set;}
	}


	public class KlyuchiAnalitikiUchetaPartijjService /*�������������������������������*/ : Service
	{
		public object Any(KlyuchiAnalitikiUchetaPartijjRequest request)
		{
			return new KlyuchiAnalitikiUchetaPartijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlyuchiAnalitikiUchetaPartijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������.�����������(���������);
				if (������ == null)
				{
					return new KlyuchiAnalitikiUchetaPartijjResponse() {Result = "������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������.�����������(1);
			}
		}

		public object Get(KlyuchiAnalitikiUchetaPartijjsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������.�����������(���������);
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
