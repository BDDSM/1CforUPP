
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/RegistraciyaVIFNS")]
	[Route("/Catalogs/RegistraciyaVIFNS/{Code}")]
	public class RegistraciyaVIFNSRequest/*����������������������*/: V82.�����������������.����������������,IReturn<RegistraciyaVIFNSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RegistraciyaVIFNSResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RegistraciyaVIFNSs")]
	[Route("/Catalogs/RegistraciyaVIFNSs/{Codes}")]
	public class RegistraciyaVIFNSsRequest/*����������������������*/: IReturn<List<RegistraciyaVIFNSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RegistraciyaVIFNSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RegistraciyaVIFNSsResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class RegistraciyaVIFNSService /*����������������������*/ : Service
	{
		public object Any(RegistraciyaVIFNSRequest request)
		{
			return new RegistraciyaVIFNSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RegistraciyaVIFNSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new RegistraciyaVIFNSResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(RegistraciyaVIFNSsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
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
