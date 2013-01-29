
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/FormyObucheniya")]
	[Route("/Catalogs/FormyObucheniya/{Code}")]
	public class FormyObucheniyaRequest/*�������������������*/: V82.�����������������.�������������,IReturn<FormyObucheniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class FormyObucheniyaResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/FormyObucheniyas")]
	[Route("/Catalogs/FormyObucheniyas/{Codes}")]
	public class FormyObucheniyasRequest/*�������������������*/: IReturn<List<FormyObucheniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public FormyObucheniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class FormyObucheniyasResponse//������������������
	{
		public string Result {get;set;}
	}


	public class FormyObucheniyaService /*�������������������*/ : Service
	{
		public object Any(FormyObucheniyaRequest request)
		{
			return new FormyObucheniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(FormyObucheniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new FormyObucheniyaResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(FormyObucheniyasRequest request)
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
