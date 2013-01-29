
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KHranilishheDopolnitelnojjInformacii")]
	[Route("/Catalogs/KHranilishheDopolnitelnojjInformacii/{Code}")]
	public class KHranilishheDopolnitelnojjInformaciiRequest/*���������������������������������������*/: V82.�����������������.���������������������������������,IReturn<KHranilishheDopolnitelnojjInformaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KHranilishheDopolnitelnojjInformaciiResponse//��������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KHranilishheDopolnitelnojjInformaciis")]
	[Route("/Catalogs/KHranilishheDopolnitelnojjInformaciis/{Codes}")]
	public class KHranilishheDopolnitelnojjInformaciisRequest/*���������������������������������������*/: IReturn<List<KHranilishheDopolnitelnojjInformaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KHranilishheDopolnitelnojjInformaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KHranilishheDopolnitelnojjInformaciisResponse//��������������������������������������
	{
		public string Result {get;set;}
	}


	public class KHranilishheDopolnitelnojjInformaciiService /*���������������������������������������*/ : Service
	{
		public object Any(KHranilishheDopolnitelnojjInformaciiRequest request)
		{
			return new KHranilishheDopolnitelnojjInformaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KHranilishheDopolnitelnojjInformaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������������.�����������(���������);
				if (������ == null)
				{
					return new KHranilishheDopolnitelnojjInformaciiResponse() {Result = "��������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������������.�����������(1);
			}
		}

		public object Get(KHranilishheDopolnitelnojjInformaciisRequest request)
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
