
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/StatiZatrat")]
	[Route("/Catalogs/StatiZatrat/{Code}")]
	public class StatiZatratRequest/*������������������*/: V82.�����������������.������������,IReturn<StatiZatratRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StatiZatratResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StatiZatrats")]
	[Route("/Catalogs/StatiZatrats/{Codes}")]
	public class StatiZatratsRequest/*������������������*/: IReturn<List<StatiZatratRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StatiZatratsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StatiZatratsResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class StatiZatratService /*������������������*/ : Service
	{
		public object Any(StatiZatratRequest request)
		{
			return new StatiZatratResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StatiZatratRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new StatiZatratResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(StatiZatratsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������.�����������(���������);
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
