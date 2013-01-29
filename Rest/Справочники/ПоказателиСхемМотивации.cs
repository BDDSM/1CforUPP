
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/PokazateliSkhemMotivacii")]
	[Route("/Catalogs/PokazateliSkhemMotivacii/{Code}")]
	public class PokazateliSkhemMotivaciiRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<PokazateliSkhemMotivaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PokazateliSkhemMotivaciiResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PokazateliSkhemMotivaciis")]
	[Route("/Catalogs/PokazateliSkhemMotivaciis/{Codes}")]
	public class PokazateliSkhemMotivaciisRequest/*�����������������������������*/: IReturn<List<PokazateliSkhemMotivaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PokazateliSkhemMotivaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PokazateliSkhemMotivaciisResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class PokazateliSkhemMotivaciiService /*�����������������������������*/ : Service
	{
		public object Any(PokazateliSkhemMotivaciiRequest request)
		{
			return new PokazateliSkhemMotivaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PokazateliSkhemMotivaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new PokazateliSkhemMotivaciiResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(PokazateliSkhemMotivaciisRequest request)
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
