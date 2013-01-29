
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlyuchiAnalitikiVidaUcheta")]
	[Route("/Catalogs/KlyuchiAnalitikiVidaUcheta/{Code}")]
	public class KlyuchiAnalitikiVidaUchetaRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<KlyuchiAnalitikiVidaUchetaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlyuchiAnalitikiVidaUchetaResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlyuchiAnalitikiVidaUchetas")]
	[Route("/Catalogs/KlyuchiAnalitikiVidaUchetas/{Codes}")]
	public class KlyuchiAnalitikiVidaUchetasRequest/*�����������������������������*/: IReturn<List<KlyuchiAnalitikiVidaUchetaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlyuchiAnalitikiVidaUchetasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlyuchiAnalitikiVidaUchetasResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class KlyuchiAnalitikiVidaUchetaService /*�����������������������������*/ : Service
	{
		public object Any(KlyuchiAnalitikiVidaUchetaRequest request)
		{
			return new KlyuchiAnalitikiVidaUchetaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlyuchiAnalitikiVidaUchetaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new KlyuchiAnalitikiVidaUchetaResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(KlyuchiAnalitikiVidaUchetasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������.�����������(���������);
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
