
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OtpravkiFSS")]
	[Route("/Catalogs/OtpravkiFSS/{Code}")]
	public class OtpravkiFSSRequest/*�����������������*/: V82.�����������������.�����������,IReturn<OtpravkiFSSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OtpravkiFSSResponse//����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OtpravkiFSSs")]
	[Route("/Catalogs/OtpravkiFSSs/{Codes}")]
	public class OtpravkiFSSsRequest/*�����������������*/: IReturn<List<OtpravkiFSSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OtpravkiFSSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OtpravkiFSSsResponse//����������������
	{
		public string Result {get;set;}
	}


	public class OtpravkiFSSService /*�����������������*/ : Service
	{
		public object Any(OtpravkiFSSRequest request)
		{
			return new OtpravkiFSSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OtpravkiFSSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������.�����������(���������);
				if (������ == null)
				{
					return new OtpravkiFSSResponse() {Result = "����������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������.�����������(1);
			}
		}

		public object Get(OtpravkiFSSsRequest request)
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
