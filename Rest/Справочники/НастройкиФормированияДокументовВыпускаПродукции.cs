
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovVypuskaProdukcii")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovVypuskaProdukcii/{Code}")]
	public class NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiRequest/*�����������������������������������������������������*/: V82.�����������������.�����������������������������������������������,IReturn<NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiResponse//����������������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovVypuskaProdukciis")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovVypuskaProdukciis/{Codes}")]
	public class NastrojjkiFormirovaniyaDokumentovVypuskaProdukciisRequest/*�����������������������������������������������������*/: IReturn<List<NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiFormirovaniyaDokumentovVypuskaProdukciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiFormirovaniyaDokumentovVypuskaProdukciisResponse//����������������������������������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiService /*�����������������������������������������������������*/ : Service
	{
		public object Any(NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiRequest request)
		{
			return new NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiFormirovaniyaDokumentovVypuskaProdukciiResponse() {Result = "����������������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovVypuskaProdukciisRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������������������������.�����������(���������);
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
