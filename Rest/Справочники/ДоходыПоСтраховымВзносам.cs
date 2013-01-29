
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DokhodyPoStrakhovymVznosam")]
	[Route("/Catalogs/DokhodyPoStrakhovymVznosam/{Code}")]
	public class DokhodyPoStrakhovymVznosamRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<DokhodyPoStrakhovymVznosamRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DokhodyPoStrakhovymVznosamResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DokhodyPoStrakhovymVznosams")]
	[Route("/Catalogs/DokhodyPoStrakhovymVznosams/{Codes}")]
	public class DokhodyPoStrakhovymVznosamsRequest/*������������������������������*/: IReturn<List<DokhodyPoStrakhovymVznosamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DokhodyPoStrakhovymVznosamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DokhodyPoStrakhovymVznosamsResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class DokhodyPoStrakhovymVznosamService /*������������������������������*/ : Service
	{
		public object Any(DokhodyPoStrakhovymVznosamRequest request)
		{
			return new DokhodyPoStrakhovymVznosamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DokhodyPoStrakhovymVznosamRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new DokhodyPoStrakhovymVznosamResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(DokhodyPoStrakhovymVznosamsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
