
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProfiliIzmeneniyaPlanovPoPeriodam")]
	[Route("/Catalogs/ProfiliIzmeneniyaPlanovPoPeriodam/{Code}")]
	public class ProfiliIzmeneniyaPlanovPoPeriodamRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<ProfiliIzmeneniyaPlanovPoPeriodamRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProfiliIzmeneniyaPlanovPoPeriodamResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProfiliIzmeneniyaPlanovPoPeriodams")]
	[Route("/Catalogs/ProfiliIzmeneniyaPlanovPoPeriodams/{Codes}")]
	public class ProfiliIzmeneniyaPlanovPoPeriodamsRequest/*��������������������������������������*/: IReturn<List<ProfiliIzmeneniyaPlanovPoPeriodamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProfiliIzmeneniyaPlanovPoPeriodamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProfiliIzmeneniyaPlanovPoPeriodamsResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class ProfiliIzmeneniyaPlanovPoPeriodamService /*��������������������������������������*/ : Service
	{
		public object Any(ProfiliIzmeneniyaPlanovPoPeriodamRequest request)
		{
			return new ProfiliIzmeneniyaPlanovPoPeriodamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProfiliIzmeneniyaPlanovPoPeriodamRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ProfiliIzmeneniyaPlanovPoPeriodamResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(ProfiliIzmeneniyaPlanovPoPeriodamsRequest request)
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
