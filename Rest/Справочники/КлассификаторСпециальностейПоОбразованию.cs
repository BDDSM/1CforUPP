
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlassifikatorSpecialnostejjPoObrazovaniyu")]
	[Route("/Catalogs/KlassifikatorSpecialnostejjPoObrazovaniyu/{Code}")]
	public class KlassifikatorSpecialnostejjPoObrazovaniyuRequest/*����������������������������������������������*/: V82.�����������������.����������������������������������������,IReturn<KlassifikatorSpecialnostejjPoObrazovaniyuRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlassifikatorSpecialnostejjPoObrazovaniyuResponse//���������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlassifikatorSpecialnostejjPoObrazovaniyus")]
	[Route("/Catalogs/KlassifikatorSpecialnostejjPoObrazovaniyus/{Codes}")]
	public class KlassifikatorSpecialnostejjPoObrazovaniyusRequest/*����������������������������������������������*/: IReturn<List<KlassifikatorSpecialnostejjPoObrazovaniyuRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlassifikatorSpecialnostejjPoObrazovaniyusRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlassifikatorSpecialnostejjPoObrazovaniyusResponse//���������������������������������������������
	{
		public string Result {get;set;}
	}


	public class KlassifikatorSpecialnostejjPoObrazovaniyuService /*����������������������������������������������*/ : Service
	{
		public object Any(KlassifikatorSpecialnostejjPoObrazovaniyuRequest request)
		{
			return new KlassifikatorSpecialnostejjPoObrazovaniyuResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlassifikatorSpecialnostejjPoObrazovaniyuRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new KlassifikatorSpecialnostejjPoObrazovaniyuResponse() {Result = "���������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������������������.�����������(1);
			}
		}

		public object Get(KlassifikatorSpecialnostejjPoObrazovaniyusRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������������������������.�����������(���������);
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
