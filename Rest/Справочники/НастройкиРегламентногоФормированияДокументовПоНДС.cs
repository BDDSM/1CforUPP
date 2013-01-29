
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDS")]
	[Route("/Catalogs/NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDS/{Code}")]
	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest/*�������������������������������������������������������*/: V82.�����������������.�������������������������������������������������,IReturn<NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSResponse//������������������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSs")]
	[Route("/Catalogs/NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSs/{Codes}")]
	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSsRequest/*�������������������������������������������������������*/: IReturn<List<NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSsResponse//������������������������������������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSService /*�������������������������������������������������������*/ : Service
	{
		public object Any(NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest request)
		{
			return new NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSResponse() {Result = "������������������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������������������������.�����������(���������);
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
