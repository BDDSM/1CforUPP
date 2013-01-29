
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/IndividualnyeGrafikiAmortizacii")]
	[Route("/Catalogs/IndividualnyeGrafikiAmortizacii/{Code}")]
	public class IndividualnyeGrafikiAmortizaciiRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<IndividualnyeGrafikiAmortizaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class IndividualnyeGrafikiAmortizaciiResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/IndividualnyeGrafikiAmortizaciis")]
	[Route("/Catalogs/IndividualnyeGrafikiAmortizaciis/{Codes}")]
	public class IndividualnyeGrafikiAmortizaciisRequest/*��������������������������������������*/: IReturn<List<IndividualnyeGrafikiAmortizaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public IndividualnyeGrafikiAmortizaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class IndividualnyeGrafikiAmortizaciisResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class IndividualnyeGrafikiAmortizaciiService /*��������������������������������������*/ : Service
	{
		public object Any(IndividualnyeGrafikiAmortizaciiRequest request)
		{
			return new IndividualnyeGrafikiAmortizaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(IndividualnyeGrafikiAmortizaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new IndividualnyeGrafikiAmortizaciiResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(IndividualnyeGrafikiAmortizaciisRequest request)
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
