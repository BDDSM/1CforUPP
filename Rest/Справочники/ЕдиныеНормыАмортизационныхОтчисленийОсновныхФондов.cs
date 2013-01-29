
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondov")]
	[Route("/Catalogs/EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondov/{Code}")]
	public class EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovRequest/*��������������������������������������������������������*/: V82.�����������������.��������������������������������������������������,IReturn<EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovResponse//�������������������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovs")]
	[Route("/Catalogs/EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovs/{Codes}")]
	public class EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovsRequest/*��������������������������������������������������������*/: IReturn<List<EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovsResponse//�������������������������������������������������������
	{
		public string Result {get;set;}
	}


	public class EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovService /*��������������������������������������������������������*/ : Service
	{
		public object Any(EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovRequest request)
		{
			return new EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovResponse() {Result = "�������������������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������������������������.�����������(1);
			}
		}

		public object Get(EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondovsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������������������������.�����������(���������);
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
