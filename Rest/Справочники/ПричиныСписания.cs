
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PrichinySpisaniya")]
	[Route("/Catalogs/PrichinySpisaniya/{Code}")]
	public class PrichinySpisaniyaRequest/*���������������������*/: V82.�����������������.���������������,IReturn<PrichinySpisaniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PrichinySpisaniyaResponse//��������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PrichinySpisaniyas")]
	[Route("/Catalogs/PrichinySpisaniyas/{Codes}")]
	public class PrichinySpisaniyasRequest/*���������������������*/: IReturn<List<PrichinySpisaniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PrichinySpisaniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PrichinySpisaniyasResponse//��������������������
	{
		public string Result {get;set;}
	}


	public class PrichinySpisaniyaService /*���������������������*/ : Service
	{
		public object Any(PrichinySpisaniyaRequest request)
		{
			return new PrichinySpisaniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PrichinySpisaniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������.�����������(���������);
				if (������ == null)
				{
					return new PrichinySpisaniyaResponse() {Result = "��������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������.�����������(1);
			}
		}

		public object Get(PrichinySpisaniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������.�����������(���������);
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
