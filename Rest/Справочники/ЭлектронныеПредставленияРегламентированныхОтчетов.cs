
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/EHlektronnyePredstavleniyaReglamentirovannykhOtchetov")]
	[Route("/Catalogs/EHlektronnyePredstavleniyaReglamentirovannykhOtchetov/{Code}")]
	public class EHlektronnyePredstavleniyaReglamentirovannykhOtchetovRequest/*�������������������������������������������������������*/: V82.�����������������.�������������������������������������������������,IReturn<EHlektronnyePredstavleniyaReglamentirovannykhOtchetovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class EHlektronnyePredstavleniyaReglamentirovannykhOtchetovResponse//������������������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/EHlektronnyePredstavleniyaReglamentirovannykhOtchetovs")]
	[Route("/Catalogs/EHlektronnyePredstavleniyaReglamentirovannykhOtchetovs/{Codes}")]
	public class EHlektronnyePredstavleniyaReglamentirovannykhOtchetovsRequest/*�������������������������������������������������������*/: IReturn<List<EHlektronnyePredstavleniyaReglamentirovannykhOtchetovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public EHlektronnyePredstavleniyaReglamentirovannykhOtchetovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class EHlektronnyePredstavleniyaReglamentirovannykhOtchetovsResponse//������������������������������������������������������
	{
		public string Result {get;set;}
	}


	public class EHlektronnyePredstavleniyaReglamentirovannykhOtchetovService /*�������������������������������������������������������*/ : Service
	{
		public object Any(EHlektronnyePredstavleniyaReglamentirovannykhOtchetovRequest request)
		{
			return new EHlektronnyePredstavleniyaReglamentirovannykhOtchetovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(EHlektronnyePredstavleniyaReglamentirovannykhOtchetovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new EHlektronnyePredstavleniyaReglamentirovannykhOtchetovResponse() {Result = "������������������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������������������������.�����������(1);
			}
		}

		public object Get(EHlektronnyePredstavleniyaReglamentirovannykhOtchetovsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������������������������.�����������(���������);
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
