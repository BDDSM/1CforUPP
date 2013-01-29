
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/FinansovyeRaschety")]
	[Route("/Catalogs/FinansovyeRaschety/{Code}")]
	public class FinansovyeRaschetyRequest/*�����������������������*/: V82.�����������������.�����������������,IReturn<FinansovyeRaschetyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class FinansovyeRaschetyResponse//����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/FinansovyeRaschetys")]
	[Route("/Catalogs/FinansovyeRaschetys/{Codes}")]
	public class FinansovyeRaschetysRequest/*�����������������������*/: IReturn<List<FinansovyeRaschetyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public FinansovyeRaschetysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class FinansovyeRaschetysResponse//����������������������
	{
		public string Result {get;set;}
	}


	public class FinansovyeRaschetyService /*�����������������������*/ : Service
	{
		public object Any(FinansovyeRaschetyRequest request)
		{
			return new FinansovyeRaschetyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(FinansovyeRaschetyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������.�����������(���������);
				if (������ == null)
				{
					return new FinansovyeRaschetyResponse() {Result = "����������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������.�����������(1);
			}
		}

		public object Get(FinansovyeRaschetysRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������.�����������(���������);
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
