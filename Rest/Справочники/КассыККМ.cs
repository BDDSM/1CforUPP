
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KassyKKM")]
	[Route("/Catalogs/KassyKKM/{Code}")]
	public class KassyKKMRequest/*��������������*/: V82.�����������������.��������,IReturn<KassyKKMRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KassyKKMResponse//�������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KassyKKMs")]
	[Route("/Catalogs/KassyKKMs/{Codes}")]
	public class KassyKKMsRequest/*��������������*/: IReturn<List<KassyKKMRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KassyKKMsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KassyKKMsResponse//�������������
	{
		public string Result {get;set;}
	}


	public class KassyKKMService /*��������������*/ : Service
	{
		public object Any(KassyKKMRequest request)
		{
			return new KassyKKMResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KassyKKMRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������.�����������(���������);
				if (������ == null)
				{
					return new KassyKKMResponse() {Result = "�������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������.�����������(1);
			}
		}

		public object Get(KassyKKMsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������.�����������(���������);
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
