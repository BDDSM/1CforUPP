
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/UchebnyeZavedeniya")]
	[Route("/Catalogs/UchebnyeZavedeniya/{Code}")]
	public class UchebnyeZavedeniyaRequest/*����������������������*/: V82.�����������������.����������������,IReturn<UchebnyeZavedeniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class UchebnyeZavedeniyaResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/UchebnyeZavedeniyas")]
	[Route("/Catalogs/UchebnyeZavedeniyas/{Codes}")]
	public class UchebnyeZavedeniyasRequest/*����������������������*/: IReturn<List<UchebnyeZavedeniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public UchebnyeZavedeniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class UchebnyeZavedeniyasResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class UchebnyeZavedeniyaService /*����������������������*/ : Service
	{
		public object Any(UchebnyeZavedeniyaRequest request)
		{
			return new UchebnyeZavedeniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(UchebnyeZavedeniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new UchebnyeZavedeniyaResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(UchebnyeZavedeniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
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
