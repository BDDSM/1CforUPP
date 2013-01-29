
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TipyZapisejjZametok")]
	[Route("/Catalogs/TipyZapisejjZametok/{Code}")]
	public class TipyZapisejjZametokRequest/*������������������������*/: V82.�����������������.������������������,IReturn<TipyZapisejjZametokRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TipyZapisejjZametokResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TipyZapisejjZametoks")]
	[Route("/Catalogs/TipyZapisejjZametoks/{Codes}")]
	public class TipyZapisejjZametoksRequest/*������������������������*/: IReturn<List<TipyZapisejjZametokRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TipyZapisejjZametoksRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TipyZapisejjZametoksResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class TipyZapisejjZametokService /*������������������������*/ : Service
	{
		public object Any(TipyZapisejjZametokRequest request)
		{
			return new TipyZapisejjZametokResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TipyZapisejjZametokRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new TipyZapisejjZametokResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(TipyZapisejjZametoksRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������.�����������(���������);
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
