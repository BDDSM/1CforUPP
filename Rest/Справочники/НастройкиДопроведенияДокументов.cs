
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiDoprovedeniyaDokumentov")]
	[Route("/Catalogs/NastrojjkiDoprovedeniyaDokumentov/{Code}")]
	public class NastrojjkiDoprovedeniyaDokumentovRequest/*�������������������������������������*/: V82.�����������������.�������������������������������,IReturn<NastrojjkiDoprovedeniyaDokumentovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiDoprovedeniyaDokumentovResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiDoprovedeniyaDokumentovs")]
	[Route("/Catalogs/NastrojjkiDoprovedeniyaDokumentovs/{Codes}")]
	public class NastrojjkiDoprovedeniyaDokumentovsRequest/*�������������������������������������*/: IReturn<List<NastrojjkiDoprovedeniyaDokumentovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiDoprovedeniyaDokumentovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiDoprovedeniyaDokumentovsResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiDoprovedeniyaDokumentovService /*�������������������������������������*/ : Service
	{
		public object Any(NastrojjkiDoprovedeniyaDokumentovRequest request)
		{
			return new NastrojjkiDoprovedeniyaDokumentovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiDoprovedeniyaDokumentovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiDoprovedeniyaDokumentovResponse() {Result = "������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiDoprovedeniyaDokumentovsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������.�����������(���������);
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
