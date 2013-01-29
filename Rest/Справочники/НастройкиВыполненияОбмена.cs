
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiVypolneniyaObmena")]
	[Route("/Catalogs/NastrojjkiVypolneniyaObmena/{Code}")]
	public class NastrojjkiVypolneniyaObmenaRequest/*�������������������������������*/: V82.�����������������.�������������������������,IReturn<NastrojjkiVypolneniyaObmenaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiVypolneniyaObmenaResponse//������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiVypolneniyaObmenas")]
	[Route("/Catalogs/NastrojjkiVypolneniyaObmenas/{Codes}")]
	public class NastrojjkiVypolneniyaObmenasRequest/*�������������������������������*/: IReturn<List<NastrojjkiVypolneniyaObmenaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiVypolneniyaObmenasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiVypolneniyaObmenasResponse//������������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiVypolneniyaObmenaService /*�������������������������������*/ : Service
	{
		public object Any(NastrojjkiVypolneniyaObmenaRequest request)
		{
			return new NastrojjkiVypolneniyaObmenaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiVypolneniyaObmenaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiVypolneniyaObmenaResponse() {Result = "������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiVypolneniyaObmenasRequest request)
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
