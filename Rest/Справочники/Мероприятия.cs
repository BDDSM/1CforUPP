
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Meropriyatiya")]
	[Route("/Catalogs/Meropriyatiya/{Code}")]
	public class MeropriyatiyaRequest/*�����������������*/: V82.�����������������.�����������,IReturn<MeropriyatiyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class MeropriyatiyaResponse//����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Meropriyatiyas")]
	[Route("/Catalogs/Meropriyatiyas/{Codes}")]
	public class MeropriyatiyasRequest/*�����������������*/: IReturn<List<MeropriyatiyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public MeropriyatiyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class MeropriyatiyasResponse//����������������
	{
		public string Result {get;set;}
	}


	public class MeropriyatiyaService /*�����������������*/ : Service
	{
		public object Any(MeropriyatiyaRequest request)
		{
			return new MeropriyatiyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(MeropriyatiyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������.�����������(���������);
				if (������ == null)
				{
					return new MeropriyatiyaResponse() {Result = "����������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������.�����������(1);
			}
		}

		public object Get(MeropriyatiyasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������.�����������(���������);
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
