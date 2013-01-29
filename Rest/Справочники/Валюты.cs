
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Valyuty")]
	[Route("/Catalogs/Valyuty/{Code}")]
	public class ValyutyRequest/*������������*/: V82.�����������������.������,IReturn<ValyutyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ValyutyResponse//�����������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Valyutys")]
	[Route("/Catalogs/Valyutys/{Codes}")]
	public class ValyutysRequest/*������������*/: IReturn<List<ValyutyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ValyutysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ValyutysResponse//�����������
	{
		public string Result {get;set;}
	}


	public class ValyutyService /*������������*/ : Service
	{
		public object Any(ValyutyRequest request)
		{
			return new ValyutyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ValyutyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������.�����������(���������);
				if (������ == null)
				{
					return new ValyutyResponse() {Result = "������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������.�����������(1);
			}
		}

		public object Get(ValyutysRequest request)
		{
			var ��������� = new List<V82.�����������������.������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������.�����������(���������);
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
