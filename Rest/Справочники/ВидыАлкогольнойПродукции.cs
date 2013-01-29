
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyAlkogolnojjProdukcii")]
	[Route("/Catalogs/VidyAlkogolnojjProdukcii/{Code}")]
	public class VidyAlkogolnojjProdukciiRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<VidyAlkogolnojjProdukciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyAlkogolnojjProdukciiResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyAlkogolnojjProdukciis")]
	[Route("/Catalogs/VidyAlkogolnojjProdukciis/{Codes}")]
	public class VidyAlkogolnojjProdukciisRequest/*������������������������������*/: IReturn<List<VidyAlkogolnojjProdukciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyAlkogolnojjProdukciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyAlkogolnojjProdukciisResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class VidyAlkogolnojjProdukciiService /*������������������������������*/ : Service
	{
		public object Any(VidyAlkogolnojjProdukciiRequest request)
		{
			return new VidyAlkogolnojjProdukciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyAlkogolnojjProdukciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyAlkogolnojjProdukciiResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(VidyAlkogolnojjProdukciisRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
