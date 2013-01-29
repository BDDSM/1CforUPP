
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KategoriiObektov")]
	[Route("/Catalogs/KategoriiObektov/{Code}")]
	public class KategoriiObektovRequest/*�����������������������*/: V82.�����������������.�����������������,IReturn<KategoriiObektovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KategoriiObektovResponse//����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KategoriiObektovs")]
	[Route("/Catalogs/KategoriiObektovs/{Codes}")]
	public class KategoriiObektovsRequest/*�����������������������*/: IReturn<List<KategoriiObektovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KategoriiObektovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KategoriiObektovsResponse//����������������������
	{
		public string Result {get;set;}
	}


	public class KategoriiObektovService /*�����������������������*/ : Service
	{
		public object Any(KategoriiObektovRequest request)
		{
			return new KategoriiObektovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KategoriiObektovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������.�����������(���������);
				if (������ == null)
				{
					return new KategoriiObektovResponse() {Result = "����������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������.�����������(1);
			}
		}

		public object Get(KategoriiObektovsRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������.�����������(���������);
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
