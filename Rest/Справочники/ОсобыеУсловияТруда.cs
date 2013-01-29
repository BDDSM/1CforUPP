
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OsobyeUsloviyaTruda")]
	[Route("/Catalogs/OsobyeUsloviyaTruda/{Code}")]
	public class OsobyeUsloviyaTrudaRequest/*������������������������*/: V82.�����������������.������������������,IReturn<OsobyeUsloviyaTrudaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OsobyeUsloviyaTrudaResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OsobyeUsloviyaTrudas")]
	[Route("/Catalogs/OsobyeUsloviyaTrudas/{Codes}")]
	public class OsobyeUsloviyaTrudasRequest/*������������������������*/: IReturn<List<OsobyeUsloviyaTrudaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OsobyeUsloviyaTrudasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OsobyeUsloviyaTrudasResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class OsobyeUsloviyaTrudaService /*������������������������*/ : Service
	{
		public object Any(OsobyeUsloviyaTrudaRequest request)
		{
			return new OsobyeUsloviyaTrudaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OsobyeUsloviyaTrudaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new OsobyeUsloviyaTrudaResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(OsobyeUsloviyaTrudasRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������.�����������(���������);
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
