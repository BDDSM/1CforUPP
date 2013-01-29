
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OstatkiOtpuskovOrganizacijj")]
	[Route("/Catalogs/OstatkiOtpuskovOrganizacijj/{Code}")]
	public class OstatkiOtpuskovOrganizacijjRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<OstatkiOtpuskovOrganizacijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OstatkiOtpuskovOrganizacijjResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OstatkiOtpuskovOrganizacijjs")]
	[Route("/Catalogs/OstatkiOtpuskovOrganizacijjs/{Codes}")]
	public class OstatkiOtpuskovOrganizacijjsRequest/*��������������������������������*/: IReturn<List<OstatkiOtpuskovOrganizacijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OstatkiOtpuskovOrganizacijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OstatkiOtpuskovOrganizacijjsResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class OstatkiOtpuskovOrganizacijjService /*��������������������������������*/ : Service
	{
		public object Any(OstatkiOtpuskovOrganizacijjRequest request)
		{
			return new OstatkiOtpuskovOrganizacijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OstatkiOtpuskovOrganizacijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new OstatkiOtpuskovOrganizacijjResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(OstatkiOtpuskovOrganizacijjsRequest request)
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
