
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlyuchiAnalitikiUchetaZatrat")]
	[Route("/Catalogs/KlyuchiAnalitikiUchetaZatrat/{Code}")]
	public class KlyuchiAnalitikiUchetaZatratRequest/*�������������������������������*/: V82.�����������������.�������������������������,IReturn<KlyuchiAnalitikiUchetaZatratRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlyuchiAnalitikiUchetaZatratResponse//������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlyuchiAnalitikiUchetaZatrats")]
	[Route("/Catalogs/KlyuchiAnalitikiUchetaZatrats/{Codes}")]
	public class KlyuchiAnalitikiUchetaZatratsRequest/*�������������������������������*/: IReturn<List<KlyuchiAnalitikiUchetaZatratRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlyuchiAnalitikiUchetaZatratsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlyuchiAnalitikiUchetaZatratsResponse//������������������������������
	{
		public string Result {get;set;}
	}


	public class KlyuchiAnalitikiUchetaZatratService /*�������������������������������*/ : Service
	{
		public object Any(KlyuchiAnalitikiUchetaZatratRequest request)
		{
			return new KlyuchiAnalitikiUchetaZatratResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlyuchiAnalitikiUchetaZatratRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������.�����������(���������);
				if (������ == null)
				{
					return new KlyuchiAnalitikiUchetaZatratResponse() {Result = "������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������.�����������(1);
			}
		}

		public object Get(KlyuchiAnalitikiUchetaZatratsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������.�����������(���������);
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
