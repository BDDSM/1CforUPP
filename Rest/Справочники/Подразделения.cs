
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Podrazdeleniya")]
	[Route("/Catalogs/Podrazdeleniya/{Code}")]
	public class PodrazdeleniyaRequest/*�������������������*/: V82.�����������������.�������������,IReturn<PodrazdeleniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PodrazdeleniyaResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Podrazdeleniyas")]
	[Route("/Catalogs/Podrazdeleniyas/{Codes}")]
	public class PodrazdeleniyasRequest/*�������������������*/: IReturn<List<PodrazdeleniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PodrazdeleniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PodrazdeleniyasResponse//������������������
	{
		public string Result {get;set;}
	}


	public class PodrazdeleniyaService /*�������������������*/ : Service
	{
		public object Any(PodrazdeleniyaRequest request)
		{
			return new PodrazdeleniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PodrazdeleniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new PodrazdeleniyaResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(PodrazdeleniyasRequest request)
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
