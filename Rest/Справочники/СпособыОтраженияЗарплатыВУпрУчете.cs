
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVUprUchete")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVUprUchete/{Code}")]
	public class SposobyOtrazheniyaZarplatyVUprUcheteRequest/*���������������������������������������*/: V82.�����������������.���������������������������������,IReturn<SposobyOtrazheniyaZarplatyVUprUcheteRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SposobyOtrazheniyaZarplatyVUprUcheteResponse//��������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVUprUchetes")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVUprUchetes/{Codes}")]
	public class SposobyOtrazheniyaZarplatyVUprUchetesRequest/*���������������������������������������*/: IReturn<List<SposobyOtrazheniyaZarplatyVUprUcheteRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SposobyOtrazheniyaZarplatyVUprUchetesRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SposobyOtrazheniyaZarplatyVUprUchetesResponse//��������������������������������������
	{
		public string Result {get;set;}
	}


	public class SposobyOtrazheniyaZarplatyVUprUcheteService /*���������������������������������������*/ : Service
	{
		public object Any(SposobyOtrazheniyaZarplatyVUprUcheteRequest request)
		{
			return new SposobyOtrazheniyaZarplatyVUprUcheteResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SposobyOtrazheniyaZarplatyVUprUcheteRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������������.�����������(���������);
				if (������ == null)
				{
					return new SposobyOtrazheniyaZarplatyVUprUcheteResponse() {Result = "��������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������������.�����������(1);
			}
		}

		public object Get(SposobyOtrazheniyaZarplatyVUprUchetesRequest request)
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
