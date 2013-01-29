
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlassifikatorOKOPF")]
	[Route("/Catalogs/KlassifikatorOKOPF/{Code}")]
	public class KlassifikatorOKOPFRequest/*������������������������*/: V82.�����������������.������������������,IReturn<KlassifikatorOKOPFRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlassifikatorOKOPFResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlassifikatorOKOPFs")]
	[Route("/Catalogs/KlassifikatorOKOPFs/{Codes}")]
	public class KlassifikatorOKOPFsRequest/*������������������������*/: IReturn<List<KlassifikatorOKOPFRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlassifikatorOKOPFsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlassifikatorOKOPFsResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class KlassifikatorOKOPFService /*������������������������*/ : Service
	{
		public object Any(KlassifikatorOKOPFRequest request)
		{
			return new KlassifikatorOKOPFResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlassifikatorOKOPFRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new KlassifikatorOKOPFResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(KlassifikatorOKOPFsRequest request)
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
