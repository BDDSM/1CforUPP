
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/RabochieMesta")]
	[Route("/Catalogs/RabochieMesta/{Code}")]
	public class RabochieMestaRequest/*������������������*/: V82.�����������������.������������,IReturn<RabochieMestaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RabochieMestaResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RabochieMestas")]
	[Route("/Catalogs/RabochieMestas/{Codes}")]
	public class RabochieMestasRequest/*������������������*/: IReturn<List<RabochieMestaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RabochieMestasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RabochieMestasResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class RabochieMestaService /*������������������*/ : Service
	{
		public object Any(RabochieMestaRequest request)
		{
			return new RabochieMestaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RabochieMestaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new RabochieMestaResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(RabochieMestasRequest request)
		{
			var ��������� = new List<V82.�����������������.������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������.�����������(���������);
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
