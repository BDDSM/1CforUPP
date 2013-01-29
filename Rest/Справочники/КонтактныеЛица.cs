
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KontaktnyeLica")]
	[Route("/Catalogs/KontaktnyeLica/{Code}")]
	public class KontaktnyeLicaRequest/*��������������������*/: V82.�����������������.��������������,IReturn<KontaktnyeLicaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KontaktnyeLicaResponse//�������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KontaktnyeLicas")]
	[Route("/Catalogs/KontaktnyeLicas/{Codes}")]
	public class KontaktnyeLicasRequest/*��������������������*/: IReturn<List<KontaktnyeLicaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KontaktnyeLicasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KontaktnyeLicasResponse//�������������������
	{
		public string Result {get;set;}
	}


	public class KontaktnyeLicaService /*��������������������*/ : Service
	{
		public object Any(KontaktnyeLicaRequest request)
		{
			return new KontaktnyeLicaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KontaktnyeLicaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������.�����������(���������);
				if (������ == null)
				{
					return new KontaktnyeLicaResponse() {Result = "�������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������.�����������(1);
			}
		}

		public object Get(KontaktnyeLicasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������.�����������(���������);
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
