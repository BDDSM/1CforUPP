
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppyPolzovatelejj")]
	[Route("/Catalogs/GruppyPolzovatelejj/{Code}")]
	public class GruppyPolzovatelejjRequest/*�������������������������*/: V82.�����������������.�������������������,IReturn<GruppyPolzovatelejjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppyPolzovatelejjResponse//������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppyPolzovatelejjs")]
	[Route("/Catalogs/GruppyPolzovatelejjs/{Codes}")]
	public class GruppyPolzovatelejjsRequest/*�������������������������*/: IReturn<List<GruppyPolzovatelejjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppyPolzovatelejjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppyPolzovatelejjsResponse//������������������������
	{
		public string Result {get;set;}
	}


	public class GruppyPolzovatelejjService /*�������������������������*/ : Service
	{
		public object Any(GruppyPolzovatelejjRequest request)
		{
			return new GruppyPolzovatelejjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppyPolzovatelejjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������.�����������(���������);
				if (������ == null)
				{
					return new GruppyPolzovatelejjResponse() {Result = "������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������.�����������(1);
			}
		}

		public object Get(GruppyPolzovatelejjsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������.�����������(���������);
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
