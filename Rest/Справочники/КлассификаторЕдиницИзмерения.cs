
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlassifikatorEdinicIzmereniya")]
	[Route("/Catalogs/KlassifikatorEdinicIzmereniya/{Code}")]
	public class KlassifikatorEdinicIzmereniyaRequest/*����������������������������������*/: V82.�����������������.����������������������������,IReturn<KlassifikatorEdinicIzmereniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlassifikatorEdinicIzmereniyaResponse//���������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlassifikatorEdinicIzmereniyas")]
	[Route("/Catalogs/KlassifikatorEdinicIzmereniyas/{Codes}")]
	public class KlassifikatorEdinicIzmereniyasRequest/*����������������������������������*/: IReturn<List<KlassifikatorEdinicIzmereniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlassifikatorEdinicIzmereniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlassifikatorEdinicIzmereniyasResponse//���������������������������������
	{
		public string Result {get;set;}
	}


	public class KlassifikatorEdinicIzmereniyaService /*����������������������������������*/ : Service
	{
		public object Any(KlassifikatorEdinicIzmereniyaRequest request)
		{
			return new KlassifikatorEdinicIzmereniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlassifikatorEdinicIzmereniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������.�����������(���������);
				if (������ == null)
				{
					return new KlassifikatorEdinicIzmereniyaResponse() {Result = "���������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������.�����������(1);
			}
		}

		public object Get(KlassifikatorEdinicIzmereniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������������.�����������(���������);
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
