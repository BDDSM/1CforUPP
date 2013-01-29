
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KHarakteristikiNomenklatury")]
	[Route("/Catalogs/KHarakteristikiNomenklatury/{Code}")]
	public class KHarakteristikiNomenklaturyRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<KHarakteristikiNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KHarakteristikiNomenklaturyResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KHarakteristikiNomenklaturys")]
	[Route("/Catalogs/KHarakteristikiNomenklaturys/{Codes}")]
	public class KHarakteristikiNomenklaturysRequest/*��������������������������������*/: IReturn<List<KHarakteristikiNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KHarakteristikiNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KHarakteristikiNomenklaturysResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class KHarakteristikiNomenklaturyService /*��������������������������������*/ : Service
	{
		public object Any(KHarakteristikiNomenklaturyRequest request)
		{
			return new KHarakteristikiNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KHarakteristikiNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new KHarakteristikiNomenklaturyResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(KHarakteristikiNomenklaturysRequest request)
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
