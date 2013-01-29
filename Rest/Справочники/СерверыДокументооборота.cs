
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ServeryDokumentooborota")]
	[Route("/Catalogs/ServeryDokumentooborota/{Code}")]
	public class ServeryDokumentooborotaRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<ServeryDokumentooborotaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ServeryDokumentooborotaResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ServeryDokumentooborotas")]
	[Route("/Catalogs/ServeryDokumentooborotas/{Codes}")]
	public class ServeryDokumentooborotasRequest/*�����������������������������*/: IReturn<List<ServeryDokumentooborotaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ServeryDokumentooborotasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ServeryDokumentooborotasResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class ServeryDokumentooborotaService /*�����������������������������*/ : Service
	{
		public object Any(ServeryDokumentooborotaRequest request)
		{
			return new ServeryDokumentooborotaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ServeryDokumentooborotaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new ServeryDokumentooborotaResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(ServeryDokumentooborotasRequest request)
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
