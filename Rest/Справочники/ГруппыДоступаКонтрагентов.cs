
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppyDostupaKontragentov")]
	[Route("/Catalogs/GruppyDostupaKontragentov/{Code}")]
	public class GruppyDostupaKontragentovRequest/*�������������������������������*/: V82.�����������������.�������������������������,IReturn<GruppyDostupaKontragentovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppyDostupaKontragentovResponse//������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppyDostupaKontragentovs")]
	[Route("/Catalogs/GruppyDostupaKontragentovs/{Codes}")]
	public class GruppyDostupaKontragentovsRequest/*�������������������������������*/: IReturn<List<GruppyDostupaKontragentovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppyDostupaKontragentovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppyDostupaKontragentovsResponse//������������������������������
	{
		public string Result {get;set;}
	}


	public class GruppyDostupaKontragentovService /*�������������������������������*/ : Service
	{
		public object Any(GruppyDostupaKontragentovRequest request)
		{
			return new GruppyDostupaKontragentovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppyDostupaKontragentovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������.�����������(���������);
				if (������ == null)
				{
					return new GruppyDostupaKontragentovResponse() {Result = "������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������.�����������(1);
			}
		}

		public object Get(GruppyDostupaKontragentovsRequest request)
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
