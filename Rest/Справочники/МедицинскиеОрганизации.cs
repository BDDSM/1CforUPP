
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/MedicinskieOrganizacii")]
	[Route("/Catalogs/MedicinskieOrganizacii/{Code}")]
	public class MedicinskieOrganizaciiRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<MedicinskieOrganizaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class MedicinskieOrganizaciiResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/MedicinskieOrganizaciis")]
	[Route("/Catalogs/MedicinskieOrganizaciis/{Codes}")]
	public class MedicinskieOrganizaciisRequest/*����������������������������*/: IReturn<List<MedicinskieOrganizaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public MedicinskieOrganizaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class MedicinskieOrganizaciisResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class MedicinskieOrganizaciiService /*����������������������������*/ : Service
	{
		public object Any(MedicinskieOrganizaciiRequest request)
		{
			return new MedicinskieOrganizaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(MedicinskieOrganizaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new MedicinskieOrganizaciiResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(MedicinskieOrganizaciisRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
