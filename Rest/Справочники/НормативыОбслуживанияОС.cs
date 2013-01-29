
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NormativyObsluzhivaniyaOS")]
	[Route("/Catalogs/NormativyObsluzhivaniyaOS/{Code}")]
	public class NormativyObsluzhivaniyaOSRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<NormativyObsluzhivaniyaOSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NormativyObsluzhivaniyaOSResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NormativyObsluzhivaniyaOSs")]
	[Route("/Catalogs/NormativyObsluzhivaniyaOSs/{Codes}")]
	public class NormativyObsluzhivaniyaOSsRequest/*�����������������������������*/: IReturn<List<NormativyObsluzhivaniyaOSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NormativyObsluzhivaniyaOSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NormativyObsluzhivaniyaOSsResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class NormativyObsluzhivaniyaOSService /*�����������������������������*/ : Service
	{
		public object Any(NormativyObsluzhivaniyaOSRequest request)
		{
			return new NormativyObsluzhivaniyaOSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NormativyObsluzhivaniyaOSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new NormativyObsluzhivaniyaOSResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(NormativyObsluzhivaniyaOSsRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������.�����������(���������);
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
