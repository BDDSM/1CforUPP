
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Nagrady")]
	[Route("/Catalogs/Nagrady/{Code}")]
	public class NagradyRequest/*�������������*/: V82.�����������������.�������,IReturn<NagradyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NagradyResponse//������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Nagradys")]
	[Route("/Catalogs/Nagradys/{Codes}")]
	public class NagradysRequest/*�������������*/: IReturn<List<NagradyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NagradysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NagradysResponse//������������
	{
		public string Result {get;set;}
	}


	public class NagradyService /*�������������*/ : Service
	{
		public object Any(NagradyRequest request)
		{
			return new NagradyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NagradyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������.�����������(���������);
				if (������ == null)
				{
					return new NagradyResponse() {Result = "������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������.�����������(1);
			}
		}

		public object Get(NagradysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������.�����������(���������);
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
