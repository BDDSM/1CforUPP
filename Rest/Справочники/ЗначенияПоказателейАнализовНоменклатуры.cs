
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ZnacheniyaPokazatelejjAnalizovNomenklatury")]
	[Route("/Catalogs/ZnacheniyaPokazatelejjAnalizovNomenklatury/{Code}")]
	public class ZnacheniyaPokazatelejjAnalizovNomenklaturyRequest/*���������������������������������������������*/: V82.�����������������.���������������������������������������,IReturn<ZnacheniyaPokazatelejjAnalizovNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ZnacheniyaPokazatelejjAnalizovNomenklaturyResponse//��������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ZnacheniyaPokazatelejjAnalizovNomenklaturys")]
	[Route("/Catalogs/ZnacheniyaPokazatelejjAnalizovNomenklaturys/{Codes}")]
	public class ZnacheniyaPokazatelejjAnalizovNomenklaturysRequest/*���������������������������������������������*/: IReturn<List<ZnacheniyaPokazatelejjAnalizovNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ZnacheniyaPokazatelejjAnalizovNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ZnacheniyaPokazatelejjAnalizovNomenklaturysResponse//��������������������������������������������
	{
		public string Result {get;set;}
	}


	public class ZnacheniyaPokazatelejjAnalizovNomenklaturyService /*���������������������������������������������*/ : Service
	{
		public object Any(ZnacheniyaPokazatelejjAnalizovNomenklaturyRequest request)
		{
			return new ZnacheniyaPokazatelejjAnalizovNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ZnacheniyaPokazatelejjAnalizovNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ZnacheniyaPokazatelejjAnalizovNomenklaturyResponse() {Result = "��������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������������������.�����������(1);
			}
		}

		public object Get(ZnacheniyaPokazatelejjAnalizovNomenklaturysRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������������������.�����������(���������);
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
