
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ObshherossijjskijjKlassifikatorProdukcii")]
	[Route("/Catalogs/ObshherossijjskijjKlassifikatorProdukcii/{Code}")]
	public class ObshherossijjskijjKlassifikatorProdukciiRequest/*������������������������������������������*/: V82.�����������������.������������������������������������,IReturn<ObshherossijjskijjKlassifikatorProdukciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ObshherossijjskijjKlassifikatorProdukciiResponse//�����������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ObshherossijjskijjKlassifikatorProdukciis")]
	[Route("/Catalogs/ObshherossijjskijjKlassifikatorProdukciis/{Codes}")]
	public class ObshherossijjskijjKlassifikatorProdukciisRequest/*������������������������������������������*/: IReturn<List<ObshherossijjskijjKlassifikatorProdukciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ObshherossijjskijjKlassifikatorProdukciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ObshherossijjskijjKlassifikatorProdukciisResponse//�����������������������������������������
	{
		public string Result {get;set;}
	}


	public class ObshherossijjskijjKlassifikatorProdukciiService /*������������������������������������������*/ : Service
	{
		public object Any(ObshherossijjskijjKlassifikatorProdukciiRequest request)
		{
			return new ObshherossijjskijjKlassifikatorProdukciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ObshherossijjskijjKlassifikatorProdukciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ObshherossijjskijjKlassifikatorProdukciiResponse() {Result = "������������������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������������.�����������(1);
			}
		}

		public object Get(ObshherossijjskijjKlassifikatorProdukciisRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������������������.�����������(���������);
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
