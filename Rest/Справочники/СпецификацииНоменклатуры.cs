
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SpecifikaciiNomenklatury")]
	[Route("/Catalogs/SpecifikaciiNomenklatury/{Code}")]
	public class SpecifikaciiNomenklaturyRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<SpecifikaciiNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SpecifikaciiNomenklaturyResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SpecifikaciiNomenklaturys")]
	[Route("/Catalogs/SpecifikaciiNomenklaturys/{Codes}")]
	public class SpecifikaciiNomenklaturysRequest/*������������������������������*/: IReturn<List<SpecifikaciiNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SpecifikaciiNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SpecifikaciiNomenklaturysResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class SpecifikaciiNomenklaturyService /*������������������������������*/ : Service
	{
		public object Any(SpecifikaciiNomenklaturyRequest request)
		{
			return new SpecifikaciiNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SpecifikaciiNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new SpecifikaciiNomenklaturyResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(SpecifikaciiNomenklaturysRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
