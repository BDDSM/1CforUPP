
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StrokiFinansovogoRascheta")]
	[Route("/Catalogs/StrokiFinansovogoRascheta/{Code}")]
	public class StrokiFinansovogoRaschetaRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<StrokiFinansovogoRaschetaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StrokiFinansovogoRaschetaResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StrokiFinansovogoRaschetas")]
	[Route("/Catalogs/StrokiFinansovogoRaschetas/{Codes}")]
	public class StrokiFinansovogoRaschetasRequest/*������������������������������*/: IReturn<List<StrokiFinansovogoRaschetaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StrokiFinansovogoRaschetasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StrokiFinansovogoRaschetasResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class StrokiFinansovogoRaschetaService /*������������������������������*/ : Service
	{
		public object Any(StrokiFinansovogoRaschetaRequest request)
		{
			return new StrokiFinansovogoRaschetaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StrokiFinansovogoRaschetaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new StrokiFinansovogoRaschetaResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(StrokiFinansovogoRaschetasRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
