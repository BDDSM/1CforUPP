
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlyuchiAnalitikiUchetaProchikhZatrat")]
	[Route("/Catalogs/KlyuchiAnalitikiUchetaProchikhZatrat/{Code}")]
	public class KlyuchiAnalitikiUchetaProchikhZatratRequest/*�������������������������������������*/: V82.�����������������.�������������������������������,IReturn<KlyuchiAnalitikiUchetaProchikhZatratRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlyuchiAnalitikiUchetaProchikhZatratResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlyuchiAnalitikiUchetaProchikhZatrats")]
	[Route("/Catalogs/KlyuchiAnalitikiUchetaProchikhZatrats/{Codes}")]
	public class KlyuchiAnalitikiUchetaProchikhZatratsRequest/*�������������������������������������*/: IReturn<List<KlyuchiAnalitikiUchetaProchikhZatratRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlyuchiAnalitikiUchetaProchikhZatratsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlyuchiAnalitikiUchetaProchikhZatratsResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	public class KlyuchiAnalitikiUchetaProchikhZatratService /*�������������������������������������*/ : Service
	{
		public object Any(KlyuchiAnalitikiUchetaProchikhZatratRequest request)
		{
			return new KlyuchiAnalitikiUchetaProchikhZatratResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlyuchiAnalitikiUchetaProchikhZatratRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������.�����������(���������);
				if (������ == null)
				{
					return new KlyuchiAnalitikiUchetaProchikhZatratResponse() {Result = "������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������.�����������(1);
			}
		}

		public object Get(KlyuchiAnalitikiUchetaProchikhZatratsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������.�����������(���������);
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
