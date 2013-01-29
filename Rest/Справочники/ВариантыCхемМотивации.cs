
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VariantyCkhemMotivacii")]
	[Route("/Catalogs/VariantyCkhemMotivacii/{Code}")]
	public class VariantyCkhemMotivaciiRequest/*��������C������������������*/: V82.�����������������.��������C������������,IReturn<VariantyCkhemMotivaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VariantyCkhemMotivaciiResponse//��������C�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VariantyCkhemMotivaciis")]
	[Route("/Catalogs/VariantyCkhemMotivaciis/{Codes}")]
	public class VariantyCkhemMotivaciisRequest/*��������C������������������*/: IReturn<List<VariantyCkhemMotivaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VariantyCkhemMotivaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VariantyCkhemMotivaciisResponse//��������C�����������������
	{
		public string Result {get;set;}
	}


	public class VariantyCkhemMotivaciiService /*��������C������������������*/ : Service
	{
		public object Any(VariantyCkhemMotivaciiRequest request)
		{
			return new VariantyCkhemMotivaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VariantyCkhemMotivaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������C������������.�����������(���������);
				if (������ == null)
				{
					return new VariantyCkhemMotivaciiResponse() {Result = "��������C������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������C������������.�����������(1);
			}
		}

		public object Get(VariantyCkhemMotivaciisRequest request)
		{
			var ��������� = new List<V82.�����������������.��������C������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������C������������.�����������(���������);
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
