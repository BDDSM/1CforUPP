
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ZanyatiyaKursovObucheniya")]
	[Route("/Catalogs/ZanyatiyaKursovObucheniya/{Code}")]
	public class ZanyatiyaKursovObucheniyaRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<ZanyatiyaKursovObucheniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ZanyatiyaKursovObucheniyaResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ZanyatiyaKursovObucheniyas")]
	[Route("/Catalogs/ZanyatiyaKursovObucheniyas/{Codes}")]
	public class ZanyatiyaKursovObucheniyasRequest/*���������������������������*/: IReturn<List<ZanyatiyaKursovObucheniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ZanyatiyaKursovObucheniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ZanyatiyaKursovObucheniyasResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class ZanyatiyaKursovObucheniyaService /*���������������������������*/ : Service
	{
		public object Any(ZanyatiyaKursovObucheniyaRequest request)
		{
			return new ZanyatiyaKursovObucheniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ZanyatiyaKursovObucheniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new ZanyatiyaKursovObucheniyaResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(ZanyatiyaKursovObucheniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������.�����������(���������);
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
