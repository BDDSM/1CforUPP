
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KursyObucheniya")]
	[Route("/Catalogs/KursyObucheniya/{Code}")]
	public class KursyObucheniyaRequest/*�������������������*/: V82.�����������������.�������������,IReturn<KursyObucheniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KursyObucheniyaResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KursyObucheniyas")]
	[Route("/Catalogs/KursyObucheniyas/{Codes}")]
	public class KursyObucheniyasRequest/*�������������������*/: IReturn<List<KursyObucheniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KursyObucheniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KursyObucheniyasResponse//������������������
	{
		public string Result {get;set;}
	}


	public class KursyObucheniyaService /*�������������������*/ : Service
	{
		public object Any(KursyObucheniyaRequest request)
		{
			return new KursyObucheniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KursyObucheniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new KursyObucheniyaResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(KursyObucheniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
