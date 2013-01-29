
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StepeniRodstvaFizLic")]
	[Route("/Catalogs/StepeniRodstvaFizLic/{Code}")]
	public class StepeniRodstvaFizLicRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<StepeniRodstvaFizLicRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StepeniRodstvaFizLicResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StepeniRodstvaFizLics")]
	[Route("/Catalogs/StepeniRodstvaFizLics/{Codes}")]
	public class StepeniRodstvaFizLicsRequest/*��������������������������*/: IReturn<List<StepeniRodstvaFizLicRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StepeniRodstvaFizLicsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StepeniRodstvaFizLicsResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class StepeniRodstvaFizLicService /*��������������������������*/ : Service
	{
		public object Any(StepeniRodstvaFizLicRequest request)
		{
			return new StepeniRodstvaFizLicResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StepeniRodstvaFizLicRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new StepeniRodstvaFizLicResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(StepeniRodstvaFizLicsRequest request)
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
