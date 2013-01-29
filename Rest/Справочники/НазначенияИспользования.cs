
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NaznacheniyaIspolzovaniya")]
	[Route("/Catalogs/NaznacheniyaIspolzovaniya/{Code}")]
	public class NaznacheniyaIspolzovaniyaRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<NaznacheniyaIspolzovaniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NaznacheniyaIspolzovaniyaResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NaznacheniyaIspolzovaniyas")]
	[Route("/Catalogs/NaznacheniyaIspolzovaniyas/{Codes}")]
	public class NaznacheniyaIspolzovaniyasRequest/*�����������������������������*/: IReturn<List<NaznacheniyaIspolzovaniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NaznacheniyaIspolzovaniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NaznacheniyaIspolzovaniyasResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class NaznacheniyaIspolzovaniyaService /*�����������������������������*/ : Service
	{
		public object Any(NaznacheniyaIspolzovaniyaRequest request)
		{
			return new NaznacheniyaIspolzovaniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NaznacheniyaIspolzovaniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new NaznacheniyaIspolzovaniyaResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(NaznacheniyaIspolzovaniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������.�����������(���������);
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
