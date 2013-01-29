
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OrganyFSGS")]
	[Route("/Catalogs/OrganyFSGS/{Code}")]
	public class OrganyFSGSRequest/*����������������*/: V82.�����������������.����������,IReturn<OrganyFSGSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OrganyFSGSResponse//���������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OrganyFSGSs")]
	[Route("/Catalogs/OrganyFSGSs/{Codes}")]
	public class OrganyFSGSsRequest/*����������������*/: IReturn<List<OrganyFSGSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OrganyFSGSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OrganyFSGSsResponse//���������������
	{
		public string Result {get;set;}
	}


	public class OrganyFSGSService /*����������������*/ : Service
	{
		public object Any(OrganyFSGSRequest request)
		{
			return new OrganyFSGSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OrganyFSGSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������.�����������(���������);
				if (������ == null)
				{
					return new OrganyFSGSResponse() {Result = "���������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������.�����������(1);
			}
		}

		public object Get(OrganyFSGSsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������.�����������(���������);
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
