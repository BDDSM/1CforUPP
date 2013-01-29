
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StatiByudzheta")]
	[Route("/Catalogs/StatiByudzheta/{Code}")]
	public class StatiByudzhetaRequest/*�������������������*/: V82.�����������������.�������������,IReturn<StatiByudzhetaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StatiByudzhetaResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StatiByudzhetas")]
	[Route("/Catalogs/StatiByudzhetas/{Codes}")]
	public class StatiByudzhetasRequest/*�������������������*/: IReturn<List<StatiByudzhetaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StatiByudzhetasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StatiByudzhetasResponse//������������������
	{
		public string Result {get;set;}
	}


	public class StatiByudzhetaService /*�������������������*/ : Service
	{
		public object Any(StatiByudzhetaRequest request)
		{
			return new StatiByudzhetaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StatiByudzhetaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new StatiByudzhetaResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(StatiByudzhetasRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
