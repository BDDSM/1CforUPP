
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/CiklyObmena")]
	[Route("/Catalogs/CiklyObmena/{Code}")]
	public class CiklyObmenaRequest/*�����������������*/: V82.�����������������.�����������,IReturn<CiklyObmenaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class CiklyObmenaResponse//����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/CiklyObmenas")]
	[Route("/Catalogs/CiklyObmenas/{Codes}")]
	public class CiklyObmenasRequest/*�����������������*/: IReturn<List<CiklyObmenaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public CiklyObmenasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class CiklyObmenasResponse//����������������
	{
		public string Result {get;set;}
	}


	public class CiklyObmenaService /*�����������������*/ : Service
	{
		public object Any(CiklyObmenaRequest request)
		{
			return new CiklyObmenaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(CiklyObmenaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������.�����������(���������);
				if (������ == null)
				{
					return new CiklyObmenaResponse() {Result = "����������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������.�����������(1);
			}
		}

		public object Get(CiklyObmenasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������.�����������(���������);
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
