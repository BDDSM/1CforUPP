
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TipyCenNomenklaturyKontragentov")]
	[Route("/Catalogs/TipyCenNomenklaturyKontragentov/{Code}")]
	public class TipyCenNomenklaturyKontragentovRequest/*�������������������������������������*/: V82.�����������������.�������������������������������,IReturn<TipyCenNomenklaturyKontragentovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TipyCenNomenklaturyKontragentovResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TipyCenNomenklaturyKontragentovs")]
	[Route("/Catalogs/TipyCenNomenklaturyKontragentovs/{Codes}")]
	public class TipyCenNomenklaturyKontragentovsRequest/*�������������������������������������*/: IReturn<List<TipyCenNomenklaturyKontragentovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TipyCenNomenklaturyKontragentovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TipyCenNomenklaturyKontragentovsResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	public class TipyCenNomenklaturyKontragentovService /*�������������������������������������*/ : Service
	{
		public object Any(TipyCenNomenklaturyKontragentovRequest request)
		{
			return new TipyCenNomenklaturyKontragentovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TipyCenNomenklaturyKontragentovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������.�����������(���������);
				if (������ == null)
				{
					return new TipyCenNomenklaturyKontragentovResponse() {Result = "������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������.�����������(1);
			}
		}

		public object Get(TipyCenNomenklaturyKontragentovsRequest request)
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
