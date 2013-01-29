
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OstatkiOtpuskov")]
	[Route("/Catalogs/OstatkiOtpuskov/{Code}")]
	public class OstatkiOtpuskovRequest/*���������������������*/: V82.�����������������.���������������,IReturn<OstatkiOtpuskovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OstatkiOtpuskovResponse//��������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OstatkiOtpuskovs")]
	[Route("/Catalogs/OstatkiOtpuskovs/{Codes}")]
	public class OstatkiOtpuskovsRequest/*���������������������*/: IReturn<List<OstatkiOtpuskovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OstatkiOtpuskovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OstatkiOtpuskovsResponse//��������������������
	{
		public string Result {get;set;}
	}


	public class OstatkiOtpuskovService /*���������������������*/ : Service
	{
		public object Any(OstatkiOtpuskovRequest request)
		{
			return new OstatkiOtpuskovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OstatkiOtpuskovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������.�����������(���������);
				if (������ == null)
				{
					return new OstatkiOtpuskovResponse() {Result = "��������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������.�����������(1);
			}
		}

		public object Get(OstatkiOtpuskovsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������.�����������(���������);
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
