
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NormativnyeDokumentySertifikaciiNomenklatury")]
	[Route("/Catalogs/NormativnyeDokumentySertifikaciiNomenklatury/{Code}")]
	public class NormativnyeDokumentySertifikaciiNomenklaturyRequest/*��������������������������������������������������*/: V82.�����������������.��������������������������������������������,IReturn<NormativnyeDokumentySertifikaciiNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NormativnyeDokumentySertifikaciiNomenklaturyResponse//�������������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NormativnyeDokumentySertifikaciiNomenklaturys")]
	[Route("/Catalogs/NormativnyeDokumentySertifikaciiNomenklaturys/{Codes}")]
	public class NormativnyeDokumentySertifikaciiNomenklaturysRequest/*��������������������������������������������������*/: IReturn<List<NormativnyeDokumentySertifikaciiNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NormativnyeDokumentySertifikaciiNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NormativnyeDokumentySertifikaciiNomenklaturysResponse//�������������������������������������������������
	{
		public string Result {get;set;}
	}


	public class NormativnyeDokumentySertifikaciiNomenklaturyService /*��������������������������������������������������*/ : Service
	{
		public object Any(NormativnyeDokumentySertifikaciiNomenklaturyRequest request)
		{
			return new NormativnyeDokumentySertifikaciiNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NormativnyeDokumentySertifikaciiNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NormativnyeDokumentySertifikaciiNomenklaturyResponse() {Result = "�������������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������������������.�����������(1);
			}
		}

		public object Get(NormativnyeDokumentySertifikaciiNomenklaturysRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������������������.�����������(���������);
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
