
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DetalizaciyaAnaliticheskogoBalansa")]
	[Route("/Catalogs/DetalizaciyaAnaliticheskogoBalansa/{Code}")]
	public class DetalizaciyaAnaliticheskogoBalansaRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<DetalizaciyaAnaliticheskogoBalansaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DetalizaciyaAnaliticheskogoBalansaResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DetalizaciyaAnaliticheskogoBalansas")]
	[Route("/Catalogs/DetalizaciyaAnaliticheskogoBalansas/{Codes}")]
	public class DetalizaciyaAnaliticheskogoBalansasRequest/*��������������������������������������*/: IReturn<List<DetalizaciyaAnaliticheskogoBalansaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DetalizaciyaAnaliticheskogoBalansasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DetalizaciyaAnaliticheskogoBalansasResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class DetalizaciyaAnaliticheskogoBalansaService /*��������������������������������������*/ : Service
	{
		public object Any(DetalizaciyaAnaliticheskogoBalansaRequest request)
		{
			return new DetalizaciyaAnaliticheskogoBalansaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DetalizaciyaAnaliticheskogoBalansaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new DetalizaciyaAnaliticheskogoBalansaResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(DetalizaciyaAnaliticheskogoBalansasRequest request)
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
