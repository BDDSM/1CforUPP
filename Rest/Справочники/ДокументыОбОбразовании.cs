
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DokumentyObObrazovanii")]
	[Route("/Catalogs/DokumentyObObrazovanii/{Code}")]
	public class DokumentyObObrazovaniiRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<DokumentyObObrazovaniiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DokumentyObObrazovaniiResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DokumentyObObrazovaniis")]
	[Route("/Catalogs/DokumentyObObrazovaniis/{Codes}")]
	public class DokumentyObObrazovaniisRequest/*����������������������������*/: IReturn<List<DokumentyObObrazovaniiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DokumentyObObrazovaniisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DokumentyObObrazovaniisResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class DokumentyObObrazovaniiService /*����������������������������*/ : Service
	{
		public object Any(DokumentyObObrazovaniiRequest request)
		{
			return new DokumentyObObrazovaniiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DokumentyObObrazovaniiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new DokumentyObObrazovaniiResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(DokumentyObObrazovaniisRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
