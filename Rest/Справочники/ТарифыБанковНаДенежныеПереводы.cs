
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TarifyBankovNaDenezhnyePerevody")]
	[Route("/Catalogs/TarifyBankovNaDenezhnyePerevody/{Code}")]
	public class TarifyBankovNaDenezhnyePerevodyRequest/*������������������������������������*/: V82.�����������������.������������������������������,IReturn<TarifyBankovNaDenezhnyePerevodyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TarifyBankovNaDenezhnyePerevodyResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TarifyBankovNaDenezhnyePerevodys")]
	[Route("/Catalogs/TarifyBankovNaDenezhnyePerevodys/{Codes}")]
	public class TarifyBankovNaDenezhnyePerevodysRequest/*������������������������������������*/: IReturn<List<TarifyBankovNaDenezhnyePerevodyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TarifyBankovNaDenezhnyePerevodysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TarifyBankovNaDenezhnyePerevodysResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	public class TarifyBankovNaDenezhnyePerevodyService /*������������������������������������*/ : Service
	{
		public object Any(TarifyBankovNaDenezhnyePerevodyRequest request)
		{
			return new TarifyBankovNaDenezhnyePerevodyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TarifyBankovNaDenezhnyePerevodyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������.�����������(���������);
				if (������ == null)
				{
					return new TarifyBankovNaDenezhnyePerevodyResponse() {Result = "������������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������.�����������(1);
			}
		}

		public object Get(TarifyBankovNaDenezhnyePerevodysRequest request)
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
