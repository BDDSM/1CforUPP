
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TerritorialnyeUsloviya")]
	[Route("/Catalogs/TerritorialnyeUsloviya/{Code}")]
	public class TerritorialnyeUsloviyaRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<TerritorialnyeUsloviyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TerritorialnyeUsloviyaResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TerritorialnyeUsloviyas")]
	[Route("/Catalogs/TerritorialnyeUsloviyas/{Codes}")]
	public class TerritorialnyeUsloviyasRequest/*����������������������������*/: IReturn<List<TerritorialnyeUsloviyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TerritorialnyeUsloviyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TerritorialnyeUsloviyasResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class TerritorialnyeUsloviyaService /*����������������������������*/ : Service
	{
		public object Any(TerritorialnyeUsloviyaRequest request)
		{
			return new TerritorialnyeUsloviyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TerritorialnyeUsloviyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new TerritorialnyeUsloviyaResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(TerritorialnyeUsloviyasRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
