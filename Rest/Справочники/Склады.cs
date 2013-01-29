
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Sklady")]
	[Route("/Catalogs/Sklady/{Code}")]
	public class SkladyRequest/*������������*/: V82.�����������������.������,IReturn<SkladyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SkladyResponse//�����������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Skladys")]
	[Route("/Catalogs/Skladys/{Codes}")]
	public class SkladysRequest/*������������*/: IReturn<List<SkladyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SkladysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SkladysResponse//�����������
	{
		public string Result {get;set;}
	}


	public class SkladyService /*������������*/ : Service
	{
		public object Any(SkladyRequest request)
		{
			return new SkladyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SkladyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������.�����������(���������);
				if (������ == null)
				{
					return new SkladyResponse() {Result = "������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������.�����������(1);
			}
		}

		public object Get(SkladysRequest request)
		{
			var ��������� = new List<V82.�����������������.������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������.�����������(���������);
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
