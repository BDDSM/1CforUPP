
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TransportnyeUpakovki")]
	[Route("/Catalogs/TransportnyeUpakovki/{Code}")]
	public class TransportnyeUpakovkiRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<TransportnyeUpakovkiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TransportnyeUpakovkiResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TransportnyeUpakovkis")]
	[Route("/Catalogs/TransportnyeUpakovkis/{Codes}")]
	public class TransportnyeUpakovkisRequest/*��������������������������*/: IReturn<List<TransportnyeUpakovkiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TransportnyeUpakovkisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TransportnyeUpakovkisResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class TransportnyeUpakovkiService /*��������������������������*/ : Service
	{
		public object Any(TransportnyeUpakovkiRequest request)
		{
			return new TransportnyeUpakovkiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TransportnyeUpakovkiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new TransportnyeUpakovkiResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(TransportnyeUpakovkisRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
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
