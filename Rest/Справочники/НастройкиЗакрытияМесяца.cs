
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiZakrytiyaMesyaca")]
	[Route("/Catalogs/NastrojjkiZakrytiyaMesyaca/{Code}")]
	public class NastrojjkiZakrytiyaMesyacaRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<NastrojjkiZakrytiyaMesyacaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiZakrytiyaMesyacaResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiZakrytiyaMesyacas")]
	[Route("/Catalogs/NastrojjkiZakrytiyaMesyacas/{Codes}")]
	public class NastrojjkiZakrytiyaMesyacasRequest/*�����������������������������*/: IReturn<List<NastrojjkiZakrytiyaMesyacaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiZakrytiyaMesyacasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiZakrytiyaMesyacasResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiZakrytiyaMesyacaService /*�����������������������������*/ : Service
	{
		public object Any(NastrojjkiZakrytiyaMesyacaRequest request)
		{
			return new NastrojjkiZakrytiyaMesyacaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiZakrytiyaMesyacaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiZakrytiyaMesyacaResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiZakrytiyaMesyacasRequest request)
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
