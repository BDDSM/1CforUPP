
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DokhodyBudushhikhPeriodov")]
	[Route("/Catalogs/DokhodyBudushhikhPeriodov/{Code}")]
	public class DokhodyBudushhikhPeriodovRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<DokhodyBudushhikhPeriodovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DokhodyBudushhikhPeriodovResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DokhodyBudushhikhPeriodovs")]
	[Route("/Catalogs/DokhodyBudushhikhPeriodovs/{Codes}")]
	public class DokhodyBudushhikhPeriodovsRequest/*���������������������������*/: IReturn<List<DokhodyBudushhikhPeriodovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DokhodyBudushhikhPeriodovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DokhodyBudushhikhPeriodovsResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class DokhodyBudushhikhPeriodovService /*���������������������������*/ : Service
	{
		public object Any(DokhodyBudushhikhPeriodovRequest request)
		{
			return new DokhodyBudushhikhPeriodovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DokhodyBudushhikhPeriodovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new DokhodyBudushhikhPeriodovResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(DokhodyBudushhikhPeriodovsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������.�����������(���������);
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
