
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VariantyNastroekFinAnaliza")]
	[Route("/Catalogs/VariantyNastroekFinAnaliza/{Code}")]
	public class VariantyNastroekFinAnalizaRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<VariantyNastroekFinAnalizaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VariantyNastroekFinAnalizaResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VariantyNastroekFinAnalizas")]
	[Route("/Catalogs/VariantyNastroekFinAnalizas/{Codes}")]
	public class VariantyNastroekFinAnalizasRequest/*��������������������������������*/: IReturn<List<VariantyNastroekFinAnalizaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VariantyNastroekFinAnalizasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VariantyNastroekFinAnalizasResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class VariantyNastroekFinAnalizaService /*��������������������������������*/ : Service
	{
		public object Any(VariantyNastroekFinAnalizaRequest request)
		{
			return new VariantyNastroekFinAnalizaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VariantyNastroekFinAnalizaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new VariantyNastroekFinAnalizaResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(VariantyNastroekFinAnalizasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
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
