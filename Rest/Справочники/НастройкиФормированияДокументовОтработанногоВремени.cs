
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeni")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeni/{Code}")]
	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest/*���������������������������������������������������������*/: V82.�����������������.���������������������������������������������������,IReturn<NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniResponse//��������������������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenis")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenis/{Codes}")]
	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenisRequest/*���������������������������������������������������������*/: IReturn<List<NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenisResponse//��������������������������������������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniService /*���������������������������������������������������������*/ : Service
	{
		public object Any(NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest request)
		{
			return new NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniResponse() {Result = "��������������������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������������������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenisRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������������������������������.�����������(���������);
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
