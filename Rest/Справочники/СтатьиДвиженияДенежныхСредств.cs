
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StatiDvizheniyaDenezhnykhSredstv")]
	[Route("/Catalogs/StatiDvizheniyaDenezhnykhSredstv/{Code}")]
	public class StatiDvizheniyaDenezhnykhSredstvRequest/*�����������������������������������*/: V82.�����������������.�����������������������������,IReturn<StatiDvizheniyaDenezhnykhSredstvRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StatiDvizheniyaDenezhnykhSredstvResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StatiDvizheniyaDenezhnykhSredstvs")]
	[Route("/Catalogs/StatiDvizheniyaDenezhnykhSredstvs/{Codes}")]
	public class StatiDvizheniyaDenezhnykhSredstvsRequest/*�����������������������������������*/: IReturn<List<StatiDvizheniyaDenezhnykhSredstvRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StatiDvizheniyaDenezhnykhSredstvsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StatiDvizheniyaDenezhnykhSredstvsResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	public class StatiDvizheniyaDenezhnykhSredstvService /*�����������������������������������*/ : Service
	{
		public object Any(StatiDvizheniyaDenezhnykhSredstvRequest request)
		{
			return new StatiDvizheniyaDenezhnykhSredstvResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StatiDvizheniyaDenezhnykhSredstvRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������.�����������(���������);
				if (������ == null)
				{
					return new StatiDvizheniyaDenezhnykhSredstvResponse() {Result = "����������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������.�����������(1);
			}
		}

		public object Get(StatiDvizheniyaDenezhnykhSredstvsRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������.�����������(���������);
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
