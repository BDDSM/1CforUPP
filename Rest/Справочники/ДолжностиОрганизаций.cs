
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DolzhnostiOrganizacijj")]
	[Route("/Catalogs/DolzhnostiOrganizacijj/{Code}")]
	public class DolzhnostiOrganizacijjRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<DolzhnostiOrganizacijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DolzhnostiOrganizacijjResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DolzhnostiOrganizacijjs")]
	[Route("/Catalogs/DolzhnostiOrganizacijjs/{Codes}")]
	public class DolzhnostiOrganizacijjsRequest/*��������������������������*/: IReturn<List<DolzhnostiOrganizacijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DolzhnostiOrganizacijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DolzhnostiOrganizacijjsResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class DolzhnostiOrganizacijjService /*��������������������������*/ : Service
	{
		public object Any(DolzhnostiOrganizacijjRequest request)
		{
			return new DolzhnostiOrganizacijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DolzhnostiOrganizacijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new DolzhnostiOrganizacijjResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(DolzhnostiOrganizacijjsRequest request)
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
