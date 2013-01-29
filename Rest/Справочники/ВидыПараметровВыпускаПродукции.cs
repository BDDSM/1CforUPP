
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyParametrovVypuskaProdukcii")]
	[Route("/Catalogs/VidyParametrovVypuskaProdukcii/{Code}")]
	public class VidyParametrovVypuskaProdukciiRequest/*������������������������������������*/: V82.�����������������.������������������������������,IReturn<VidyParametrovVypuskaProdukciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyParametrovVypuskaProdukciiResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyParametrovVypuskaProdukciis")]
	[Route("/Catalogs/VidyParametrovVypuskaProdukciis/{Codes}")]
	public class VidyParametrovVypuskaProdukciisRequest/*������������������������������������*/: IReturn<List<VidyParametrovVypuskaProdukciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyParametrovVypuskaProdukciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyParametrovVypuskaProdukciisResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	public class VidyParametrovVypuskaProdukciiService /*������������������������������������*/ : Service
	{
		public object Any(VidyParametrovVypuskaProdukciiRequest request)
		{
			return new VidyParametrovVypuskaProdukciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyParametrovVypuskaProdukciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyParametrovVypuskaProdukciiResponse() {Result = "������������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������.�����������(1);
			}
		}

		public object Get(VidyParametrovVypuskaProdukciisRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������������.�����������(���������);
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
