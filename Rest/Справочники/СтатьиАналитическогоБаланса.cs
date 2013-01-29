
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StatiAnaliticheskogoBalansa")]
	[Route("/Catalogs/StatiAnaliticheskogoBalansa/{Code}")]
	public class StatiAnaliticheskogoBalansaRequest/*���������������������������������*/: V82.�����������������.���������������������������,IReturn<StatiAnaliticheskogoBalansaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StatiAnaliticheskogoBalansaResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StatiAnaliticheskogoBalansas")]
	[Route("/Catalogs/StatiAnaliticheskogoBalansas/{Codes}")]
	public class StatiAnaliticheskogoBalansasRequest/*���������������������������������*/: IReturn<List<StatiAnaliticheskogoBalansaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StatiAnaliticheskogoBalansasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StatiAnaliticheskogoBalansasResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	public class StatiAnaliticheskogoBalansaService /*���������������������������������*/ : Service
	{
		public object Any(StatiAnaliticheskogoBalansaRequest request)
		{
			return new StatiAnaliticheskogoBalansaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StatiAnaliticheskogoBalansaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������.�����������(���������);
				if (������ == null)
				{
					return new StatiAnaliticheskogoBalansaResponse() {Result = "��������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������.�����������(1);
			}
		}

		public object Get(StatiAnaliticheskogoBalansasRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������.�����������(���������);
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
