
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TipyCenNomenklatury")]
	[Route("/Catalogs/TipyCenNomenklatury/{Code}")]
	public class TipyCenNomenklaturyRequest/*�������������������������*/: V82.�����������������.�������������������,IReturn<TipyCenNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TipyCenNomenklaturyResponse//������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TipyCenNomenklaturys")]
	[Route("/Catalogs/TipyCenNomenklaturys/{Codes}")]
	public class TipyCenNomenklaturysRequest/*�������������������������*/: IReturn<List<TipyCenNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TipyCenNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TipyCenNomenklaturysResponse//������������������������
	{
		public string Result {get;set;}
	}


	public class TipyCenNomenklaturyService /*�������������������������*/ : Service
	{
		public object Any(TipyCenNomenklaturyRequest request)
		{
			return new TipyCenNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TipyCenNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������.�����������(���������);
				if (������ == null)
				{
					return new TipyCenNomenklaturyResponse() {Result = "������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������.�����������(1);
			}
		}

		public object Get(TipyCenNomenklaturysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������.�����������(���������);
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
