
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlassifikatorIspolzovaniyaRabochegoVremeni")]
	[Route("/Catalogs/KlassifikatorIspolzovaniyaRabochegoVremeni/{Code}")]
	public class KlassifikatorIspolzovaniyaRabochegoVremeniRequest/*�����������������������������������������������*/: V82.�����������������.�����������������������������������������,IReturn<KlassifikatorIspolzovaniyaRabochegoVremeniRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlassifikatorIspolzovaniyaRabochegoVremeniResponse//����������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlassifikatorIspolzovaniyaRabochegoVremenis")]
	[Route("/Catalogs/KlassifikatorIspolzovaniyaRabochegoVremenis/{Codes}")]
	public class KlassifikatorIspolzovaniyaRabochegoVremenisRequest/*�����������������������������������������������*/: IReturn<List<KlassifikatorIspolzovaniyaRabochegoVremeniRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlassifikatorIspolzovaniyaRabochegoVremenisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlassifikatorIspolzovaniyaRabochegoVremenisResponse//����������������������������������������������
	{
		public string Result {get;set;}
	}


	public class KlassifikatorIspolzovaniyaRabochegoVremeniService /*�����������������������������������������������*/ : Service
	{
		public object Any(KlassifikatorIspolzovaniyaRabochegoVremeniRequest request)
		{
			return new KlassifikatorIspolzovaniyaRabochegoVremeniResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlassifikatorIspolzovaniyaRabochegoVremeniRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new KlassifikatorIspolzovaniyaRabochegoVremeniResponse() {Result = "����������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������������������.�����������(1);
			}
		}

		public object Get(KlassifikatorIspolzovaniyaRabochegoVremenisRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������������������.�����������(���������);
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
