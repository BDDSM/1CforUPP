
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ZayavkiKandidatov")]
	[Route("/Catalogs/ZayavkiKandidatov/{Code}")]
	public class ZayavkiKandidatovRequest/*����������������������*/: V82.�����������������.����������������,IReturn<ZayavkiKandidatovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ZayavkiKandidatovResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ZayavkiKandidatovs")]
	[Route("/Catalogs/ZayavkiKandidatovs/{Codes}")]
	public class ZayavkiKandidatovsRequest/*����������������������*/: IReturn<List<ZayavkiKandidatovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ZayavkiKandidatovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ZayavkiKandidatovsResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class ZayavkiKandidatovService /*����������������������*/ : Service
	{
		public object Any(ZayavkiKandidatovRequest request)
		{
			return new ZayavkiKandidatovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ZayavkiKandidatovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new ZayavkiKandidatovResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(ZayavkiKandidatovsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
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
