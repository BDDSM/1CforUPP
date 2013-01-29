
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProgrammyMedicinskogoStrakhovaniya")]
	[Route("/Catalogs/ProgrammyMedicinskogoStrakhovaniya/{Code}")]
	public class ProgrammyMedicinskogoStrakhovaniyaRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<ProgrammyMedicinskogoStrakhovaniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProgrammyMedicinskogoStrakhovaniyaResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProgrammyMedicinskogoStrakhovaniyas")]
	[Route("/Catalogs/ProgrammyMedicinskogoStrakhovaniyas/{Codes}")]
	public class ProgrammyMedicinskogoStrakhovaniyasRequest/*��������������������������������������*/: IReturn<List<ProgrammyMedicinskogoStrakhovaniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProgrammyMedicinskogoStrakhovaniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProgrammyMedicinskogoStrakhovaniyasResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class ProgrammyMedicinskogoStrakhovaniyaService /*��������������������������������������*/ : Service
	{
		public object Any(ProgrammyMedicinskogoStrakhovaniyaRequest request)
		{
			return new ProgrammyMedicinskogoStrakhovaniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProgrammyMedicinskogoStrakhovaniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ProgrammyMedicinskogoStrakhovaniyaResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(ProgrammyMedicinskogoStrakhovaniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������.�����������(���������);
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
