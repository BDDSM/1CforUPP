
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PerepiskaSKontroliruyushhimiOrganami")]
	[Route("/Catalogs/PerepiskaSKontroliruyushhimiOrganami/{Code}")]
	public class PerepiskaSKontroliruyushhimiOrganamiRequest/*���������������������������������������*/: V82.�����������������.���������������������������������,IReturn<PerepiskaSKontroliruyushhimiOrganamiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PerepiskaSKontroliruyushhimiOrganamiResponse//��������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PerepiskaSKontroliruyushhimiOrganamis")]
	[Route("/Catalogs/PerepiskaSKontroliruyushhimiOrganamis/{Codes}")]
	public class PerepiskaSKontroliruyushhimiOrganamisRequest/*���������������������������������������*/: IReturn<List<PerepiskaSKontroliruyushhimiOrganamiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PerepiskaSKontroliruyushhimiOrganamisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PerepiskaSKontroliruyushhimiOrganamisResponse//��������������������������������������
	{
		public string Result {get;set;}
	}


	public class PerepiskaSKontroliruyushhimiOrganamiService /*���������������������������������������*/ : Service
	{
		public object Any(PerepiskaSKontroliruyushhimiOrganamiRequest request)
		{
			return new PerepiskaSKontroliruyushhimiOrganamiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PerepiskaSKontroliruyushhimiOrganamiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������������.�����������(���������);
				if (������ == null)
				{
					return new PerepiskaSKontroliruyushhimiOrganamiResponse() {Result = "��������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������������.�����������(1);
			}
		}

		public object Get(PerepiskaSKontroliruyushhimiOrganamisRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������������.�����������(���������);
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
