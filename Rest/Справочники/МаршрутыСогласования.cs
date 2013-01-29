
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/MarshrutySoglasovaniya")]
	[Route("/Catalogs/MarshrutySoglasovaniya/{Code}")]
	public class MarshrutySoglasovaniyaRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<MarshrutySoglasovaniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class MarshrutySoglasovaniyaResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/MarshrutySoglasovaniyas")]
	[Route("/Catalogs/MarshrutySoglasovaniyas/{Codes}")]
	public class MarshrutySoglasovaniyasRequest/*��������������������������*/: IReturn<List<MarshrutySoglasovaniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public MarshrutySoglasovaniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class MarshrutySoglasovaniyasResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class MarshrutySoglasovaniyaService /*��������������������������*/ : Service
	{
		public object Any(MarshrutySoglasovaniyaRequest request)
		{
			return new MarshrutySoglasovaniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(MarshrutySoglasovaniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new MarshrutySoglasovaniyaResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(MarshrutySoglasovaniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
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
