
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderam")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderam/{Code}")]
	public class NastrojjkiFormirovaniyaDokumentovPoOrderamRequest/*����������������������������������������������*/: V82.�����������������.����������������������������������������,IReturn<NastrojjkiFormirovaniyaDokumentovPoOrderamRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiFormirovaniyaDokumentovPoOrderamResponse//���������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderams")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovPoOrderams/{Codes}")]
	public class NastrojjkiFormirovaniyaDokumentovPoOrderamsRequest/*����������������������������������������������*/: IReturn<List<NastrojjkiFormirovaniyaDokumentovPoOrderamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiFormirovaniyaDokumentovPoOrderamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiFormirovaniyaDokumentovPoOrderamsResponse//���������������������������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiFormirovaniyaDokumentovPoOrderamService /*����������������������������������������������*/ : Service
	{
		public object Any(NastrojjkiFormirovaniyaDokumentovPoOrderamRequest request)
		{
			return new NastrojjkiFormirovaniyaDokumentovPoOrderamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovPoOrderamRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiFormirovaniyaDokumentovPoOrderamResponse() {Result = "���������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovPoOrderamsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������������������������.�����������(���������);
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
