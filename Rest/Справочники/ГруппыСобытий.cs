
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppySobytijj")]
	[Route("/Catalogs/GruppySobytijj/{Code}")]
	public class GruppySobytijjRequest/*�������������������*/: V82.�����������������.�������������,IReturn<GruppySobytijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppySobytijjResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppySobytijjs")]
	[Route("/Catalogs/GruppySobytijjs/{Codes}")]
	public class GruppySobytijjsRequest/*�������������������*/: IReturn<List<GruppySobytijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppySobytijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppySobytijjsResponse//������������������
	{
		public string Result {get;set;}
	}


	public class GruppySobytijjService /*�������������������*/ : Service
	{
		public object Any(GruppySobytijjRequest request)
		{
			return new GruppySobytijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppySobytijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new GruppySobytijjResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(GruppySobytijjsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
