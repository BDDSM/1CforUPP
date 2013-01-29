
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SotrudnikiOrganizacijj")]
	[Route("/Catalogs/SotrudnikiOrganizacijj/{Code}")]
	public class SotrudnikiOrganizacijjRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<SotrudnikiOrganizacijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SotrudnikiOrganizacijjResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SotrudnikiOrganizacijjs")]
	[Route("/Catalogs/SotrudnikiOrganizacijjs/{Codes}")]
	public class SotrudnikiOrganizacijjsRequest/*���������������������������*/: IReturn<List<SotrudnikiOrganizacijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SotrudnikiOrganizacijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SotrudnikiOrganizacijjsResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class SotrudnikiOrganizacijjService /*���������������������������*/ : Service
	{
		public object Any(SotrudnikiOrganizacijjRequest request)
		{
			return new SotrudnikiOrganizacijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SotrudnikiOrganizacijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new SotrudnikiOrganizacijjResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(SotrudnikiOrganizacijjsRequest request)
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
