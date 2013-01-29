
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NaznacheniyaIspolzovaniyaSpecifikacijj")]
	[Route("/Catalogs/NaznacheniyaIspolzovaniyaSpecifikacijj/{Code}")]
	public class NaznacheniyaIspolzovaniyaSpecifikacijjRequest/*�����������������������������������������*/: V82.�����������������.�����������������������������������,IReturn<NaznacheniyaIspolzovaniyaSpecifikacijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NaznacheniyaIspolzovaniyaSpecifikacijjResponse//����������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NaznacheniyaIspolzovaniyaSpecifikacijjs")]
	[Route("/Catalogs/NaznacheniyaIspolzovaniyaSpecifikacijjs/{Codes}")]
	public class NaznacheniyaIspolzovaniyaSpecifikacijjsRequest/*�����������������������������������������*/: IReturn<List<NaznacheniyaIspolzovaniyaSpecifikacijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NaznacheniyaIspolzovaniyaSpecifikacijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NaznacheniyaIspolzovaniyaSpecifikacijjsResponse//����������������������������������������
	{
		public string Result {get;set;}
	}


	public class NaznacheniyaIspolzovaniyaSpecifikacijjService /*�����������������������������������������*/ : Service
	{
		public object Any(NaznacheniyaIspolzovaniyaSpecifikacijjRequest request)
		{
			return new NaznacheniyaIspolzovaniyaSpecifikacijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NaznacheniyaIspolzovaniyaSpecifikacijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NaznacheniyaIspolzovaniyaSpecifikacijjResponse() {Result = "����������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������������.�����������(1);
			}
		}

		public object Get(NaznacheniyaIspolzovaniyaSpecifikacijjsRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������������.�����������(���������);
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
