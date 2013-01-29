
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/InformacionnyeKarty")]
	[Route("/Catalogs/InformacionnyeKarty/{Code}")]
	public class InformacionnyeKartyRequest/*�������������������������*/: V82.�����������������.�������������������,IReturn<InformacionnyeKartyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class InformacionnyeKartyResponse//������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/InformacionnyeKartys")]
	[Route("/Catalogs/InformacionnyeKartys/{Codes}")]
	public class InformacionnyeKartysRequest/*�������������������������*/: IReturn<List<InformacionnyeKartyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public InformacionnyeKartysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class InformacionnyeKartysResponse//������������������������
	{
		public string Result {get;set;}
	}


	public class InformacionnyeKartyService /*�������������������������*/ : Service
	{
		public object Any(InformacionnyeKartyRequest request)
		{
			return new InformacionnyeKartyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(InformacionnyeKartyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������.�����������(���������);
				if (������ == null)
				{
					return new InformacionnyeKartyResponse() {Result = "������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������.�����������(1);
			}
		}

		public object Get(InformacionnyeKartysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������.�����������(���������);
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
