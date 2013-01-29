
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Banki")]
	[Route("/Catalogs/Banki/{Code}")]
	public class BankiRequest/*�����������*/: V82.�����������������.�����,IReturn<BankiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class BankiResponse//����������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Bankis")]
	[Route("/Catalogs/Bankis/{Codes}")]
	public class BankisRequest/*�����������*/: IReturn<List<BankiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public BankisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class BankisResponse//����������
	{
		public string Result {get;set;}
	}


	public class BankiService /*�����������*/ : Service
	{
		public object Any(BankiRequest request)
		{
			return new BankiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(BankiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����.�����������(���������);
				if (������ == null)
				{
					return new BankiResponse() {Result = "����� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����.�����������(1);
			}
		}

		public object Get(BankisRequest request)
		{
			var ��������� = new List<V82.�����������������.�����>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����.�����������(���������);
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
