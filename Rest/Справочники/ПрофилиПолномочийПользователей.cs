
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProfiliPolnomochijjPolzovatelejj")]
	[Route("/Catalogs/ProfiliPolnomochijjPolzovatelejj/{Code}")]
	public class ProfiliPolnomochijjPolzovatelejjRequest/*������������������������������������*/: V82.�����������������.������������������������������,IReturn<ProfiliPolnomochijjPolzovatelejjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProfiliPolnomochijjPolzovatelejjResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProfiliPolnomochijjPolzovatelejjs")]
	[Route("/Catalogs/ProfiliPolnomochijjPolzovatelejjs/{Codes}")]
	public class ProfiliPolnomochijjPolzovatelejjsRequest/*������������������������������������*/: IReturn<List<ProfiliPolnomochijjPolzovatelejjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProfiliPolnomochijjPolzovatelejjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProfiliPolnomochijjPolzovatelejjsResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	public class ProfiliPolnomochijjPolzovatelejjService /*������������������������������������*/ : Service
	{
		public object Any(ProfiliPolnomochijjPolzovatelejjRequest request)
		{
			return new ProfiliPolnomochijjPolzovatelejjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProfiliPolnomochijjPolzovatelejjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ProfiliPolnomochijjPolzovatelejjResponse() {Result = "������������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������.�����������(1);
			}
		}

		public object Get(ProfiliPolnomochijjPolzovatelejjsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������������.�����������(���������);
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
