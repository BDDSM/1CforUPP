
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ParametryVyrabotkiOS")]
	[Route("/Catalogs/ParametryVyrabotkiOS/{Code}")]
	public class ParametryVyrabotkiOSRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<ParametryVyrabotkiOSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ParametryVyrabotkiOSResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ParametryVyrabotkiOSs")]
	[Route("/Catalogs/ParametryVyrabotkiOSs/{Codes}")]
	public class ParametryVyrabotkiOSsRequest/*��������������������������*/: IReturn<List<ParametryVyrabotkiOSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ParametryVyrabotkiOSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ParametryVyrabotkiOSsResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class ParametryVyrabotkiOSService /*��������������������������*/ : Service
	{
		public object Any(ParametryVyrabotkiOSRequest request)
		{
			return new ParametryVyrabotkiOSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ParametryVyrabotkiOSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new ParametryVyrabotkiOSResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(ParametryVyrabotkiOSsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
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
