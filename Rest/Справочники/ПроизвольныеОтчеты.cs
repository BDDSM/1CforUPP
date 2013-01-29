
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProizvolnyeOtchety")]
	[Route("/Catalogs/ProizvolnyeOtchety/{Code}")]
	public class ProizvolnyeOtchetyRequest/*������������������������*/: V82.�����������������.������������������,IReturn<ProizvolnyeOtchetyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProizvolnyeOtchetyResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProizvolnyeOtchetys")]
	[Route("/Catalogs/ProizvolnyeOtchetys/{Codes}")]
	public class ProizvolnyeOtchetysRequest/*������������������������*/: IReturn<List<ProizvolnyeOtchetyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProizvolnyeOtchetysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProizvolnyeOtchetysResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class ProizvolnyeOtchetyService /*������������������������*/ : Service
	{
		public object Any(ProizvolnyeOtchetyRequest request)
		{
			return new ProizvolnyeOtchetyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProizvolnyeOtchetyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new ProizvolnyeOtchetyResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(ProizvolnyeOtchetysRequest request)
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
