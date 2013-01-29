
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PodrazdeleniyaOrganizacijj")]
	[Route("/Catalogs/PodrazdeleniyaOrganizacijj/{Code}")]
	public class PodrazdeleniyaOrganizacijjRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<PodrazdeleniyaOrganizacijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PodrazdeleniyaOrganizacijjResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PodrazdeleniyaOrganizacijjs")]
	[Route("/Catalogs/PodrazdeleniyaOrganizacijjs/{Codes}")]
	public class PodrazdeleniyaOrganizacijjsRequest/*������������������������������*/: IReturn<List<PodrazdeleniyaOrganizacijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PodrazdeleniyaOrganizacijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PodrazdeleniyaOrganizacijjsResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class PodrazdeleniyaOrganizacijjService /*������������������������������*/ : Service
	{
		public object Any(PodrazdeleniyaOrganizacijjRequest request)
		{
			return new PodrazdeleniyaOrganizacijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PodrazdeleniyaOrganizacijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new PodrazdeleniyaOrganizacijjResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(PodrazdeleniyaOrganizacijjsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
