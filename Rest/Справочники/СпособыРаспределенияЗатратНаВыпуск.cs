
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SposobyRaspredeleniyaZatratNaVypusk")]
	[Route("/Catalogs/SposobyRaspredeleniyaZatratNaVypusk/{Code}")]
	public class SposobyRaspredeleniyaZatratNaVypuskRequest/*����������������������������������������*/: V82.�����������������.����������������������������������,IReturn<SposobyRaspredeleniyaZatratNaVypuskRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SposobyRaspredeleniyaZatratNaVypuskResponse//���������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SposobyRaspredeleniyaZatratNaVypusks")]
	[Route("/Catalogs/SposobyRaspredeleniyaZatratNaVypusks/{Codes}")]
	public class SposobyRaspredeleniyaZatratNaVypusksRequest/*����������������������������������������*/: IReturn<List<SposobyRaspredeleniyaZatratNaVypuskRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SposobyRaspredeleniyaZatratNaVypusksRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SposobyRaspredeleniyaZatratNaVypusksResponse//���������������������������������������
	{
		public string Result {get;set;}
	}


	public class SposobyRaspredeleniyaZatratNaVypuskService /*����������������������������������������*/ : Service
	{
		public object Any(SposobyRaspredeleniyaZatratNaVypuskRequest request)
		{
			return new SposobyRaspredeleniyaZatratNaVypuskResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SposobyRaspredeleniyaZatratNaVypuskRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������������.�����������(���������);
				if (������ == null)
				{
					return new SposobyRaspredeleniyaZatratNaVypuskResponse() {Result = "���������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������������.�����������(1);
			}
		}

		public object Get(SposobyRaspredeleniyaZatratNaVypusksRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������������������.�����������(���������);
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
