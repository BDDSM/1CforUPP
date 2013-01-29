
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KategoriiRaschetov")]
	[Route("/Catalogs/KategoriiRaschetov/{Code}")]
	public class KategoriiRaschetovRequest/*�����������������������*/: V82.�����������������.�����������������,IReturn<KategoriiRaschetovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KategoriiRaschetovResponse//����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KategoriiRaschetovs")]
	[Route("/Catalogs/KategoriiRaschetovs/{Codes}")]
	public class KategoriiRaschetovsRequest/*�����������������������*/: IReturn<List<KategoriiRaschetovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KategoriiRaschetovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KategoriiRaschetovsResponse//����������������������
	{
		public string Result {get;set;}
	}


	public class KategoriiRaschetovService /*�����������������������*/ : Service
	{
		public object Any(KategoriiRaschetovRequest request)
		{
			return new KategoriiRaschetovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KategoriiRaschetovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������.�����������(���������);
				if (������ == null)
				{
					return new KategoriiRaschetovResponse() {Result = "����������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������.�����������(1);
			}
		}

		public object Get(KategoriiRaschetovsRequest request)
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
