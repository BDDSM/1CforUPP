
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/AdresnyeSokrashheniya")]
	[Route("/Catalogs/AdresnyeSokrashheniya/{Code}")]
	public class AdresnyeSokrashheniyaRequest/*������������������������*/: V82.�����������������.������������������,IReturn<AdresnyeSokrashheniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class AdresnyeSokrashheniyaResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/AdresnyeSokrashheniyas")]
	[Route("/Catalogs/AdresnyeSokrashheniyas/{Codes}")]
	public class AdresnyeSokrashheniyasRequest/*������������������������*/: IReturn<List<AdresnyeSokrashheniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public AdresnyeSokrashheniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class AdresnyeSokrashheniyasResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class AdresnyeSokrashheniyaService /*������������������������*/ : Service
	{
		public object Any(AdresnyeSokrashheniyaRequest request)
		{
			return new AdresnyeSokrashheniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(AdresnyeSokrashheniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new AdresnyeSokrashheniyaResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(AdresnyeSokrashheniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������.�����������(���������);
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
