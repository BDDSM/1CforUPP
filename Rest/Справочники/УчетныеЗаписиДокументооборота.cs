
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/UchetnyeZapisiDokumentooborota")]
	[Route("/Catalogs/UchetnyeZapisiDokumentooborota/{Code}")]
	public class UchetnyeZapisiDokumentooborotaRequest/*�����������������������������������*/: V82.�����������������.�����������������������������,IReturn<UchetnyeZapisiDokumentooborotaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class UchetnyeZapisiDokumentooborotaResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/UchetnyeZapisiDokumentooborotas")]
	[Route("/Catalogs/UchetnyeZapisiDokumentooborotas/{Codes}")]
	public class UchetnyeZapisiDokumentooborotasRequest/*�����������������������������������*/: IReturn<List<UchetnyeZapisiDokumentooborotaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public UchetnyeZapisiDokumentooborotasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class UchetnyeZapisiDokumentooborotasResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	public class UchetnyeZapisiDokumentooborotaService /*�����������������������������������*/ : Service
	{
		public object Any(UchetnyeZapisiDokumentooborotaRequest request)
		{
			return new UchetnyeZapisiDokumentooborotaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(UchetnyeZapisiDokumentooborotaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������.�����������(���������);
				if (������ == null)
				{
					return new UchetnyeZapisiDokumentooborotaResponse() {Result = "����������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������.�����������(1);
			}
		}

		public object Get(UchetnyeZapisiDokumentooborotasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������.�����������(���������);
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
