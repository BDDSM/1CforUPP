
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SostavMeropriyatiya")]
	[Route("/Catalogs/SostavMeropriyatiya/{Code}")]
	public class SostavMeropriyatiyaRequest/*�����������������������*/: V82.�����������������.�����������������,IReturn<SostavMeropriyatiyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SostavMeropriyatiyaResponse//����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SostavMeropriyatiyas")]
	[Route("/Catalogs/SostavMeropriyatiyas/{Codes}")]
	public class SostavMeropriyatiyasRequest/*�����������������������*/: IReturn<List<SostavMeropriyatiyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SostavMeropriyatiyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SostavMeropriyatiyasResponse//����������������������
	{
		public string Result {get;set;}
	}


	public class SostavMeropriyatiyaService /*�����������������������*/ : Service
	{
		public object Any(SostavMeropriyatiyaRequest request)
		{
			return new SostavMeropriyatiyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SostavMeropriyatiyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������.�����������(���������);
				if (������ == null)
				{
					return new SostavMeropriyatiyaResponse() {Result = "����������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������.�����������(1);
			}
		}

		public object Get(SostavMeropriyatiyasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������.�����������(���������);
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
