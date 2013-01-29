
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Dolzhnosti")]
	[Route("/Catalogs/Dolzhnosti/{Code}")]
	public class DolzhnostiRequest/*���������������*/: V82.�����������������.���������,IReturn<DolzhnostiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DolzhnostiResponse//��������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Dolzhnostis")]
	[Route("/Catalogs/Dolzhnostis/{Codes}")]
	public class DolzhnostisRequest/*���������������*/: IReturn<List<DolzhnostiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DolzhnostisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DolzhnostisResponse//��������������
	{
		public string Result {get;set;}
	}


	public class DolzhnostiService /*���������������*/ : Service
	{
		public object Any(DolzhnostiRequest request)
		{
			return new DolzhnostiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DolzhnostiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������.�����������(���������);
				if (������ == null)
				{
					return new DolzhnostiResponse() {Result = "��������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������.�����������(1);
			}
		}

		public object Get(DolzhnostisRequest request)
		{
			var ��������� = new List<V82.�����������������.���������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������.�����������(���������);
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
