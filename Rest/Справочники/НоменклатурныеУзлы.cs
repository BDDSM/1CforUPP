
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NomenklaturnyeUzly")]
	[Route("/Catalogs/NomenklaturnyeUzly/{Code}")]
	public class NomenklaturnyeUzlyRequest/*������������������������*/: V82.�����������������.������������������,IReturn<NomenklaturnyeUzlyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NomenklaturnyeUzlyResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NomenklaturnyeUzlys")]
	[Route("/Catalogs/NomenklaturnyeUzlys/{Codes}")]
	public class NomenklaturnyeUzlysRequest/*������������������������*/: IReturn<List<NomenklaturnyeUzlyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NomenklaturnyeUzlysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NomenklaturnyeUzlysResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class NomenklaturnyeUzlyService /*������������������������*/ : Service
	{
		public object Any(NomenklaturnyeUzlyRequest request)
		{
			return new NomenklaturnyeUzlyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NomenklaturnyeUzlyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new NomenklaturnyeUzlyResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(NomenklaturnyeUzlysRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������.�����������(���������);
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
