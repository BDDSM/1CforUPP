
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SeriiNomenklatury")]
	[Route("/Catalogs/SeriiNomenklatury/{Code}")]
	public class SeriiNomenklaturyRequest/*�����������������������*/: V82.�����������������.�����������������,IReturn<SeriiNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SeriiNomenklaturyResponse//����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SeriiNomenklaturys")]
	[Route("/Catalogs/SeriiNomenklaturys/{Codes}")]
	public class SeriiNomenklaturysRequest/*�����������������������*/: IReturn<List<SeriiNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SeriiNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SeriiNomenklaturysResponse//����������������������
	{
		public string Result {get;set;}
	}


	public class SeriiNomenklaturyService /*�����������������������*/ : Service
	{
		public object Any(SeriiNomenklaturyRequest request)
		{
			return new SeriiNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SeriiNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������.�����������(���������);
				if (������ == null)
				{
					return new SeriiNomenklaturyResponse() {Result = "����������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������.�����������(1);
			}
		}

		public object Get(SeriiNomenklaturysRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������.�����������(���������);
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
