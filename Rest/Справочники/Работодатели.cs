
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Rabotodateli")]
	[Route("/Catalogs/Rabotodateli/{Code}")]
	public class RabotodateliRequest/*������������������*/: V82.�����������������.������������,IReturn<RabotodateliRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RabotodateliResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Rabotodatelis")]
	[Route("/Catalogs/Rabotodatelis/{Codes}")]
	public class RabotodatelisRequest/*������������������*/: IReturn<List<RabotodateliRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RabotodatelisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RabotodatelisResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class RabotodateliService /*������������������*/ : Service
	{
		public object Any(RabotodateliRequest request)
		{
			return new RabotodateliResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RabotodateliRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new RabotodateliResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(RabotodatelisRequest request)
		{
			var ��������� = new List<V82.�����������������.������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������.�����������(���������);
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
