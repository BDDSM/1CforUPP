
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OtraslevyeSegmentyPoMSFO")]
	[Route("/Catalogs/OtraslevyeSegmentyPoMSFO/{Code}")]
	public class OtraslevyeSegmentyPoMSFORequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<OtraslevyeSegmentyPoMSFORequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OtraslevyeSegmentyPoMSFOResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OtraslevyeSegmentyPoMSFOs")]
	[Route("/Catalogs/OtraslevyeSegmentyPoMSFOs/{Codes}")]
	public class OtraslevyeSegmentyPoMSFOsRequest/*������������������������������*/: IReturn<List<OtraslevyeSegmentyPoMSFORequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OtraslevyeSegmentyPoMSFOsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OtraslevyeSegmentyPoMSFOsResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class OtraslevyeSegmentyPoMSFOService /*������������������������������*/ : Service
	{
		public object Any(OtraslevyeSegmentyPoMSFORequest request)
		{
			return new OtraslevyeSegmentyPoMSFOResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OtraslevyeSegmentyPoMSFORequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new OtraslevyeSegmentyPoMSFOResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(OtraslevyeSegmentyPoMSFOsRequest request)
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
