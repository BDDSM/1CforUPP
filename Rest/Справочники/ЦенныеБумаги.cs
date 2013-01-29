
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/CennyeBumagi")]
	[Route("/Catalogs/CennyeBumagi/{Code}")]
	public class CennyeBumagiRequest/*������������������*/: V82.�����������������.������������,IReturn<CennyeBumagiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class CennyeBumagiResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/CennyeBumagis")]
	[Route("/Catalogs/CennyeBumagis/{Codes}")]
	public class CennyeBumagisRequest/*������������������*/: IReturn<List<CennyeBumagiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public CennyeBumagisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class CennyeBumagisResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class CennyeBumagiService /*������������������*/ : Service
	{
		public object Any(CennyeBumagiRequest request)
		{
			return new CennyeBumagiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(CennyeBumagiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new CennyeBumagiResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(CennyeBumagisRequest request)
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
