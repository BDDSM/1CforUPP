
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SposobyOtrazheniyaRaskhodovPoAmortizacii")]
	[Route("/Catalogs/SposobyOtrazheniyaRaskhodovPoAmortizacii/{Code}")]
	public class SposobyOtrazheniyaRaskhodovPoAmortizaciiRequest/*�������������������������������������������*/: V82.�����������������.�������������������������������������,IReturn<SposobyOtrazheniyaRaskhodovPoAmortizaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SposobyOtrazheniyaRaskhodovPoAmortizaciiResponse//������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SposobyOtrazheniyaRaskhodovPoAmortizaciis")]
	[Route("/Catalogs/SposobyOtrazheniyaRaskhodovPoAmortizaciis/{Codes}")]
	public class SposobyOtrazheniyaRaskhodovPoAmortizaciisRequest/*�������������������������������������������*/: IReturn<List<SposobyOtrazheniyaRaskhodovPoAmortizaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SposobyOtrazheniyaRaskhodovPoAmortizaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SposobyOtrazheniyaRaskhodovPoAmortizaciisResponse//������������������������������������������
	{
		public string Result {get;set;}
	}


	public class SposobyOtrazheniyaRaskhodovPoAmortizaciiService /*�������������������������������������������*/ : Service
	{
		public object Any(SposobyOtrazheniyaRaskhodovPoAmortizaciiRequest request)
		{
			return new SposobyOtrazheniyaRaskhodovPoAmortizaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SposobyOtrazheniyaRaskhodovPoAmortizaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new SposobyOtrazheniyaRaskhodovPoAmortizaciiResponse() {Result = "������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������������.�����������(1);
			}
		}

		public object Get(SposobyOtrazheniyaRaskhodovPoAmortizaciisRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������������.�����������(���������);
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
