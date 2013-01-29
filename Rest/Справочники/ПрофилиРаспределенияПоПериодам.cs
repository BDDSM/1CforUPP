
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProfiliRaspredeleniyaPoPeriodam")]
	[Route("/Catalogs/ProfiliRaspredeleniyaPoPeriodam/{Code}")]
	public class ProfiliRaspredeleniyaPoPeriodamRequest/*������������������������������������*/: V82.�����������������.������������������������������,IReturn<ProfiliRaspredeleniyaPoPeriodamRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProfiliRaspredeleniyaPoPeriodamResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProfiliRaspredeleniyaPoPeriodams")]
	[Route("/Catalogs/ProfiliRaspredeleniyaPoPeriodams/{Codes}")]
	public class ProfiliRaspredeleniyaPoPeriodamsRequest/*������������������������������������*/: IReturn<List<ProfiliRaspredeleniyaPoPeriodamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProfiliRaspredeleniyaPoPeriodamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProfiliRaspredeleniyaPoPeriodamsResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	public class ProfiliRaspredeleniyaPoPeriodamService /*������������������������������������*/ : Service
	{
		public object Any(ProfiliRaspredeleniyaPoPeriodamRequest request)
		{
			return new ProfiliRaspredeleniyaPoPeriodamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProfiliRaspredeleniyaPoPeriodamRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ProfiliRaspredeleniyaPoPeriodamResponse() {Result = "������������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������.�����������(1);
			}
		}

		public object Get(ProfiliRaspredeleniyaPoPeriodamsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������������.�����������(���������);
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
