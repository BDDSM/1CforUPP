
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlyuchiAnalitikiRaspredeleniyaZatrat")]
	[Route("/Catalogs/KlyuchiAnalitikiRaspredeleniyaZatrat/{Code}")]
	public class KlyuchiAnalitikiRaspredeleniyaZatratRequest/*���������������������������������������*/: V82.�����������������.���������������������������������,IReturn<KlyuchiAnalitikiRaspredeleniyaZatratRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlyuchiAnalitikiRaspredeleniyaZatratResponse//��������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlyuchiAnalitikiRaspredeleniyaZatrats")]
	[Route("/Catalogs/KlyuchiAnalitikiRaspredeleniyaZatrats/{Codes}")]
	public class KlyuchiAnalitikiRaspredeleniyaZatratsRequest/*���������������������������������������*/: IReturn<List<KlyuchiAnalitikiRaspredeleniyaZatratRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlyuchiAnalitikiRaspredeleniyaZatratsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlyuchiAnalitikiRaspredeleniyaZatratsResponse//��������������������������������������
	{
		public string Result {get;set;}
	}


	public class KlyuchiAnalitikiRaspredeleniyaZatratService /*���������������������������������������*/ : Service
	{
		public object Any(KlyuchiAnalitikiRaspredeleniyaZatratRequest request)
		{
			return new KlyuchiAnalitikiRaspredeleniyaZatratResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlyuchiAnalitikiRaspredeleniyaZatratRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������������.�����������(���������);
				if (������ == null)
				{
					return new KlyuchiAnalitikiRaspredeleniyaZatratResponse() {Result = "��������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������������.�����������(1);
			}
		}

		public object Get(KlyuchiAnalitikiRaspredeleniyaZatratsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������������.�����������(���������);
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
