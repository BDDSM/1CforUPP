
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PrichinyOtsutstviyaNaRabote")]
	[Route("/Catalogs/PrichinyOtsutstviyaNaRabote/{Code}")]
	public class PrichinyOtsutstviyaNaRaboteRequest/*�������������������������������*/: V82.�����������������.�������������������������,IReturn<PrichinyOtsutstviyaNaRaboteRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PrichinyOtsutstviyaNaRaboteResponse//������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PrichinyOtsutstviyaNaRabotes")]
	[Route("/Catalogs/PrichinyOtsutstviyaNaRabotes/{Codes}")]
	public class PrichinyOtsutstviyaNaRabotesRequest/*�������������������������������*/: IReturn<List<PrichinyOtsutstviyaNaRaboteRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PrichinyOtsutstviyaNaRabotesRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PrichinyOtsutstviyaNaRabotesResponse//������������������������������
	{
		public string Result {get;set;}
	}


	public class PrichinyOtsutstviyaNaRaboteService /*�������������������������������*/ : Service
	{
		public object Any(PrichinyOtsutstviyaNaRaboteRequest request)
		{
			return new PrichinyOtsutstviyaNaRaboteResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PrichinyOtsutstviyaNaRaboteRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������.�����������(���������);
				if (������ == null)
				{
					return new PrichinyOtsutstviyaNaRaboteResponse() {Result = "������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������.�����������(1);
			}
		}

		public object Get(PrichinyOtsutstviyaNaRabotesRequest request)
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
