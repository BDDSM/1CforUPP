
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GodovyeGrafikiAmortizaciiOS")]
	[Route("/Catalogs/GodovyeGrafikiAmortizaciiOS/{Code}")]
	public class GodovyeGrafikiAmortizaciiOSRequest/*���������������������������������*/: V82.�����������������.���������������������������,IReturn<GodovyeGrafikiAmortizaciiOSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GodovyeGrafikiAmortizaciiOSResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GodovyeGrafikiAmortizaciiOSs")]
	[Route("/Catalogs/GodovyeGrafikiAmortizaciiOSs/{Codes}")]
	public class GodovyeGrafikiAmortizaciiOSsRequest/*���������������������������������*/: IReturn<List<GodovyeGrafikiAmortizaciiOSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GodovyeGrafikiAmortizaciiOSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GodovyeGrafikiAmortizaciiOSsResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	public class GodovyeGrafikiAmortizaciiOSService /*���������������������������������*/ : Service
	{
		public object Any(GodovyeGrafikiAmortizaciiOSRequest request)
		{
			return new GodovyeGrafikiAmortizaciiOSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GodovyeGrafikiAmortizaciiOSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������.�����������(���������);
				if (������ == null)
				{
					return new GodovyeGrafikiAmortizaciiOSResponse() {Result = "��������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������.�����������(1);
			}
		}

		public object Get(GodovyeGrafikiAmortizaciiOSsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������.�����������(���������);
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
