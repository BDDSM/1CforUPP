
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TarifnyeRazryady")]
	[Route("/Catalogs/TarifnyeRazryady/{Code}")]
	public class TarifnyeRazryadyRequest/*���������������������*/: V82.�����������������.���������������,IReturn<TarifnyeRazryadyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TarifnyeRazryadyResponse//��������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TarifnyeRazryadys")]
	[Route("/Catalogs/TarifnyeRazryadys/{Codes}")]
	public class TarifnyeRazryadysRequest/*���������������������*/: IReturn<List<TarifnyeRazryadyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TarifnyeRazryadysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TarifnyeRazryadysResponse//��������������������
	{
		public string Result {get;set;}
	}


	public class TarifnyeRazryadyService /*���������������������*/ : Service
	{
		public object Any(TarifnyeRazryadyRequest request)
		{
			return new TarifnyeRazryadyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TarifnyeRazryadyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������.�����������(���������);
				if (������ == null)
				{
					return new TarifnyeRazryadyResponse() {Result = "��������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������.�����������(1);
			}
		}

		public object Get(TarifnyeRazryadysRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������.�����������(���������);
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
