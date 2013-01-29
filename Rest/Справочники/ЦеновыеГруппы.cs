
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/CenovyeGruppy")]
	[Route("/Catalogs/CenovyeGruppy/{Code}")]
	public class CenovyeGruppyRequest/*�������������������*/: V82.�����������������.�������������,IReturn<CenovyeGruppyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class CenovyeGruppyResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/CenovyeGruppys")]
	[Route("/Catalogs/CenovyeGruppys/{Codes}")]
	public class CenovyeGruppysRequest/*�������������������*/: IReturn<List<CenovyeGruppyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public CenovyeGruppysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class CenovyeGruppysResponse//������������������
	{
		public string Result {get;set;}
	}


	public class CenovyeGruppyService /*�������������������*/ : Service
	{
		public object Any(CenovyeGruppyRequest request)
		{
			return new CenovyeGruppyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(CenovyeGruppyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new CenovyeGruppyResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(CenovyeGruppysRequest request)
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
