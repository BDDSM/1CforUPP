
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Rezervy")]
	[Route("/Catalogs/Rezervy/{Code}")]
	public class RezervyRequest/*�������������*/: V82.�����������������.�������,IReturn<RezervyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RezervyResponse//������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Rezervys")]
	[Route("/Catalogs/Rezervys/{Codes}")]
	public class RezervysRequest/*�������������*/: IReturn<List<RezervyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RezervysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RezervysResponse//������������
	{
		public string Result {get;set;}
	}


	public class RezervyService /*�������������*/ : Service
	{
		public object Any(RezervyRequest request)
		{
			return new RezervyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RezervyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������.�����������(���������);
				if (������ == null)
				{
					return new RezervyResponse() {Result = "������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������.�����������(1);
			}
		}

		public object Get(RezervysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������.�����������(���������);
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
