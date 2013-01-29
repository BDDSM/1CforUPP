
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Organizacii")]
	[Route("/Catalogs/Organizacii/{Code}")]
	public class OrganizaciiRequest/*�����������������*/: V82.�����������������.�����������,IReturn<OrganizaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OrganizaciiResponse//����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Organizaciis")]
	[Route("/Catalogs/Organizaciis/{Codes}")]
	public class OrganizaciisRequest/*�����������������*/: IReturn<List<OrganizaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OrganizaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OrganizaciisResponse//����������������
	{
		public string Result {get;set;}
	}


	public class OrganizaciiService /*�����������������*/ : Service
	{
		public object Any(OrganizaciiRequest request)
		{
			return new OrganizaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OrganizaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������.�����������(���������);
				if (������ == null)
				{
					return new OrganizaciiResponse() {Result = "����������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������.�����������(1);
			}
		}

		public object Get(OrganizaciisRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������.�����������(���������);
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
