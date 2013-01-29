
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiZapolneniyaForm")]
	[Route("/Catalogs/NastrojjkiZapolneniyaForm/{Code}")]
	public class NastrojjkiZapolneniyaFormRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<NastrojjkiZapolneniyaFormRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiZapolneniyaFormResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiZapolneniyaForms")]
	[Route("/Catalogs/NastrojjkiZapolneniyaForms/{Codes}")]
	public class NastrojjkiZapolneniyaFormsRequest/*�����������������������������*/: IReturn<List<NastrojjkiZapolneniyaFormRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiZapolneniyaFormsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiZapolneniyaFormsResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiZapolneniyaFormService /*�����������������������������*/ : Service
	{
		public object Any(NastrojjkiZapolneniyaFormRequest request)
		{
			return new NastrojjkiZapolneniyaFormResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiZapolneniyaFormRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiZapolneniyaFormResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiZapolneniyaFormsRequest request)
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
