
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyZadachPolzovatelejj")]
	[Route("/Catalogs/VidyZadachPolzovatelejj/{Code}")]
	public class VidyZadachPolzovatelejjRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<VidyZadachPolzovatelejjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyZadachPolzovatelejjResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyZadachPolzovatelejjs")]
	[Route("/Catalogs/VidyZadachPolzovatelejjs/{Codes}")]
	public class VidyZadachPolzovatelejjsRequest/*����������������������������*/: IReturn<List<VidyZadachPolzovatelejjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyZadachPolzovatelejjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyZadachPolzovatelejjsResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class VidyZadachPolzovatelejjService /*����������������������������*/ : Service
	{
		public object Any(VidyZadachPolzovatelejjRequest request)
		{
			return new VidyZadachPolzovatelejjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyZadachPolzovatelejjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyZadachPolzovatelejjResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(VidyZadachPolzovatelejjsRequest request)
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
