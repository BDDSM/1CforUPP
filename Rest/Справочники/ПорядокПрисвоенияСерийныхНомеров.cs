
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PoryadokPrisvoeniyaSerijjnykhNomerov")]
	[Route("/Catalogs/PoryadokPrisvoeniyaSerijjnykhNomerov/{Code}")]
	public class PoryadokPrisvoeniyaSerijjnykhNomerovRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<PoryadokPrisvoeniyaSerijjnykhNomerovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PoryadokPrisvoeniyaSerijjnykhNomerovResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PoryadokPrisvoeniyaSerijjnykhNomerovs")]
	[Route("/Catalogs/PoryadokPrisvoeniyaSerijjnykhNomerovs/{Codes}")]
	public class PoryadokPrisvoeniyaSerijjnykhNomerovsRequest/*��������������������������������������*/: IReturn<List<PoryadokPrisvoeniyaSerijjnykhNomerovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PoryadokPrisvoeniyaSerijjnykhNomerovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PoryadokPrisvoeniyaSerijjnykhNomerovsResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class PoryadokPrisvoeniyaSerijjnykhNomerovService /*��������������������������������������*/ : Service
	{
		public object Any(PoryadokPrisvoeniyaSerijjnykhNomerovRequest request)
		{
			return new PoryadokPrisvoeniyaSerijjnykhNomerovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PoryadokPrisvoeniyaSerijjnykhNomerovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new PoryadokPrisvoeniyaSerijjnykhNomerovResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(PoryadokPrisvoeniyaSerijjnykhNomerovsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������.�����������(���������);
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
