
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProfiliIzmeneniyaPlanovPoIzmereniyam")]
	[Route("/Catalogs/ProfiliIzmeneniyaPlanovPoIzmereniyam/{Code}")]
	public class ProfiliIzmeneniyaPlanovPoIzmereniyamRequest/*����������������������������������������*/: V82.�����������������.����������������������������������,IReturn<ProfiliIzmeneniyaPlanovPoIzmereniyamRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProfiliIzmeneniyaPlanovPoIzmereniyamResponse//���������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProfiliIzmeneniyaPlanovPoIzmereniyams")]
	[Route("/Catalogs/ProfiliIzmeneniyaPlanovPoIzmereniyams/{Codes}")]
	public class ProfiliIzmeneniyaPlanovPoIzmereniyamsRequest/*����������������������������������������*/: IReturn<List<ProfiliIzmeneniyaPlanovPoIzmereniyamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProfiliIzmeneniyaPlanovPoIzmereniyamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProfiliIzmeneniyaPlanovPoIzmereniyamsResponse//���������������������������������������
	{
		public string Result {get;set;}
	}


	public class ProfiliIzmeneniyaPlanovPoIzmereniyamService /*����������������������������������������*/ : Service
	{
		public object Any(ProfiliIzmeneniyaPlanovPoIzmereniyamRequest request)
		{
			return new ProfiliIzmeneniyaPlanovPoIzmereniyamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProfiliIzmeneniyaPlanovPoIzmereniyamRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ProfiliIzmeneniyaPlanovPoIzmereniyamResponse() {Result = "���������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������������.�����������(1);
			}
		}

		public object Get(ProfiliIzmeneniyaPlanovPoIzmereniyamsRequest request)
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
