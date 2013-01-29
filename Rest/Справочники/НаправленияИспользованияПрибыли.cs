
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NapravleniyaIspolzovaniyaPribyli")]
	[Route("/Catalogs/NapravleniyaIspolzovaniyaPribyli/{Code}")]
	public class NapravleniyaIspolzovaniyaPribyliRequest/*�������������������������������������*/: V82.�����������������.�������������������������������,IReturn<NapravleniyaIspolzovaniyaPribyliRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NapravleniyaIspolzovaniyaPribyliResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NapravleniyaIspolzovaniyaPribylis")]
	[Route("/Catalogs/NapravleniyaIspolzovaniyaPribylis/{Codes}")]
	public class NapravleniyaIspolzovaniyaPribylisRequest/*�������������������������������������*/: IReturn<List<NapravleniyaIspolzovaniyaPribyliRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NapravleniyaIspolzovaniyaPribylisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NapravleniyaIspolzovaniyaPribylisResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	public class NapravleniyaIspolzovaniyaPribyliService /*�������������������������������������*/ : Service
	{
		public object Any(NapravleniyaIspolzovaniyaPribyliRequest request)
		{
			return new NapravleniyaIspolzovaniyaPribyliResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NapravleniyaIspolzovaniyaPribyliRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NapravleniyaIspolzovaniyaPribyliResponse() {Result = "������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������.�����������(1);
			}
		}

		public object Get(NapravleniyaIspolzovaniyaPribylisRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������.�����������(���������);
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
