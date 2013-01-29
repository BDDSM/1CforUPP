
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ProfessiiRabochikh")]
	[Route("/Catalogs/ProfessiiRabochikh/{Code}")]
	public class ProfessiiRabochikhRequest/*����������������������*/: V82.�����������������.����������������,IReturn<ProfessiiRabochikhRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProfessiiRabochikhResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProfessiiRabochikhs")]
	[Route("/Catalogs/ProfessiiRabochikhs/{Codes}")]
	public class ProfessiiRabochikhsRequest/*����������������������*/: IReturn<List<ProfessiiRabochikhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProfessiiRabochikhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProfessiiRabochikhsResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class ProfessiiRabochikhService /*����������������������*/ : Service
	{
		public object Any(ProfessiiRabochikhRequest request)
		{
			return new ProfessiiRabochikhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProfessiiRabochikhRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new ProfessiiRabochikhResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(ProfessiiRabochikhsRequest request)
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
