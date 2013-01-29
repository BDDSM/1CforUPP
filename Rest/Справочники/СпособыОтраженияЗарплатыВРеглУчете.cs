
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchete")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchete/{Code}")]
	public class SposobyOtrazheniyaZarplatyVReglUcheteRequest/*����������������������������������������*/: V82.�����������������.����������������������������������,IReturn<SposobyOtrazheniyaZarplatyVReglUcheteRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SposobyOtrazheniyaZarplatyVReglUcheteResponse//���������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchetes")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVReglUchetes/{Codes}")]
	public class SposobyOtrazheniyaZarplatyVReglUchetesRequest/*����������������������������������������*/: IReturn<List<SposobyOtrazheniyaZarplatyVReglUcheteRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SposobyOtrazheniyaZarplatyVReglUchetesRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SposobyOtrazheniyaZarplatyVReglUchetesResponse//���������������������������������������
	{
		public string Result {get;set;}
	}


	public class SposobyOtrazheniyaZarplatyVReglUcheteService /*����������������������������������������*/ : Service
	{
		public object Any(SposobyOtrazheniyaZarplatyVReglUcheteRequest request)
		{
			return new SposobyOtrazheniyaZarplatyVReglUcheteResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SposobyOtrazheniyaZarplatyVReglUcheteRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������������.�����������(���������);
				if (������ == null)
				{
					return new SposobyOtrazheniyaZarplatyVReglUcheteResponse() {Result = "���������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������������.�����������(1);
			}
		}

		public object Get(SposobyOtrazheniyaZarplatyVReglUchetesRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������������������.�����������(���������);
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
