
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OsnovaniyaVyslugiLet")]
	[Route("/Catalogs/OsnovaniyaVyslugiLet/{Code}")]
	public class OsnovaniyaVyslugiLetRequest/*�������������������������*/: V82.�����������������.�������������������,IReturn<OsnovaniyaVyslugiLetRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OsnovaniyaVyslugiLetResponse//������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OsnovaniyaVyslugiLets")]
	[Route("/Catalogs/OsnovaniyaVyslugiLets/{Codes}")]
	public class OsnovaniyaVyslugiLetsRequest/*�������������������������*/: IReturn<List<OsnovaniyaVyslugiLetRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OsnovaniyaVyslugiLetsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OsnovaniyaVyslugiLetsResponse//������������������������
	{
		public string Result {get;set;}
	}


	public class OsnovaniyaVyslugiLetService /*�������������������������*/ : Service
	{
		public object Any(OsnovaniyaVyslugiLetRequest request)
		{
			return new OsnovaniyaVyslugiLetResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OsnovaniyaVyslugiLetRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������.�����������(���������);
				if (������ == null)
				{
					return new OsnovaniyaVyslugiLetResponse() {Result = "������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������.�����������(1);
			}
		}

		public object Get(OsnovaniyaVyslugiLetsRequest request)
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
