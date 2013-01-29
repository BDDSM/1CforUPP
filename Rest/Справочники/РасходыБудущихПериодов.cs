
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/RaskhodyBudushhikhPeriodov")]
	[Route("/Catalogs/RaskhodyBudushhikhPeriodov/{Code}")]
	public class RaskhodyBudushhikhPeriodovRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<RaskhodyBudushhikhPeriodovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RaskhodyBudushhikhPeriodovResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RaskhodyBudushhikhPeriodovs")]
	[Route("/Catalogs/RaskhodyBudushhikhPeriodovs/{Codes}")]
	public class RaskhodyBudushhikhPeriodovsRequest/*����������������������������*/: IReturn<List<RaskhodyBudushhikhPeriodovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RaskhodyBudushhikhPeriodovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RaskhodyBudushhikhPeriodovsResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class RaskhodyBudushhikhPeriodovService /*����������������������������*/ : Service
	{
		public object Any(RaskhodyBudushhikhPeriodovRequest request)
		{
			return new RaskhodyBudushhikhPeriodovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RaskhodyBudushhikhPeriodovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new RaskhodyBudushhikhPeriodovResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(RaskhodyBudushhikhPeriodovsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
