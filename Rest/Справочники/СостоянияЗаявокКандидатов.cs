
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SostoyaniyaZayavokKandidatov")]
	[Route("/Catalogs/SostoyaniyaZayavokKandidatov/{Code}")]
	public class SostoyaniyaZayavokKandidatovRequest/*�������������������������������*/: V82.�����������������.�������������������������,IReturn<SostoyaniyaZayavokKandidatovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SostoyaniyaZayavokKandidatovResponse//������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SostoyaniyaZayavokKandidatovs")]
	[Route("/Catalogs/SostoyaniyaZayavokKandidatovs/{Codes}")]
	public class SostoyaniyaZayavokKandidatovsRequest/*�������������������������������*/: IReturn<List<SostoyaniyaZayavokKandidatovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SostoyaniyaZayavokKandidatovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SostoyaniyaZayavokKandidatovsResponse//������������������������������
	{
		public string Result {get;set;}
	}


	public class SostoyaniyaZayavokKandidatovService /*�������������������������������*/ : Service
	{
		public object Any(SostoyaniyaZayavokKandidatovRequest request)
		{
			return new SostoyaniyaZayavokKandidatovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SostoyaniyaZayavokKandidatovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������.�����������(���������);
				if (������ == null)
				{
					return new SostoyaniyaZayavokKandidatovResponse() {Result = "������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������.�����������(1);
			}
		}

		public object Get(SostoyaniyaZayavokKandidatovsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������.�����������(���������);
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
