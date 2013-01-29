
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StatiOborotovPoByudzhetam")]
	[Route("/Catalogs/StatiOborotovPoByudzhetam/{Code}")]
	public class StatiOborotovPoByudzhetamRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<StatiOborotovPoByudzhetamRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StatiOborotovPoByudzhetamResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StatiOborotovPoByudzhetams")]
	[Route("/Catalogs/StatiOborotovPoByudzhetams/{Codes}")]
	public class StatiOborotovPoByudzhetamsRequest/*������������������������������*/: IReturn<List<StatiOborotovPoByudzhetamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StatiOborotovPoByudzhetamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StatiOborotovPoByudzhetamsResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class StatiOborotovPoByudzhetamService /*������������������������������*/ : Service
	{
		public object Any(StatiOborotovPoByudzhetamRequest request)
		{
			return new StatiOborotovPoByudzhetamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StatiOborotovPoByudzhetamRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new StatiOborotovPoByudzhetamResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(StatiOborotovPoByudzhetamsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
