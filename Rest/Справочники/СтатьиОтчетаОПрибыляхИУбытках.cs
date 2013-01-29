
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StatiOtchetaOPribylyakhIUbytkakh")]
	[Route("/Catalogs/StatiOtchetaOPribylyakhIUbytkakh/{Code}")]
	public class StatiOtchetaOPribylyakhIUbytkakhRequest/*�����������������������������������*/: V82.�����������������.�����������������������������,IReturn<StatiOtchetaOPribylyakhIUbytkakhRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StatiOtchetaOPribylyakhIUbytkakhResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StatiOtchetaOPribylyakhIUbytkakhs")]
	[Route("/Catalogs/StatiOtchetaOPribylyakhIUbytkakhs/{Codes}")]
	public class StatiOtchetaOPribylyakhIUbytkakhsRequest/*�����������������������������������*/: IReturn<List<StatiOtchetaOPribylyakhIUbytkakhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StatiOtchetaOPribylyakhIUbytkakhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StatiOtchetaOPribylyakhIUbytkakhsResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	public class StatiOtchetaOPribylyakhIUbytkakhService /*�����������������������������������*/ : Service
	{
		public object Any(StatiOtchetaOPribylyakhIUbytkakhRequest request)
		{
			return new StatiOtchetaOPribylyakhIUbytkakhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StatiOtchetaOPribylyakhIUbytkakhRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������.�����������(���������);
				if (������ == null)
				{
					return new StatiOtchetaOPribylyakhIUbytkakhResponse() {Result = "����������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������.�����������(1);
			}
		}

		public object Get(StatiOtchetaOPribylyakhIUbytkakhsRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������.�����������(���������);
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
