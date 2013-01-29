
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ParametryVypuskaProdukcii")]
	[Route("/Catalogs/ParametryVypuskaProdukcii/{Code}")]
	public class ParametryVypuskaProdukciiRequest/*�������������������������������*/: V82.�����������������.�������������������������,IReturn<ParametryVypuskaProdukciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ParametryVypuskaProdukciiResponse//������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ParametryVypuskaProdukciis")]
	[Route("/Catalogs/ParametryVypuskaProdukciis/{Codes}")]
	public class ParametryVypuskaProdukciisRequest/*�������������������������������*/: IReturn<List<ParametryVypuskaProdukciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ParametryVypuskaProdukciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ParametryVypuskaProdukciisResponse//������������������������������
	{
		public string Result {get;set;}
	}


	public class ParametryVypuskaProdukciiService /*�������������������������������*/ : Service
	{
		public object Any(ParametryVypuskaProdukciiRequest request)
		{
			return new ParametryVypuskaProdukciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ParametryVypuskaProdukciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������.�����������(���������);
				if (������ == null)
				{
					return new ParametryVypuskaProdukciiResponse() {Result = "������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������.�����������(1);
			}
		}

		public object Get(ParametryVypuskaProdukciisRequest request)
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
