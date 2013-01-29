
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KontaktnyeLicaKontragentov")]
	[Route("/Catalogs/KontaktnyeLicaKontragentov/{Code}")]
	public class KontaktnyeLicaKontragentovRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<KontaktnyeLicaKontragentovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KontaktnyeLicaKontragentovResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KontaktnyeLicaKontragentovs")]
	[Route("/Catalogs/KontaktnyeLicaKontragentovs/{Codes}")]
	public class KontaktnyeLicaKontragentovsRequest/*��������������������������������*/: IReturn<List<KontaktnyeLicaKontragentovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KontaktnyeLicaKontragentovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KontaktnyeLicaKontragentovsResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class KontaktnyeLicaKontragentovService /*��������������������������������*/ : Service
	{
		public object Any(KontaktnyeLicaKontragentovRequest request)
		{
			return new KontaktnyeLicaKontragentovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KontaktnyeLicaKontragentovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new KontaktnyeLicaKontragentovResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(KontaktnyeLicaKontragentovsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
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
