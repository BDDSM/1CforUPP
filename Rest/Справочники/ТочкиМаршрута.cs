
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TochkiMarshruta")]
	[Route("/Catalogs/TochkiMarshruta/{Code}")]
	public class TochkiMarshrutaRequest/*�������������������*/: V82.�����������������.�������������,IReturn<TochkiMarshrutaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TochkiMarshrutaResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TochkiMarshrutas")]
	[Route("/Catalogs/TochkiMarshrutas/{Codes}")]
	public class TochkiMarshrutasRequest/*�������������������*/: IReturn<List<TochkiMarshrutaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TochkiMarshrutasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TochkiMarshrutasResponse//������������������
	{
		public string Result {get;set;}
	}


	public class TochkiMarshrutaService /*�������������������*/ : Service
	{
		public object Any(TochkiMarshrutaRequest request)
		{
			return new TochkiMarshrutaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TochkiMarshrutaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new TochkiMarshrutaResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(TochkiMarshrutasRequest request)
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
