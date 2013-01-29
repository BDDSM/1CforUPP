
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KodyOKPD")]
	[Route("/Catalogs/KodyOKPD/{Code}")]
	public class KodyOKPDRequest/*��������������*/: V82.�����������������.��������,IReturn<KodyOKPDRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KodyOKPDResponse//�������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KodyOKPDs")]
	[Route("/Catalogs/KodyOKPDs/{Codes}")]
	public class KodyOKPDsRequest/*��������������*/: IReturn<List<KodyOKPDRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KodyOKPDsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KodyOKPDsResponse//�������������
	{
		public string Result {get;set;}
	}


	public class KodyOKPDService /*��������������*/ : Service
	{
		public object Any(KodyOKPDRequest request)
		{
			return new KodyOKPDResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KodyOKPDRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������.�����������(���������);
				if (������ == null)
				{
					return new KodyOKPDResponse() {Result = "�������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������.�����������(1);
			}
		}

		public object Get(KodyOKPDsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������.�����������(���������);
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
