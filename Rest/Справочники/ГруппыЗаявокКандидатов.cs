
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppyZayavokKandidatov")]
	[Route("/Catalogs/GruppyZayavokKandidatov/{Code}")]
	public class GruppyZayavokKandidatovRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<GruppyZayavokKandidatovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppyZayavokKandidatovResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppyZayavokKandidatovs")]
	[Route("/Catalogs/GruppyZayavokKandidatovs/{Codes}")]
	public class GruppyZayavokKandidatovsRequest/*����������������������������*/: IReturn<List<GruppyZayavokKandidatovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppyZayavokKandidatovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppyZayavokKandidatovsResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class GruppyZayavokKandidatovService /*����������������������������*/ : Service
	{
		public object Any(GruppyZayavokKandidatovRequest request)
		{
			return new GruppyZayavokKandidatovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppyZayavokKandidatovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new GruppyZayavokKandidatovResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(GruppyZayavokKandidatovsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
