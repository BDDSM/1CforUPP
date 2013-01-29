
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OsnovaniyaUvolneniyaIzOrganizacii")]
	[Route("/Catalogs/OsnovaniyaUvolneniyaIzOrganizacii/{Code}")]
	public class OsnovaniyaUvolneniyaIzOrganizaciiRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<OsnovaniyaUvolneniyaIzOrganizaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OsnovaniyaUvolneniyaIzOrganizaciiResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OsnovaniyaUvolneniyaIzOrganizaciis")]
	[Route("/Catalogs/OsnovaniyaUvolneniyaIzOrganizaciis/{Codes}")]
	public class OsnovaniyaUvolneniyaIzOrganizaciisRequest/*��������������������������������������*/: IReturn<List<OsnovaniyaUvolneniyaIzOrganizaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OsnovaniyaUvolneniyaIzOrganizaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OsnovaniyaUvolneniyaIzOrganizaciisResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class OsnovaniyaUvolneniyaIzOrganizaciiService /*��������������������������������������*/ : Service
	{
		public object Any(OsnovaniyaUvolneniyaIzOrganizaciiRequest request)
		{
			return new OsnovaniyaUvolneniyaIzOrganizaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OsnovaniyaUvolneniyaIzOrganizaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new OsnovaniyaUvolneniyaIzOrganizaciiResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(OsnovaniyaUvolneniyaIzOrganizaciisRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������.�����������(���������);
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
