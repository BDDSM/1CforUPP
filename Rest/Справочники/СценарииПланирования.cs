
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ScenariiPlanirovaniya")]
	[Route("/Catalogs/ScenariiPlanirovaniya/{Code}")]
	public class ScenariiPlanirovaniyaRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<ScenariiPlanirovaniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ScenariiPlanirovaniyaResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ScenariiPlanirovaniyas")]
	[Route("/Catalogs/ScenariiPlanirovaniyas/{Codes}")]
	public class ScenariiPlanirovaniyasRequest/*��������������������������*/: IReturn<List<ScenariiPlanirovaniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ScenariiPlanirovaniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ScenariiPlanirovaniyasResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class ScenariiPlanirovaniyaService /*��������������������������*/ : Service
	{
		public object Any(ScenariiPlanirovaniyaRequest request)
		{
			return new ScenariiPlanirovaniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ScenariiPlanirovaniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new ScenariiPlanirovaniyaResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(ScenariiPlanirovaniyasRequest request)
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
