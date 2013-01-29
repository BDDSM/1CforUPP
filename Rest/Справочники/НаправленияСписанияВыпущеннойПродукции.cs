
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NapravleniyaSpisaniyaVypushhennojjProdukcii")]
	[Route("/Catalogs/NapravleniyaSpisaniyaVypushhennojjProdukcii/{Code}")]
	public class NapravleniyaSpisaniyaVypushhennojjProdukciiRequest/*��������������������������������������������*/: V82.�����������������.��������������������������������������,IReturn<NapravleniyaSpisaniyaVypushhennojjProdukciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NapravleniyaSpisaniyaVypushhennojjProdukciiResponse//�������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NapravleniyaSpisaniyaVypushhennojjProdukciis")]
	[Route("/Catalogs/NapravleniyaSpisaniyaVypushhennojjProdukciis/{Codes}")]
	public class NapravleniyaSpisaniyaVypushhennojjProdukciisRequest/*��������������������������������������������*/: IReturn<List<NapravleniyaSpisaniyaVypushhennojjProdukciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NapravleniyaSpisaniyaVypushhennojjProdukciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NapravleniyaSpisaniyaVypushhennojjProdukciisResponse//�������������������������������������������
	{
		public string Result {get;set;}
	}


	public class NapravleniyaSpisaniyaVypushhennojjProdukciiService /*��������������������������������������������*/ : Service
	{
		public object Any(NapravleniyaSpisaniyaVypushhennojjProdukciiRequest request)
		{
			return new NapravleniyaSpisaniyaVypushhennojjProdukciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NapravleniyaSpisaniyaVypushhennojjProdukciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NapravleniyaSpisaniyaVypushhennojjProdukciiResponse() {Result = "�������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������������.�����������(1);
			}
		}

		public object Get(NapravleniyaSpisaniyaVypushhennojjProdukciisRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������������.�����������(���������);
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
