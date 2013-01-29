
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NematerialnyeAktivy")]
	[Route("/Catalogs/NematerialnyeAktivy/{Code}")]
	public class NematerialnyeAktivyRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<NematerialnyeAktivyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NematerialnyeAktivyResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NematerialnyeAktivys")]
	[Route("/Catalogs/NematerialnyeAktivys/{Codes}")]
	public class NematerialnyeAktivysRequest/*��������������������������*/: IReturn<List<NematerialnyeAktivyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NematerialnyeAktivysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NematerialnyeAktivysResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class NematerialnyeAktivyService /*��������������������������*/ : Service
	{
		public object Any(NematerialnyeAktivyRequest request)
		{
			return new NematerialnyeAktivyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NematerialnyeAktivyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new NematerialnyeAktivyResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(NematerialnyeAktivysRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
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
