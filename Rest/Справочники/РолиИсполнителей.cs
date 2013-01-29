
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/RoliIspolnitelejj")]
	[Route("/Catalogs/RoliIspolnitelejj/{Code}")]
	public class RoliIspolnitelejjRequest/*����������������������*/: V82.�����������������.����������������,IReturn<RoliIspolnitelejjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RoliIspolnitelejjResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RoliIspolnitelejjs")]
	[Route("/Catalogs/RoliIspolnitelejjs/{Codes}")]
	public class RoliIspolnitelejjsRequest/*����������������������*/: IReturn<List<RoliIspolnitelejjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RoliIspolnitelejjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RoliIspolnitelejjsResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class RoliIspolnitelejjService /*����������������������*/ : Service
	{
		public object Any(RoliIspolnitelejjRequest request)
		{
			return new RoliIspolnitelejjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RoliIspolnitelejjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new RoliIspolnitelejjResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(RoliIspolnitelejjsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
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
