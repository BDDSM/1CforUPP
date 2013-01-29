
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/UsloviyaProdazh")]
	[Route("/Catalogs/UsloviyaProdazh/{Code}")]
	public class UsloviyaProdazhRequest/*�������������������*/: V82.�����������������.�������������,IReturn<UsloviyaProdazhRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class UsloviyaProdazhResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/UsloviyaProdazhs")]
	[Route("/Catalogs/UsloviyaProdazhs/{Codes}")]
	public class UsloviyaProdazhsRequest/*�������������������*/: IReturn<List<UsloviyaProdazhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public UsloviyaProdazhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class UsloviyaProdazhsResponse//������������������
	{
		public string Result {get;set;}
	}


	public class UsloviyaProdazhService /*�������������������*/ : Service
	{
		public object Any(UsloviyaProdazhRequest request)
		{
			return new UsloviyaProdazhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(UsloviyaProdazhRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new UsloviyaProdazhResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(UsloviyaProdazhsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
