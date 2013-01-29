
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PrichinyZakrytiyaZakazov")]
	[Route("/Catalogs/PrichinyZakrytiyaZakazov/{Code}")]
	public class PrichinyZakrytiyaZakazovRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<PrichinyZakrytiyaZakazovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PrichinyZakrytiyaZakazovResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PrichinyZakrytiyaZakazovs")]
	[Route("/Catalogs/PrichinyZakrytiyaZakazovs/{Codes}")]
	public class PrichinyZakrytiyaZakazovsRequest/*����������������������������*/: IReturn<List<PrichinyZakrytiyaZakazovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PrichinyZakrytiyaZakazovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PrichinyZakrytiyaZakazovsResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class PrichinyZakrytiyaZakazovService /*����������������������������*/ : Service
	{
		public object Any(PrichinyZakrytiyaZakazovRequest request)
		{
			return new PrichinyZakrytiyaZakazovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PrichinyZakrytiyaZakazovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new PrichinyZakrytiyaZakazovResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(PrichinyZakrytiyaZakazovsRequest request)
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
