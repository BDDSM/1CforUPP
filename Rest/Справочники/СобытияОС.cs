
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SobytiyaOS")]
	[Route("/Catalogs/SobytiyaOS/{Code}")]
	public class SobytiyaOSRequest/*���������������*/: V82.�����������������.���������,IReturn<SobytiyaOSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SobytiyaOSResponse//��������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SobytiyaOSs")]
	[Route("/Catalogs/SobytiyaOSs/{Codes}")]
	public class SobytiyaOSsRequest/*���������������*/: IReturn<List<SobytiyaOSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SobytiyaOSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SobytiyaOSsResponse//��������������
	{
		public string Result {get;set;}
	}


	public class SobytiyaOSService /*���������������*/ : Service
	{
		public object Any(SobytiyaOSRequest request)
		{
			return new SobytiyaOSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SobytiyaOSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������.�����������(���������);
				if (������ == null)
				{
					return new SobytiyaOSResponse() {Result = "��������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������.�����������(1);
			}
		}

		public object Get(SobytiyaOSsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������.�����������(���������);
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
