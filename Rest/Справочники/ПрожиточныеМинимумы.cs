
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProzhitochnyeMinimumy")]
	[Route("/Catalogs/ProzhitochnyeMinimumy/{Code}")]
	public class ProzhitochnyeMinimumyRequest/*�������������������������*/: V82.�����������������.�������������������,IReturn<ProzhitochnyeMinimumyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProzhitochnyeMinimumyResponse//������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProzhitochnyeMinimumys")]
	[Route("/Catalogs/ProzhitochnyeMinimumys/{Codes}")]
	public class ProzhitochnyeMinimumysRequest/*�������������������������*/: IReturn<List<ProzhitochnyeMinimumyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProzhitochnyeMinimumysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProzhitochnyeMinimumysResponse//������������������������
	{
		public string Result {get;set;}
	}


	public class ProzhitochnyeMinimumyService /*�������������������������*/ : Service
	{
		public object Any(ProzhitochnyeMinimumyRequest request)
		{
			return new ProzhitochnyeMinimumyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProzhitochnyeMinimumyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������.�����������(���������);
				if (������ == null)
				{
					return new ProzhitochnyeMinimumyResponse() {Result = "������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������.�����������(1);
			}
		}

		public object Get(ProzhitochnyeMinimumysRequest request)
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
