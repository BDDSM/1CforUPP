
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PokazateliAnalizovNomenklatury")]
	[Route("/Catalogs/PokazateliAnalizovNomenklatury/{Code}")]
	public class PokazateliAnalizovNomenklaturyRequest/*������������������������������������*/: V82.�����������������.������������������������������,IReturn<PokazateliAnalizovNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PokazateliAnalizovNomenklaturyResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PokazateliAnalizovNomenklaturys")]
	[Route("/Catalogs/PokazateliAnalizovNomenklaturys/{Codes}")]
	public class PokazateliAnalizovNomenklaturysRequest/*������������������������������������*/: IReturn<List<PokazateliAnalizovNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PokazateliAnalizovNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PokazateliAnalizovNomenklaturysResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	public class PokazateliAnalizovNomenklaturyService /*������������������������������������*/ : Service
	{
		public object Any(PokazateliAnalizovNomenklaturyRequest request)
		{
			return new PokazateliAnalizovNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PokazateliAnalizovNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������.�����������(���������);
				if (������ == null)
				{
					return new PokazateliAnalizovNomenklaturyResponse() {Result = "������������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������.�����������(1);
			}
		}

		public object Get(PokazateliAnalizovNomenklaturysRequest request)
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
