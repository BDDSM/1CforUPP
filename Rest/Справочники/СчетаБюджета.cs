
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SchetaByudzheta")]
	[Route("/Catalogs/SchetaByudzheta/{Code}")]
	public class SchetaByudzhetaRequest/*������������������*/: V82.�����������������.������������,IReturn<SchetaByudzhetaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SchetaByudzhetaResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SchetaByudzhetas")]
	[Route("/Catalogs/SchetaByudzhetas/{Codes}")]
	public class SchetaByudzhetasRequest/*������������������*/: IReturn<List<SchetaByudzhetaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SchetaByudzhetasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SchetaByudzhetasResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class SchetaByudzhetaService /*������������������*/ : Service
	{
		public object Any(SchetaByudzhetaRequest request)
		{
			return new SchetaByudzhetaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SchetaByudzhetaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new SchetaByudzhetaResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(SchetaByudzhetasRequest request)
		{
			var ��������� = new List<V82.�����������������.������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������.�����������(���������);
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
