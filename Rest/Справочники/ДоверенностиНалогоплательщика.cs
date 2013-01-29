
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DoverennostiNalogoplatelshhika")]
	[Route("/Catalogs/DoverennostiNalogoplatelshhika/{Code}")]
	public class DoverennostiNalogoplatelshhikaRequest/*�����������������������������������*/: V82.�����������������.�����������������������������,IReturn<DoverennostiNalogoplatelshhikaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DoverennostiNalogoplatelshhikaResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DoverennostiNalogoplatelshhikas")]
	[Route("/Catalogs/DoverennostiNalogoplatelshhikas/{Codes}")]
	public class DoverennostiNalogoplatelshhikasRequest/*�����������������������������������*/: IReturn<List<DoverennostiNalogoplatelshhikaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DoverennostiNalogoplatelshhikasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DoverennostiNalogoplatelshhikasResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	public class DoverennostiNalogoplatelshhikaService /*�����������������������������������*/ : Service
	{
		public object Any(DoverennostiNalogoplatelshhikaRequest request)
		{
			return new DoverennostiNalogoplatelshhikaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DoverennostiNalogoplatelshhikaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������.�����������(���������);
				if (������ == null)
				{
					return new DoverennostiNalogoplatelshhikaResponse() {Result = "����������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������.�����������(1);
			}
		}

		public object Get(DoverennostiNalogoplatelshhikasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������.�����������(���������);
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
