
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DetalizaciyaOtchetaOPribylyakhIUbytkakh")]
	[Route("/Catalogs/DetalizaciyaOtchetaOPribylyakhIUbytkakh/{Code}")]
	public class DetalizaciyaOtchetaOPribylyakhIUbytkakhRequest/*����������������������������������������*/: V82.�����������������.����������������������������������,IReturn<DetalizaciyaOtchetaOPribylyakhIUbytkakhRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DetalizaciyaOtchetaOPribylyakhIUbytkakhResponse//���������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DetalizaciyaOtchetaOPribylyakhIUbytkakhs")]
	[Route("/Catalogs/DetalizaciyaOtchetaOPribylyakhIUbytkakhs/{Codes}")]
	public class DetalizaciyaOtchetaOPribylyakhIUbytkakhsRequest/*����������������������������������������*/: IReturn<List<DetalizaciyaOtchetaOPribylyakhIUbytkakhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DetalizaciyaOtchetaOPribylyakhIUbytkakhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DetalizaciyaOtchetaOPribylyakhIUbytkakhsResponse//���������������������������������������
	{
		public string Result {get;set;}
	}


	public class DetalizaciyaOtchetaOPribylyakhIUbytkakhService /*����������������������������������������*/ : Service
	{
		public object Any(DetalizaciyaOtchetaOPribylyakhIUbytkakhRequest request)
		{
			return new DetalizaciyaOtchetaOPribylyakhIUbytkakhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DetalizaciyaOtchetaOPribylyakhIUbytkakhRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������������.�����������(���������);
				if (������ == null)
				{
					return new DetalizaciyaOtchetaOPribylyakhIUbytkakhResponse() {Result = "���������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������������.�����������(1);
			}
		}

		public object Get(DetalizaciyaOtchetaOPribylyakhIUbytkakhsRequest request)
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
