
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Kontragenty")]
	[Route("/Catalogs/Kontragenty/{Code}")]
	public class KontragentyRequest/*�����������������*/: V82.�����������������.�����������,IReturn<KontragentyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KontragentyResponse//����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Kontragentys")]
	[Route("/Catalogs/Kontragentys/{Codes}")]
	public class KontragentysRequest/*�����������������*/: IReturn<List<KontragentyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KontragentysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KontragentysResponse//����������������
	{
		public string Result {get;set;}
	}


	public class KontragentyService /*�����������������*/ : Service
	{
		public object Any(KontragentyRequest request)
		{
			return new KontragentyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KontragentyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������.�����������(���������);
				if (������ == null)
				{
					return new KontragentyResponse() {Result = "����������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������.�����������(1);
			}
		}

		public object Get(KontragentysRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������.�����������(���������);
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
