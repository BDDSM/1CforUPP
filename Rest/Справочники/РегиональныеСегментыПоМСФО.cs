
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/RegionalnyeSegmentyPoMSFO")]
	[Route("/Catalogs/RegionalnyeSegmentyPoMSFO/{Code}")]
	public class RegionalnyeSegmentyPoMSFORequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<RegionalnyeSegmentyPoMSFORequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RegionalnyeSegmentyPoMSFOResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RegionalnyeSegmentyPoMSFOs")]
	[Route("/Catalogs/RegionalnyeSegmentyPoMSFOs/{Codes}")]
	public class RegionalnyeSegmentyPoMSFOsRequest/*��������������������������������*/: IReturn<List<RegionalnyeSegmentyPoMSFORequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RegionalnyeSegmentyPoMSFOsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RegionalnyeSegmentyPoMSFOsResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class RegionalnyeSegmentyPoMSFOService /*��������������������������������*/ : Service
	{
		public object Any(RegionalnyeSegmentyPoMSFORequest request)
		{
			return new RegionalnyeSegmentyPoMSFOResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RegionalnyeSegmentyPoMSFORequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new RegionalnyeSegmentyPoMSFOResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(RegionalnyeSegmentyPoMSFOsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
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
