
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PrichinyObsluzhivaniyaOS")]
	[Route("/Catalogs/PrichinyObsluzhivaniyaOS/{Code}")]
	public class PrichinyObsluzhivaniyaOSRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<PrichinyObsluzhivaniyaOSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PrichinyObsluzhivaniyaOSResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PrichinyObsluzhivaniyaOSs")]
	[Route("/Catalogs/PrichinyObsluzhivaniyaOSs/{Codes}")]
	public class PrichinyObsluzhivaniyaOSsRequest/*���������������������������*/: IReturn<List<PrichinyObsluzhivaniyaOSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PrichinyObsluzhivaniyaOSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PrichinyObsluzhivaniyaOSsResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class PrichinyObsluzhivaniyaOSService /*���������������������������*/ : Service
	{
		public object Any(PrichinyObsluzhivaniyaOSRequest request)
		{
			return new PrichinyObsluzhivaniyaOSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PrichinyObsluzhivaniyaOSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new PrichinyObsluzhivaniyaOSResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(PrichinyObsluzhivaniyaOSsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������.�����������(���������);
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
