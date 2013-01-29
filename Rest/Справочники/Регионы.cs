
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Regiony")]
	[Route("/Catalogs/Regiony/{Code}")]
	public class RegionyRequest/*�������������*/: V82.�����������������.�������,IReturn<RegionyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RegionyResponse//������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Regionys")]
	[Route("/Catalogs/Regionys/{Codes}")]
	public class RegionysRequest/*�������������*/: IReturn<List<RegionyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RegionysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RegionysResponse//������������
	{
		public string Result {get;set;}
	}


	public class RegionyService /*�������������*/ : Service
	{
		public object Any(RegionyRequest request)
		{
			return new RegionyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RegionyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������.�����������(���������);
				if (������ == null)
				{
					return new RegionyResponse() {Result = "������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������.�����������(1);
			}
		}

		public object Get(RegionysRequest request)
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
