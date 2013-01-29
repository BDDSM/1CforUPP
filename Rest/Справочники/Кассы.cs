
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Kassy")]
	[Route("/Catalogs/Kassy/{Code}")]
	public class KassyRequest/*�����������*/: V82.�����������������.�����,IReturn<KassyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KassyResponse//����������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Kassys")]
	[Route("/Catalogs/Kassys/{Codes}")]
	public class KassysRequest/*�����������*/: IReturn<List<KassyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KassysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KassysResponse//����������
	{
		public string Result {get;set;}
	}


	public class KassyService /*�����������*/ : Service
	{
		public object Any(KassyRequest request)
		{
			return new KassyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KassyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����.�����������(���������);
				if (������ == null)
				{
					return new KassyResponse() {Result = "����� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����.�����������(1);
			}
		}

		public object Get(KassysRequest request)
		{
			var ��������� = new List<V82.�����������������.�����>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����.�����������(���������);
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
