
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TekhnologicheskieOperacii")]
	[Route("/Catalogs/TekhnologicheskieOperacii/{Code}")]
	public class TekhnologicheskieOperaciiRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<TekhnologicheskieOperaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TekhnologicheskieOperaciiResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TekhnologicheskieOperaciis")]
	[Route("/Catalogs/TekhnologicheskieOperaciis/{Codes}")]
	public class TekhnologicheskieOperaciisRequest/*�����������������������������*/: IReturn<List<TekhnologicheskieOperaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TekhnologicheskieOperaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TekhnologicheskieOperaciisResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class TekhnologicheskieOperaciiService /*�����������������������������*/ : Service
	{
		public object Any(TekhnologicheskieOperaciiRequest request)
		{
			return new TekhnologicheskieOperaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TekhnologicheskieOperaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new TekhnologicheskieOperaciiResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(TekhnologicheskieOperaciisRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������.�����������(���������);
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
