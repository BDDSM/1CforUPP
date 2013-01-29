
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Polzovateli")]
	[Route("/Catalogs/Polzovateli/{Code}")]
	public class PolzovateliRequest/*������������������*/: V82.�����������������.������������,IReturn<PolzovateliRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PolzovateliResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Polzovatelis")]
	[Route("/Catalogs/Polzovatelis/{Codes}")]
	public class PolzovatelisRequest/*������������������*/: IReturn<List<PolzovateliRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PolzovatelisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PolzovatelisResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class PolzovateliService /*������������������*/ : Service
	{
		public object Any(PolzovateliRequest request)
		{
			return new PolzovateliResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PolzovateliRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new PolzovateliResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(PolzovatelisRequest request)
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
