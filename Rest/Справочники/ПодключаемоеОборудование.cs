
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PodklyuchaemoeOborudovanie")]
	[Route("/Catalogs/PodklyuchaemoeOborudovanie/{Code}")]
	public class PodklyuchaemoeOborudovanieRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<PodklyuchaemoeOborudovanieRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PodklyuchaemoeOborudovanieResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PodklyuchaemoeOborudovanies")]
	[Route("/Catalogs/PodklyuchaemoeOborudovanies/{Codes}")]
	public class PodklyuchaemoeOborudovaniesRequest/*������������������������������*/: IReturn<List<PodklyuchaemoeOborudovanieRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PodklyuchaemoeOborudovaniesRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PodklyuchaemoeOborudovaniesResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class PodklyuchaemoeOborudovanieService /*������������������������������*/ : Service
	{
		public object Any(PodklyuchaemoeOborudovanieRequest request)
		{
			return new PodklyuchaemoeOborudovanieResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PodklyuchaemoeOborudovanieRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new PodklyuchaemoeOborudovanieResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(PodklyuchaemoeOborudovaniesRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
