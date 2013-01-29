
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/YAzykiNarodovMira")]
	[Route("/Catalogs/YAzykiNarodovMira/{Code}")]
	public class YAzykiNarodovMiraRequest/*����������������������*/: V82.�����������������.����������������,IReturn<YAzykiNarodovMiraRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class YAzykiNarodovMiraResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/YAzykiNarodovMiras")]
	[Route("/Catalogs/YAzykiNarodovMiras/{Codes}")]
	public class YAzykiNarodovMirasRequest/*����������������������*/: IReturn<List<YAzykiNarodovMiraRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public YAzykiNarodovMirasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class YAzykiNarodovMirasResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class YAzykiNarodovMiraService /*����������������������*/ : Service
	{
		public object Any(YAzykiNarodovMiraRequest request)
		{
			return new YAzykiNarodovMiraResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(YAzykiNarodovMiraRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new YAzykiNarodovMiraResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(YAzykiNarodovMirasRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
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
