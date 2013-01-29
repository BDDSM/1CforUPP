
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TipovyeAnalizyNomenklatury")]
	[Route("/Catalogs/TipovyeAnalizyNomenklatury/{Code}")]
	public class TipovyeAnalizyNomenklaturyRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<TipovyeAnalizyNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TipovyeAnalizyNomenklaturyResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TipovyeAnalizyNomenklaturys")]
	[Route("/Catalogs/TipovyeAnalizyNomenklaturys/{Codes}")]
	public class TipovyeAnalizyNomenklaturysRequest/*��������������������������������*/: IReturn<List<TipovyeAnalizyNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TipovyeAnalizyNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TipovyeAnalizyNomenklaturysResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class TipovyeAnalizyNomenklaturyService /*��������������������������������*/ : Service
	{
		public object Any(TipovyeAnalizyNomenklaturyRequest request)
		{
			return new TipovyeAnalizyNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TipovyeAnalizyNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new TipovyeAnalizyNomenklaturyResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(TipovyeAnalizyNomenklaturysRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
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
