
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OrganyPFR")]
	[Route("/Catalogs/OrganyPFR/{Code}")]
	public class OrganyPFRRequest/*���������������*/: V82.�����������������.���������,IReturn<OrganyPFRRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OrganyPFRResponse//��������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OrganyPFRs")]
	[Route("/Catalogs/OrganyPFRs/{Codes}")]
	public class OrganyPFRsRequest/*���������������*/: IReturn<List<OrganyPFRRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OrganyPFRsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OrganyPFRsResponse//��������������
	{
		public string Result {get;set;}
	}


	public class OrganyPFRService /*���������������*/ : Service
	{
		public object Any(OrganyPFRRequest request)
		{
			return new OrganyPFRResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OrganyPFRRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������.�����������(���������);
				if (������ == null)
				{
					return new OrganyPFRResponse() {Result = "��������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������.�����������(1);
			}
		}

		public object Get(OrganyPFRsRequest request)
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
