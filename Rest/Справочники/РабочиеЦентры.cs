
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/RabochieCentry")]
	[Route("/Catalogs/RabochieCentry/{Code}")]
	public class RabochieCentryRequest/*�������������������*/: V82.�����������������.�������������,IReturn<RabochieCentryRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RabochieCentryResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RabochieCentrys")]
	[Route("/Catalogs/RabochieCentrys/{Codes}")]
	public class RabochieCentrysRequest/*�������������������*/: IReturn<List<RabochieCentryRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RabochieCentrysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RabochieCentrysResponse//������������������
	{
		public string Result {get;set;}
	}


	public class RabochieCentryService /*�������������������*/ : Service
	{
		public object Any(RabochieCentryRequest request)
		{
			return new RabochieCentryResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RabochieCentryRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new RabochieCentryResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(RabochieCentrysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
