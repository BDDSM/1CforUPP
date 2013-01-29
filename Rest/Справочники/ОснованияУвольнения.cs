
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OsnovaniyaUvolneniya")]
	[Route("/Catalogs/OsnovaniyaUvolneniya/{Code}")]
	public class OsnovaniyaUvolneniyaRequest/*�������������������������*/: V82.�����������������.�������������������,IReturn<OsnovaniyaUvolneniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OsnovaniyaUvolneniyaResponse//������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OsnovaniyaUvolneniyas")]
	[Route("/Catalogs/OsnovaniyaUvolneniyas/{Codes}")]
	public class OsnovaniyaUvolneniyasRequest/*�������������������������*/: IReturn<List<OsnovaniyaUvolneniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OsnovaniyaUvolneniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OsnovaniyaUvolneniyasResponse//������������������������
	{
		public string Result {get;set;}
	}


	public class OsnovaniyaUvolneniyaService /*�������������������������*/ : Service
	{
		public object Any(OsnovaniyaUvolneniyaRequest request)
		{
			return new OsnovaniyaUvolneniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OsnovaniyaUvolneniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������.�����������(���������);
				if (������ == null)
				{
					return new OsnovaniyaUvolneniyaResponse() {Result = "������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������.�����������(1);
			}
		}

		public object Get(OsnovaniyaUvolneniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������.�����������(���������);
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
