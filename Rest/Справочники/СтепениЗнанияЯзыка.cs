
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StepeniZnaniyaYAzyka")]
	[Route("/Catalogs/StepeniZnaniyaYAzyka/{Code}")]
	public class StepeniZnaniyaYAzykaRequest/*������������������������*/: V82.�����������������.������������������,IReturn<StepeniZnaniyaYAzykaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StepeniZnaniyaYAzykaResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StepeniZnaniyaYAzykas")]
	[Route("/Catalogs/StepeniZnaniyaYAzykas/{Codes}")]
	public class StepeniZnaniyaYAzykasRequest/*������������������������*/: IReturn<List<StepeniZnaniyaYAzykaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StepeniZnaniyaYAzykasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StepeniZnaniyaYAzykasResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class StepeniZnaniyaYAzykaService /*������������������������*/ : Service
	{
		public object Any(StepeniZnaniyaYAzykaRequest request)
		{
			return new StepeniZnaniyaYAzykaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StepeniZnaniyaYAzykaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new StepeniZnaniyaYAzykaResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(StepeniZnaniyaYAzykasRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������.�����������(���������);
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
